using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<EvcilDbContext>();
 
builder.Services.AddScoped<IAsiTakipDal,EfAsiTakibiDal>();
builder.Services.AddScoped<IAsiTakibiService, AsiTakibiManager>();

builder.Services.AddScoped<IBeslenmeTakipDal, EfBeslenmeTakibiDal>();
builder.Services.AddScoped<IBeslenmeTakibiService, BeslenmeTakibiManager>();

builder.Services.AddScoped<IHayvaniminBilgileriDal, EfHayvaniminBilgileriDal>();
builder.Services.AddScoped<IHayvaniminBilgileriService, HayvaniminBilgileriManager>();

builder.Services.AddScoped<ISaglikTakibiDal, EfSaglikTakibiDal>();
builder.Services.AddScoped<ISaglikTakibiService, SaglikTakibiManager>();

builder.Services.AddScoped<ISosyalAktiviteDal, EfSosyalAktiviteleriDal>();
builder.Services.AddScoped<ISosyalAktiviteService, SosyalAktiviteManager>();

builder.Services.AddScoped<ITemizlikTakibiDal, EfTemizlikTakibiDal>();
builder.Services.AddScoped<ITemizlikTakibiService, TemizlikTakibiManager>();

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSession();
builder.Services.AddDistributedMemoryCache(); // Önbellek için daðýtýlmýþ belleði ekleyin


builder.Services.AddCors(opt =>
{
    opt.AddPolicy("EvcilHayvanimApi", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("EvcilHayvanimApi");
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
