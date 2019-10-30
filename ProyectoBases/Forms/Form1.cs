using DataBaseClass.Activities;
using DataBaseClass.Services;
using System;
using System.Windows.Forms;

namespace ProyectoBases.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Registry_Click_1(object sender, EventArgs e)
        {
            Form_Registry registry = new Form_Registry();
            this.Hide();
            registry.Show();
        }

        private void Btn_ingresar_Click_1(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var user = Users.Search(Txt_User.Text, Txt_User.Text);
            if (user != null)
            {
                if (user.password.Equals(Txt_Password.Text))
                {
                    Profile_information.Id = user.id;
                    Form_profil profil = new Form_profil();
                    this.Hide();
                    profil.Show();
                }
                else
                {
                    MessageBox.Show("La contraseña es invalida");
                }
            }
            else
            {
                MessageBox.Show("El correo no esta registrado o puede ya existir");
            }
        }

        private void Txt_Password_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }


    }
}
