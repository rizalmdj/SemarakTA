using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DiagramDesigner
{
    /// <summary>
    /// Interaction logic for ButtonForm.xaml
    /// </summary>
    public partial class ButtonForm : Window
    {
        DesignerItem item;
        public ButtonForm(DesignerItem _item)
        {
            InitializeComponent();
            item = _item;
            Console.WriteLine("Drivernbsadkjhnaskjdfhn");
            if (_item.activity != null && _item.activity.GetType() == typeof(Button))
            {

                XpathButton.Text = ((Button)(_item.activity)).xpathButton;
            }
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            Activity a = new Button(XpathButton.Text);
            item.activity = a;
            //Ac = haha.Text;
            Close();
        }
    }
}
