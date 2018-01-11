using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Coding_Dojo_5.ViewModel
{
    public class ItemVm
    {
        public ObservableCollection<ItemVm> ItemList { get; set; }
        public string Description { get; set; }
        public BitmapImage Image { get; set; }
        public string AgeRecommendation { get; set; }

        public ItemVm(string description, BitmapImage image, string ageRecommendation)
        {
            Description = description;
            Image = image;
            AgeRecommendation = ageRecommendation;
        }

        public void AddItem(ItemVm item)
        {
            if (ItemList == null)
                ItemList = new ObservableCollection<ItemVm>();

            ItemList.Add(item);
        }
    }
}
