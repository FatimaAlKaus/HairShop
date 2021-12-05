using BLL.Models;
using BLL.Repository;
using DevExpress.Mvvm;
using DLL.EF;
using HairShop.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;

namespace HairShop.ViewModel
{
    public class MainViewModel : BindableBase
    {
        private readonly IProductRepository _productRepository;
        private readonly HairShopDbContext context;

        public MainViewModel(IProductRepository productRepository, HairShopDbContext context)
        {
            _productRepository = productRepository;
            this.context = context;
        }
        public ObservableCollection<Product> Products => new ObservableCollection<Product>(_productRepository.GetAll());

        public Page Page { get; set; }
        public ICommand ShowProductList => new DelegateCommand(() => Page = Ioc.Resolve<ProductList>());
        public ICommand AddRandomProduct => new DelegateCommand(() =>
        {
            var product = new Product();
            product.Name = $"{new Random().Next(2000)}_Product";
            product.Brand = context.Brands.First();
            product.Price = new Random().Next(100000);
            product.Volume = new Random().Next(500);
            product.Type = context.ProductTypes.First();
            product.HairTypes = new List<HairType>();
            product.HairTypes.Add(context.HairTypes.First());
            context.Products.Add(product);
            context.SaveChanges();
            RaisePropertyChanged("Products");
        });
    }
}
