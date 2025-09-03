using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Interactive_cell_generator.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Interactive_cell_generator.ViewModels
{
    partial class MainWindowViewModel : ObservableObject
    {
        [RelayCommand]
        private void OpenFile() 
        {
            string[] files = new string[10];
            files[0] = Path.Combine(AppContext.BaseDirectory, "Content", "Мітохондрія.obj");
            files[1] = Path.Combine(AppContext.BaseDirectory, "Content", "Сітка і рибосоми.obj");
            ViewerWindowViewModel viewModel = new ViewerWindowViewModel(files);
            ViewerWindow viewerWindow = new ViewerWindow();
            viewerWindow.DataContext = viewModel;
            viewerWindow.ShowDialog();
        }

    }
}
