using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuckQustodio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Qustodio has been blocked.");
            System.Diagnostics.Process.Start(@"C:/Program Files/FuckQustodio/FuckQustodio.bat");
        }

        private void nuke_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:/Program Files (x86)/Qustodio");
            DialogResult dialogResult = MessageBox.Show("By continuing, your parents can find out you deleted Qustodio, proceed with caution.", "WARNING", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show("Nuke launched");
                if (di.Exists)
                {
                    DeleteDirectory(@"C:/Program Files (x86)/Qustodio");
                    MessageBox.Show("Nuke has hit the target");
                }
                else
                {
                    MessageBox.Show("Qustodio was not found on your computer", "Error");
                }
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Cancelled");
            }
        }
        public static void DeleteDirectory(string target)
        {
            string[] files = Directory.GetFiles(target);
            string[] dir1 = Directory.GetDirectories(target);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }
            foreach (string dir in dir1)
            {
                DeleteDirectory(dir);
            }
            Directory.Delete(target, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Qustodio has been blocked.");
            System.Diagnostics.Process.Start(@"C:/Program Files/FuckQustodio/StopFuckQustodio.bat");
        }
    }
}
