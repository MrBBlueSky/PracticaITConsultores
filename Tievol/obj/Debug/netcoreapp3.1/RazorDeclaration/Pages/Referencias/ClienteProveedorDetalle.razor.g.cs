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
#nullable restore
#line 1 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\ClienteProveedorDetalle.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Referencias/ClienteProveedorDetalle/{Id:int}")]
    public partial class ClienteProveedorDetalle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\ClienteProveedorDetalle.razor"
       
        public Data.Entities.ClienteProveedor PCP { get; set; }
        public List<Pais> LstPaises { get; set; }
        private string IDClieProv { get; set; }
        private string NClieProv { get; set; }
        private string TipoCLiPro { get; set; }
        private string RutCP { get; set; }
        private string RazSoc { get; set; }
        private string Giro { get; set; }
        private string Direc { get; set; }
        private string Country { get; set; }
        private string City { get; set; }
        private string Commune { get; set; }
        private string Region { get; set; }
        //private string RutAux { get; set; }
        private string SReason { get; set; }
        private string LBusiness { get; set; }
        private string Address { get; set; }
        private string Phone { get; set; }
        private string Mobile { get; set; }
        private string EmailA { get; set; }
        private string DateE { get; set; }
        private string SaleCond { get; set; }
        private double AmountC { get; set; }
        private string Remarks { get; set; }
        private Ciudad nCiudad { get; set; }
        private Comuna nComuna { get; set; }
        private Region nRegion { get; set; }
        private Pais nPais { get; set; }
    
        //private string StatusAux { get; set; }
        private string NombreClienteProveedor {get;set;}




    [Parameter]
    public int Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Data.Entities.ClienteProveedor clProvedor = await srvClienteProveedor.GetClienteProveedors(Id);

        NombreClienteProveedor = clProvedor.N_Cliente_Proveedor;
        PCP = await srvClienteProveedor.GetClienteProveedors(Id);
        IDClieProv = PCP.ID_Cliente_Proveedor.ToString();
        NClieProv = PCP.N_Cliente_Proveedor;
        TipoCLiPro = PCP.ID_Tipo_Cliente_Proveedor.ToString();
        RutCP = PCP.Rut;
        RazSoc = PCP.Razon_Social;
        nPais = await srvPaises.GetPais(PCP.ID_Pais);
        Country = nPais.N_Pais;
        nCiudad = await srvCiudades.GetCiudad(PCP.ID_Ciudad);
        City = nCiudad.N_Ciudad;
        nComuna = await srvComunas.GetComuna(PCP.ID_Comuna);
        Commune = nComuna.N_Comuna;
        nRegion = await srvRegiones.GetRegion(PCP.ID_Region);
        Region = nRegion.N_Region;
        //RutAux = PCP.Rut;
        SReason = PCP.Razon_Social;
        LBusiness = PCP.Giro;
        Address = PCP.Direccion;
        Phone = PCP.Telefono;
        Mobile = PCP.Movil;
        EmailA = PCP.Direccion_Correo;
        DateE = PCP.Fecha_Ingreso.ToString();
        SaleCond = PCP.ID_Condicion_Venta.ToString();
        AmountC = PCP.Monto_Credito;
        Remarks = PCP.Observaciones;
        //StatusAux = PCP.Estado.ToString();




    }

    void RedirectProduct()
    {
        NavigationManager.NavigateTo("/Referencias/ClienteProveedor");
    }
    Telerik.Blazor.Components.TelerikTabStrip TabDetalleClienteProveedor;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClienteProveedorServices srvClienteProveedor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PaisesServices srvPaises { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RegionesServices srvRegiones { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ComunasServices srvComunas { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CiudadesServices srvCiudades { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
