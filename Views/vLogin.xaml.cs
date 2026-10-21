namespace eclavijoS3i.Views;

public partial class vLogin : ContentPage
{
    string usuario="";
    string contrasena = "";

    public vLogin()
	{
		InitializeComponent();
	}
    public vLogin(String usuarioNuevo, String contrasenaNueva)
    {
        InitializeComponent();
        usuario = usuarioNuevo;
        contrasena = contrasenaNueva;
    }

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        try
        {
            string usuarioingresado = txtUsuario.Text;
            string contrasenaingresado = txtcontrasena.Text;
            if (usuario == usuarioingresado && contrasena == contrasenaingresado)
            {
                await Navigation.PushAsync(new Views.vPrincipal(usuario));
            }
            else
            {
                await DisplayAlertAsync("Error", "Usuario o contraseña incorrectos", "Cerrar");
                txtUsuario.Text = "";
                txtcontrasena.Text = "";
            }
        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("Error", ex.Message, "OK");
        }
    }

    private async void btnRegistrarUsuario_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.vRegistro());
    }
}