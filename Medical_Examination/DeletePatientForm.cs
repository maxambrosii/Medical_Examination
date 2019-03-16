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
    public partial class DeletePatientForm : Form
    {
        public DeletePatientForm()
        {
            InitializeComponent();
            this.BackColor = AuthorizationForm.bgcolor;
            this.BackgroundImage = AuthorizationForm.bgimage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить?", "Удаление пациента", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                label2.Text = "";
                label3.Text = "Вы успешно удалили данные";
                comboBox1.Text = "";
            }
            else if (dialogResult == DialogResult.No)
            {
                label2.Text = "";
                label3.Text = "";
                comboBox1.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "Вы выбрали : ФИО";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label4.Left > -label4.Width)
            {
                label4.Left -= 3;
            }
            else
            {
                label4.Left = label4.Width;
            }
        }
    }
}
