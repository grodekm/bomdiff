using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileHelpers;

namespace BOM_diff
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog newFile = new OpenFileDialog();
            newFile.Multiselect = true;
            newFile.Filter = "Pliki CSV (*.csv)|*.csv";
            if (newFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in newFile.FileNames)
                {
                    if (!listBoxFiles.Items.Contains(fileName))
                        listBoxFiles.Items.Add(fileName);
                    else
                        MessageBox.Show(string.Format("Plik już istnieje\n{0}", fileName));
                }
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if(listBoxFiles.Items.Count != 0)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelpDialog hlpDialog = new HelpDialog();
            hlpDialog.ShowDialog();
        }
    }
}
