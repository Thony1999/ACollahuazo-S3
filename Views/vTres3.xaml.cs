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
			string contrase�a =txtContrase�a.Text;
			Navigation.PushAsync(new vUno1(usuario, contrase�a));
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
    }
}