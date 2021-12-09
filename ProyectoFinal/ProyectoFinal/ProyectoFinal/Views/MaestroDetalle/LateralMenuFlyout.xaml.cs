using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal.Views.MaestroDetalle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LateralMenuFlyout : ContentPage
    {
        public ListView ListView;

        public LateralMenuFlyout()
        {
            InitializeComponent();

            BindingContext = new LateralMenuFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        //class LateralMenuFlyoutViewModel : INotifyPropertyChanged
        //{
        //    public ObservableCollection<LateralMenuFlyoutMenuItem> MenuItems { get; set; }

        //    public LateralMenuFlyoutViewModel()
        //    {
        //        MenuItems = new ObservableCollection<LateralMenuFlyoutMenuItem>(new[]
        //        {
        //            new LateralMenuFlyoutMenuItem { Id = 0, Title = "Page 1" },
        //            new LateralMenuFlyoutMenuItem { Id = 1, Title = "Page 2" },
        //            new LateralMenuFlyoutMenuItem { Id = 2, Title = "Page 3" },
        //            new LateralMenuFlyoutMenuItem { Id = 3, Title = "Page 4" },
        //            new LateralMenuFlyoutMenuItem { Id = 4, Title = "Page 5" },
        //        });
        //    }

        //    #region INotifyPropertyChanged Implementation
        //    public event PropertyChangedEventHandler PropertyChanged;
        //    void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //    {
        //        if (PropertyChanged == null)
        //            return;

        //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //    #endregion
        //}
    }
}