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
using System.Windows.Shapes;
using WPF_Research_Practise.ViewModels;

namespace WPF_Research_Practise.Views {
    public partial class AddImageView : Page {
        public AddImageView() {
            InitializeComponent();
            DataContext = new AddImageViewModel();
        }
    }
}
