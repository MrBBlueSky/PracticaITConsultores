#pragma checksum "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8599c07e73afa9cdd8faa81ac9f8b93f421d06a1"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Referencias/Tipo_documentos")]
    public partial class Tipo_documentos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Tievol.Pages.Referencias.Tipo_documentos.TypeInference.CreateTelerikGrid_0(__builder, 0, 1, 
#nullable restore
#line 6 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                   LstTDocumentos

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 6 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                             GridEditMode.Popup

#line default
#line hidden
#nullable disable
            , 3, "100%", 4, 
#nullable restore
#line 7 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                      true

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 7 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                    true

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 7 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                                  10

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 8 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                            GridSelectionMode.Single

#line default
#line hidden
#nullable disable
            , 8, (__builder2) => {
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(10);
                __builder2.AddAttribute(11, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.GridCommandEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                       () => OnClick("Add", null) 

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(12, "Icon", "add");
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(14, "Agregar");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n    ");
            }
            , 16, (__builder2) => {
                __builder2.AddMarkupContent(17, "\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridCommandColumn>(18);
                __builder2.AddAttribute(19, "Width", "150px");
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(21, "\n            ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(22);
                    __builder3.AddAttribute(23, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.GridCommandEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                          (args) => OnClick("Upd", args.Item as Tipo_documento)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(24, "Icon", "edit");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\n            ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(26);
                    __builder3.AddAttribute(27, "Command", "Delete");
                    __builder3.AddAttribute(28, "Icon", "delete");
                    __builder3.AddAttribute(29, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.GridCommandEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                                                         (args) => OnClick("Del", args.Item as Tipo_documento)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(32);
                __builder2.AddAttribute(33, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                           nameof(Tipo_documento.N_Tipo_Documento)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Title", "Nombre");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(36);
                __builder2.AddAttribute(37, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                           nameof(Tipo_documento.Estado)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Title", "Estado");
                __builder2.AddAttribute(39, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(40, "\n                ");
                    __builder3.AddContent(41, 
#nullable restore
#line 23 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                   (context as Tipo_documento).Estado.N_Estado

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(42, "\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\n    ");
            }
            );
            __builder.AddMarkupContent(44, "\n\n");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikWindow>(45);
            __builder.AddAttribute(46, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                        ShowWindow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "Modal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "Class", "c-Window");
            __builder.AddAttribute(49, "WindowContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(50, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(51);
                __builder2.AddAttribute(52, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 31 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                         SelectedTDocumento

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 31 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                                             OnSave

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenElement(56, "div");
                    __builder3.AddAttribute(57, "class", "card");
                    __builder3.AddAttribute(58, "style", "width: 500px; height: 450px;");
                    __builder3.AddMarkupContent(59, "\n                ");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "card-header blue-gradient-rgba text-black");
                    __builder3.AddMarkupContent(62, "\n                    ");
                    __builder3.OpenElement(63, "h5");
                    __builder3.AddAttribute(64, "class", "card-title my-2");
                    __builder3.OpenElement(65, "strong");
                    __builder3.AddContent(66, 
#nullable restore
#line 35 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                                         TituloWindow

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\n\n                ");
                    __builder3.OpenElement(69, "div");
                    __builder3.AddAttribute(70, "class", "card-body text-muted");
                    __builder3.AddMarkupContent(71, "\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(72);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\n                    \n                    \n                    ");
                    __builder3.OpenElement(74, "div");
                    __builder3.AddAttribute(75, "class", "row mt-2");
                    __builder3.AddMarkupContent(76, "\n                        ");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "col");
                    __builder3.AddMarkupContent(79, "\n                            ");
                    __builder3.AddMarkupContent(80, "<label class=\"k-label\">Nombre</label>\n                            ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.TelerikTextBox>(81);
                    __builder3.AddAttribute(82, "Width", "100%");
                    __builder3.AddAttribute(83, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                                         SelectedTDocumento.N_Tipo_Documento 

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(84, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedTDocumento.N_Tipo_Documento  = __value, SelectedTDocumento.N_Tipo_Documento ))));
                    __builder3.AddAttribute(85, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SelectedTDocumento.N_Tipo_Documento ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(86, "\n                            ");
                    __Blazor.Tievol.Pages.Referencias.Tipo_documentos.TypeInference.CreateValidationMessage_1(__builder3, 87, 88, 
#nullable restore
#line 52 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                                      () => SelectedTDocumento.N_Tipo_Documento

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(89, "\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(91, "\n\n                    ");
                    __builder3.OpenElement(92, "div");
                    __builder3.AddAttribute(93, "class", "row mt-4");
                    __builder3.AddMarkupContent(94, "\n                        ");
                    __builder3.OpenElement(95, "div");
                    __builder3.AddAttribute(96, "class", "col");
                    __builder3.AddMarkupContent(97, "\n                            ");
                    __builder3.AddMarkupContent(98, "<label class=\"k-label\">Estado</label>\n                            ");
                    __Blazor.Tievol.Pages.Referencias.Tipo_documentos.TypeInference.CreateTelerikComboBox_2(__builder3, 99, 100, 
#nullable restore
#line 60 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                                    LstEstado

#line default
#line hidden
#nullable disable
                    , 101, "100%", 102, "N_Estado", 103, "ID_Estado", 104, "Seleccione un Estado...", 105, 
#nullable restore
#line 62 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
                    , 106, 
#nullable restore
#line 62 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                                                                                                  true

#line default
#line hidden
#nullable disable
                    , 107, 
#nullable restore
#line 60 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                                                            SelectedTDocumento.Estado.ID_Estado

#line default
#line hidden
#nullable disable
                    , 108, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedTDocumento.Estado.ID_Estado = __value, SelectedTDocumento.Estado.ID_Estado)), 109, () => SelectedTDocumento.Estado.ID_Estado);
                    __builder3.AddMarkupContent(110, "\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(111, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(112, "\n\n\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\n                ");
                    __builder3.OpenElement(114, "div");
                    __builder3.AddAttribute(115, "class", "card-footer");
                    __builder3.AddMarkupContent(116, "\n                    ");
                    __builder3.OpenElement(117, "div");
                    __builder3.AddAttribute(118, "class", "form-row d-flex d-flex justify-content-between");
                    __builder3.AddMarkupContent(119, "\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.TelerikButton>(120);
                    __builder3.AddAttribute(121, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                              IconButton

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(122, "Class", "btn btn-outline-info btn-telerik");
                    __builder3.AddAttribute(123, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ButtonType>(
#nullable restore
#line 73 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                                    ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(124, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(125, "\n                            ");
                        __builder4.OpenElement(126, "strong");
                        __builder4.AddContent(127, 
#nullable restore
#line 74 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                     TituloButton

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(128, "\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(129, "\n\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.TelerikButton>(130);
                    __builder3.AddAttribute(131, "Icon", "cancel");
                    __builder3.AddAttribute(132, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                                               OnCancel

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(133, "Class", "btn btn-outline-danger btn-telerik");
                    __builder3.AddAttribute(134, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ButtonType>(
#nullable restore
#line 79 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                                                    ButtonType.Button

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(135, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(136, "Cancelar");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(137, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(138, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(139, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(140, "\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(141, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(142, "\n\n");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikNotification>(143);
            __builder.AddComponentReferenceCapture(144, (__value) => {
#nullable restore
#line 88 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
                            Notification = (Telerik.Blazor.Components.TelerikNotification)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Tipo_documentos.razor"
       


    public List<Tipo_documento> LstTDocumentos { get; set; }
    public List<Estado> LstEstado { get; set; }
    public string Accion { get; set; }
    public Tipo_documento SelectedTDocumento { get; set; }
    public string TituloWindow { get; set; }
    public string TituloButton { get; set; }
    public string IconButton { get; set; }
    public bool ShowWindow { get; set; } = false;
    public TelerikNotification Notification { get; set; }
    private System.Threading.ManualResetEvent Trigger = new System.Threading.ManualResetEvent(false);
    private Telerik.Blazor.Components.TelerikNumericTextBox<int> IDInt;



    protected override async Task OnInitializedAsync()
    {
        LstEstado = await srvEstados.GetEstados();
        LstTDocumentos = await srvTDocumentos.GetTipoDocumentos();


    }

    private void OnCancel(MouseEventArgs e)
    {
        ShowWindow = false;
        Task.Delay(5000);
        StateHasChanged();

    }

    private void OnClick(string cAccion, Tipo_documento tipo_Documento)
    {
        ShowWindow = true;
        Accion = cAccion;
        SelectedTDocumento = tipo_Documento;

        if (cAccion == "Add")
        {
            SelectedTDocumento = new Tipo_documento()
            {
                ID_Tipo_Documento = 0,
                N_Tipo_Documento = string.Empty,
                Estado = new Estado()
                {
                    ID_Estado = 0,
                    N_Estado= string.Empty
                }

            };

            TituloWindow = "Agregar Tipo de Documento";
            TituloButton = "Agregar";
            IconButton = "add";
        }
        else
        {
            SelectedTDocumento = tipo_Documento;


            if (Accion == "Upd")
            {
                TituloWindow = "Actualizar Tipo de Documento";
                TituloButton = "Guardar";
                IconButton = "save";

            }
            else
            {
                TituloWindow = "Eliminar Tipo de Documento";
                TituloButton = "Eliminar";
                IconButton = "delete";

            }
        }

        Task.Delay(5000);

        StateHasChanged();
        Task.Delay(500);
        Trigger.Set();
    }

    private async Task OnSave()
    {
        ShowWindow = false;
        if (Accion == "Add")
        {
            if (LstTDocumentos.Exists(td => td.N_Tipo_Documento == SelectedTDocumento.N_Tipo_Documento))
            {
                //toast.ShowWarning("La descripción ya se encuentra en la lista...", "ATENCION");
                return;
            }

            var response = await srvTDocumentos.CreateAsync(SelectedTDocumento);
            if (response.IsSuccess)
            {
                LstTDocumentos.Add(response.Result);

                //toast.ShowSuccess("Los datos se almacenaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        if (Accion == "Upd")// Metodo comportamiento extraño
        {

            var response = await srvTDocumentos.UpdateAsync(SelectedTDocumento);
            if (response.IsSuccess)
            {
                LstTDocumentos.Add(response.Result);
                var posicion = LstTDocumentos.FindIndex(td => td.ID_Tipo_Documento == SelectedTDocumento.ID_Tipo_Documento);
                if (posicion == -1)
                {
                    //toast.ShowError("Se produjo un error inesperado...", "ERROR");
                }
                else
                {
                    LstTDocumentos[posicion] = SelectedTDocumento;
                    Notification.Show(new NotificationModel()
                    {
                        Text = "Se edito el Tipo de Documento correctamente...",
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
            var response = await srvTDocumentos.DeleteAsync(SelectedTDocumento);
            if (response.IsSuccess)
            {
                LstTDocumentos = await srvTDocumentos.GetTipoDocumentos();
                Notification.Show(new NotificationModel()
                {
                    Text = "Se elimino el Tipo de Documento correctamente...",
                    ThemeColor = "error",
                    ShowIcon = true
                });
                //toast.ShowSuccess("Los datos se eliminaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }


        LstTDocumentos = await srvTDocumentos.GetTipoDocumentos();
        Trigger.Reset();
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EstadosServices srvEstados { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipoDocumentosServices srvTDocumentos { get; set; }
    }
}
namespace __Blazor.Tievol.Pages.Referencias.Tipo_documentos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::Telerik.Blazor.GridEditMode __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Int32 __arg5, int __seq6, global::Telerik.Blazor.GridSelectionMode __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "EditMode", __arg1);
        __builder.AddAttribute(__seq2, "Height", __arg2);
        __builder.AddAttribute(__seq3, "Sortable", __arg3);
        __builder.AddAttribute(__seq4, "Pageable", __arg4);
        __builder.AddAttribute(__seq5, "PageSize", __arg5);
        __builder.AddAttribute(__seq6, "SelectionMode", __arg6);
        __builder.AddAttribute(__seq7, "GridToolBar", __arg7);
        __builder.AddAttribute(__seq8, "GridColumns", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateTelerikComboBox_2<TItem, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::System.Boolean __arg6, int __seq7, TValue __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg8, int __seq9, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg9)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikComboBox<TItem, TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Width", __arg1);
        __builder.AddAttribute(__seq2, "TextField", __arg2);
        __builder.AddAttribute(__seq3, "ValueField", __arg3);
        __builder.AddAttribute(__seq4, "Placeholder", __arg4);
        __builder.AddAttribute(__seq5, "ClearButton", __arg5);
        __builder.AddAttribute(__seq6, "Filterable", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.AddAttribute(__seq9, "ValueExpression", __arg9);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
