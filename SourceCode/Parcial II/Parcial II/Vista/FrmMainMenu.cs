using System;
using System.Drawing;
using System.Windows.Forms;
using Parcial_II.Controlador;
using Parcial_II.Modelo;

namespace Parcial_II.Vista
{
    public partial class FrmMainMenu : Form
    {
        private static readonly Font CFontUltra = 
            new Font(CustomFonts.CustomFont(CustomFonts.FontType.Ultra).Families[0],40.0f);

        private static readonly Font CFontBlack = 
            new Font(CustomFonts.CustomFont(CustomFonts.FontType.Black).Families[0],12.0f);

        private static User _userData;
        
        private static UserControl _current;
        
        public FrmMainMenu(User userD)
        {
            InitializeComponent();
            lblTittle.Font = CFontUltra;
            btnUsuario.Font = CFontBlack;
            btnOrders.Font = CFontBlack;
            btnAddress.Font = CFontBlack;
            btnBusiness.Font = CFontBlack;
            btnProducts.Font = CFontBlack;
            _userData = userD;
            _current = null;

            if (!_userData.UserType.Equals("Normal")) return;
            
            btnAddress.Visible = false;
            btnAddress.Enabled = false;
            btnBusiness.Visible = false;
            btnBusiness.Enabled = false;
            btnProducts.Visible = false;
            btnProducts.Enabled = false;
        }

        private void lblTittle_FontChanged(object sender, EventArgs e)
        {
            lblTittle.Font = CFontUltra;
        }

        private void btnUsuario_FontChanged(object sender, EventArgs e)
        {
            btnUsuario.Font = CFontBlack;
        }

        private void btnOrders_FontChanged(object sender, EventArgs e)
        {
            btnOrders.Font = CFontBlack;
        }

        private void btnAddress_FontChanged(object sender, EventArgs e)
        {
            btnAddress.Font = CFontBlack;
        }

        private void btnBusiness_FontChanged(object sender, EventArgs e)
        {
            btnBusiness.Font = CFontBlack;
        }

        private void btnProducts_FontChanged(object sender, EventArgs e)
        {
            btnProducts.Font = CFontBlack;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (_userData.UserType.Equals("Normal"))
            {
                if(_current != null)
                    tlpMainMenu.Controls.Remove(_current);
                _current = new NormalUser(_userData){Dock = DockStyle.Fill};
                tlpMainMenu.Controls.Add(_current,1,1);
                tlpMainMenu.SetRowSpan(_current,5);
            }
            else
            {
                if(_current != null)
                    tlpMainMenu.Controls.Remove(_current);
                _current = new UserAdmin(_userData){Dock = DockStyle.Fill};
                tlpMainMenu.Controls.Add(_current,1,1);
                tlpMainMenu.SetRowSpan(_current,5);
            }
        }

        private void FrmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}