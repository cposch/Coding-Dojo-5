using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace Coding_Dojo_5.ViewModel
{
    public class ItemVm
    {
        public ObservableCollection<ItemVm> Items { get; set; }
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
            if (Items == null)
                Items = new ObservableCollection<ItemVm>();

            Items.Add(item);
        }
    }
}
