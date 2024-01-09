namespace rescobarExamen.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string[] users = { "estudiante2024", "examen1", "NombreEstudiante" };
        string[] passwords = { "uisrael2024", "parcial1", "2024" };

        string usuarioIngresado = txtUsuario.Text;
        string contrasenaIngresada = txtContraseña.Text;

        for (int i = 0; i < users.Length; i++)
        {
            if (users[i] == usuarioIngresado && passwords[i] == contrasenaIngresada)
            {
                Navigation.PushAsync(new Registro(usuarioIngresado));
                DisplayAlert("WELCOME", "Bienvenido " + usuarioIngresado + "\n" + "Usuario Conectado", "Cerrar");
                break;
            }
            else
            {
                DisplayAlert("ALERTA", "Usuarios o contraseña Incorrectos", "Cerrar");
            }
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("B", "Creado por Rodney Escobar \n Ingenieria en Sistemas \n Octavo Semestre", "Cerrar");
    }
}