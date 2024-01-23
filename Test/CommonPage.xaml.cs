namespace Test;

public partial class CommonPage : ContentPage
{
    public CommonPage()
    {
        InitializeComponent();
    }
    private void BornDP_DateSelected(object sender, DateChangedEventArgs e)
    {

    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        var result = await MediaPicker.PickPhotoAsync();
        if (result != null)
        {
            var selectedPhotoStream = await result.OpenReadAsync();
            ImageView.Source = ImageSource.FromStream(() => selectedPhotoStream);
        }
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Preferences.Default.Set("familia", Surname.Text);
        Preferences.Default.Set("name", Name.Text);
        Preferences.Default.Set("secondname", Secondname.Text);
        Preferences.Default.Set("borndate", BornDP.Date);
        Preferences.Default.Set("starosta", Starosta.SelectedItem.ToString());
        Preferences.Default.Set("gender", Gender.SelectedItem.ToString());
        Preferences.Default.Set("obchez", Obchez.SelectedItem.ToString());
        Preferences.Default.Set("mid", MidBal.SelectedItem.ToString());
        Preferences.Default.Set("image", Convert.ToString(ImageView.Source));

    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        Surname.Text = Preferences.Default.Get("familia", "");
        Name.Text = Preferences.Default.Get("name", "");
        Secondname.Text = Preferences.Default.Get("secondname", "");
        BornDP.Date = Preferences.Default.Get("borndate", DateTime.Now);
        Starosta.SelectedItem = Preferences.Default.Get("starosta", "");
        Gender.SelectedItem = Preferences.Default.Get("gender", "");
        Obchez.SelectedItem = Preferences.Default.Get("obchez", "");
        MidBal.SelectedItem = Preferences.Default.Get("mid", "");
        ImageView.Source = Preferences.Default.Get("image", "");
    }
}