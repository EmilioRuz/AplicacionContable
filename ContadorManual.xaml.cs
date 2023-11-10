namespace ContadorManual;

public partial class MainPage : ContentPage
{
    private int conteo;

    public MainPage()
    {
        InitializeComponent();
        conteo = 0;
        ConteoLabel.Text = conteo.ToString();
    }

    private void ContarButton(object sender, EventArgs e)
    {
        conteo++;
        ConteoLabel.Text = conteo.ToString();
    }

    private void ReiniciarButton(object sender, EventArgs e)
    {
        conteo = 0;
        ConteoLabel.Text = conteo.ToString();
    }
}