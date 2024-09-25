using MudBlazor;

namespace PiolaWeb.Components;
public class TipografiaPiola
{
    public H1 TituloPrincipal { get; set; } = new();
    public Subtitle2 TextoPequeño { get; set; } = new();

    public TipografiaPiola()
    {
        TituloPrincipal = new()
        {
            FontFamily = ["Arial", "Helvetica", "sans-serif"], // Define la familia de fuentes
            FontSize = "10rem", // Establece el tamaño de fuente
            FontWeight = 700, // Establece el peso de la fuente
            LineHeight = 1.5, // Establece la altura de línea
            LetterSpacing = "0.5em" // Establece el espaciado entre letras
        };

        TextoPequeño = new()
        {
            FontFamily = ["Arial", "Helvetica", "sans-serif"], // Define la familia de fuentes
            FontSize = "5rem", // Establece el tamaño de fuente
            FontWeight = 500, // Establece el peso de la fuente
            LineHeight = 1.5, // Establece la altura de línea
            LetterSpacing = "0.05em" // Establece el espaciado entre letras
        };
    }
}