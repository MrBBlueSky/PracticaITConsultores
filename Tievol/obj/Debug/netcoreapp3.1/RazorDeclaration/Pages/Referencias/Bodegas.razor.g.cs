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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Referencias/Bodegas")]
    public partial class Bodegas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Bodegas.razor"
       
        //
    public List<Bodega> LstBodegas { get; set; }
    public List<Sucursal> LstSucursales { get; set; }
    public List<Estado> LstEstados { get; set; }

    //
    public string Accion { get; set; }
    public Bodega SelectedBodega { get; set; }

    //
    public string TituloWindow { get; set; }
    public string TituloButton { get; set; }
    public string IconButton { get; set; }

    public bool ShowWindow { get; set; } = false;

    // Referencias de tipo
    private Telerik.Blazor.Components.TelerikNumericTextBox<int> IDInt;
    //
    protected override async Task OnInitializedAsync()
    {

        LstBodegas = await srvBodegas.GetBodegas();
        LstSucursales = await srvSucursales.GetSucursales();
        LstEstados = await srvEstados.GetEstados();
    }
    //
    private void OnCancel(MouseEventArgs e)
    {
        ShowWindow = false;
        //
        StateHasChanged();
    }
    //
    private void OnClick(string cAccion, Bodega bodega)
    {
        ShowWindow = true;
        Accion = cAccion;
        SelectedBodega = bodega;

        if (cAccion == "Add")
        {   //
            SelectedBodega = new Bodega()
            {
                ID_Bodega = 0,
                N_Bodega = string.Empty,
                Sucursal = new Sucursal()
                {
                    ID_Sucursal = 0,
                    N_Sucursal = string.Empty,
                    Direccion = string.Empty,
                    Telefono1 = string.Empty,
                    Telefono2 = string.Empty,
                    Movil1 = string.Empty,
                    Movil2 = string.Empty,
                    Direccion_Correo = string.Empty
                },
                Estado = new Estado()
                {
                    ID_Estado = 0,
                    N_Estado = string.Empty
                }
            };

            TituloWindow = "Agregar Bodega";
            TituloButton = "Agregar";
            IconButton = "add";
        }
        else
        {   //
            SelectedBodega = bodega;

            //
            if (Accion == "Upd")
            {
                TituloWindow = "Actualizar Bodega";
                TituloButton = "Guardar";
                IconButton = "save";

            }
            else
            {
                TituloWindow = "Eliminar Bodega";
                TituloButton = "Eliminar";
                IconButton = "delete";

            }
        }

        //
        StateHasChanged();
    }
    //
    private async Task OnSave()
    {
        ShowWindow = false;
        if (Accion == "Add")
        {
            if (LstBodegas.Exists(e => e.N_Bodega == SelectedBodega.N_Bodega))
            {
                //toast.ShowWarning("La descripción ya se encuentra en la lista...", "ATENCION");
                return;
            }

            var response = await srvBodegas.CreateAsync(SelectedBodega);
            if (response.IsSuccess)
            {
                LstBodegas.Add(response.Result);
                //toast.ShowSuccess("Los datos se almacenaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        if (Accion == "Upd")
        {

            var response = await srvBodegas.UpdateAsync(SelectedBodega);
            if (response.IsSuccess)
            {
                LstBodegas.Add(response.Result);
                var posicion = LstBodegas.FindIndex(e => e.ID_Bodega == SelectedBodega.ID_Bodega);
                if (posicion == -1)
                {
                    //toast.ShowError("Se produjo un error inesperado...", "ERROR");
                }
                else
                {
                    LstBodegas[posicion] = SelectedBodega;
                    //toast.ShowSuccess("Los datos se almacenaron correctamente...", "ATENCION");
                }
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        if (Accion == "Del")
        {
            var response = await srvBodegas.DeleteAsync(SelectedBodega);
            if (response.IsSuccess)
            {
                LstBodegas = await srvBodegas.GetBodegas();
                //toast.ShowSuccess("Los datos se eliminaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        //
        LstBodegas = await srvBodegas.GetBodegas();

        //
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EstadosServices srvEstados { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SucursalesServices srvSucursales { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BodegasServices srvBodegas { get; set; }
    }
}
#pragma warning restore 1591