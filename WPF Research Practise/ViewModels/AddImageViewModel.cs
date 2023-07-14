using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Forms;
using WPF_Research_Practise.Commands;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using static WPF_Research_Practise.Commands.JsonHandling;
using WPF_Research_Practise.Models;

namespace WPF_Research_Practise.ViewModels;


public class AddImageViewModel : INotifyPropertyChanged {

    private string _path;
    public string path { get => _path; set {
            _path = value;
            PrpertyChanged();
        } 
    }
    public ICommand? SelectCommand { get; set; }

    public AddImageViewModel() {
        SelectCommand = new RelayCommand(SelectImage);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void PrpertyChanged([CallerMemberName] string? name = null) {
        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
    }

    private void SelectImage(object? param) {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "*.png|*.jpeg";
        if (openFileDialog.ShowDialog() == DialogResult.OK) {
            path = openFileDialog.FileName;
            Galery galery = new Galery();
            if (JsonHandling.paths == null) JsonHandling.paths = new();
            galery.path = path;
            JsonHandling.paths.Add(galery);
            WriteData<List<Galery>>(paths, "images");
        }

    }

}