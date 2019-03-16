﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Examination
{
    public partial class UpdateDoctorForm : Form
    {
        public UpdateDoctorForm()
        {
            InitializeComponent();
            this.BackColor = AuthorizationForm.bgcolor;
            this.BackgroundImage = AuthorizationForm.bgimage;
            label1.ForeColor = AuthorizationForm.textcolor;
            checkBox1.ForeColor = AuthorizationForm.textcolor;
            checkBox2.ForeColor = AuthorizationForm.textcolor;
            textBox1.BackColor = Color.FromArgb(160, 160, 160);
            textBox2.BackColor = Color.FromArgb(160, 160, 160);
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.BackColor = Color.FromArgb(255, 255, 255);
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.BackColor = Color.FromArgb(160, 160, 160);
                textBox1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.BackColor = Color.FromArgb(255, 255, 255);
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.BackColor = Color.FromArgb(160, 160, 160);
                textBox2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                label2.Text = "Вы успешно внесли данные";
            }
            else
            {
                label2.Text = "Вы ничего не изменили";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}