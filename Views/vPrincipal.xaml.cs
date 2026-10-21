namespace eclavijoS3i.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal( string usuario)
	{
		InitializeComponent();

		DisplayAlertAsync("BIENVENIDO", usuario, "Cerrar");
		lblUsuario.Text = "Usuario Conectado " + usuario;
	}
}