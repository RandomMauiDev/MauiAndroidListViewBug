namespace MauiAndroidListvViewBug;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
		BindingContext = new Page2ViewModel();
	}
}