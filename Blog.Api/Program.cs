using Blog.Dados.Interfaces;
using Blog.Dados.Repository;
using Blog.Domain.Context;
using Blog.Services.Interfaces;
using Blog.Services.Services;
using Microsoft.Extensions.FileProviders;
using System.Text.Json.Serialization;
using Blog.Domain.DataConnection;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped(typeof(IDataContext<>), typeof(DataContext<>));
builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IPostServices, PostServices>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.Configure<DataConnection>(builder.Configuration);


var app = builder.Build();

if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });

}

app.UseStaticFiles(
	new StaticFileOptions
	{
		FileProvider = new PhysicalFileProvider(builder.Configuration.GetSection("CaminhoArquivo").Value),
		RequestPath = "/Imagens"
	});

app.UseHttpsRedirection();
app.UseRequestLocalization("pt-BR");
app.MapControllers();

app.Run();
