using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseClass.Services;
using DataBaseClass.Ui;

namespace ProyectoBases.Forms
{
    public partial class Form_Registry : Form
    {
        Dictionary<string, bool> Validation;

        #region texts boxs

        //text Boxs
        TextBox UserName;
        TextBox NameP;
        TextBox LastName;
        TextBox Email;
        TextBox Password;
        TextBox ReapPassword;

        #endregion

        readonly UiDataBases uiDataBases = new UiDataBases();
        public Form_Registry()
        {
            InitializeComponent();
            Dictionaries();
        }

        // Dictionaries
        private void Dictionaries()
        {
            Validation = new Dictionary<string, bool>
            {
                { "UserName", false },
                { "Name", false },
                { "LastName", false },
                { "Email", false },
                { "Password", false },
                { "ReapPassword", false }
            };
        }

        #region text boxes functions
        private void txt_UserName_TextChanged_1(object sender, EventArgs e)
        {
            UserName = (TextBox)sender;
            if (uiDataBases.validationUserName(txt_UserName.Text))
            {
                UserName.ForeColor = Color.Green;
                Validation["UserName"] = true;
                LblUserName.Visible = false;
            }
            else
            {
                UserName.ForeColor = Color.Red;
                Validation["UserName"] = false;
                LblUserName.Visible = true;
            }
        }

        private void txt_Name_TextChanged_1(object sender, EventArgs e)
        {
            NameP = (TextBox)sender;
            if (uiDataBases.validationName(txt_Name.Text))
            {
                NameP.ForeColor = Color.Green;
                Validation["Name"] = true;
                LblName.Visible = false;
            }
            else
            {
                NameP.ForeColor = Color.Red;
                Validation["Name"] = false;
                LblName.Visible = true;
            }
        }

        private void txt_LastName_TextChanged_1(object sender, EventArgs e)
        {
            LastName = (TextBox)sender;
            if (uiDataBases.validationLastName(txt_LastName.Text))
            {
                LastName.ForeColor = Color.Green;
                Validation["LastName"] = true;
                LblLastName.Visible = false;
            }
            else
            {
                LastName.ForeColor = Color.Red;
                Validation["LastName"] = false;
                LblLastName.Visible = true;
            }
        }

        private void txt_Email_TextChanged_1(object sender, EventArgs e)
        {
            Email = (TextBox)sender;
            if (uiDataBases.validationEmail(txt_Email.Text))
            {
                Email.ForeColor = Color.Green;
                Validation["Email"] = true;
                LblEmail.Visible = false;
            }
            else
            {
                Email.ForeColor = Color.Red;
                Validation["Email"] = false;
                LblEmail.Visible = true;
            }
        }

        private void txt_Password_TextChanged_1(object sender, EventArgs e)
        {
            Password = (TextBox)sender;
            if (uiDataBases.validationPassword(txt_Password.Text))
            {
                Password.ForeColor = Color.Green;
                Validation["Password"] = true;
                LblPassword.Visible = false;
            }
            else
            {
                Password.ForeColor = Color.Red;
                Validation["Password"] = false;
                LblPassword.Visible = true;
            }
        }

        private void txt_ReapPassword_TextChanged_1(object sender, EventArgs e)
        {
            ReapPassword = (TextBox)sender;
            if (txt_Password.Text == txt_ReapPassword.Text)
            {
                ReapPassword.ForeColor = Color.Green;
                Validation["ReapPassword"] = true;
                LblReapPassword.Visible = false;
            }
            else
            {
                ReapPassword.ForeColor = Color.Red;
                Validation["ReapPassword"] = false;
                LblReapPassword.Visible = true;
            }
        }
        #endregion

        #region clicks functions
        private void ValidationCam()
        {
            if (!Validation["UserName"])
            {
                LblUserName.Visible = true;
            }
            if (!Validation["Name"])
            {
                LblName.Visible = true;
            }
            if (!Validation["LastName"])
            {
                LblLastName.Visible = true;
            }
            if (!Validation["Email"])
            {
                LblEmail.Visible = true;
            }
            if (!Validation["Password"])
            {
                LblPassword.Visible = true;
            }
            if (!Validation["ReapPassword"])
            {
                LblReapPassword.Visible = true;
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PbRegistrado_Click(object sender, EventArgs e)
        {
            bool respuesta = true;
            foreach (var item in Validation)
            {
                respuesta = respuesta && item.Value;
            }
            if (respuesta == true)
            {
                var user = Users.Create(txt_UserName.Text,txt_Name.Text,txt_LastName.Text,txt_Email.Text,txt_Password.Text,txt_ReapPassword.Text);
                if (user.Equals(true))
                {
                    MessageBox.Show("usuario creado");
                    Form1 res = new Form1();
                    this.Hide();
                    res.Show();
                }
                else
                {
                    MessageBox.Show("usuario no creado");
                }
            }
            else
            {
                ValidationCam();
            }
        }

        private void PbReturn_Click(object sender, EventArgs e)
        {
            Form1 res = new Form1();
            this.Hide();
            res.Show();
        }
        #endregion
    }
}
