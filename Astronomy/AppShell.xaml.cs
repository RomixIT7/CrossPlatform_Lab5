namespace Astronomy;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Реєструємо маршрут для переходу на сторінку деталей
        Routing.RegisterRoute("astronomicalbodydetails", typeof(Pages.AstronomicalBodyPage));
    }
}