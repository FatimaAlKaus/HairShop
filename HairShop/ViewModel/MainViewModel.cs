using BLL.Repository;
using DevExpress.Mvvm;
using System.Windows.Input;

namespace HairShop.ViewModel
{
    public class MainViewModel : BindableBase
    {
        private readonly IProductRepository _productRepository;

        public MainViewModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public string Prop { get; set; } = "sadsad";

        public ICommand AddProduct => new DelegateCommand(()=> { }); 
    }
}
