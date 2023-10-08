using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NetCoreWithSPA.WebApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedEmail = false;
}).AddEntityFrameworkStores<ApplicationDbContext>()
  .AddDefaultTokenProviders();

// CORSの設定を追加
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder => builder.WithOrigins("http://localhost:8080")
                                               .AllowAnyMethod()
                                               .AllowAnyHeader()
                                               .AllowCredentials());
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.SameSite = SameSiteMode.None; // SameSiteポリシーをNoneに設定
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // クッキーをセキュアに設定
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseHttpsRedirection();

// CORSミドルウェアの使用を追加
app.UseCors();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
