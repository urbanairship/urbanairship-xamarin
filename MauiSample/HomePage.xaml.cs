using AirshipDotNet;

namespace MauiSample;

public partial class HomePage : ContentPage
{
    HomePageViewModel viewModel = new HomePageViewModel();

    public HomePage()
	{
		InitializeComponent();
        BindingContext = viewModel;
   	}

    protected override void OnAppearing()
    {
        viewModel.Refresh();
    }
}
