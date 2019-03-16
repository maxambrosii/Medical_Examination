using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Medical_Examination
{
    public partial class GeneralForm : Form
    {
        public GeneralForm(int lvlaccept)
        { 
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
            //EditThemeToolStripMenuItem.Enabled = false;
            if (lvlaccept == 2)
            {
                EditToolStripMenuItem.Enabled = false;
                //EditToolStripMenuItem.Visible = false;
                BackupToolStripMenuItem.Enabled = false;
            }
            this.BackColor = AuthorizationForm.bgcolor;
            exitToolStripMenuItem.Visible = false;
        }
        private void ExitFromAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        private void LightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(255, 236, 233, 216);
            menuStrip1.BackColor = Color.FromArgb(240, 240, 240);
            ExitFromAccountToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            ViewDoctorToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            ViewPacientToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            ViewMedicineToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            ViewRecipientToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            ViewTreatmentToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            EditAddToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            PatientToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            DoctorToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            MedicineToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            DiagnosisToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            ReceptionToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            EditUpdateToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            EditDeleteToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            EditThemeToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            LightToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            DarkToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            BackgroundColorToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            GrayToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            WhiteToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            LightBlueToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            RoseToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            GradientLightBlueToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            BackupToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            ReferenceToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            SupportToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            EditUpdatePatientToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            EditUpdateDoctorToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            EditUpdateReceptionToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);

            ControllToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            ExitFromAccountToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            ViewDoctorToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            ViewPacientToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            ViewMedicineToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            ViewRecipientToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            ViewTreatmentToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            EditToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            ToolsToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            HelpToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            exitToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            ViewToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            EditAddToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            PatientToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            DoctorToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            MedicineToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            DiagnosisToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            ReceptionToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            EditUpdateToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            EditDeleteToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            EditThemeToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            LightToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            DarkToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            BackgroundColorToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            GrayToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            WhiteToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            LightBlueToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            RoseToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            GradientLightBlueToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            BackupToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            ReferenceToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            SupportToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            EditUpdatePatientToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            EditUpdateDoctorToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            EditUpdateReceptionToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);

            MyRenderer.CurrentColor = Color.FromArgb(255, 255, 255);
            MyRenderer.MenuItemBorderColor = Color.DarkBlue;
            MyRenderer.MenuItemSelectedColor = Color.LightBlue;

        }

        private void DarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.FromArgb(85, 85, 85);
            ExitFromAccountToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            ExitFromAccountToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            ViewDoctorToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            ViewPacientToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            ViewMedicineToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            ViewRecipientToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            ViewTreatmentToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            EditAddToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            PatientToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            DoctorToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            MedicineToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            DiagnosisToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            ReceptionToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            EditUpdateToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            EditDeleteToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            EditThemeToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            LightToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            DarkToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            BackgroundColorToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            GrayToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            WhiteToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            LightBlueToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            RoseToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            GradientLightBlueToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            BackupToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            ReferenceToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            SupportToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            EditUpdatePatientToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            EditUpdateDoctorToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);
            EditUpdateReceptionToolStripMenuItem.BackColor = Color.FromArgb(85, 85, 85);

            ExitFromAccountToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            ControllToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            ViewDoctorToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            ViewPacientToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            ViewMedicineToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            ViewRecipientToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            ViewTreatmentToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            EditToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            ToolsToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            HelpToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            exitToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            ViewToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            EditAddToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            PatientToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            DoctorToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            MedicineToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            DiagnosisToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            ReceptionToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            EditUpdateToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            EditDeleteToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            EditThemeToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            LightToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            DarkToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            BackgroundColorToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            GrayToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            WhiteToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            LightBlueToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            RoseToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            GradientLightBlueToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            BackupToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            ReferenceToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            SupportToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            EditUpdatePatientToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            EditUpdateDoctorToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            EditUpdateReceptionToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);

            MyRenderer.CurrentColor = Color.FromArgb(30, 30, 30);
            MyRenderer.MenuItemBorderColor = Color.Transparent;
            MyRenderer.MenuItemSelectedColor = Color.FromArgb(30, 30, 30);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            AuthorizationForm.ActiveForm.Close();
        }

        private void PacientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPatientForm pacientform = new AddPatientForm();
            pacientform.ShowDialog();
            pacientform = null;
            this.Show();
        }

        private void DoctorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDoctorForm doctorform = new AddDoctorForm();
            doctorform.ShowDialog();
            doctorform = null;
            this.Show();
        }

        private void MedicineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMedicineForm medicineform = new AddMedicineForm();
            medicineform.ShowDialog();
            medicineform = null;
            this.Show();
        }

        private void ReceptionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddReceptionForm receptionform = new AddReceptionForm();
            receptionform.ShowDialog();
            receptionform = null;
            this.Show();
        }

        private void DiagnosisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDiagnosisForm diagnosisform = new AddDiagnosisForm();
            diagnosisform.ShowDialog();
            diagnosisform = null;
            this.Show();
        }

        private void WhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm.bgimage = null;
            AuthorizationForm.bgcolor = Color.FromArgb(255, 255, 255);
            AuthorizationForm.textcolor = Color.FromArgb(0, 0, 0);
            this.BackColor = AuthorizationForm.bgcolor;
            this.BackgroundImage = AuthorizationForm.bgimage;
        }

        private void GreyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm.bgimage = null;
            AuthorizationForm.bgcolor = Color.FromArgb(45, 45, 45);
            AuthorizationForm.textcolor = Color.FromArgb(255, 255, 255);
            this.BackColor = AuthorizationForm.bgcolor;
            this.BackgroundImage = AuthorizationForm.bgimage;
        }

        private void LightBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm.bgimage = null;
            AuthorizationForm.bgcolor = Color.FromArgb(180, 255, 255);
            AuthorizationForm.textcolor = Color.FromArgb(0, 0, 0);
            this.BackColor = AuthorizationForm.bgcolor;
            this.BackgroundImage = AuthorizationForm.bgimage;
        }

        private void RoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm.bgimage = null;
            AuthorizationForm.bgcolor = Color.FromArgb(255, 188, 185);
            AuthorizationForm.textcolor = Color.FromArgb(0, 0, 0);
            this.BackColor = AuthorizationForm.bgcolor;
            this.BackgroundImage = AuthorizationForm.bgimage;
        }

        private void GradientLightBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm.bgimage = Properties.Resources.Untitled_13;
            AuthorizationForm.textcolor = Color.FromArgb(0, 0, 0);
            this.BackColor = AuthorizationForm.bgcolor;
            this.BackgroundImage = AuthorizationForm.bgimage;
        }

        private void EditUpdatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdatePatientForm pacientform = new UpdatePatientForm();
            pacientform.ShowDialog();
            pacientform = null;
            this.Show();
        }

        private void EditUpdateDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateDoctorForm doctorform = new UpdateDoctorForm();
            doctorform.ShowDialog();
            doctorform = null;
            this.Show();
        }

        private void EditUpdateReceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateReceptionForm receptionform = new UpdateReceptionForm();
            receptionform.ShowDialog();
            receptionform = null;
            this.Show();
        }

        private void EditDeletePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletePatientForm deletepatientform = new DeletePatientForm();
            deletepatientform.ShowDialog();
            deletepatientform = null;
            this.Show();
        }

        private void EditDeleteDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteDoctorForm deletedoctorform = new DeleteDoctorForm();
            deletedoctorform.ShowDialog();
            deletedoctorform = null;
            this.Show();
        }

    }

    public class MyRenderer : ToolStripProfessionalRenderer
    {
        public static Color CurrentColor = Color.FromArgb(255, 255, 255);
        public static Color MenuItemBorderColor = Color.DarkBlue;
        public static Color MenuItemSelectedColor = Color.LightBlue;
        public MyRenderer() : base(new MyColors()) { }
    }

    public class MyColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return MyRenderer.MenuItemSelectedColor; } // эта
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return MyRenderer.CurrentColor; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return MyRenderer.CurrentColor; } // и эта
        }
        //public override Color MenuStripGradientBegin
        //{
        //    get { return Color.Green; }
        //}
        //public override Color MenuBorder
        //{
        //    get { return Color.Red; }
        //}
        public override Color MenuItemPressedGradientMiddle
        {
            get { return Color.HotPink; }
        }
        public override Color MenuItemPressedGradientBegin // this
        {
            get { return MyRenderer.CurrentColor; }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return MyRenderer.CurrentColor; }
        }
        public override Color MenuItemBorder
        {
            get { return MyRenderer.MenuItemBorderColor; } // Обводка итемов при навидение
        }
    }
}
