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
using System.IO;


namespace XCoderPro
{
    
    public partial class Form1 : Form
    {
        
        byte[] file;
        public Form1()
        {
            

            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        public byte[] Cipher = {
    0x78, 0xF1, 0xF4, 0xFC, 0xF9, 0xD8, 0x0F, 0xE6, 0x3D, 0x34, 0x53, 0x27, 0xB3, 0xDD, 0xAD, 0x7F,
    0x80, 0x43, 0x0B, 0xF5, 0x21, 0xC2, 0x9A, 0x75, 0xD0, 0x86, 0x6E, 0xBE, 0xEE, 0xD1, 0x2A, 0x76,
    0x3E, 0x0A, 0xAF, 0x3F, 0x93, 0xC9, 0xEF, 0xEB, 0xA1, 0x30, 0x76, 0x24, 0x17, 0x9C, 0xF2, 0x12,
    0x4C, 0xB1, 0x07, 0xD6, 0x28, 0xE3, 0x5F, 0xA8, 0x6F, 0xA2, 0x5C, 0x94, 0xEC, 0xEC, 0x40, 0x0E,
    0x10, 0xD1, 0x36, 0x0A, 0xE9, 0xDA, 0x2E, 0x26, 0xD6, 0x80, 0xE4, 0x7A, 0x79, 0xA1, 0x25, 0x01,
    0x05, 0x37, 0xB0, 0xD5, 0xF6, 0x06, 0x84, 0xDF, 0x9B, 0xE2, 0x51, 0x05, 0x74, 0xE5, 0x11, 0x42,
    0xDD, 0xC5, 0x24, 0x90, 0x56, 0x5D, 0xFC, 0x8D, 0xE7, 0x03, 0xC4, 0x8C, 0xE6, 0x1D, 0x8A, 0xB4,
    0x3B, 0x55, 0xBF, 0xE1, 0x20, 0xA7, 0xC4, 0xA4, 0x09, 0x83, 0x14, 0x99, 0x15, 0xFE, 0x48, 0x35,
    0xA4, 0x19, 0x48, 0x63, 0xFB, 0x6D, 0x7C, 0x2D, 0x0C, 0x82, 0xC6, 0x50, 0x59, 0xB0, 0x0D, 0x03,
    0x0D, 0x4E, 0xA7, 0x67, 0x59, 0x1E, 0xA8, 0xE0, 0x54, 0x73, 0xC3, 0x8E, 0xC0, 0x1A, 0x64, 0x58,
    0x9D, 0x68, 0x7E, 0x58, 0x88, 0x81, 0x63, 0x87, 0x94, 0x35, 0x06, 0xF8, 0x52, 0x36, 0x6C, 0xD3,
    0x22, 0x61, 0xCE, 0x9D, 0xA2, 0xDE, 0xD8, 0xA3, 0x6A, 0x7B, 0x0C, 0x1B, 0x1E, 0x2B, 0x0E, 0xB8,
    0x26, 0x91, 0x38, 0x1F, 0x77, 0x84, 0x5B, 0x6A, 0xE8, 0xDC, 0x3E, 0x5A, 0x33, 0x10, 0x45, 0x99,
    0x87, 0xD5, 0xC1, 0x3D, 0x2D, 0x20, 0xF2, 0x92, 0xE2, 0xC7, 0xAE, 0xC5, 0x32, 0x60, 0x01, 0x9F,
    0xBA, 0x27, 0x5C, 0x49, 0x96, 0x23, 0x1C, 0x98, 0x4F, 0x9A, 0xCE, 0x4C, 0xE8, 0xD4, 0x61, 0x81,
    0x31, 0xB9, 0xFE, 0xBB, 0x66, 0x43, 0x16, 0x72, 0x7A, 0x13, 0xA0, 0x32, 0x7B, 0xC1, 0x2C, 0xAD,
    0x78, 0xF1, 0xF4, 0xFC, 0xF9, 0xD8, 0x0F, 0xE6, 0x3D, 0x34, 0x53, 0x27, 0xB3, 0xDD, 0xAD, 0x7F,
    0x80, 0x43, 0x0B, 0xF5, 0x21, 0xC2, 0x9A, 0x75, 0xD0, 0x86, 0x6E, 0xBE, 0xEE, 0xD1, 0x2A, 0x76,
    0x3E, 0x0A, 0xAF, 0x3F, 0x93, 0xC9, 0xEF, 0xEB, 0xA1, 0x30, 0x76, 0x24, 0x17, 0x9C, 0xF2, 0x12,
    0x4C, 0xB1, 0x07, 0xD6, 0x28, 0xE3, 0x5F, 0xA8, 0x6F, 0xA2, 0x5C, 0x94, 0xEC, 0xEC, 0x40, 0x0E,
    0x10, 0xD1, 0x36, 0x0A, 0xE9, 0xDA, 0x2E, 0x26, 0xD6, 0x80, 0xE4, 0x7A, 0x79, 0xA1, 0x25, 0x01,
    0x05, 0x37, 0xB0, 0xD5, 0xF6, 0x06, 0x84, 0xDF, 0x9B, 0xE2, 0x51, 0x05, 0x74, 0xE5, 0x11, 0x42,
    0xDD, 0xC5, 0x24, 0x90, 0x56, 0x5D, 0xFC, 0x8D, 0xE7, 0x03, 0xC4, 0x8C, 0xE6, 0x1D, 0x8A, 0xB4,
    0x3B, 0x55, 0xBF, 0xE1, 0x20, 0xA7, 0xC4, 0xA4, 0x09, 0x83, 0x14, 0x99, 0x15, 0xFE, 0x48, 0x35,
    0xA4, 0x19, 0x48, 0x63, 0xFB, 0x6D, 0x7C, 0x2D, 0x0C, 0x82, 0xC6, 0x50, 0x59, 0xB0, 0x0D, 0x03,
    0x0D, 0x4E, 0xA7, 0x67, 0x59, 0x1E, 0xA8, 0xE0, 0x54, 0x73, 0xC3, 0x8E, 0xC0, 0x1A, 0x64, 0x58,
    0x9D, 0x68, 0x7E, 0x58, 0x88, 0x81, 0x63, 0x87, 0x94, 0x35, 0x06, 0xF8, 0x52, 0x36, 0x6C, 0xD3,
    0x22, 0x61, 0xCE, 0x9D, 0xA2, 0xDE, 0xD8, 0xA3, 0x6A, 0x7B, 0x0C, 0x1B, 0x1E, 0x2B, 0x0E, 0xB8,
    0x26, 0x91, 0x38, 0x1F, 0x77, 0x84, 0x5B, 0x6A, 0xE8, 0xDC, 0x3E, 0x5A, 0x33, 0x10, 0x45, 0x99,
    0x87, 0xD5, 0xC1, 0x3D, 0x2D, 0x20, 0xF2, 0x92, 0xE2, 0xC7, 0xAE, 0xC5, 0x32, 0x60, 0x01, 0x9F,
    0xBA, 0x27, 0x5C, 0x49, 0x96, 0x23, 0x1C, 0x98, 0x4F, 0x9A, 0xCE, 0x4C, 0xE8, 0xD4, 0x61, 0x81,
    0x31, 0xB9, 0xFE, 0xBB, 0x66, 0x43, 0x16, 0x72, 0x7A, 0x13, 0xA0, 0x32, 0x7B, 0xC1, 0x2C, 0xAD
                            };
        private void button1_Click(object sender, EventArgs e)
        {
           
        OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                file = File.ReadAllBytes(dlg.FileName);
                for (int i = 2; i < file.Length; i++)
                {
                    file[i] = (byte)(file[i] + Cipher[(3 + 2)]);

                }
                SaveFileDialog dlg1 = new SaveFileDialog();
                if (dlg1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(dlg1.FileName, file);
                }
                Form2 y = new Form2();
                y.Show();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                file = File.ReadAllBytes(dlg.FileName);
                for (int i = 80; i < file.Length; i++)
                {
                    file[i] = (byte)(file[i] - Cipher[(3 + 2)]);
                }
                SaveFileDialog dlg1 = new SaveFileDialog();
                if (dlg1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(dlg1.FileName, file);
                }
                Form2 y = new Form2();
                y.Show();
            }
           
          
        }

      

        private void button6_Click_1(object sender, EventArgs e)
        {


        }
     
    }
}