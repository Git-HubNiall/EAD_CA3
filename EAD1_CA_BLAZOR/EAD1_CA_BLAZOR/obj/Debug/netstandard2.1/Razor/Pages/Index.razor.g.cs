#pragma checksum "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbf15d9f79ff6d245d9342a6a18c379c130fc382"
// <auto-generated/>
#pragma warning disable 1591
namespace EAD1_CA_BLAZOR.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using EAD1_CA_BLAZOR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using EAD1_CA_BLAZOR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
using System.Runtime.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EAD CA3</h3>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
 if (data == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading Data...</em></p>\r\n");
#nullable restore
#line 14 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "\r\n    \r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "id", "searchTerm");
            __builder.AddAttribute(7, "placeholder", "Search Drinks...");
            __builder.AddAttribute(8, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
                                                                    Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
                                                                                   searchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchTerm = __value, searchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
                      Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.AddMarkupContent(17, "    <br>\r\n");
#nullable restore
#line 27 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
     if (found)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "        ");
            __builder.OpenElement(19, "div");
            __builder.AddMarkupContent(20, "\r\n            Name: ");
            __builder.AddContent(21, 
#nullable restore
#line 30 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
                   data.drinks[0].strDrink

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddMarkupContent(25, "\r\n            Glass Type: ");
            __builder.AddContent(26, 
#nullable restore
#line 33 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
                         data.drinks[0].strGlass

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddMarkupContent(30, "\r\n            Image Link: ");
            __builder.AddContent(31, 
#nullable restore
#line 36 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
                         data.drinks[0].strImageSource

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddMarkupContent(35, "\r\n            <br>\r\n            Instructions: ");
            __builder.AddContent(36, 
#nullable restore
#line 40 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
                           data.drinks[0].strInstructions

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, " \r\n            <br>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 43 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
     


}

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, 
#nullable restore
#line 47 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
 errorMess

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Niall\Desktop\EAD_CA3\EAD_CA3\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
       


    private String searchTerm = "margarita";
    private bool found;
    private Root data;
    private string errorMess;


    private async Task getHPAsync()
    {

        try
        {
            string uri = "https://www.thecocktaildb.com/api/json/v1/1/search.php?s=" + searchTerm;
            data = await Http.GetFromJsonAsync<Root>(uri);
            found = true;
            errorMess = string.Empty;
        }
        catch (Exception e)
        {
            found = false;
            errorMess = e.Message;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        await getHPAsync();
    }

    public async void Search()
    {
        await getHPAsync();
        StateHasChanged();
    }






    public class Drink
    {
        public string idDrink { get; set; }
        public string strDrink { get; set; }
        public object strDrinkAlternate { get; set; }
        public string strTags { get; set; }
        public object strVideo { get; set; }
        public string strCategory { get; set; }
        public string strIBA { get; set; }
        public string strAlcoholic { get; set; }
        public string strGlass { get; set; }
        public string strInstructions { get; set; }
        public string strDrinkThumb { get; set; }
        public string strIngredient1 { get; set; }
        public string strIngredient2 { get; set; }
        public string strIngredient3 { get; set; }
        public string strIngredient4 { get; set; }
        public string strIngredient5 { get; set; }
        public string strIngredient6 { get; set; }
        public string strIngredient7 { get; set; }
        public object strIngredient8 { get; set; }
        public object strIngredient9 { get; set; }
        public object strIngredient10 { get; set; }
        public object strIngredient11 { get; set; }
        public object strIngredient12 { get; set; }
        public object strIngredient13 { get; set; }
        public object strIngredient14 { get; set; }
        public object strIngredient15 { get; set; }
        public string strMeasure1 { get; set; }
        public string strMeasure2 { get; set; }
        public string strMeasure3 { get; set; }
        public string strMeasure4 { get; set; }
        public string strMeasure5 { get; set; }
        public string strMeasure6 { get; set; }
        public string strMeasure7 { get; set; }
        public object strMeasure8 { get; set; }
        public object strMeasure9 { get; set; }
        public object strMeasure10 { get; set; }
        public object strMeasure11 { get; set; }
        public object strMeasure12 { get; set; }
        public object strMeasure13 { get; set; }
        public object strMeasure14 { get; set; }
        public object strMeasure15 { get; set; }
        public string strImageSource { get; set; }
        public string strImageAttribution { get; set; }
        public string strCreativeCommonsConfirmed { get; set; }
        public string dateModified { get; set; }
    }

    public class Root
    {
        public List<Drink> drinks { get; set; }
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
