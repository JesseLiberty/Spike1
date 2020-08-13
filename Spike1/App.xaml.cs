using MonkeyCache.LiteDB;
using Spike1.Services;
using Xamarin.Forms;

namespace Spike1
{
    public partial class App : Application
    {

        public App()
        {
            Barrel.ApplicationId = "Spike1";
            Barrel.EncryptionKey = "EncryptMe";
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
