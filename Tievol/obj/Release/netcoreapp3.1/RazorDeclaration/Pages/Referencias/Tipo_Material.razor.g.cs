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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Referencias/Tipo_Material")]
    public partial class Tipo_Material : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_Material.razor"
       

    //
    public List<Tipo_material> LstTMaterial { get; set; }
    public List<Estado> LstEstado { get; set; }
    //
    public string Accion { get; set; }
    public Tipo_material SelectedTEmpresa { get; set; }

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
        LstEstado = await srvEstados.GetEstados();
        LstTMaterial = await srvTEmpresa.GetTipoMaterial();
    }
    //
    private void OnCancel(MouseEventArgs e)
    {
        ShowWindow = false;

    }
    //
    private void OnClick(string cAccion, Tipo_material tipo_Documento)
    {
        ShowWindow = true;
        Accion = cAccion;

        if (cAccion == "Add")
        {   //
            SelectedTEmpresa = new Tipo_material()
            {
                ID_Tipo_Material = 0,
                N_Tipo_Material = string.Empty,
                Estado = new Estado()
                {
                    ID_Estado = 0,
                    N_Estado = string.Empty
                }

            };

            TituloWindow = "Agregar Tipo de Material";
            TituloButton = "Agregar";
            IconButton = "add";
        }
        else
        {   //
            SelectedTEmpresa = tipo_Documento;

            //
            if (Accion == "Upd")
            {
                TituloWindow = "Actualizar Tipo de Material";
                TituloButton = "Guardar";
                IconButton = "save";

            }
            else
            {
                TituloWindow = "Eliminar Tipo de Material";
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
            if (LstTMaterial.Exists(td => td.N_Tipo_Material == SelectedTEmpresa.N_Tipo_Material))
            {
                //toast.ShowWarning("La descripción ya se encuentra en la lista...", "ATENCION");
                return;
            }

            var response = await srvTEmpresa.CreateAsync(SelectedTEmpresa);
            if (response.IsSuccess)
            {
                LstTMaterial.Add(response.Result);
                //toast.ShowSuccess("Los datos se almacenaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        if (Accion == "Upd")// Metodo comportamiento extraño
        {

            var response = await srvTEmpresa.UpdateAsync(SelectedTEmpresa);
            if (response.IsSuccess)
            {
                LstTMaterial.Add(response.Result);
                var posicion = LstTMaterial.FindIndex(td => td.ID_Tipo_Material == SelectedTEmpresa.ID_Tipo_Material);
                if (posicion == -1)
                {
                    //toast.ShowError("Se produjo un error inesperado...", "ERROR");
                }
                else
                {
                    LstTMaterial[posicion] = SelectedTEmpresa;
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
            var response = await srvTEmpresa.DeleteAsync(SelectedTEmpresa);
            if (response.IsSuccess)
            {
                LstTMaterial = await srvTEmpresa.GetTipoMaterial();
                //toast.ShowSuccess("Los datos se eliminaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        //
        LstTMaterial = await srvTEmpresa.GetTipoMaterial();

        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EstadosServices srvEstados { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipoMaterialServices srvTEmpresa { get; set; }
    }
}
#pragma warning restore 1591
