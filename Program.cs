namespace _3duPlanet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Add services to the container.
            var builder = WebApplication.CreateBuilder(args);
#if DEBUG
            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
#else
            builder.Services.AddRazorPages();
#endif

            // Configure the HTTP request pipeline.
            var app = builder.Build();
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.MapRazorPages();
            app.Run();
        }
    }
}