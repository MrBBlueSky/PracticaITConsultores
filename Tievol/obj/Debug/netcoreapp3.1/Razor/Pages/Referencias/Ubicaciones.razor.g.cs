#pragma checksum "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1e185aeb3ec8db15da0331aa2fbd8b95eefdc5c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Referencias/Ubicaciones")]
    public partial class Ubicaciones : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Tievol.Pages.Referencias.Ubicaciones.TypeInference.CreateTelerikGrid_0(__builder, 0, 1, 
#nullable restore
#line 7 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                   LstUbicacion

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 7 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                           GridEditMode.Popup

#line default
#line hidden
#nullable disable
            , 3, "100%", 4, 
#nullable restore
#line 8 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                      true

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 8 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                    true

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 8 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                  10

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 9 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                            GridSelectionMode.Single

#line default
#line hidden
#nullable disable
            , 8, (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(10);
                __builder2.AddAttribute(11, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.GridCommandEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
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
                __builder2.AddMarkupContent(15, "\r\n    ");
            }
            , 16, (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridCommandColumn>(18);
                __builder2.AddAttribute(19, "Width", "150px");
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(21, "\r\n            ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(22);
                    __builder3.AddAttribute(23, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.GridCommandEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                          (args) => OnClick("Upd", args.Item as Ubicacion)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(24, "Icon", "edit");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n            ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(26);
                    __builder3.AddAttribute(27, "Command", "Delete");
                    __builder3.AddAttribute(28, "Icon", "delete");
                    __builder3.AddAttribute(29, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.GridCommandEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                                         (args) => OnClick("Del", args.Item as Ubicacion)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(32);
                __builder2.AddAttribute(33, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                           nameof(Ubicacion.N_Ubicacion)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Title", "Nombre");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(36);
                __builder2.AddAttribute(37, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                           nameof(Ubicacion.Bodega)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Title", "Bodega");
                __builder2.AddAttribute(39, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(40, "\r\n            ");
                    __builder3.AddContent(41, 
#nullable restore
#line 24 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
               (context as Ubicacion).Bodega.N_Bodega

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(42, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(44);
                __builder2.AddAttribute(45, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                           nameof(Ubicacion.Estado)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "Title", "Estado");
                __builder2.AddAttribute(47, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                                             false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(49, "\r\n                ");
                    __builder3.AddContent(50, 
#nullable restore
#line 29 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                   (context as Ubicacion).Estado.N_Estado

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(51, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(53, "\r\n\r\n");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikWindow>(54);
            __builder.AddAttribute(55, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                        ShowWindow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "Modal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "Class", "c-Window");
            __builder.AddAttribute(58, "WindowContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(60);
                __builder2.AddAttribute(61, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 37 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                         SelectedUbicacion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 37 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                            OnSave

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(64, "\r\n            ");
                    __builder3.OpenElement(65, "div");
                    __builder3.AddAttribute(66, "class", "card");
                    __builder3.AddAttribute(67, "style", "width: 500px; height: 450px;");
                    __builder3.AddMarkupContent(68, "\r\n                ");
                    __builder3.OpenElement(69, "div");
                    __builder3.AddAttribute(70, "class", "card-header blue-gradient-rgba text-black");
                    __builder3.AddMarkupContent(71, "\r\n                    ");
                    __builder3.OpenElement(72, "h5");
                    __builder3.AddAttribute(73, "class", "card-title my-2");
                    __builder3.OpenElement(74, "strong");
                    __builder3.AddContent(75, 
#nullable restore
#line 41 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                         TituloWindow

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\r\n\r\n                ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "class", "card-body text-muted");
                    __builder3.AddMarkupContent(80, "\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(81);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\r\n                    \r\n                    \r\n                    ");
                    __builder3.OpenElement(83, "div");
                    __builder3.AddAttribute(84, "class", "row mt-2");
                    __builder3.AddMarkupContent(85, "\r\n                        ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "col");
                    __builder3.AddMarkupContent(88, "\r\n                            ");
                    __builder3.AddMarkupContent(89, "<label class=\"k-label\">Nombre</label>\r\n                            ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.TelerikTextBox>(90);
                    __builder3.AddAttribute(91, "Width", "100%");
                    __builder3.AddAttribute(92, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                         SelectedUbicacion.N_Ubicacion

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(93, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedUbicacion.N_Ubicacion = __value, SelectedUbicacion.N_Ubicacion))));
                    __builder3.AddAttribute(94, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SelectedUbicacion.N_Ubicacion));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\r\n                            ");
                    __Blazor.Tievol.Pages.Referencias.Ubicaciones.TypeInference.CreateValidationMessage_1(__builder3, 96, 97, 
#nullable restore
#line 58 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                      () => SelectedUbicacion.N_Ubicacion

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(98, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(99, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(100, "\r\n\r\n                    ");
                    __builder3.OpenElement(101, "div");
                    __builder3.AddAttribute(102, "class", "row mt-4");
                    __builder3.AddMarkupContent(103, "\r\n                        ");
                    __builder3.OpenElement(104, "div");
                    __builder3.AddAttribute(105, "class", "col");
                    __builder3.AddMarkupContent(106, "\r\n                            ");
                    __builder3.AddMarkupContent(107, "<label class=\"k-label\">Bodega</label>\r\n                            ");
                    __Blazor.Tievol.Pages.Referencias.Ubicaciones.TypeInference.CreateTelerikComboBox_2(__builder3, 108, 109, 
#nullable restore
#line 66 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                    LstBodega

#line default
#line hidden
#nullable disable
                    , 110, "100%", 111, "N_Bodega", 112, "ID_Bodega", 113, "Seleccione una Bodega...", 114, 
#nullable restore
#line 68 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                                                                 true

#line default
#line hidden
#nullable disable
                    , 115, 
#nullable restore
#line 68 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                                                                                   true

#line default
#line hidden
#nullable disable
                    , 116, 
#nullable restore
#line 66 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                                            SelectedUbicacion.Bodega.ID_Bodega

#line default
#line hidden
#nullable disable
                    , 117, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedUbicacion.Bodega.ID_Bodega = __value, SelectedUbicacion.Bodega.ID_Bodega)), 118, () => SelectedUbicacion.Bodega.ID_Bodega);
                    __builder3.AddMarkupContent(119, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(121, "\r\n\r\n                    ");
                    __builder3.OpenElement(122, "div");
                    __builder3.AddAttribute(123, "class", "row mt-4");
                    __builder3.AddMarkupContent(124, "\r\n                        ");
                    __builder3.OpenElement(125, "div");
                    __builder3.AddAttribute(126, "class", "col");
                    __builder3.AddMarkupContent(127, "\r\n                            ");
                    __builder3.AddMarkupContent(128, "<label class=\"k-label\">Estado</label>\r\n                            ");
                    __Blazor.Tievol.Pages.Referencias.Ubicaciones.TypeInference.CreateTelerikComboBox_3(__builder3, 129, 130, 
#nullable restore
#line 77 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                    LstEstado

#line default
#line hidden
#nullable disable
                    , 131, "100%", 132, "N_Estado", 133, "ID_Estado", 134, "Seleccione un Estado...", 135, 
#nullable restore
#line 79 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
                    , 136, 
#nullable restore
#line 79 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                                                                                  true

#line default
#line hidden
#nullable disable
                    , 137, 
#nullable restore
#line 77 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                                            SelectedUbicacion.Estado.ID_Estado

#line default
#line hidden
#nullable disable
                    , 138, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedUbicacion.Estado.ID_Estado = __value, SelectedUbicacion.Estado.ID_Estado)), 139, () => SelectedUbicacion.Estado.ID_Estado);
                    __builder3.AddMarkupContent(140, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(141, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(142, "\r\n\r\n\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(143, "\r\n                ");
                    __builder3.OpenElement(144, "div");
                    __builder3.AddAttribute(145, "class", "card-footer");
                    __builder3.AddMarkupContent(146, "\r\n                    ");
                    __builder3.OpenElement(147, "div");
                    __builder3.AddAttribute(148, "class", "form-row d-flex d-flex justify-content-between");
                    __builder3.AddMarkupContent(149, "\r\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.TelerikButton>(150);
                    __builder3.AddAttribute(151, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 88 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                              IconButton

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(152, "Class", "btn btn-outline-info btn-telerik");
                    __builder3.AddAttribute(153, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ButtonType>(
#nullable restore
#line 90 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                    ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(154, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(155, "\r\n                            ");
                        __builder4.OpenElement(156, "strong");
                        __builder4.AddContent(157, 
#nullable restore
#line 91 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                     TituloButton

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(158, "\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(159, "\r\n\r\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.TelerikButton>(160);
                    __builder3.AddAttribute(161, "Icon", "cancel");
                    __builder3.AddAttribute(162, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                               OnCancel

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(163, "Class", "btn btn-outline-danger btn-telerik");
                    __builder3.AddAttribute(164, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ButtonType>(
#nullable restore
#line 96 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
                                                    ButtonType.Button

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(165, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(166, "Cancelar");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(167, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(168, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(169, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(170, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(171, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(172, "\r\n\r\n");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikNotification>(173);
            __builder.AddComponentReferenceCapture(174, (__value) => {
#nullable restore
#line 105 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ubicaciones.razor"
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
namespace __Blazor.Tievol.Pages.Referencias.Ubicaciones
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
        public static void CreateTelerikComboBox_3<TItem, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::System.Boolean __arg6, int __seq7, TValue __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg8, int __seq9, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg9)
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
