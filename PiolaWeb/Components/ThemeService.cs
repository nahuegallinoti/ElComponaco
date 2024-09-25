using MudBlazor;

namespace PiolaWeb.Components;
public class ThemeService
{
    public MudTheme CreateCustomTheme()
    {
        TemaPiolaDark paletaPiolaDark = new();
        TemaPiolaLight paletaPiolaLight = new();
        TipografiaPiola tipografiaPiola = new();

        MudTheme customTheme = new()
        {
            PaletteDark = new()
            {
                Primary = paletaPiolaDark.ColorPrimario,
                Secondary = paletaPiolaDark.ColorSecundario
            },

            PaletteLight = new()
            {
                Primary = paletaPiolaLight.ColorPrimario,
                Secondary = paletaPiolaLight.ColorSecundario
            },

            Typography = new()
            {
                H1 = tipografiaPiola.TituloPrincipal,
                Subtitle2 = tipografiaPiola.TextoPequeño
            }

        };

        return customTheme;
    }
}
