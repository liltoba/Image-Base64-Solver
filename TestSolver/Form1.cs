﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageCaptchaSolver;

namespace TestSolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                try
                {
                    ImageCaptchaSolver.ImageCaptchaSolver solver = new ImageCaptchaSolver.ImageCaptchaSolver();
                    solver.ImageSolver(textBox3.Text, textBox1.Text);
                    pictureBox1.Image = Image.FromFile(textBox1.Text);

                }
                catch
                {
                
                }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/liltoba");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
