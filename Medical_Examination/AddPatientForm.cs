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
    public partial class AddPatientForm : Form
    {
        int codPatient;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Medical_Examination\Medical_Examination\Dispanserizatsia.mdf;Integrated Security=True;Connect Timeout=30");

        public AddPatientForm()
        {
            InitializeComponent();
            this.BackColor = AuthorizationForm.bgcolor;
            this.BackgroundImage = AuthorizationForm.bgimage;
            label1.ForeColor = AuthorizationForm.textcolor;
            label2.ForeColor = AuthorizationForm.textcolor;
            label3.ForeColor = AuthorizationForm.textcolor;
            label4.ForeColor = AuthorizationForm.textcolor;
            label5.ForeColor = AuthorizationForm.textcolor;
            label6.ForeColor = AuthorizationForm.textcolor;
            label7.ForeColor = AuthorizationForm.textcolor;
            radioButton1.ForeColor = AuthorizationForm.textcolor;
            radioButton2.ForeColor = AuthorizationForm.textcolor;
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gender;
            if (radioButton1.Checked)
                gender = 0;
            else
                gender = 1;

            SqlCommand command = new SqlCommand("SELECT MAX(Cod_Pacient) FROM Pacient", connection);

            codPatient = 0;
            codPatient = Convert.ToInt32(command.ExecuteScalar());
            codPatient++;

            command = new SqlCommand("INSERT INTO Pacient(Cod_Pacient, FIO_Pacient, IDNP, Adress, Strahovka, Nr_Uchastka, age, gender) VALUES(@codPatient, @fio, @idnp, @adress, @strahovka, @nr_uchastka, @age, @gender)", connection);
            command.Parameters.AddWithValue("codPatient", codPatient);
            command.Parameters.AddWithValue("fio", textBox1.Text);
            command.Parameters.AddWithValue("idnp", textBox2.Text);
            command.Parameters.AddWithValue("adress", textBox3.Text);
            command.Parameters.AddWithValue("strahovka", textBox4.Text);
            command.Parameters.AddWithValue("nr_uchastka", textBox5.Text);
            command.Parameters.AddWithValue("age", DateTime.Now.Year - dateTimePicker1.Value.Year);
            command.Parameters.AddWithValue("gender", gender);
            command.ExecuteNonQuery();
            label8.Text = "Вы успешно внесли данные";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPatientForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Medical_Examination\Medical_Examination\Dispanserizatsia.mdf;Integrated Security=True;Connect Timeout=30");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            connection.Open();
        }

        private void AddPatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
