using DataBaseClass.Activities;
using DataBaseClass.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBases.Forms
{
    public partial class Form_Create_project : Form
    {
        public Form_Create_project()
        {
            InitializeComponent();
        }

        private void Btn_Create_project_Profile_Click(object sender, EventArgs e)
        {
            Form_profil form_Profil = new Form_profil();
            this.Hide();
            form_Profil.Show();
        }

        private void Btn_Create_project_Click(object sender, EventArgs e)
        {
            var model = Models.Create_Model(Txt_ProjectName.Text, Txt_ProjectDescription.Text, Profile_information.Id);
            if (model.Equals(true))
            {
                MessageBox.Show("Create project");
                Form_profil form_Profil = new Form_profil();
                this.Hide();
                form_Profil.Show();
            }
            else
            {
                MessageBox.Show("Create not project");
                Form_profil form_Profil = new Form_profil();
                this.Hide();
                form_Profil.Show();
            }
        }
    }
}
