using System;
using System.Drawing;
using System.Windows.Forms;
using Parcial_II.Controlador;
using Parcial_II.Modelo;

namespace Parcial_II.Vista
{
    public partial class LogIn : Form
    {
        static Font _cFontUltra = 
            new Font(CustomFonts.CustomFont(CustomFonts.FontType.Ultra).Families[0],40.0f);
        static Font _cFontBlack = 
            new Font(CustomFonts.CustomFont(CustomFonts.FontType.Black).Families[0],18.0f);
        public LogIn()
        {
            InitializeComponent();
            ActiveControl = lblTittle;
            lblTittle.Font = _cFontUltra;
            btnLogIn.Font = _cFontBlack;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.ForeColor = Color.Black;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals("")) return;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.Text = @" Contraseña";
            txtPassword.ForeColor = SystemColors.GrayText;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtUser.BackColor = SystemColors.Window;
            txtUser.ForeColor = Color.Black;
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (!txtUser.Text.Equals("")) return;
            txtUser.BackColor = SystemColors.Control;
            txtUser.Text = @" Usuario";
            txtUser.ForeColor = SystemColors.GrayText;
        }

        private void btnLogIn_MouseEnter(object sender, EventArgs e)
        {
            btnLogIn.ForeColor = SystemColors.GrayText;
        }

        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            btnLogIn.ForeColor = Color.White;
        }

        private void btnLogIn_FontChanged(object sender, EventArgs e)
        {
            btnLogIn.Font = _cFontBlack;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                var userData = UserDAO.CheckLogIn(txtUser.Text, txtPassword.Text);
                
                new FrmMainMenu(userData).Show();
                Hide();
            }
            catch (InvalidCredentialsException ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK,
                     MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void lblTittle_FontChanged(object sender, EventArgs e)
        {
            lblTittle.Font = _cFontUltra;
        }
    }
}