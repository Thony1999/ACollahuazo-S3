namespace ACollahuazo_S3.Views;

public partial class vTres3 : ContentPage
{
	public vTres3()
	{
		InitializeComponent();
	}

    private void btnSalir_Clicked(object sender, EventArgs e)
    {
		try 
		{ 
			string usuario = txtUsuario.Text;
			string contraseña =txtContraseña.Text;
			Navigation.PushAsync(new vUno1(usuario, contraseña));
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
    }
}