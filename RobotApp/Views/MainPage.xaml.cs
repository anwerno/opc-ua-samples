// Copyright (c) Converter Systems LLC. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using RobotApp.ViewModels;
using Windows.UI.Xaml.Controls;

namespace RobotApp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        public MainPageViewModel ViewModel
        {
            get { return this.DataContext as MainPageViewModel; }
            set { this.DataContext = value; }
        }
    }
}
