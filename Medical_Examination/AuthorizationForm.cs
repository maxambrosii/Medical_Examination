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
    public partial class AuthorizationForm : Form
    {
        public SqlConnection connection = null;
        public static Color bgcolor, textcolor;
        public static Image bgimage;
        private int error_login = 0, lvlacces = 0;
        private bool isCorrect = false;
        public AuthorizationForm()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
            bgcolor = Color.FromArgb(45, 45, 45);
            textcolor = Color.FromArgb(255, 255, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignIn();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            AuthorizationForm.ActiveForm.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                SignIn();
        }

        private async void AuthorizationForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hi-tech\Desktop\Medical_Examination\Medical_Examination\Dispanserizatsia.mdf;Integrated Security=True;Connect Timeout=30");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection failed!\n" + ex);
            }
            finally
            {

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                SignIn();
        }

        private void SignIn()
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox1.Text == "1" && textBox2.Text == "1")
                {
                    lvlacces = 1;
                    isCorrect = true;
                }
                if (textBox1.Text == "tanya" && textBox2.Text == "qwerty")
                {
                    lvlacces = 2;
                    isCorrect = true;
                }
            }
            if (isCorrect == true)
            {
                /*
                this.Hide();
                GeneralForm gform = new GeneralForm(lvlacces);
                gform.ShowDialog();
                gform = null;
                this.Show();
                */
                this.Hide();
                var generalform = new GeneralForm(lvlacces);
                generalform.Closed += (s, args) => this.Close();
                generalform.Show();
                label3.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                isCorrect = false;
                this.BackColor = AuthorizationForm.bgcolor;
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                label3.Text = "Неправильный логин или пароль";
                error_login++;
            }
            if (error_login == 3)
                Application.Exit();
            this.ActiveControl = textBox1;
        }
    }
}
