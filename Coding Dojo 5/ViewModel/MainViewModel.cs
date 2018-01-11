using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace Coding_Dojo_5.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ItemVm> ItemList { get; set; }
        public ObservableCollection<ItemVm> WishList { get; set; }
        private RelayCommand<ItemVm> buyBtnClickedCmd;
        private ItemVm currentItem;

        public ItemVm CurrentItem
        {
            get { return currentItem; }
            set { currentItem = value; }
        }


        public RelayCommand<ItemVm> BuyBtnClickedCmd
        {
            get { return buyBtnClickedCmd; }
            set
            {
                buyBtnClickedCmd = value;
                RaisePropertyChanged();
            }
        }


        public MainViewModel()
        {
            WishList = new ObservableCollection<ItemVm>();


        }
        
        private void GenerateDemoData()
        {
            ItemList.Add(new ItemVm("MY Lego",new BitmapImage(new Uri("Images/lego1.png",UriKind.Relative)),"-"));
            ItemList.Add(new ItemVm("MY Playmobil", new BitmapImage(new Uri("Images/playmobil1.png", UriKind.Relative)), "-"));
        }
    }
}