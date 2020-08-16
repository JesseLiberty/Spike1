using System.Windows.Input;
using MonkeyCache.LiteDB;
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
            UpdateFromCacheCommand = new Command(() => UpdateFromBarrel());

        }

        public void UpdateFromBarrel()
        {
            if (!Barrel.Current.IsExpired(key: "FirstItem"))
            {
                FromCache = Barrel.Current.Get<Item>(key: "FirstItem");
            }

        }

        public ICommand OpenWebCommand { get; }
        public ICommand UpdateFromCacheCommand { get; }


        private Item _fromCache;
        public Item FromCache
        {
            get => _fromCache;
            set => SetProperty(ref _fromCache, value);
        }


    }
}