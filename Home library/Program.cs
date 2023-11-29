using Home_library.Implementations;
using Home_library.Interfaces;
using Home_library.Models;
using Home_library.Models.Book;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Home_library;

internal static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; }

    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
    }

    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddTransient<IValidator<User>, UserValidator>();
                services.AddTransient<IValidator<Book>, BookValidator>();
                services.AddTransient<IManager<User>, UserManager>();
                services.AddTransient<IManager<Book>, BookManager>();

                services.AddTransient<LoginForm>();
                services.AddTransient<DashboardForm>();
                services.AddTransient<AddBookForm>();
            });
    }
}