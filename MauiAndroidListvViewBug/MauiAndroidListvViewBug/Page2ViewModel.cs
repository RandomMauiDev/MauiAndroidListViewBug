using System.Collections.ObjectModel;

namespace MauiAndroidListvViewBug
{
    public class Page2ViewModel
    {
        public Page2ViewModel()
        {
            Items = new ObservableCollection<dynamic>(Enumerable.Range(0, 50).Select(x => new { Test = "test" }));
        }

        public ObservableCollection<dynamic> Items { get; }
    }
}
