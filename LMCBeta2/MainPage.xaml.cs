using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;
using Newtonsoft.Json;
using MyToolkit;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace LMCBeta2
{

    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainPageViewModel ViewModel = new MainPageViewModel();

        public MainPage()
        {
            this.InitializeComponent();
            ViewModel.Visib1 = Visibility.Visible;
            ViewModel.Visib2 = Visibility.Collapsed;
            ViewModel.Visib3 = Visibility.Collapsed;
            ViewModel.Visib4 = Visibility.Visible;
            ViewModel.Visib5 = Visibility.Collapsed;
            ViewModel.Visib6 = Visibility.Collapsed;
            ViewModel.Visib7 = Visibility.Collapsed;
            ViewModel.Visib8 = Visibility.Collapsed;
            ViewModel.UserReadOnly = true;
            ViewModel.EmailReadOnly = true;
            ViewModel.UsernameMod = "Modify user name";
            ViewModel.EmailMod = "Modify Email address";
            ViewModel.LoginLoading = false;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
