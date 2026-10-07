using MauiApp1.Models;
using System.Xml.Linq;

namespace MauiApp1.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    public void Login_Clicked(object sender, EventArgs e)
    {


        bool exists = Data.Users.Any(u =>
            u.Name == Name.Text &&
            u.Password == Password.Text
        );




    }


}