using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace CleanTemp
{
    public partial class TempCleaner : Form
    {
        
        
        public TempCleaner()
        {
            InitializeComponent();
        }

        private void TempCleaner_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            string folder_usr = Path.Combine("C:\\Users\\" + userName + "\\AppData\\Local\\Temp");

            // cmd commands
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = false;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();


            //commands
            cmd.StandardInput.WriteLine(@"del C:\Windows\Temp");
            cmd.StandardInput.WriteLine("Y");

            cmd.StandardInput.WriteLine(@"del C:\Windows\Prefetch");
            cmd.StandardInput.WriteLine("Y");

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            DirectoryInfo di = new DirectoryInfo(folder_usr);

            try
            {
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }

                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }

            searchFiles();
            

        }

        private void searchFiles()
        {
            files_dump.Text = "Temp and prefetch Files cleared Remaining Files are" + Environment.NewLine + Environment.NewLine;

            List<string> files = new List<string>();
            string userName = Environment.UserName;
            files.AddRange(Directory.GetFiles(@"C:\Windows\Prefetch"));
            files.AddRange(Directory.GetFiles(@"C:\Windows\Temp"));
            string folder_usr = Path.Combine("C:\\Users\\" + userName + "\\AppData\\Local\\Temp");
            files.AddRange(Directory.GetFiles(@folder_usr));

            foreach (string file in files)
            {
                files_dump.Text += file + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formBack = new Form();
            try
            {
                using (Form_about fa = new Form_about())
                {
                    formBack.StartPosition = FormStartPosition.CenterParent;
                    formBack.FormBorderStyle = FormBorderStyle.None;
                    formBack.Opacity = .50d;
                    formBack.BackColor = Color.Black;
                    formBack.WindowState = FormWindowState.Maximized;
                    formBack.TopMost = true;
                    formBack.Location = this.Location;
                    formBack.ShowInTaskbar = false;
                    formBack.Show();

                    fa.Owner = formBack;
                    fa.ShowDialog();

                    formBack.Dispose();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                formBack.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
