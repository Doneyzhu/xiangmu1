var builder = WebApplication.CreateBuilder(args);

// ��ӿ���������ͼ����
builder.Services.AddControllersWithViews();

var app = builder.Build();


// ��ȡ EndpointDataSource ʵ��
var endpointDataSource = app.Services.GetRequiredService<Microsoft.AspNetCore.Routing.EndpointDataSource>();

// �������·����Ϣ
foreach (var endpoint in endpointDataSource.Endpoints)
{
    if (endpoint is Microsoft.AspNetCore.Routing.RouteEndpoint routeEndpoint)
    {
        Console.WriteLine($"·��ģʽ: {routeEndpoint.RoutePattern.RawText}");
        Console.WriteLine($"�������: {routeEndpoint.RequestDelegate?.Target}");
        Console.WriteLine("----------------------");
    }
}

// ���� HTTP ������
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// �޸�Ĭ��·��
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Query1",
    pattern: "Query1/{action=Index}/{id?}",
    defaults: new { controller = "Query1" });

app.Run();