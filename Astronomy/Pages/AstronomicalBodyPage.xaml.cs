namespace Astronomy.Pages;

[QueryProperty(nameof(AstroName), "astroName")]
public partial class AstronomicalBodyPage : ContentPage
{
    string astroName;
    public string AstroName
    {
        get => astroName;
        set
        {
            astroName = value;
            UpdateAstroBodyUI(astroName);
        }
    }

    public AstronomicalBodyPage()
    {
        InitializeComponent();
    }

    private void UpdateAstroBodyUI(string name)
    {
        if (string.IsNullOrEmpty(name)) return;

        AstronomicalBody body = null;

        switch (name.ToLower())
        {
            case "sun":
                body = SolarSystemData.Sun;
                break;
            case "earth":
                body = SolarSystemData.Earth;
                break;
            case "moon":
                body = SolarSystemData.Moon;
                break;
            case "comet":
                body = SolarSystemData.HalleysComet;
                break;
        }

        if (body != null)
        {
            this.Title = body.Name;

            if (lblMass != null) lblMass.Text = body.Mass;
            if (lblCircumference != null) lblCircumference.Text = body.Circumference;
            if (lblAge != null) lblAge.Text = body.Age;

            // Спробуємо знайти будь-який елемент на сторінці, куди можна вивести емодзі
            // Зазвичай у Microsoft верхнє поле опису або іконки називаєтьсяlblIcon або lblHeader
            var lblIcon = FindByName("lblIcon") as Label ?? FindByName("lblHeader") as Label;
            if (lblIcon != null)
            {
                lblIcon.Text = body.EmojiIcon;
                lblIcon.FontSize = 80; // Робимо емодзі планети великим і красивим
                lblIcon.HorizontalOptions = LayoutOptions.Center;
            }
        }
    }
}