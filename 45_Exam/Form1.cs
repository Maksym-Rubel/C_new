using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _45_Exam
{
   
    public partial class lblHelloWorld : Form
    {
   
        public lblHelloWorld()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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
                listBox1.Items.Add($"{file.Name,-20}{file.LastWriteTime,-30}{file.CreationTime,-30}");
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


            textBox1.Text = Path.Combine(textBox1.Text,listBox1.SelectedItem.ToString());
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
                listBox1.Items.Add($"{file.Name,-20}{file.LastWriteTime,-30}{file.CreationTime,-30}");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
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
                listBox1.Items.Add($"{file.Name,-40}{file.LastWriteTime,-30}{file.CreationTime,-30}");
            }

        }

        private void lblHelloWorld_Load(object sender, EventArgs e)
        {

        }
    }
}
