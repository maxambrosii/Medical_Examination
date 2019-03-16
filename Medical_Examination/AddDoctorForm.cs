using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Medical_Examination
{
    public partial class AddDoctorForm : Form
    {
        //int codDoctor;
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Medical_Examination\Medical_Examination\Dispanserizatsia.mdf;Integrated Security=True;Connect Timeout=30");

        public AddDoctorForm()
        {
            InitializeComponent();
            this.BackColor = AuthorizationForm.bgcolor;
            this.BackgroundImage = AuthorizationForm.bgimage;
            label1.ForeColor = AuthorizationForm.textcolor;
            label2.ForeColor = AuthorizationForm.textcolor;
            label3.ForeColor = AuthorizationForm.textcolor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "Вы успешно внесли данные";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
