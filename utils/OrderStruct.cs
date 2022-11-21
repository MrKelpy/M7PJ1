using System.Windows.Forms;

namespace M7PJ1.utils
{
    public partial class OrderStruct : Form
    {
        /// <summary>
        /// This struct implements an easy way to store and manipulate product orders, in a way that
        /// both the history and item selection can understand.
        /// </summary>
        public struct Order
        {
            public string Product;
            public int Quantity;

            public Order(string product, int quantity)
            {
                this.Product = product;
                this.Quantity = quantity;
            }
        }
        
        #region form
        public OrderStruct()
        {
            InitializeComponent();
        }
        #endregion form
    }
}