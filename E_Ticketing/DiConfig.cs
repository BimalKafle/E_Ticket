using E_Ticketing.CoreLayer.Repository;
using E_Ticketing.CoreLayer.Service;
using E_Ticketing.CoreLayer.Service.ServiceInterface;
using E_Ticketing.DataLayer.Repository;

namespace E_Ticketing
{
    public static class DiConfig
    {
        public static void UseETicketing(this IServiceCollection services)
        {
           
            UseRepository(services);
            UseService(services);
        }

        private static void UseRepository(this IServiceCollection services)
        {
            services.AddScoped<VehicleCategoryRepositoryInterface, VehicleCategoryRepository>();

        }
        private static void UseService(this IServiceCollection services)
        {
            services.AddScoped<VehicleCategoryServiceInterface, VehicleCategoryService>();
        }
    }
}
