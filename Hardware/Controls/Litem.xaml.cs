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

namespace Hardware.Controls
{
    /// <summary>
    /// Логика взаимодействия для Litem.xaml
    /// </summary>
    public partial class Litem : UserControl
    {
        public Litem()
        {
            InitializeComponent();
        }
        public void Set(string name , string value , string type )
        {
            Name.Content = name;
            Value.Content = $"Value: {value}";
            Type.Content = $"Type: {type}";
        }

    }
}
