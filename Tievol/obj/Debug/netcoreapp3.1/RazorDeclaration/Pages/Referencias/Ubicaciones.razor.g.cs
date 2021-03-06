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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Referencias/Ubicaciones")]
    public partial class Ubicaciones : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
       


    public List<Ubicacion> LstUbicacion { get; set; }
    public List<Bodega> LstBodega { get; set; }
    public List<Estado> LstEstado { get; set; }
    public string Accion { get; set; }
    public Ubicacion SelectedUbicacion { get; set; }
    public string TituloWindow { get; set; }
    public string TituloButton { get; set; }
    public string IconButton { get; set; }
    public bool ShowWindow { get; set; } = false;
    public TelerikNotification Notification { get; set; }
    private Telerik.Blazor.Components.TelerikNumericTextBox<int> IDInt;


    protected override async Task OnInitializedAsync()
    {
        LstBodega = await srvBodegas.GetBodegas();
        LstEstado = await srvEstados.GetEstados();
        LstUbicacion = await srvUbicaciones.GetUbicaciones();
    }

    private void OnCancel(MouseEventArgs e)
    {
        ShowWindow = false;

    }

    private void OnClick(string cAccion, Ubicacion ubicacion)
    {
        ShowWindow = true;
        Accion = cAccion;

        if (cAccion == "Add")
        {
            SelectedUbicacion = new Ubicacion()
            {
                ID_Ubicacion = 0,
                N_Ubicacion = string.Empty,
                Bodega = new Bodega()
                {
                    ID_Bodega = 0,
                    N_Bodega = string.Empty
                },
                Estado = new Estado()
                {
                    ID_Estado = 0,
                    N_Estado =string.Empty
                }

            };

            TituloWindow = "Agregar Ubicacion";
            TituloButton = "Agregar";
            IconButton = "add";
        }
        else
        {
            SelectedUbicacion = ubicacion;


            if (Accion == "Upd")
            {
                TituloWindow = "Actualizar Ubicacion";
                TituloButton = "Guardar";
                IconButton = "save";

            }
            else
            {
                TituloWindow = "Eliminar Ubicacion";
                TituloButton = "Eliminar";
                IconButton = "delete";

            }
        }


        StateHasChanged();
    }

    private async Task OnSave()
    {
        ShowWindow = false;
        if (Accion == "Add")
        {
            if (LstUbicacion.Exists(ub => ub.N_Ubicacion== SelectedUbicacion.N_Ubicacion))
            {
                //toast.ShowWarning("La descripción ya se encuentra en la lista...", "ATENCION");
                return;
            }

            var response = await srvUbicaciones.CreateAsync(SelectedUbicacion);
            if (response.IsSuccess)
            {
                LstUbicacion.Add(response.Result);
                //toast.ShowSuccess("Los datos se almacenaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        if (Accion == "Upd")// Metodo comportamiento extraño
        {

            var response = await srvUbicaciones.UpdateAsync(SelectedUbicacion);
            if (response.IsSuccess)
            {
                LstUbicacion.Add(response.Result);
                var posicion = LstUbicacion.FindIndex(ub => ub.ID_Ubicacion == SelectedUbicacion.ID_Ubicacion);
                if (posicion == -1)
                {
                    //toast.ShowError("Se produjo un error inesperado...", "ERROR");
                }
                else
                {
                    LstUbicacion[posicion] = SelectedUbicacion;
                    Notification.Show(new NotificationModel()
                    {
                        Text = "La Ubicación se actualizo con éxito",
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
            var response = await srvUbicaciones.DeleteAsync(SelectedUbicacion);
            if (response.IsSuccess)
            {
                LstUbicacion = await srvUbicaciones.GetUbicaciones();

                //telerik notifications
            }
            else
            {
                //telerik notifications
            }
        }


        LstUbicacion = await srvUbicaciones.GetUbicaciones();


        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EstadosServices srvEstados { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BodegasServices srvBodegas { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UbicacionesServices srvUbicaciones { get; set; }
    }
}
#pragma warning restore 1591
