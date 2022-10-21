namespace AspMvc.Configurations
{
    public static class MiddlewaresConfigurations
    {
        /// <summary>
        /// // Configure the HTTP request pipeline.
        /// </summary>
        internal static void ConfigureMiddleware(this WebApplicationBuilder? builder)
        {
            if (builder is null)
                throw new NullReferenceException("WebApplicationBuilder is null");

            var app = builder.Build();


            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
