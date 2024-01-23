

namespace Test
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {

            InitializeComponent();
            
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            
            bool isAuthenticated = PerformAuthentication(username, password);

            if (isAuthenticated)
            {
                
                Navigation.PushAsync(new ModalPage());
                NameEntry.Text = ""; FamilyEntry.Text = "";UsernameEntry.Text = "";PasswordEntry.Text = "";
            }
            else
            {
               
                DisplayAlert("Ошибка", "Неверные учетные данные", "OK");
            }
        }

        private bool PerformAuthentication(string username, string password)
        {
            if (username == Preferences.Default.Get("username", "") & password == Preferences.Default.Get("password","") & NameEntry.Text != null & FamilyEntry.Text != null)
            {
                Data.Name = NameEntry.Text;
                Data.Familia = FamilyEntry.Text;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
