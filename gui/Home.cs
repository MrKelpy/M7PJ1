using System.Windows.Forms;

namespace M7PJ1.gui
{
    /// <summary>
    /// This form creates the layout for the homepage of the program.
    /// </summary>
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        
        /// <returns>
        /// Returns the panel containing the content to be added.
        /// </returns>
        public Panel GetContent() => this.content;
    }
}