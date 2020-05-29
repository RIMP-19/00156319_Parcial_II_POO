using System;
using System.Drawing;
using System.Windows.Forms;
using Parcial_II.Controlador;
using Parcial_II.Modelo;
using DBC = Parcial_II.Modelo.DBConnection;

namespace Parcial_II.Vista
{
    public partial class NormalUser : UserControl
    {
        private static readonly Font CFontLight = 
            new Font(CustomFonts.CustomFont(CustomFonts.FontType.Light).Families[0],25.0f);
        private static readonly Font CFontBlack = 
            new Font(CustomFonts.CustomFont(CustomFonts.FontType.Black).Families[0],18.0f);
        
        private static User _userData;
        public NormalUser(User userDt)
        {
            InitializeComponent();
            lblTittle.Font = CFontLight;
            btnChangePass.Font = CFontBlack;
            _userData = userDt;
        }

        private void lblTittle_FontChanged(object sender, EventArgs e)
        {
            lblTittle.Font = CFontLight;
        }

        private void txtActual_Enter(object sender, EventArgs e)
        {
            txtActual.Text = "";            
            txtActual.ForeColor = Color.Black;
            txtActual.UseSystemPasswordChar = true;
        }

        private void txtActual_Leave(object sender, EventArgs e)
        {
            if (!txtActual.Text.Equals("")) return;
            txtActual.Text = @" Contraseña actual";
            txtActual.ForeColor = SystemColors.GrayText;
            txtActual.UseSystemPasswordChar = false;
        }

        private void btnChangePass_FontChanged(object sender, EventArgs e)
        {
            btnChangePass.Font = CFontBlack;
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            txtNewPass.Text = "";
            txtNewPass.ForeColor = Color.Black;
            txtNewPass.UseSystemPasswordChar = true;
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            if (!txtNewPass.Text.Equals("")) return;
            txtNewPass.Text = @" Contraseña nueva";
            txtNewPass.ForeColor = SystemColors.GrayText;
            txtNewPass.UseSystemPasswordChar = false;
        }

        private void txtNewPass2_Enter(object sender, EventArgs e)
        {
            txtNewPass2.Text = "";
            txtNewPass2.ForeColor = Color.Black;
            txtNewPass2.UseSystemPasswordChar = true;
        }

        private void txtNewPass2_Leave(object sender, EventArgs e)
        {
            if (!txtNewPass2.Text.Equals("")) return;
            txtNewPass2.Text = @" Confirmar contraseña";
            txtNewPass2.ForeColor = SystemColors.GrayText;
            txtNewPass2.UseSystemPasswordChar = false;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                var passDb = DBC.ExecuteQuery("SELECT \"password\" FROM \"APPUSER\" WHERE " +
                                              $"username = '{_userData.Username}';").Rows[0][0].ToString();

                if (PasswordHashing.CheckPassword(txtActual.Text, passDb))
                {
                    if (!txtNewPass.Text.Equals(txtNewPass2.Text))
                        MessageBox.Show(@"Las contraseñas nuevas no coinciden",
                            @"Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                    else
                    {
                        var hashedNew = PasswordHashing.CreateHash(txtNewPass.Text);
                        var command = $"UPDATE \"APPUSER\" SET \"password\" = '{hashedNew}'" +
                                      $" WHERE username = '{_userData.Username}';";

                        DBC.ExecuteNonQuery(command);

                        MessageBox.Show(@"Contraseña actualizada", @"Completado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else
                {
                    MessageBox.Show(@"Su contraseña actual no es correcta", @"Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            finally
            {
                txtActual.Text = "";
                txtActual_Leave(null, EventArgs.Empty);
                txtNewPass.Text = "";
                txtNewPass_Leave(null,EventArgs.Empty);
                txtNewPass2.Text = "";
                txtNewPass2_Leave(null,EventArgs.Empty);
            }
        }
    }
}