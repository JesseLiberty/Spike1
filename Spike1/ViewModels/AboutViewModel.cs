using System;
using System.Windows.Input;
using MonkeyCache.FileStore;
using Spike1.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Spike1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));

            if (!Barrel.Current.IsExpired(key: "FirstItem"))
            {
                FromCache = Barrel.Current.Get<Item>(key: "FirstItem");
            }
        }

        public ICommand OpenWebCommand { get; }

        public Item FromCache { get; set; }



    }
}