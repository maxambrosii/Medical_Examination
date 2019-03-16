using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Examination
{

    public partial class AddDiagnosisForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Medical_Examination\Medical_Examination\Dispanserizatsia.mdf;Integrated Security=True;Connect Timeout=30");
        int codDiagnosis;

        public AddDiagnosisForm()
        {
            InitializeComponent();
            this.BackColor = AuthorizationForm.bgcolor;
            this.BackgroundImage = AuthorizationForm.bgimage;
            label1.ForeColor = AuthorizationForm.textcolor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT MAX(Cod_Diagnoz) FROM DocDiagnoz", connection);

            codDiagnosis = 0;
            codDiagnosis = Convert.ToInt32(command.ExecuteScalar());
            codDiagnosis++;

            command = new SqlCommand("INSERT INTO DocDiagnoz(Cod_Diagnoz, Diagnoz) VALUES(@Cod, @Diagnoz)", connection);
            command.Parameters.AddWithValue("Cod", codDiagnosis);
            command.Parameters.AddWithValue("Diagnoz", textBox1.Text);

            command.ExecuteNonQuery();
            textBox1.Text = "";
            label2.Text = "Вы успешно внесли данные";
        }

        private void AddDiagnosisForm_Load(object sender, EventArgs e)
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

        private void AddDiagnosisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
    }
}
