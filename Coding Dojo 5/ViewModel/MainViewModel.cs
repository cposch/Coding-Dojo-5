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
            set
            {
                currentItem = value;
                RaisePropertyChanged();
            }
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
            ItemList = new ObservableCollection<ItemVm>();

            BuyBtnClickedCmd = new RelayCommand<ItemVm>((p) =>
            {
                WishList.Add(p);
            }, (p) => { return true; }
            );

            GenerateDemoData();
        }
        
        private void GenerateDemoData()
        {
            ItemList.Add(new ItemVm("MY Lego", new BitmapImage(new Uri("Images/lego1.png", UriKind.Relative)), "-"));
            ItemList[ItemList.Count - 1].AddItem(
                new ItemVm("Lego 2", new BitmapImage(new Uri("Images/lego2.jpg", UriKind.Relative)), "5+"));
            ItemList[ItemList.Count - 1].AddItem(
                new ItemVm("Lego 3", new BitmapImage(new Uri("Images/lego3.jpg", UriKind.Relative)), "10+"));
            ItemList[ItemList.Count - 1].AddItem(
                new ItemVm("Lego 4", new BitmapImage(new Uri("Images/lego4.jpg", UriKind.Relative)), "10+"));

            ItemList.Add(new ItemVm("MY Playmobil", new BitmapImage(new Uri("Images/playmobil1.png", UriKind.Relative)), "-"));
            ItemList[ItemList.Count - 1].AddItem(
                new ItemVm("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            ItemList[ItemList.Count - 1].AddItem(
                new ItemVm("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
        }
    }
}