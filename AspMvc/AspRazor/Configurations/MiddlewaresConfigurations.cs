namespace AspRazor.Configurations
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


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseStatusCodePages();
            app.Use(async (ctx, next) =>
            {
                await next();

                if (ctx.Response.StatusCode == 404 /*&& !ctx.Response.HasStarted*/)
                {
                    ctx.Request.Path = "/NotFound";
                    await next();
                }
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
