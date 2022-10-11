namespace Tarea2;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	public MainPage(string name)
	{
        InitializeComponent();

		// Si el nombre es distinto a ¡Bienvenido! se realizara el cambio por ¡Bienvenido nombre del usuario! 
		// En caso de no haber ingresado nombre o que sea igual  a ¡Bienvenido!, no se realiza ningun cambio.
        if (name != "¡Bienvenido!")
		{
			labelName.Text = $"¡Bienvenid@ {name}!";
		}
	}

	private async void agregarClicked(object sender, EventArgs e)
	{
        // Variable local que permite que no se cree una pila de paginas
        var paginaFinal = Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();

        // Lleva a la pagina Details
		await Navigation.PushAsync(new Details());

        // Elimina la pagina anterior, de esta forma no permite que se cree una pila de paginas
        Navigation.RemovePage(paginaFinal);
	}
}

