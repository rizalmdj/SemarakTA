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
    /// Interaction logic for GetDataForm.xaml
    /// </summary>
    public partial class GetDataForm : Window
    {
        DesignerItem item;
        public GetDataForm(DesignerItem _item)
        {
            InitializeComponent();
            item = _item;
            Console.WriteLine("Drivernbsadkjhnaskjdfhn");
            if (_item.activity != null && _item.activity.GetType() == typeof(GetData))
            {
                nama.Text = ((GetData)(_item.activity)).nama;
                xpath.Text = ((GetData)(_item.activity)).xpath;
            }
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            Activity a = new GetData(nama.Text,xpath.Text);
            item.activity = a;
            //Ac = haha.Text;
            Close();
        }
    }
}
