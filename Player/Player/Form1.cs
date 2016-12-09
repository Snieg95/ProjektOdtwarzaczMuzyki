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

namespace Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        string[] files, paths;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                paths = openFileDialog1.FileNames;
                listBox1.Items.Clear();
                for (int i = 0; i <files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);
                }
            }
        }
        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        

        private void button5_Click(object sender, EventArgs e)
            {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                
                axWindowsMediaPlayer1.Ctlcontrols.play();
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if(files.Length - 1 > listBox1.SelectedIndex)
            {
                axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex + 1];
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex - 1];
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int losowa = rnd.Next(0, files.Length);
            axWindowsMediaPlayer1.URL = paths[losowa];
            listBox1.SelectedIndex = losowa;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
        }
    }
    }

