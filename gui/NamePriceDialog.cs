using System;
using System.Drawing;
using System.Windows.Forms;

namespace M7PJ1.gui
{
    /// <summary>
    /// This class adds a custom dialog that allows a user to input prices and strings into
    /// specific text boxes, that can be shown on request.
    /// </summary>
    public partial class NamePriceDialog : Form
    {
        public DialogResult Result;
        public new string Name;
        public double Price;

        public NamePriceDialog(string title)
        {
            InitializeComponent();
            this.lblTitle.Text = title;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        /// <summary>
        /// Shows the Name field for the NamePriceDialog.
        /// </summary>
        public NamePriceDialog WithName()
        {
            this.nameLayout.Visible = true;
            return this; // Return the NamePriceDialog for chaining.
        }

        /// <summary>
        /// Shows the Price field for the NamePriceDialog.
        /// </summary>
        public NamePriceDialog WithPrice()
        {
            this.priceLayout.Visible = true;
            return this; // Return the NamePriceDialog for chaining.
        }

        /// <summary>
        /// Monitors the text entered on the TextBox, changing the foreground colour to match whether or not
        /// the inputs are valid.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void txtPrice_TextChanged(object sender, EventArgs e) => txtPrice.ForeColor =
            double.TryParse(txtPrice.Text, out double _) && double.Parse(txtPrice.Text) > 0 
                                                         && !txtPrice.Text.Contains(",")
                                                         && !txtPrice.Text.Contains(" ")
                                                         && !txtPrice.Text.Trim().Equals("") ? Color.Black : Color.Firebrick;

        /// <summary>
        /// Limits the amount of characters that can go into the listing name to 35.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.ForeColor = (txtName.Text.Length > 35 || txtName.Text.Trim() == "") ? Color.Firebrick : Color.Black;
            lblListingName.Text = $@"Nome do Artigo ({txtName.Text.Length}/35)";
        }

        /// <summary>
        /// Sets the Result, Name and Price variables (taking into account the current dialog context) and closes the form.
        /// If the Price field is shown, and has an unmatched value in it, return without doing anything.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPrice.Visible && txtPrice.ForeColor == Color.Firebrick) return;
            if (txtName.Visible && txtName.ForeColor == Color.Firebrick) return;
            this.Price = txtPrice.Visible ? double.Parse(txtPrice.Text) : -1D;
            this.Name = txtName.Text;
            this.Result = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Closes the dialog with a cancelled result.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Result = DialogResult.Cancel;
            this.Close();
        }
    }

}