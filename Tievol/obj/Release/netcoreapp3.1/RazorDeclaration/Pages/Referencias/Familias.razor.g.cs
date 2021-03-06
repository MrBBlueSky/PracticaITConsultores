// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tievol.Pages.Referencias
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Tievol;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Tievol.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Tievol.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Tievol.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Tievol.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Referencias/Familias")]
    public partial class Familias : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
       

    //
    public List<Familia> LstFamilias { get; set; }
    public List<Estado> LstEstado { get; set; }

    //
    public string Accion { get; set; }
    public Familia SelectedFamilia { get; set; }

    //
    public string TituloWindow { get; set; }
    public string TituloButton { get; set; }
    public string IconButton { get; set; }

    public bool ShowWindow { get; set; } = false;

    public TelerikNotification Notification { get; set; }

    // Referencias de tipo
    private Telerik.Blazor.Components.TelerikNumericTextBox<int> IDInt;

    //
    protected override async Task OnInitializedAsync()
    {
        LstFamilias = await srvFamilia.GetFamilias();
        LstEstado = await srvEstado.GetEstados();
    }
    //
    private void OnCancel(MouseEventArgs e)
    {
        ShowWindow = false;

    }
    //
    private void OnClick(string cAccion, Familia familia) // Problem de Excepción nula, interrupción de la aplicación. 
    {
        ShowWindow = true;
        Accion = cAccion;
        SelectedFamilia = familia;

        if (cAccion == "Add")
        {   //
            SelectedFamilia = new Familia()
            {
                ID_Familia = 0,
                N_Familia = string.Empty,
                Estado = new Estado()
                {
                    ID_Estado = 0,
                    N_Estado = string.Empty
                }

            };

            TituloWindow = "Agregar Familia";
            IconButton = "add";
        }
        else
        {   //
            SelectedFamilia = familia;

            //
            if (Accion == "Upd")
            {
                TituloWindow = "Actualizar Familia";
                TituloButton = "Guardar";
                IconButton = "save";

            }
            else
            {
                TituloWindow = "Eliminar Familia";
                TituloButton = "Eliminar";
                IconButton = "delete";

            }
        }

        StateHasChanged();
        Task.Delay(1000);
    }
    //
    private async Task OnSave()
    {
        ShowWindow = false;
        if (Accion == "Add")
        {
            if (LstFamilias.Exists(f => f.N_Familia == SelectedFamilia.N_Familia))
            {
                //toast.ShowWarning("La descripción ya se encuentra en la lista...", "ATENCION");
                return;
            }

            var response = await srvFamilia.CreateAsync(SelectedFamilia);
            if (response.IsSuccess)
            {
                LstFamilias.Add(response.Result);
                //toast.ShowSuccess("Los datos se almacenaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        if (Accion == "Upd")
        {

            var response = await srvFamilia.UpdateAsync(SelectedFamilia);
            if (response.IsSuccess)
            {
                LstFamilias.Add(response.Result);
                var posicion = LstFamilias.FindIndex(f => f.ID_Familia == SelectedFamilia.ID_Familia);
                if (posicion == -1)
                {
                    //toast.ShowError("Se produjo un error inesperado...", "ERROR");
                }
                else
                {
                    LstFamilias[posicion] = SelectedFamilia;
                    Notification.Show(new NotificationModel()
                    {
                        Text = "Los datos se almacenaron correctamente...",
                        ThemeColor = "primary",
                        ShowIcon = true
                    });
                }
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        if (Accion == "Del")
        {
            var response = await srvFamilia.DeleteAsync(SelectedFamilia);
            if (response.IsSuccess)
            {
                LstFamilias = await srvFamilia.GetFamilias();
                //toast.ShowSuccess("Los datos se eliminaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        //
        LstFamilias = await srvFamilia.GetFamilias();



        StateHasChanged();
        await Task.Delay(1000);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EstadosServices srvEstado { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FamiliasServices srvFamilia { get; set; }
    }
}
#pragma warning restore 1591
