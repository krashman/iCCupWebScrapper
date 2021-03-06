using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using iCCup.UI.Infrastructure.Contracts;
using iCCup.UI.Infrastructure.Scrapper;
using iCCup.UI.Infrastructure.Service;
using Microsoft.Practices.ServiceLocation;

namespace iCCup.UI.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            DispatcherHelper.Initialize();

            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<IScrapperService, ScrapperService>();
            SimpleIoc.Default.Register<IMessangerService, MessangerService>();
            SimpleIoc.Default.Register<ILoggerService, LoggerService>();

            var scrapperBase = new ScrapperBase(SimpleIoc.Default.GetInstance<ILoggerService>());

            SimpleIoc.Default.Unregister<ScrapperBase>();
            SimpleIoc.Default.Register(() => scrapperBase);

            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
    }
}