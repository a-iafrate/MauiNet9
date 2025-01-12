using MauiNet9.Models;
using MauiNet9.PageModels;

namespace MauiNet9.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}