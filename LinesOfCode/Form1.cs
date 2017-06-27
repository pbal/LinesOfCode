using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace LinesOfCode
{
    public partial class Form1 : Form
    {
        private readonly DataTable _dt;
        int i = 1;
        private int total;

        public Form1()
        {
            InitializeComponent();

            _dt = new DataTable();
        }
        private void GetAllDirs(DirectoryInfo di)
        {
            var theDirs = di.GetDirectories();

            foreach (var directoryInfo in theDirs)
            {
                GetAllDirs(directoryInfo);
                GetAllFilesFromArray(directoryInfo);
            }
        }

        private void GetAllFilesFromArray(DirectoryInfo di)
        {
            var theFiles = di.GetFiles();

            foreach (var file in theFiles)
            {
                if (ValidateCodeFile(file.Extension)) continue;
                var dr = _dt.NewRow();
                dr[0] = i++;
                dr[1] = file.FullName;
                dr[2] = file.Name;
                var lines = CalculateLineOfCode(file.FullName);
                total += lines;
                dr[3] = lines;
                _dt.Rows.Add(dr);
            }
        }

        private static bool ValidateCodeFile(string ext)
        {
            switch (ext.ToLower())
            {
                case ".aspx":
                case ".cs":
                case ".resx":
                case ".vb":
                case ".aspx.vb":
                case ".aspx.cs":
                case ".htm":
                case ".html":
                case ".css":
                case ".js":
                case ".php":
                    return false;
                default:
                    return true;
            }
        }

        private static int CalculateLineOfCode(string path)
        {
            var count = 0;
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (var sr = new StreamReader(path))
                {
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    var s = string.Empty;
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrEmpty(s)) continue;
                        count++;
                    }
                }
            }
            catch (Exception e)
            {
                return -1;
            }
            return count;
        }

        private void btnLinesOfCode_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
                return;
            }
            var homePath = folderBrowserDialog1.SelectedPath;

            var dataColumn = new DataColumn("ID") { DataType = Type.GetType("System.Int32") };
            _dt.Columns.Add(dataColumn);
            dataColumn = new DataColumn("Location") { DataType = Type.GetType("System.String") };
            _dt.Columns.Add(dataColumn);
            dataColumn = new DataColumn("File Name") { DataType = Type.GetType("System.String") };
            _dt.Columns.Add(dataColumn);
            dataColumn = new DataColumn("Lines of Code") { DataType = Type.GetType("System.Int32") };
            _dt.Columns.Add(dataColumn);

            var di = new DirectoryInfo(homePath);
            GetAllDirs(di);
            GetAllFilesFromArray(di);
            dataGridView1.DataSource = _dt;


            label1.Text = @"Total lines of Code : " + total;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
                return;
            }
            var homePath = folderBrowserDialog1.SelectedPath;

            var di = new DirectoryInfo(homePath);
            GetFilesInFolder(di);

        }
        private void GetFilesInFolder(DirectoryInfo di)
        {
            var theFiles = di.GetFiles();

            int i = 0;
            string startName = txtRenameStartName.Text;
            if (startName.Equals(string.Empty))
                startName = "sample";

            foreach (var file in theFiles)
            {
                while (true)
                {
                    if (!File.Exists(file.DirectoryName + "\\" + startName + "_" + i + file.Extension)) break;
                    i += 1;
                }
                File.Copy(file.DirectoryName + "\\" + file.Name,
                    file.DirectoryName + "\\" + startName + "_" + i + file.Extension);

                i += 1;
            }
            lblResult.Text = "Total file renamed : " + i;
            MessageBox.Show(this, "Renaming complete!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
