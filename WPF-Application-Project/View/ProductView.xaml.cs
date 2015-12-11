using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Application_Project.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class ProductView : UserControl
    {
        public ProductView()
        {
            DataContext = this;
            InitializeComponent();
        }

        public class Product
        {
            public int ProductId { get; set; }

            public string Title { get; set; }

            public string Author { get; set; }

            public string Abstract { get; set; }

            public string Content { get; set; }

            public string Thumbnail { get; set; }

            public DateTime DateAdded { get; set; }
        }

        //public class FileInfo
        //{
        //    public string Name { get; set; }
        //    public DateTime LastModified { get; set; }
        //    public FileInfo(string name)
        //    {
        //        Name = name;
        //        LastModified = DateTime.Now;
        //    }
        //}

        //ObservableCollection<FileInfo> mFileNames = new ObservableCollection<FileInfo>();
        ObservableCollection<Product> mProducts = new ObservableCollection<Product>();

        //public ObservableCollection<FileInfo> FileNames
        //{
        //    get
        //    {
        //        return mFileNames;
        //    }
        //}

        public ObservableCollection<Product> Products
        {
            get
            {
                return mProducts;
            }
        }

        private void UpdateProducts()
        {
            var client = new ProductInventoryService.InventoryServiceClient();
            var products = client.GetAllProducts();

            foreach (var product in products)
            {
                Products.Add(new Product
                {
                    ProductId = product.ProductId,
                    Title = product.Title,
                    Author = product.Author,
                    Abstract = product.Abstract,
                    Content = product.Content,
                    Thumbnail = product.Thumbnail,
                    DateAdded = product.DateAdded
                });
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem((x) =>
            {
                //while (true)
                //{
                //    Dispatcher.BeginInvoke((Action)(() =>
                //    {
                //        mFileNames.Add(new FileInfo("X"));
                //    }));
                //    Thread.Sleep(500);
                //}

                Dispatcher.BeginInvoke((Action) (UpdateProducts));
            });
        }
    }
}
