using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApi.Data;

namespace WebApi.Controllers
{
    [Route("[controller]")]
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Configuração do banco de dados

        services.AddDbContext<DbContext>(options =>
        {
            object value = options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        });

        // Configuração dos repositórios

        services.AddScoped<IEmpresaRepository, EmpresaRepository>();
        services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
        services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();
        services.AddScoped<ITarefaRepository, TarefaRepository>();

        // Configuração dos casos de uso

        services.AddScoped<AdicionarEmpresaUseCase>();
        services.AddScoped<AtualizarEmpresaUseCase>();
        services.AddScoped<RemoverEmpresaUseCase>();

        services.AddScoped<AdicionarFuncionarioUseCase>();
        services.AddScoped<AtualizarFuncionarioUseCase>();
        services.AddScoped<RemoverFuncionarioUseCase>();

        services.AddScoped<AdicionarDepartamentoUseCase>();
        services.AddScoped<AtualizarDepartamentoUseCase>();
        services.AddScoped<RemoverDepartamentoUseCase>();

        services.AddScoped<AdicionarTarefaUseCase>();
        services.AddScoped<AtualizarTarefaUseCase>();
        services.AddScoped<RemoverTarefaUseCase>();

        // Configuração dos controladores

        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Configurações do ambiente

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        // Configurações da API

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}

}