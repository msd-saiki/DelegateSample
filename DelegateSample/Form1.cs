﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form2((empEntity) => {
                textBox1.Text = $"{empEntity.EmpNo.ToString().PadLeft(10, '0')}:{empEntity.EmpName}";
            });
            form.ShowDialog(this);
        }
    }
}
