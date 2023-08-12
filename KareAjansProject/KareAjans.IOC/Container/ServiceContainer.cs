using KareAjans.BLL.Abstract;
using KareAjans.BLL.AbstractService;
using KareAjans.BLL.Concrete;
using KareAjans.BLL.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.IOC.Container
{
    public static  class ServiceContainer
    {
        public static void ServiceConfigure(IServiceCollection services)
        {
            
            services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));//Generic yapı ne geliyorsa addscopeda eklediğimiz o yapıyı ayağa kaldıracak.Genel                ssorgulamalar.
            services.AddScoped<IAdresService, AdresService>();//Özel sorgulamalar
            services.AddScoped<IFotografService, FotografService>();
            services.AddScoped<IOrganizasyonGelirService, OrganizasyonGelirService>();
            services.AddScoped<IOrganizasyonGiderService, OrganizasyonGiderService>();
            services.AddScoped<IYorumService, YorumService>();
            services.AddScoped<IMankenService, MankenService>();
            services.AddScoped<IOrganizasyonService, OrganizasyonService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderDetailService, OrderDetailService>();
        }

    }
}
