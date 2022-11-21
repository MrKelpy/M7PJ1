using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using M7PJ1.utils;

namespace M7PJ1.gui
{
    /// <summary>
    /// This form creates and handles any operations that have to do with the order selection interface.
    /// </summary>
    public partial class ItemSelection : Form
    {
        private string _historyPath;
        private string _listingsPath;
        public readonly List<ListingStruct.Listing> Listings;
        public readonly List<OrderStruct.Order> Orders = new List<OrderStruct.Order>();
        private readonly List<Button> _gridButtons;
        private readonly DataGridView _history;
        private int _page;
        
        public ItemSelection(DataGridView history, string historyPath, string listingsPath)
        {
            InitializeComponent();
            this._gridButtons = this.BuildGridButtonList();
            this._history = history;
            this._historyPath = historyPath;
            this._listingsPath = listingsPath;
            this.Listings = this.BuildListings();
            this.NextPage();

            // Adds the event listeners en-masse to buttons 
            this._gridButtons.ForEach(button => button.Click += this.OnGridButtonClick);
        }

        /// <returns>
        /// Returns the panel containing the content to be added.
        /// </returns>
        public Panel GetContent() => this.content;

        /// <summary>
        /// Updates the buttons shown in the layout by order of available buttons.
        /// </summary>
        private void UpdateButtons(int startingIndex)
        {
            this._gridButtons.ForEach(x => x.Text = "");
            this._gridButtons.ForEach(x => x.BackColor = Color.LightGray);

            // Filters out the listings to go into the buttons accordingly to the words in the search box
            List<ListingStruct.Listing> filteredListings =
                this.Listings.FindAll(x => x.Name.ToLower().Contains(textSearch.Text.ToLower()));
                
            // Removes the excess elements from previous pages to allow for pagination.
            if (filteredListings.Count > this._gridButtons.Count) 
                filteredListings.RemoveRange(0, startingIndex);

            // Iterates over every grid button and sets a listing on it based on the starting index.
            for (int i = 0; i < this._gridButtons.Count; i++)
            {
                // Skips the current listing showcase if there are no more filtered listings.
                if (filteredListings.Count - 1 < i) continue;
                
                // Sets the Grid Button's text
                Button button = this._gridButtons.First(x => x.Text == "");
                button.Text = filteredListings[i].Name;
                button.BackColor = button.FlatAppearance.MouseOverBackColor =
                    this.Orders.Any(x => x.Product == button.Text) ? Color.LightGreen : button.BackColor;
            }
            
            lblQuantity.Text = @"Quantidade: ";
            lblSelected.Text = @"Selecionado: ";
            lblPrice.Text = @"Preço: ";
        }
        
        /// <summary>
        /// Loads in the first page of listings
        /// </summary>
        public void FirstPage()
        {
            this.UpdateButtons(0);

            this._page = 1;
            this.ValidateNavigation();
        }
        
        /// <summary>
        /// Loads in the next page of listings into the selection buttons.
        /// </summary>
        private void NextPage()
        {
            int nextPageStartingIndex = this._page * this._gridButtons.Count;

            // Updates the buttons in the page starting from the index of the next page's listings.
            this.UpdateButtons(nextPageStartingIndex);

            this._page++;
            this.ValidateNavigation();
        }
        
        /// <summary>
        /// Loads in the previous page of listings into the selection buttons.
        /// </summary>
        private void PreviousPage()
        {
            int previousPageStartingIndex = (this._page - 2) * this._gridButtons.Count;

            // Updates the buttons in the page starting from the index of the previous page's listings.
            this.UpdateButtons(previousPageStartingIndex);

            this._page--;
            this.ValidateNavigation();
        }

        /// <summary>
        /// Checks whether there are any more pages, be it forwards or backwards, and blocks the previous/next
        /// buttons accordingly.
        /// </summary>
        private void ValidateNavigation()
        {
            // Only enable the previous page button if the current page isn't page 0.
            btnPrevious.Enabled = this._page != 1;
            
            // Only enable the next page button if the first index of the next page exists in the listings.
            btnNext.Enabled = this._page * this._gridButtons.Count < this.Listings.Count;
        }

        /// <summary>
        /// Iterates through all the products and returns the product price for the one inserted.
        /// </summary>
        /// <param name="productName">The product name to search for</param>
        /// <returns>The product's price, or -1 if not found.</returns>
        private double GetProductPrice(string productName)
        {
            foreach (ListingStruct.Listing product in this.Listings)
                if (product.Name == productName) return product.Price;

            return -1D;
        }

        /// <summary>
        /// Returns a list of all the buttons that will contain products. This needs to be done
        /// unfortunately because I'm pretty lazy and didn't put the buttons inside a grid first, but
        /// I did put everything else in one.
        /// </summary>
        /// <returns></returns>
        private List<Button> BuildGridButtonList()
        {
            List<Button> buttons = new List<Button>();

            // GetContent() returns the panel where the controls are, so we can just check if the parent of a control
            // Is that layout panel, instead of any other else.
            foreach (Control control in this.GetContent().Controls)
                if (control.Parent == this.GetContent() && !(control is Panel)) buttons.Add((Button) control);

            buttons.Sort((a, b) => String.Compare(a.Name, b.Name, StringComparison.Ordinal));
            return buttons;
        }
        
        /// <summary>
        /// Creates a List containing all the default Listings to be ordered.
        /// (This static method has been paid off with me going to LGW!)
        /// </summary>
        /// <returns>The list with the default listings.</returns>
        private List<ListingStruct.Listing> BuildListings()
        {
            List<ListingStruct.Listing> builder = new List<ListingStruct.Listing>();
            
            foreach (var x in FileUtils.ReadFromFile(this._listingsPath))
            {
                string[] rawListing = x.Split(',');
                if (rawListing.Length == 0) continue;
                builder.Add(new ListingStruct.Listing(rawListing[0], double.Parse(rawListing[1])));
            }

            builder.Sort((a, b) => String.Compare(a.Name.ToLower(), b.Name.ToLower(), StringComparison.Ordinal));
            return builder;
        }
        
