using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _45_Exam
{
   
    public partial class lblHelloWorld : Form
    {
   
        public lblHelloWorld()
        {
            InitializeComponent();
            create.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !Directory.Exists(textBox1.Text))
            {
                MessageBox.Show("\r\nНедійсний шлях до каталогу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
            if (dir.Attributes != FileAttributes.Hidden)
            {
                DirectoryInfo[] dirs = dir.GetDirectories();

                foreach (DirectoryInfo d in dirs)
                {
                    listBox1.Items.Add(d);
                }


            }
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                listBox1.Items.Add(file);

                
            }

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 
            }
        }
        private void textBox1_TextChanged(object sender, KeyEventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }


        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(Path.GetExtension(Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString())) == "")
            {
                textBox1.Text = Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString());
                listBox1.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
                if (dir.Attributes != FileAttributes.Hidden)
                {
                    DirectoryInfo[] dirs = dir.GetDirectories();

                    foreach (DirectoryInfo d in dirs)
                    {
                        listBox1.Items.Add(d);
                    }


                }
                FileInfo[] files = dir.GetFiles();

                foreach (FileInfo file in files)
                {
                  
                    listBox1.Items.Add(file);

                }
            }
            else
            {
                Process.Start(Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString()));
            }

            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !Directory.Exists(textBox1.Text))
            {
                MessageBox.Show("\r\nНедійсний шлях до каталогу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox1.Text[textBox1.Text.Length - 1] == '\\') 
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1,1);
                while(textBox1.Text[textBox1.Text.Length - 1] != '\\')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

                }
            }
            else if(textBox1.Text[textBox1.Text.Length - 1] != '\\')
            {
                while (textBox1.Text[textBox1.Text.Length - 1] != '\\')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

                }
            }
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
            if (dir.Attributes != FileAttributes.Hidden)
            {
                DirectoryInfo[] dirs = dir.GetDirectories();

                foreach (DirectoryInfo d in dirs)
                {
                    listBox1.Items.Add(d);
                }


            }
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                listBox1.Items.Add(file);

                
            }

        }

        private void lblHelloWorld_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition,ToolStripDropDownDirection.Right);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedPath = Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString());
            if (Directory.Exists(selectedPath))
            {
                Directory.Delete(selectedPath, true); 
                MessageBox.Show($"Папка '{listBox1.SelectedItem}' успішно видалена");
            }
       
            else if (File.Exists(selectedPath))
            {
                File.Delete(selectedPath);
                MessageBox.Show($"Файл '{listBox1.SelectedItem}' успішно видалений");
            }
            else
            {
                MessageBox.Show($"Елемент '{listBox1.SelectedItem}' не знайдено");
            }
          
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
            if (dir.Attributes != FileAttributes.Hidden)
            {
                DirectoryInfo[] dirs = dir.GetDirectories();

                foreach (DirectoryInfo d in dirs)
                {
                    listBox1.Items.Add(d);
                }


            }
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                listBox1.Items.Add(file);


            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

          
        }
        private string sourcePath = "";

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                sourcePath = Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString());

            }
            
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            string destinationPath = Path.Combine(textBox1.Text, Path.GetFileName(sourcePath));
            
            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, destinationPath, true); 
                
            }
            else if (Directory.Exists(sourcePath)) 
            {
                CopyDirectory(sourcePath, destinationPath);

            }
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);

            if (dir.Attributes != FileAttributes.Hidden)
            {
                DirectoryInfo[] dirs = dir.GetDirectories();

                foreach (DirectoryInfo d in dirs)
                {
                    listBox1.Items.Add(d);
                }


            }
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                listBox1.Items.Add(file);


            }
        }
        private void CopyDirectory(string sourceDir, string destinationDir)
        {
            
            Directory.CreateDirectory(destinationDir);

           
            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destinationDir, Path.GetFileName(file));
                File.Copy(file, destFile, true);
            }

          
            foreach (string dir in Directory.GetDirectories(sourceDir))
            {
                string destDir = Path.Combine(destinationDir, Path.GetFileName(dir));
                CopyDirectory(dir, destDir);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !Directory.Exists(textBox1.Text))
            {
                MessageBox.Show("\r\nНедійсний шлях до каталогу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
            if (dir.Attributes != FileAttributes.Hidden)
            {
                DirectoryInfo[] dirs = dir.GetDirectories();

                foreach (DirectoryInfo d in dirs)
                {
                    listBox1.Items.Add(d);
                }
                

            }
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                listBox1.Items.Add(file);


            }
        }

        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create.Location = this.PointToClient(Cursor.Position);
            create.Visible = true;
            create.KeyDown += (s, keyEvent) =>
            {
                if (keyEvent.KeyCode == Keys.Enter)
                {
                    create.Visible = false;
                 
                    keyEvent.SuppressKeyPress = true;
                    string text = create.Text += ".txt";
                    string targetPath = Path.Combine(textBox1.Text, text);
                  
                    File.Create(targetPath).Dispose();
             
                    listBox1.Items.Clear();
                    DirectoryInfo dir = new DirectoryInfo(textBox1.Text);

                    if (dir.Attributes != FileAttributes.Hidden)
                    {
                        DirectoryInfo[] dirs = dir.GetDirectories();

                        foreach (DirectoryInfo d in dirs)
                        {
                            listBox1.Items.Add(d);
                        }


                    }
                    FileInfo[] files = dir.GetFiles();

                    foreach (FileInfo file in files)
                    {
                        listBox1.Items.Add(file);


                    }

                    create.Text = "";

                }
            };

        }

        private void directoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create.Location = this.PointToClient(Cursor.Position);
            create.Visible = true;
            create.KeyDown += (s, keyEvent) =>
            {
                if (keyEvent.KeyCode == Keys.Enter)
                {
                    create.Visible = false;

                    keyEvent.SuppressKeyPress = true;
                    string targetPath = Path.Combine(textBox1.Text, create.Text);
                    listBox1.Items.Add(Directory.CreateDirectory(targetPath));
                    listBox1.Items.Clear();
                    DirectoryInfo dir = new DirectoryInfo(textBox1.Text);

                    if (dir.Attributes != FileAttributes.Hidden)
                    {
                        DirectoryInfo[] dirs = dir.GetDirectories();

                        foreach (DirectoryInfo d in dirs)
                        {
                            listBox1.Items.Add(d);
                        }


                    }
                    FileInfo[] files = dir.GetFiles();

                    foreach (FileInfo file in files)
                    {
                        listBox1.Items.Add(file);


                    }

                    create.Text = "";

                }
            };
        }
    }
}
