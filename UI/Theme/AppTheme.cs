using MudBlazor;

namespace UI
{
    public class AppTheme
    {
        private static MudTheme _theme;

        public static MudTheme GetTheme() => _theme;
        public static MudTheme Initialize()
        {
            _theme = new MudTheme()
            {
                Palette = new PaletteLight()
                {
                    Primary = "#00008b",
                    AppbarBackground = "#00008b",
                    DrawerBackground = Colors.Grey.Lighten5,
                    Background = Colors.Grey.Lighten4,
                },

                LayoutProperties = new LayoutProperties()
                {
                    DrawerWidthLeft = "260px",
                    DrawerWidthRight = "300px",
                    AppbarHeight = "8vh",
                }
            };

            return _theme;
        }
    }
}