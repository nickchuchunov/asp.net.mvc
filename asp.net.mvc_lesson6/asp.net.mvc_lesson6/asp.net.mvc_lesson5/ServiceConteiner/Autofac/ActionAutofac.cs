using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using Autofac.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace asp.net.mvc_lesson6
{
   internal class ActionAutofac
    {

        private IHost host;
        public    IHost Hosting => host ??= CreateHostBuilder(Environment.GetCommandLineArgs()).Build();
         IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).UseServiceProviderFactory(new AutofacServiceProviderFactory())
            //.ConfigureHostOptions(opt =>opt.);
            .ConfigureServices(ConfigureServices);
        
        /// <summary>
        /// Добавление сервисов 
        /// </summary>
        /// <param name="host"></param>
        /// <param name="service"></param>

        private void ConfigureServices(HostBuilderContext host, IServiceCollection service ) 

        {

            service.AddAutofac().AddSingleton<FaceDataMachin>();
            //service.AddAutofac().AddSingleton<PseudoScannerEvent>();
            service.AddAutofac().AddSingleton<RemainingResources>();


        }



        internal ActionAutofac() 
        {
           
            

        }





    }
}
