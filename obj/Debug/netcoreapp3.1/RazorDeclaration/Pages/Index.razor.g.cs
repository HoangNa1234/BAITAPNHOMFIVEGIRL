// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorExample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\_Imports.razor"
using BlazorExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\_Imports.razor"
using BlazorExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\_Imports.razor"
using Syncfusion.Blazor.BarcodeGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\_Imports.razor"
using Syncfusion.Blazor.Schedule;

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
#line 28 "D:\LT Web\create-blazor-charts-in-a-blazor-server-app-master\Pages\Index.razor"
       
    public string ButtonContent = "HIỂN THỊ";
    public class SalesData
    {
        public string Month { get; set; }
        public double SalesValue { get; set; }
    }

    public List<SalesData> Sales = new List<SalesData> 
    {
        new SalesData { Month = "Áo sơ mi", SalesValue =235 },
        new SalesData { Month = "Áo thun", SalesValue = 228 },
        new SalesData { Month = "Áo blazer", SalesValue = 134 },
        new SalesData { Month = "Áo khoác nắng", SalesValue = 532 },
        new SalesData { Month = "Quần Tây", SalesValue = 150 },
        new SalesData { Month = "Quần Jeans", SalesValue = 332 },
        new SalesData { Month = "Quần suông", SalesValue = 535 },
        new SalesData { Month = "Chân váy", SalesValue = 545 },
        new SalesData { Month = "Áo đầm", SalesValue = 328 },
        new SalesData { Month = "Áo xô kiểu", SalesValue = 100 },
        new SalesData { Month = "Túi xách", SalesValue = 68},
        new SalesData { Month = "Phụ kiện", SalesValue = 50 },
        new SalesData { Month = "Khác...", SalesValue = 50 }

    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
