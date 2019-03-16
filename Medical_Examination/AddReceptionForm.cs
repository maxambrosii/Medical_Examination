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
    public partial class AddReceptionForm : Form
    {
        int numRows, codReception;
        public AddReceptionForm()
        {
            InitializeComponent();
            //dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.BackColor = AuthorizationForm.bgcolor;
            this.BackgroundImage = AuthorizationForm.bgimage;
            label1.ForeColor = AuthorizationForm.textcolor;
            label2.ForeColor = AuthorizationForm.textcolor;
            label3.ForeColor = AuthorizationForm.textcolor;
            label4.ForeColor = AuthorizationForm.textcolor;
            label5.ForeColor = AuthorizationForm.textcolor;
            label7.ForeColor = AuthorizationForm.textcolor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codReception = 3000 + numRows;
            label6.Text = "Вы успешно внесли данные";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRecipeForm recipeform = new AddRecipeForm();
            recipeform.ShowDialog();
            recipeform = null;
            this.Show();
        }
    }
}
