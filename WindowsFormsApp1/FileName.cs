﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
        public FrmFileName()
        {
            InitializeComponent();
        }

        private void FileName_Load(object sender, EventArgs e)
        {

        }
        
        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text + "txt";
            Close();
        }
    }
}
