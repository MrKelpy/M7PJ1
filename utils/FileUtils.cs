using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace M7PJ1.utils
{
    public partial class FileUtils : Form
    {
        /// <summary>
        /// Writes all the given data in bulk to the specified filepath.
        /// </summary>
        /// <param name="path">The filepath to dump the data into</param>
        /// <param name="data">A List(string) containing the lines to write into the file.</param>
        public static void DumpToFile(string path, List<string> data) => File.WriteAllLines(path, data.ToArray());
        
        /// <summary>
        /// Appends a given line to the end of the file.
        /// </summary>
        /// <param name="path">The filepath to append the data into</param>
        /// <param name="data">A string containing the line to write into the file.</param>
        public static void AppendToFile(string path, string data) => File.AppendAllLines(path, new[] { data });

        /// <summary>
        /// Reads all the lines from a file and returns them in the form of a list.
        /// </summary>
        /// <param name="path">The filepath to read the data from</param>
        /// <returns>A list containing all the lines in the file</returns>
        public static List<string> ReadFromFile(string path) => File.ReadAllLines(path).ToList().Select(x => x.Trim()).ToList();
        
        #region form
        public FileUtils()
        {
            InitializeComponent();
        }
        #endregion
    }
}