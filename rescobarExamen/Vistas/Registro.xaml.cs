namespace rescobarExamen.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string usuario)
	{
		InitializeComponent();
		lblUsuario.Text = usuario + " conectado";
	}

    private void txtInicial_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void txtPago_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void txtApellido_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void txtEdad_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}