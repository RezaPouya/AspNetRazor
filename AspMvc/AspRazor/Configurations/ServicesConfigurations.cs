namespace AspRazor.Configurations
{
    public static class ServicesConfigurations
    {
        internal static void ConfigureServices(this WebApplicationBuilder? builder)
        {
            if (builder is null)
                throw new NullReferenceException("WebApplicationBuilder is null");

            var configuration = builder.Configuration;

            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Add services to the container.
            builder.Services.AddRazorPages();

            //builder.Services.AddControllersWithViews();


            // https://docs.microsoft.com/en-us/ef/core/dbcontext-configuration/#avoiding-dbcontext-threading-issues
            //builder.Services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);

            builder.Services.AddCustomServices(configuration);
        }


        private static void AddCustomServices(this IServiceCollection services, ConfigurationManager? configurationManager)
        {
            //services.AddScoped<ICustomerManager, CustomerManager>();
        }
    }
}