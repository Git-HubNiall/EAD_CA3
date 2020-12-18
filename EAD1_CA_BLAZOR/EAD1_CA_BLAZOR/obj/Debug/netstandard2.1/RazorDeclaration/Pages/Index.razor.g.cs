#pragma checksum "C:\Users\Niall\Desktop\EAD\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbf15d9f79ff6d245d9342a6a18c379c130fc382"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EAD1_CA_BLAZOR.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Niall\Desktop\EAD\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Niall\Desktop\EAD\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Niall\Desktop\EAD\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Niall\Desktop\EAD\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Niall\Desktop\EAD\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Niall\Desktop\EAD\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Niall\Desktop\EAD\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Niall\Desktop\EAD\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using EAD1_CA_BLAZOR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Niall\Desktop\EAD\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\_Imports.razor"
using EAD1_CA_BLAZOR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Niall\Desktop\EAD\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
using System.Runtime.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Niall\Desktop\EAD\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Niall\Desktop\EAD\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Niall\Desktop\EAD\EAD1_CA_BLAZOR\EAD1_CA_BLAZOR\Pages\Index.razor"
       


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
