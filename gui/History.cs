using System.Windows.Forms;
using M7PJ1.utils;

namespace M7PJ1.gui
{
    /// <summary>
    /// This form creates and handles any operations that have to do with the order history.
    /// </summary>
    public partial class History : Form
    {
        /// <summary>
        /// On initialization, add the stored history contents into the grid.
        /// </summary>
        /// <param name="historyPath"></param>
        public History(string historyPath)
        {
            InitializeComponent();
            
            // ReSharper disable once CoVariantArrayConversion
            FileUtils.ReadFromFile(historyPath).ForEach(x => dataHistory.Rows.Add(x.Split(',')));
        }

        /// <returns>
        /// Returns the panel containing the content to be added.
        /// </returns>
        public Panel GetContent() => this.content;
        
        /// <returns>
        /// Returns the DataGridView that represents the history to be updated.
        /// </returns>
        public DataGridView GetHistory() => this.dataHistory;
    }
}