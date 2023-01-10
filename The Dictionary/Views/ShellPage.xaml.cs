using System;

using The_Dictionary.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.ApplicationModel.Core;


namespace The_Dictionary.Views
{
    // TODO: Change the icons and titles for all NavigationViewItems in ShellPage.xaml.
    public sealed partial class ShellPage : Page
    {
        public ShellViewModel ViewModel { get; } = new ShellViewModel();

        public ShellPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(shellFrame, navigationView, KeyboardAccelerators);
            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            Windows.UI.Xaml.Window.Current.SetTitleBar(TitleBar);
        }
    }
}
