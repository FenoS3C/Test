namespace Test;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
        Title = "Меню";
        InitializeComponent();
        NameLB.Text = Data.Name;
        FamilyLB.Text = Data.Familia;
    }

    private async void Программа_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CommonPage());
    }

    private async void UserBT_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CommonPage2());
    }
}