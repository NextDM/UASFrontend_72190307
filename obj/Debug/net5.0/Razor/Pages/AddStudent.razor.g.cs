#pragma checksum "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\Pages\AddStudent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dd76791bda2da44d2df6722dc2859780cc564db"
// <auto-generated/>
#pragma warning disable 1591
namespace UAS_Front_72190307.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\_Imports.razor"
using UAS_Front_72190307;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\_Imports.razor"
using UAS_Front_72190307.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addstudent")]
    public partial class AddStudent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Create Student</h1>\r\n\r\n<hr>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\Pages\AddStudent.razor"
                  Student

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\Pages\AddStudent.razor"
                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "width", "35%");
                __builder2.AddMarkupContent(7, "<tr><td><label for=\"studentID\" class>\r\n                    NIM\r\n                </label></td></tr>\r\n        ");
                __builder2.OpenElement(8, "tr");
                __builder2.OpenElement(9, "td");
                __builder2.AddAttribute(10, "class", "col-span-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "id", "studentID");
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "placeholder", "NIM");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\Pages\AddStudent.razor"
                                 Student.studentID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Student.studentID = __value, Student.studentID))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Student.studentID));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(19, "<tr><td><label for=\"firsName\" class>\r\n                    Nama Depan\r\n                </label></td></tr>\r\n        ");
                __builder2.OpenElement(20, "tr");
                __builder2.OpenElement(21, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "firstName");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "placeholder", "First Name");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\Pages\AddStudent.razor"
                                 Student.firstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Student.firstName = __value, Student.firstName))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Student.firstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(30, "<tr><td><label for=\"lastName\" class>\r\n                    Nama Belakang\r\n                </label></td></tr>\r\n        ");
                __builder2.OpenElement(31, "tr");
                __builder2.OpenElement(32, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "id", "lastName");
                __builder2.AddAttribute(35, "class", "form-control mb-10");
                __builder2.AddAttribute(36, "placeholder", "Last Name");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\Pages\AddStudent.razor"
                                 Student.lastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Student.lastName = __value, Student.lastName))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Student.lastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(41, "<tr><td><label for=\"enrollmentDate\" class>\r\n                    Tanggal Masuk\r\n                </label></td></tr>\r\n        ");
                __builder2.OpenElement(42, "tr");
                __builder2.OpenElement(43, "td");
                __Blazor.UAS_Front_72190307.Pages.AddStudent.TypeInference.CreateInputDate_0(__builder2, 44, 45, "enrollmentDate", 46, "form-control", 47, 
#nullable restore
#line 59 "E:\Semester 5\Pemrograman Frontend\Program\UAS\UAS_Front_72190307\Pages\AddStudent.razor"
                                                                                 Student.enrollmentDate

#line default
#line hidden
#nullable disable
                , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Student.enrollmentDate = __value, Student.enrollmentDate)), 49, () => Student.enrollmentDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(51, "<button class=\"btn btn-primary\" type=\"submit\">\r\n        Create\r\n    </button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.UAS_Front_72190307.Pages.AddStudent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591