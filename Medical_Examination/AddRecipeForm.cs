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
    public partial class AddRecipeForm : Form
    {
        int numRows, codRecipe;
        public AddRecipeForm()
        {
            InitializeComponent();
            this.BackColor = AuthorizationForm.bgcolor;
            this.BackgroundImage = AuthorizationForm.bgimage;
            listBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codRecipe = 5000 + numRows;
            Close();
        }
    }
}
