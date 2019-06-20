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
    /// Interaction logic for SetDataForm.xaml
    /// </summary>
    public partial class SetDataForm : Window
    {
        DesignerItem item;
        public SetDataForm(DesignerItem _item)
        {
            InitializeComponent();
            item = _item;
            Console.WriteLine("Drivernbsadkjhnaskjdfhn");
            if (_item.activity != null && _item.activity.GetType() == typeof(SetData))
            {
                
                Xpath.Text = ((SetData)(_item.activity)).xpath;
                Content.Text = ((SetData)(_item.activity)).content;
            }
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            Activity a = new SetData(Xpath.Text,Content.Text);
            item.activity = a;
            //Ac = haha.Text;
            Close();
        }
    }
}
