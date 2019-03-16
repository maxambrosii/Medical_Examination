using System;
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
    public partial class UpdateReceptionForm : Form
    {
        public UpdateReceptionForm()
        {
            InitializeComponent();
            this.BackColor = AuthorizationForm.bgcolor;
            this.BackgroundImage = AuthorizationForm.bgimage;
            label1.ForeColor = AuthorizationForm.textcolor;
            checkBox1.ForeColor = AuthorizationForm.textcolor;
            checkBox2.ForeColor = AuthorizationForm.textcolor;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.BackColor = Color.FromArgb(255, 255, 255);
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.BackColor = Color.FromArgb(160, 160, 160);
                dateTimePicker1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker2.BackColor = Color.FromArgb(255, 255, 255);
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker2.BackColor = Color.FromArgb(160, 160, 160);
                dateTimePicker2.Enabled = false;
            }
        }
    }
}
