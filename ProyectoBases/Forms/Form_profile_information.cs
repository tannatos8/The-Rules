using DataBaseClass.Services;
using DataBaseClass.Activities;
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
    public partial class Form_profile_information : Form
    {
        public Form_profile_information()
        {
            InitializeComponent();
            information();
        }

        private void Btn_Return_profile_information_Click(object sender, EventArgs e)
        {
            Form_profil form_Profil = new Form_profil();
            this.Hide();
            form_Profil.Show();
        }
        private void information() 
        {
            var profiles_informations = Profiles_informations.Search_Profile(Profile_information.Id);
            Lbl_User_name_profile_information.Text = profiles_informations.user_name;
            Lbl_full_name_profile_information.Text = profiles_informations.name +" "+ profiles_informations.last_name;
            Lbl_ema_profile_information.Text = profiles_informations.email;
        }

        private void Btn_password_change_Click(object sender, EventArgs e)
        {
            Profiles_informations.Update_Profile(Profile_information.Id,Txt_new_password.Text, Txt_new_password_confirmation.Text);
        }
    }
}
