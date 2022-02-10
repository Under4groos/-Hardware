using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
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

namespace Hardware
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += (o, e) =>
            {
                new WinDragMove(this, this);
                new WinResize(this).RightDown(resizeborder);
                new WBControl(this, bclose, ACTIONS.CLOSE);
                new WBControl(this, bmax, ACTIONS.SIZE_max);
                new WBControl(this, bmin, ACTIONS.SIZE_min);
                // new WindowBlureffect(this, WindowBlureffect.AccentState.ACCENT_ENABLE_BLURBEHIND);
            };
        }
    }
}
