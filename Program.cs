using Demo1.Data;
using Demo1.Interfaces;
using Demo1.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAlimSatimRepository, AlimSatimRepository>();
builder.Services.AddScoped<ICalisanRepository, CalisanRepository>();
builder.Services.AddScoped<IDepartmanRepository, DepartmanRepository>();
builder.Services.AddScoped<IDepoRepository, DepoRepository>();
builder.Services.AddScoped<IDepoUrunRepository, DepoUrunRepository>();
builder.Services.AddScoped<IIslemRepository, IslemRepository>();
builder.Services.AddScoped<IKategoriRepository, KategoriRepository>();
builder.Services.AddScoped<IKullaniciIslemRepository, KullaniciIslemRepository>();
builder.Services.AddScoped<IKullaniciRolRepository, KullaniciRolRepository>();
//sifre buraya gelicek-- henüz düzenlemedim
builder.Services.AddScoped<IMarkaRepository, MarkaRepository>();
builder.Services.AddScoped<IRolRepository, RolRepository>();
builder.Services.AddScoped<IRolYetkileriRepository, RolYetkileriRepository>();
builder.Services.AddScoped<IUrunRepository, UrunRepository>();
builder.Services.AddScoped<IYetkiRepository, YetkiRepository>();




builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();// xx??

app.MapControllers();

app.Run();
