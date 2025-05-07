var builder = WebApplication.CreateBuilder(args);

// 添加控制器和视图服务
builder.Services.AddControllersWithViews();

var app = builder.Build();


// 获取 EndpointDataSource 实例
var endpointDataSource = app.Services.GetRequiredService<Microsoft.AspNetCore.Routing.EndpointDataSource>();

// 输出所有路由信息
foreach (var endpoint in endpointDataSource.Endpoints)
{
    if (endpoint is Microsoft.AspNetCore.Routing.RouteEndpoint routeEndpoint)
    {
        Console.WriteLine($"路由模式: {routeEndpoint.RoutePattern.RawText}");
        Console.WriteLine($"处理程序: {routeEndpoint.RequestDelegate?.Target}");
        Console.WriteLine("----------------------");
    }
}

// 配置 HTTP 请求处理
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// 修改默认路由
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Query1",
    pattern: "Query1/{action=Index}/{id?}",
    defaults: new { controller = "Query1" });

app.Run();