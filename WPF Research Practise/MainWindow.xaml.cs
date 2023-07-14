using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using WPF_Research_Practise.Views;
using WPF_Research_Practise.Commands;

namespace WPF_Research_Practise {
    public partial class MainWindow : Window {
        
        public ICommand? AddImageCommand { get; set; }
        public ICommand? GaleryCommand { get; set; }
        
        public MainWindow() {
            InitializeComponent();
            DataContext = this;
            AddImageCommand = new RelayCommand(AddImage, (o)=>true);
            GaleryCommand = new RelayCommand(Galery);
        }

        private void AddImage(object? param) {
            MessageBox.Show("jjjjjjj");
            MainFrame.Content = new AddImageView();

        }
        private void Galery(object? param) {
            MainFrame.Content = new GaleryPageView();

        }
    }
}
