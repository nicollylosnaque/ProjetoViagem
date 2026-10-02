using MinhaOnBoardingPage.ViewModels;

namespace ProjetoViagem.Views;

public partial class OnboardingPage : ContentPage
{
	public OnboardingPage(OnboardingViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}