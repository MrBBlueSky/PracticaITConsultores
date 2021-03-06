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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Referencias/Tipo_Inventario")]
    public partial class Tipo_Inventario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_Inventario.razor"
       

    
    public List<Tipo_inventario> LstTInventario { get; set; }
    public List<Estado> LstEstado { get; set; }
    
    public string Accion { get; set; }
    public Tipo_inventario SelectedTInventario { get; set; }

    
    public string TituloWindow { get; set; }
    public string TituloButton { get; set; }
    public string IconButton { get; set; }

    public bool ShowWindow { get; set; } = false;

    public TelerikNotification Notification { get; set; }

    
    private Telerik.Blazor.Components.TelerikNumericTextBox<int> IDInt;

    
    protected override async Task OnInitializedAsync()
    {
        LstEstado = await srvEstados.GetEstados();
        LstTInventario = await srvTInventario.GetTipoInventario();
    }
    
    private void OnCancel(MouseEventArgs e)
    {
        ShowWindow = false;

    }
    
    private void OnClick(string cAccion, Tipo_inventario tipo_Inventario)
    {
        ShowWindow = true;
        Accion = cAccion;

        if (cAccion == "Add")
        {   
            SelectedTInventario = new Tipo_inventario()
            {
                ID_Tipo_Inventario = 0,
                N_Tipo_Inventario = string.Empty,
                Estado = new Estado()
                {
                    ID_Estado = 0,
                    N_Estado = string.Empty
                }

            };

            TituloWindow = "Agregar Tipo de Inventario";
            TituloButton = "Agregar";
            IconButton = "add";
        }
        else
        {   
            SelectedTInventario = tipo_Inventario;

            
            if (Accion == "Upd")
            {
                TituloWindow = "Actualizar Tipo de Inventario";
                TituloButton = "Guardar";
                IconButton = "save";

            }
            else
            {
                TituloWindow = "Eliminar Tipo de Inventario";
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
            if (LstTInventario.Exists(ti => ti.N_Tipo_Inventario == SelectedTInventario.N_Tipo_Inventario))
            {
                //toast.ShowWarning("La descripción ya se encuentra en la lista...", "ATENCION");
                return;
            }

            var response = await srvTInventario.CreateAsync(SelectedTInventario);
            if (response.IsSuccess)
            {
                LstTInventario.Add(response.Result);
                //toast.ShowSuccess("Los datos se almacenaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        if (Accion == "Upd")// Metodo comportamiento extraño
        {

            var response = await srvTInventario.UpdateAsync(SelectedTInventario);
            if (response.IsSuccess)
            {
                LstTInventario.Add(response.Result);
                var posicion = LstTInventario.FindIndex(ti => ti.ID_Tipo_Inventario == SelectedTInventario.ID_Tipo_Inventario);
                if (posicion == -1)
                {
                    //toast.ShowError("Se produjo un error inesperado...", "ERROR");
                }
                else
                {
                    LstTInventario[posicion] = SelectedTInventario;
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
            var response = await srvTInventario.DeleteAsync(SelectedTInventario);
            if (response.IsSuccess)
            {
                LstTInventario = await srvTInventario.GetTipoInventario();
                //toast.ShowSuccess("Los datos se eliminaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        
        LstTInventario = await srvTInventario.GetTipoInventario();

        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EstadosServices srvEstados { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipoInventarioServices srvTInventario { get; set; }
    }
}
#pragma warning restore 1591