        /// <summary>
        /// Prompts the user with a confirmation dialog and adds everything to the history afterwards.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        // ReSharper disable CoVariantArrayConversion
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // To checkout, you need to insert a student in the field. If there isn't one, return and warn the user.
            lblErrorStudent.Visible = false;
            if (txtStudent.Text == "")
            {
                lblErrorStudent.Visible = true;
                return;
            }

            // Creates a string containing the total price of the order.
            string totalPrice = this.Orders.Sum(x => this.GetProductPrice(x.Product) * x.Quantity).ToString("0.00");
            string today = $@"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";
            string id = Guid.NewGuid().ToString();

            // Confirms whether the user *really* wants to buy everything selected.
            // ReSharper disable once LocalizableElement
            if (MessageBox.Show($"Tens a certeza que queres comprar tudo isto?\nTotal: {totalPrice}€",
                    @"Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            // Sorts the orders list by ascending order of price
            this.Orders.Sort((a, b) => 
                this.GetProductPrice(a.Product)*a.Quantity > this.GetProductPrice(b.Product)*b.Quantity ? -1 : 1);
            
            // Adds each order to the history
            foreach (OrderStruct.Order order in this.Orders)
            {
                string csv = $@"{id},{txtStudent.Text},{order.Product} x{order.Quantity},{(this.GetProductPrice(order.Product) * order.Quantity).ToString("0.00") + "€"},{today}";
                this._history.Rows.Add(csv.Split(','));
                FileUtils.AppendToFile(this._historyPath, csv);
            }

            // Clears everything and gets ready for more orders.
            this.Orders.Clear();    
            this.UpdateButtons(0);
            txtStudent.Clear();
        }
        
        /// <summary>
        /// Handles all the logic related to the product selection and order registration.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        // ReSharper disable PossibleInvalidOperationException
        private void OnGridButtonClick(object sender, EventArgs e)
        {
            Button clicked = (Button) sender;
            if (clicked.Text == "") return; // Ignores if the button doesn't have a listing.
            clicked.BackColor = clicked.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            this.btnCheckout.Enabled = true;
            
            // Gets the order struct 
            OrderStruct.Order targetOrder = this.TryGetOrder(clicked.Text).Value.Product != null
                ? this.TryGetOrder(clicked.Text).Value
                : new OrderStruct.Order(clicked.Text, 1);

            lblSelected.Text = @"Selecionado: " + targetOrder.Product;
            lblQuantity.Text = @"Quantidade: " + targetOrder.Quantity;
            lblPrice.Text = @"Preço: " + this.GetProductPrice(targetOrder.Product).ToString("0.00") + @"€";
            
            // Replaces the order just in case it wasn't there before and was created on the fly.
            this.ReplaceOrder(targetOrder.Product, targetOrder);
        }

        /// <summary>
        /// Called when one of the quantity set buttons is clicked.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void OnQuantityChangeButtonClick(object sender, EventArgs e)
        {
            // Parses the product from the "selected" label and changes its quantity. 
            Button button = (Button) sender;
            OrderStruct.Order order = this.TryGetOrder(lblSelected.Text.Split(":".ToCharArray())[1].Trim()).Value;
            if (order.Quantity == 10000) return;  // Limits the order max to 10k items.

            if (order.Product == null) return;  // Ignores if there's no selected order.
            
            // Handles the incrementation/decrementation of the order quantity, or the setting of it.
            if (button.Text.Contains("+") || button.Text.Contains("-"))
                order.Quantity += int.Parse(button.Text);
            
            else order.Quantity = int.Parse(button.Text);

            // Cancels the product's order if the quantity reaches 0.
            if (order.Quantity == 0)
            {
                this.Orders.RemoveAt(this.Orders.IndexOf(this.TryGetOrder(order.Product).Value));
                this.UpdateButtons(0);
                if (this.Orders.Count == 0) this.btnCheckout.Enabled = false;
                return;
            }
            
            lblQuantity.Text = @"Quantidade: " + order.Quantity; 
            this.ReplaceOrder(order.Product, order);
        }

        /// <summary>
        /// Replaces a given order's index by name.
        /// </summary>
        /// <param name="name">The name of product order to replace</param>
        /// <param name="replacement">The Order object to replace it with.</param>
        private void ReplaceOrder(string name, OrderStruct.Order replacement)
        {
            // If the order product is not in the list, just add it.
            if (this.TryGetOrder(name).Value.Product == null)
            {
                this.Orders.Add(replacement);
                return;
            }
            
            // Iterates over every order and checks if the product name is the same as the one to be replaced.
            // If so, replaces the element at the index with the replacement
            for (var i = 0; i < this.Orders.Count; i++)
            {
                if (this.Orders[i].Product == name)
                {
                    this.Orders[i] = replacement;
                    break;
                }
            }
        }

        /// <summary>
        /// Searches for an order in the order registry and returns it. 
        /// </summary>
        /// <param name="name">The product name of the order.</param>
        /// <returns>The order object, null if it doesn't exist.</returns>
        private OrderStruct.Order? TryGetOrder(string name) => this.Orders.Find(x => x.Product == name);
        
        private void btnNext_Click(object sender, EventArgs e) => this.NextPage();

        private void btnPrevious_Click(object sender, EventArgs e) => this.PreviousPage();
        
        private void textSearch_TextChanged(object sender, EventArgs e) => this.FirstPage();
    }
}