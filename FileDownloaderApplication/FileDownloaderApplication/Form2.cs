﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDownloaderApplication
{
    public partial class Form2 : Form
    {
        public List<string> result = new List<string>();
        public string files = string.Empty;


        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = $"The are the following {files}: \r\n\r\n";
            int count = 0;
            foreach (string  str in result)
            {
                count++;
                textBox1.AppendText($"File{count}: {str} \r\n");

                
            }
            textBox1.AppendText($"\r\nThere are {count} files. \r\n");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
