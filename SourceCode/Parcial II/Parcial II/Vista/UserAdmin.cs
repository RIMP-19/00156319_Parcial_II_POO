using System;
using System.Drawing;
using System.Windows.Forms;
using Parcial_II.Modelo;
using Parcial_II.Controlador;

namespace Parcial_II.Vista
{
    public partial class UserAdmin : UserControl
    {
        
        private static readonly Font CFontLight = 
            new Font(CustomFonts.CustomFont(CustomFonts.FontType.Light).Families[0],25.0f);
        private static readonly Font CFontBlack = 
            new Font(CustomFonts.CustomFont(CustomFonts.FontType.Black).Families[0],18.0f);
        
        private static User _userData;
        public UserAdmin(User userDt)
        {
            InitializeComponent();
            _userData = userDt;
        }
    }
}