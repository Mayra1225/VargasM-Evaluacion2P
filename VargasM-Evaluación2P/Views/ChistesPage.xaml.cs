using VargasM_Evaluación2P.Repositories;

namespace VargasM_Evaluación2P.Views;

public partial class ChistesPage : ContentPage
{
    private readonly ChisteRepository _chisteRepository;

    public ChistesPage()
	{
		InitializeComponent();
        _chisteRepository = new ChisteRepository();
        CargarChiste();
	}

	public async void CargarChiste()
	{
		var chiste = await _chisteRepository.GetChisteRandom();
        lblChiste.Text = $"{chiste.setup}\n\n{chiste.punchline}";
    }

	public void OnOtroChisteClicked(object sender, EventArgs e)
    {
        CargarChiste();
    }
}