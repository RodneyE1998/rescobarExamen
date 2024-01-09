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

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double pagoinicial = Convert.ToInt32(txtInicial.Text);
        double pagomensual;
        
        pagomensual =((1500 - pagoinicial)/4) + (0.04 * 1500);
        txtPago.Text = pagomensual.ToString();

        //DisplayAlert("PAGO MENSUAL", "El paso es de " + pagomensual, "Cerrar");
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = Fecha.Date.ToString();
        string pais = pkPais.Items[pkPais.SelectedIndex].ToString();
        string ciudad = pkCiudad.Items[pkCiudad.SelectedIndex].ToString();
        string pagoinicial = txtInicial.Text;
        string pagomensual = txtPago.Text;
        double pagototal = Convert.ToDouble(pagoinicial) + Convert.ToDouble(pagomensual) * 4;


        DisplayAlert("RESUMEN", "Nombre:  "+nombre + "\n" +"Apellido: "+ apellido + "\n" +"Edad: " + edad + "\n"+ "Fecha: " +
            fecha + "\n" + "Pais: " + pais + "\n" + "Ciudad: " + ciudad + "\n" + "Pago Inicial: " 
            + pagoinicial + "\n"+ "Pago Mensual: " + pagomensual + "\n" + "Total: " + pagototal, "CERRAR");
    }
}