using Home_library.Implementations;
using Home_library.Interfaces;
using Home_library.Models;
using Home_library.Models.Book;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Home_library;

internal static class Program
{
    public static IServiceProvider? ServiceProvider { get; private set; }

    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        var loginForm = ServiceProvider.GetRequiredService<LoginForm>();

        if (loginForm.ShowDialog() == DialogResult.OK)
        {
            Application.Run(ServiceProvider.GetRequiredService<DashboardForm>());
        }
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
                services.AddSingleton<BookEditor>();

                services.AddTransient<LoginForm>();
                services.AddTransient<DashboardForm>();
                services.AddTransient<AddBookForm>();
                services.AddTransient<EditBookForm>();
            });
    }
}