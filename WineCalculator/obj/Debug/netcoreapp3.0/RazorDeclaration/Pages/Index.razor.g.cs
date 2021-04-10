#pragma checksum "G:\UDEMY\BlazorCalc\WineCalculator\WineCalculator\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25b33f6e9bce490340857856b4a19a43f2f4bfd0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WineCalculator.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\UDEMY\BlazorCalc\WineCalculator\WineCalculator\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\UDEMY\BlazorCalc\WineCalculator\WineCalculator\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\UDEMY\BlazorCalc\WineCalculator\WineCalculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\UDEMY\BlazorCalc\WineCalculator\WineCalculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\UDEMY\BlazorCalc\WineCalculator\WineCalculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\UDEMY\BlazorCalc\WineCalculator\WineCalculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\UDEMY\BlazorCalc\WineCalculator\WineCalculator\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\UDEMY\BlazorCalc\WineCalculator\WineCalculator\_Imports.razor"
using WineCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\UDEMY\BlazorCalc\WineCalculator\WineCalculator\_Imports.razor"
using WineCalculator.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\UDEMY\BlazorCalc\WineCalculator\WineCalculator\Pages\Index.razor"
using WineCalculator.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "G:\UDEMY\BlazorCalc\WineCalculator\WineCalculator\Pages\Index.razor"
       
    private WineCalc wineCalc = new WineCalc();
    private double fruitKg;
    private double yeast;
    private double sugar;
    private double potassium = 0;
    private int blgFinal;
    private bool show = false;
    private bool showIfPasterized = false;

    public class Fruit
    {
        public string name;
        public int blg;
        public double volFromOneKilo;
        public Fruit(string name, int blg, double volFromOneKilo)
        {
            this.name = name;
            this.blg = blg;
            this.volFromOneKilo = volFromOneKilo;
        }
    }
    Fruit[] fruitList = { new Fruit("jabłko",14,0.5), new Fruit("malina",14,0.6), new Fruit("wiśnia",10,0.6), new Fruit("winogrono",10,0.7),
       new Fruit("czarna porzeczka",12,0.7), new Fruit("czarny bez",8,0.7), new Fruit("pomarańcza",15,0.6)};

    Fruit mainFruit = null;

    private void HandleValidSubmit()
    {
        for (int i = 0; i < fruitList.Length; i++)
        {
            if (fruitList[i].name == wineCalc.fruit)
            {
                mainFruit = fruitList[i];
                break;
            }
        }

        //na razie uznaje ze wino ma taka sama gestosc jak woda czyli +- 1kg/1L

        fruitKg = (int.Parse(wineCalc.volume) / mainFruit.volFromOneKilo);  // kg

        FinalBlgCalc();

        sugar = (blgFinal * 10 * int.Parse(wineCalc.volume) - mainFruit.blg * 10 * int.Parse(wineCalc.volume)) / 10;  // dkg

        if (!wineCalc.pasterized)
        {
            potassium = int.Parse(wineCalc.volume) * 0.1;   // gram
            showIfPasterized = true;
        }
        else
            showIfPasterized = false;

        yeast = 2 * int.Parse(wineCalc.volume) / 10;  // gram. dozowanie 2g / 10L???

        show = true;
    }

    private void FinalBlgCalc()
    {
        if (int.Parse(wineCalc.power) == 9)
            blgFinal = 18;
        else if (int.Parse(wineCalc.power) == 11)
            blgFinal = 20;
        else if (int.Parse(wineCalc.power) == 16)
            blgFinal = 25;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
