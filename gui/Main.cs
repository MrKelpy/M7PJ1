using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using M7PJ1.utils;

namespace M7PJ1.gui
{
    /// <summary>
    /// This form manages the visual placement of each page's elements into view, and handles the user's interactions
    /// with the custom menu button existent at the top, that send them to each page.
    /// </summary>
    public partial class Main : Form
    {
        private readonly Panel _homeContent = new Home().GetContent();
        private readonly ItemSelection _itemSelection;
        private readonly Panel _historyContent;
        private Control _layoutOriginalParent;
        private const string HistoryPath = "./history.csv";
        private const string ListingsPath = "./listings.csv";

        public Main()
        {
            InitializeComponent();
            this.ProcessLayoutSelection(btnHome, _homeContent);
            this.CenterToScreen();
            
            // Ensure the existence of the core files
            if (!File.Exists(HistoryPath)) File.Create(HistoryPath).Close();
            if (!File.Exists(ListingsPath)) File.Create(ListingsPath).Close();

            // Since the ItemSelection needs the history to update it, we need to initialise those two here
            History history = new History(HistoryPath);
            this._itemSelection = new ItemSelection(history.GetHistory(), HistoryPath, ListingsPath);
            this._historyContent = history.GetContent();
        }

        /// <summary>
        /// Changes the parent form of the given content panel into the main one;
        /// If the main one already contains a layout, it will be placed back in its original parent.
        /// </summary>
        /// <param name="contentPanel">The panel containing all the content to be added</param>
        private void LoadContent(Panel contentPanel)
        {
            if (this._layoutOriginalParent != null)
                contentPanel.Parent = this._layoutOriginalParent;

            this._layoutOriginalParent = contentPanel.Parent;
            contentPanel.Parent = this.layout;
        }

        /// <summary>
        /// Processes the actions to be performed when the user presses any of the menu buttons.
        /// The currently selected layout's borders should be shown and the layout updated.
        /// </summary>
        /// <param name="btn">The button pressed</param>
        /// <param name="selectedLayout">The layout to update to</param>
        private void ProcessLayoutSelection(Button btn, Panel selectedLayout)
        {
            foreach (Button button in this.menuLayout.Controls) button.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.BorderSize = 1;
            this.LoadContent(selectedLayout);
        }
        
        /// <summary>
        /// Creates a new listing through a dialog and adds it to ItemSelection's internal listings.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void btnNewListing_Click(object sender, EventArgs e)
        {
            NamePriceDialog dialog = new NamePriceDialog("Novo Artigo").WithName().WithPrice();
            dialog.ShowDialog(this);

            if (dialog.Result != DialogResult.OK) return;
            
            // Prevents the user from adding more than one listing with the same name.
            if (this._itemSelection.Listings.Any(x => x.Name.ToLower().Equals(dialog.Name.ToLower())))
            {
                MessageBox.Show($@"Já existe um artigo chamado '{dialog.Name}'. Por favor tente de novo com outro nome ou edite o artigo já existente.",
                    $@"Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Adds the listing to a sorted list, and to the file, then force to user to go to the first page.
            this._itemSelection.Listings.Add(new ListingStruct.Listing(dialog.Name, dialog.Price));
            this._itemSelection.Listings.Sort((a, b) => String.Compare(a.Name, b.Name, StringComparison.CurrentCulture));
            FileUtils.AppendToFile(ListingsPath, dialog.Name + ',' + dialog.Price);
            this._itemSelection.FirstPage();
        }
        
        /// <summary>
        /// Deletes a listing based on its product name.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void btnDeleteListing_Click(object sender, EventArgs e)
        {
            NamePriceDialog dialog = new NamePriceDialog("Apagar Artigo").WithName();
            dialog.ShowDialog(this);

            if (dialog.Result != DialogResult.OK) return;
            
            // If no matching listing is found, tell the user and return.
            if (this._itemSelection.Listings.FindIndex(x => x.Name.Equals(dialog.Name)) == -1)
            {
                MessageBox.Show($@"Nenhum artigo chamado '{dialog.Name}' encontrado.", $@"Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Remove the listings from both internal lists
            this._itemSelection.Listings.RemoveAll(x => x.Name.Equals(dialog.Name));
            this._itemSelection.Orders.RemoveAll(x => x.Product.Equals(dialog.Name));
            if (this._itemSelection.Orders.Count == 0) this._itemSelection.btnCheckout.Enabled = false;
            
            // Remove the listings from memory
            List<string> data = FileUtils.ReadFromFile(ListingsPath);
            data.RemoveAll(x => x.Split(',')[0].ToLower().Equals(dialog.Name.ToLower()));
            FileUtils.DumpToFile(ListingsPath, data);

            this._itemSelection.FirstPage();
        }
        
        /// <summary>
        /// Edits a listing based on its name.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void btnEditListing_Click(object sender, EventArgs e)
        {
            NamePriceDialog dialog = new NamePriceDialog("Editar Artigo").WithName().WithPrice();
            dialog.ShowDialog(this);

            if (dialog.Result != DialogResult.OK) return;
            int index = this._itemSelection.Listings.FindIndex(x => x.Name.ToLower().Equals(dialog.Name.ToLower()));
            
            // If no matching listing is found, tell the user and return.
            if (index == -1)
            {
                MessageBox.Show($@"Nenhum artigo chamado '{dialog.Name}' encontrado.", $@"Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Updates the internal list with the new listing
            this._itemSelection.Listings[index] = new ListingStruct.Listing(dialog.Name, dialog.Price);
            
            // Does the same, but for the file in memory
            List<string> data = FileUtils.ReadFromFile(ListingsPath);
            data.RemoveAll(x => x.Split(',')[0].ToLower().Equals(dialog.Name.ToLower()));
            data.Add($"{dialog.Name},{dialog.Price}");
            FileUtils.DumpToFile(ListingsPath, data);

            this._itemSelection.FirstPage();
        }
        
        /// <summary>
        /// Clears all the currently selected orders, effectively cancelling the current order.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this._itemSelection.Orders.Clear();
            this._itemSelection.FirstPage();
        }
        
        private void btnHome_Click(object sender, EventArgs e) => this.ProcessLayoutSelection(btnHome, _homeContent);
        private void btnOrders_Click(object sender, EventArgs e) => this.ProcessLayoutSelection(btnOrders, _itemSelection.GetContent());
        private void btnHistory_Click(object sender, EventArgs e) => this.ProcessLayoutSelection(btnHistory, _historyContent);
        

    }
}