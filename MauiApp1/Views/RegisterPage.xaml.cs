using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    public void Login_Clicked(object sender, EventArgs e)
	{
		Data.Users.Add(new User() { Name = Name.Text, Password = Password.Text });
	}
}