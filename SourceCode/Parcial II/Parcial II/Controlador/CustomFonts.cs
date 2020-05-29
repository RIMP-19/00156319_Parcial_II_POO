using System;
using System.Drawing.Text;

namespace Parcial_II.Controlador
{
    public static class CustomFonts
    {
        public enum FontType
        {
            Book = 0,
            Light = 1,
            Black = 2,
            Ultra = 3
        }

        public static PrivateFontCollection CustomFont(FontType type) {
            var pfc = new PrivateFontCollection();

            switch (type)
            {
                case FontType.Book:
                    pfc.AddFontFile("Gotham Book.ttf");
                    break;
                case FontType.Light:
                    pfc.AddFontFile("Gotham Light.otf");
                    break;
                case FontType.Black:
                    pfc.AddFontFile("Gotham Black.otf");
                    break;
                case FontType.Ultra:
                    pfc.AddFontFile("Gotham Ultra.ttf");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return pfc;
        }
    }
}