using AspRazor.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureServices();

builder.ConfigureMiddleware();