using System;

using The_Dictionary.ViewModels;

using Windows.UI.Xaml.Controls;

namespace The_Dictionary.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
