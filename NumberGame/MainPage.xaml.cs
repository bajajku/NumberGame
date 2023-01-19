using System;
using System.Security.Cryptography;

namespace NumberGame;

public partial class MainPage : ContentPage
{   Random rGenetator= new Random();
	int randomNumber; //creates a field variable

	public MainPage()
	{
		InitializeComponent();
		//generate a random 3 digit number
		randomNumber=rGenetator.Next(100,1000);
	}

    private void OnButtonclicked(object sender, EventArgs e)
    {
		//generate 3 digits 
		int num1 = rGenetator.Next(0, 10);
		int num2 = rGenetator.Next(0, 10);
		int num3 = rGenetator.Next(0, 10);
		//use them to generate corresponding image names
		string s1 = $"n{num1}.png";
        string s2 = $"n{num2}.png";
        string s3 = $"n{num3}.png";

        //use the generated image names to show images on main page




    }
}
