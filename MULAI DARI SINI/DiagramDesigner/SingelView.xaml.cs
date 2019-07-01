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
using DiagramDesigner.Model;

namespace DiagramDesigner
{
    /// <summary>
    /// Interaction logic for SingelView.xaml
    /// </summary>
    public partial class SingelView : Window
    {
        public SingelView()
        {
            InitializeComponent();
        }
        List<Activity> Activities = new List<Activity>();

       

        private void Button_SingelView(object sender, RoutedEventArgs e)
        {

           
            //foreach (Activity a in Activities)
            //{
            //    a.run();
            //}
            //foreach (KeyValuePair<String, String> p in DataSingleton.Instance.data)
            //{
            //    Console.WriteLine(p.Key + " = " + p.Value);
            //    //hasil.ItemsSource = null;

            //}
            //hasil.ItemsSource = DataSingleton.Instance.data.Values.ToList();

        }

       public void lihat()
        {
            hasil.ItemsSource = DataSingleton.Instance.data.Values.ToList();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    hasil.ItemsSource = DataSingleton.Instance.data.Values.ToList();
        //}
    }
}
