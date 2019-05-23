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

using OpenQA.Selenium.Chrome;

namespace DiagramDesigner
{
    /// <summary>
    /// Interaction logic for OpenUrlForm.xaml
    /// </summary>
    public partial class OpenUrlForm : Window
    {
        DesignerItem item;
        public OpenUrlForm(DesignerItem _item)
        {
            InitializeComponent();
            item = _item;
            Console.WriteLine("Drivernbsadkjhnaskjdfhn");
            if (_item.activity != null && _item.activity.GetType()==typeof(OpenUrl))
            {
                url.Text = ((OpenUrl)(_item.activity)).url;
            }
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            Activity a = new OpenUrl(url.Text);
            item.activity = a;
            //Ac = haha.Text;
            Close();
        }
    }
}
