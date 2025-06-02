namespace VargasM_Evaluación2P
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnChisteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChistesPage());
        }

        private async void OnAboutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

    }
