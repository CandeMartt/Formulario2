namespace Tarea2;

public partial class Details : ContentPage
{
	public Details()
	{
		InitializeComponent();
	}

    // Atributo de la clase Details
    public string Nombre { get; set; }


    // Metodo de la clase Details
    private async void atrasClicked(object sender, EventArgs e)
    // La palabra void nos devuelve cosas. En este caso nos permite ir de una pagina a la otra

    {
        // Si la entrada no esta vacia, se enviara el nombre a la pagina principal. En caso contrario devolvera a la pagina principal sin realizar cambios
        if (validarNombre() != false)
        {
            Nombre = entryName.Text;
        }

        // Variable local que permite que no se cree una pila de paginas
        var paginaFinal = Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();
        
        // Devuleve a la MainPage llevandose el nombre ingresado por parametro
        await Navigation.PushAsync(new MainPage(Nombre));
        
        // Elimina la pagina anterior
        Navigation.RemovePage(paginaFinal);
    }

    public bool validarNombre()
    {
        // Metodo que valida que el nombre ingresado por el usuario no sea nulo
        if (string.IsNullOrWhiteSpace(entryName.Text))
        {
            return false;
        }
        else
        {
            return true;
        }

    }

}