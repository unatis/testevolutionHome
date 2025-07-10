namespace testevolutionHome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Добавляем поддержку контроллеров
            builder.Services.AddControllers();

            //session support
            builder.Services.AddDistributedMemoryCache(); // добавляем локальный кэш
            builder.Services.AddSession();

            var app = builder.Build();

            // Используем статические файлы из wwwroot
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
