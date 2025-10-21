namespace ACollahuazo_S3.Views;

public partial class vUno1 : ContentPage
{
	string usuarioglobal = "a";
	string contrase�aglobal;
	public vUno1()
	{
		InitializeComponent();
	}

    public vUno1(string usuarioacceso, string contrase�aacceso)
    {
        InitializeComponent();
		usuarioglobal = usuarioacceso;
		contrase�aglobal = contrase�aacceso;
    }

    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
		try
		{   //Datos de acceso
			string usuario = txtUsuario.Text; 
			string contrase�a = txtContrase�a.Text;
			if (usuario == usuarioglobal && contrase�a == contrase�aglobal)
			{
				Navigation.PushAsync(new vDos2(usuario, contrase�a));
			}
			else 
			{
				DisplayAlert("Error", "Usuario o contrase�a incorrectas", "OK");
			}

		}
		catch(Exception ex) 
		{
			Console.WriteLine(ex.Message);
		}

    }

    private void btnResgitro_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new vTres3());
    }
}