using CommunityToolkit.Mvvm.ComponentModel;
using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Interactive_cell_generator.ViewModels
{
    partial class ViewerWindowViewModel : ObservableObject
    {
        public ViewerWindowViewModel( string [] fileNames) 
        {
            Random random = new Random();
            Models = new Model3DGroup();
            foreach (var file in fileNames) 
            {               
                if (file != null) 
                {
                    ObjReader reader = new ObjReader();
                    Model3DGroup value = reader.Read(file);
                    value.Transform = new TranslateTransform3D()
                    {
                        OffsetX = random.Next(0, 100),
                        OffsetY = random.Next(0, 100),
                        OffsetZ = random.Next(0, 100)
                    };
                    Models.Children.Add(value);
                }
            }
        }
        [ObservableProperty]
        private Model3DGroup models;
    }
}
