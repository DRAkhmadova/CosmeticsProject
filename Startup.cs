using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Сайт.Data.interfaces;
using Сайт.Data.Mocks;

namespace Сайт
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICosmetics,MockCosmetics>();
            services.AddTransient<ICosmeticsSections,MockSections>();
            services.AddMvc(options=>options.EnableEndpointRouting=false); //подключаем поддержку mvc в проекте
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage(); // отображение ошибок
            app.UseStatusCodePages();// отображение кодов страниц
            app.UseStaticFiles();// отображение css файлов
            app.UseMvcWithDefaultRoute(); 
        }
    }
}
