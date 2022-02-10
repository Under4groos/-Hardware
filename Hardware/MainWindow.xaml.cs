using Hardware.Controls;
using HardwareLib;
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
        MObjSearcher mObjSearcher = new MObjSearcher();
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

                Set(" - ", " - ", " - ");



                foreach (HIKeys item in Enum.GetValues(typeof(HIKeys)))
                {
                    LBorder lBorder = new LBorder()
                    {
                        Content = item.ToString(),

                    };
                    
                    ComboBoxKeys.Items.Add(lBorder);
                }
                //ComboBoxKeys.SelectedValue = 0;
                //ComboBoxKeys_SelectionChanged(object sender, SelectionChangedEventArgs e)

                foreach (LBorder item in list_inf.Children)
                {
                    item.PreviewMouseLeftButtonDown += (eo, ee) =>
                    {
                        Clipboard.SetText(item.Content as string);
                    };
                }
                
            };
        }
        public void Set(string name, string value, string type, string k = "")
        {

            Name.Content = name;
            Value.Content = $"{value}";
            Type.Content = $"{type}";
            Key.Content = k;
        }
        private void ComboBoxKeys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string item_name = (ComboBoxKeys.SelectedValue as LBorder).Content as string;
            //Console.WriteLine(item_name.ToString());

            mObjSearcher.Find(item_name);
            mObjSearcher.GetInformations();

            listboxitems.Items.Clear();

            foreach (DMObject item in mObjSearcher.dMObjects)
            {
                Litem litem = new Litem();
                litem.Set(item.Name, item.Value, item.Type);
                litem.PreviewMouseLeftButtonDown += (oe, ee) =>
                {
                    this.Set(item.Name, item.Value, item.Type , item_name);
                     
                };
                listboxitems.Items.Add(litem);
            }





           


        }
    }
}
