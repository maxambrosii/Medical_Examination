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
    public partial class AddMedicineForm : Form
    {
        int numRows, codMedicine;
        public AddMedicineForm()
        {
            InitializeComponent();
            this.BackColor = AuthorizationForm.bgcolor;
            this.BackgroundImage = AuthorizationForm.bgimage;
            label1.ForeColor = AuthorizationForm.textcolor;
            label2.ForeColor = AuthorizationForm.textcolor;
            label3.ForeColor = AuthorizationForm.textcolor;
            label4.ForeColor = AuthorizationForm.textcolor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codMedicine = 4000 + numRows;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label5.Text = "Вы успешно внесли данные";
        }
    }
}
