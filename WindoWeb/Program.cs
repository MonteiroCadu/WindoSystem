using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Windo.Application;
using Windo.Application.Contratos;
using Windo.Persistence;
using Windo.Persistence.Contratos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddMemoryCache();
builder.Services.AddSession();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<ILicencaPersist, LicencaPersist>();
builder.Services.AddScoped<ILicencaService, LicencaService>();
builder.Services.AddScoped<IPessoaService, PessoaService>();
builder.Services.AddScoped<IPessoaPersist, PessoaPersist>();
builder.Services.AddScoped<IPlataformaService, PlataformaService>();
builder.Services.AddScoped<IPlataformaPersist, PlataformaPersist>();
builder.Services.AddScoped<IPlanoVendaPersist, PlanoVendaPersist>();
builder.Services.AddScoped<IPlanoVendaService, PlanoVendaService>();
builder.Services.AddScoped<ICorretoraPersist, CorretoraPersist>();
builder.Services.AddScoped<ICorretoraService, CorretoraService>();


builder.Services.AddScoped < IConectionFactory, ConectionFactory>();

builder.Services.AddControllers()
                    .AddNewtonsoftJson( //Para evitar loop infinito no carregamento de Json´s compostos
                        x => x.SerializerSettings.ReferenceLoopHandling =
                        Newtonsoft.Json.ReferenceLoopHandling.Ignore
                    );

string SqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<windo_baseContext>(options =>
{
    options.UseSqlServer(SqlConnection);
});

builder.Services.AddIdentity<IdentityUser, IdentityRole>(config =>
{
    config.Password.RequiredLength = 4;
    config.Password.RequireDigit = false;
    config.Password.RequireNonAlphanumeric = false;
    config.Password.RequireUppercase = false;   
            })
    .AddEntityFrameworkStores<windo_baseContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapControllerRoute(
//                name: "Cliente",
//                pattern: "{controller=Cliente}/{action=Edit}/{id}/{pessoa?}"
//            );

app.Run();
