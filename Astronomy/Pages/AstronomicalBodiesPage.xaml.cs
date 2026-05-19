namespace Astronomy.Pages;

public partial class AstronomicalBodiesPage : ContentPage
{
    public AstronomicalBodiesPage()
    {
        InitializeComponent();

        // Прив'язуємо кліки кнопок до нашого єдиного маршруту деталей
        btnSun.Clicked += async (s, e) =>
            await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=sun");

        btnMoon.Clicked += async (s, e) =>
            await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=moon");

        btnEarth.Clicked += async (s, e) =>
            await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=earth");

        btnComet.Clicked += async (s, e) =>
            await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=comet");
    }
}