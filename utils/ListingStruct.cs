using System.Windows.Forms;

namespace M7PJ1.utils
{
    public partial class ListingStruct : Form
    {
        /// <summary>
        /// This struct implements an easy way to store and manipulate product listings.
        /// </summary>
        public struct Listing
        {
            public string Name;
            public double Price;

            public Listing(string name, double price)
            {
                this.Name = name;
                this.Price = price;
            }
        }
        
        #region form
        public ListingStruct()
        {
            InitializeComponent();
        }
        #endregion form
    }
}