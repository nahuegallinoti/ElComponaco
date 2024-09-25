using Koalas.Base;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Koalas.MudComponents
{
    public partial class Textop : ComponentBase
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter]
        public Tamaño Tamaño { get; set; } = Tamaño.Pequeño;

        private Typo Typo { get; set; }


        protected override void OnInitialized()
        {
            Typo = Tamaño switch
            {
                Tamaño.Pequeño => Typo.subtitle2,
                Tamaño.Mediano => Typo.h3,
                Tamaño.Grande => Typo.h1,
                _ => Typo.body1
            };
        }

    }
}
