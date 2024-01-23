namespace Test;

public partial class CommonPage2 : ContentPage
{
	public CommonPage2()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(PassEntry.Text != null)
		{
			Preferences.Default.Set("password", PassEntry.Text);
			Preferences.Default.Set("username", UserEntry.Text);
			Preferences.Default.Set("name", NameEntry.Text);
			Preferences.Default.Set("family", FamilyEntry.Text);
            Navigation.PopToRootAsync();


        }
        else
		{
            DisplayAlert("Ошибка", "Неверные учетные данные", "OK");
        }
    }
}