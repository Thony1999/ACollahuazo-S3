namespace ACollahuazo_S3.Views;

public partial class vUno1 : ContentPage
{
	string usuarioglobal = "a";
	string contraseñaglobal;
	public vUno1()
	{
		InitializeComponent();
	}

    public vUno1(string usuarioacceso, string contraseñaacceso)
    {
        InitializeComponent();
		usuarioglobal = usuarioacceso;
		contraseñaglobal = contraseñaacceso;
    }

    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
		try
		{   //Datos de acceso
			string usuario = txtUsuario.Text; 
			string contraseña = txtContraseña.Text;
			if (usuario == usuarioglobal && contraseña == contraseñaglobal)
			{
				Navigation.PushAsync(new vDos2(usuario, contraseña));
			}
			else 
			{
				DisplayAlert("Error", "Usuario o contraseña incorrectas", "OK");
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