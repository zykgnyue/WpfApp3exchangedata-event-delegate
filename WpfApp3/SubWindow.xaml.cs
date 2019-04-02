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
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// SubWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SubWindow : Window
    {
        public SubWindow()
        {
            InitializeComponent();
        }
        public SubWindow(object obj)
        {
            InitializeComponent();
            var btn=  obj as Button;
            if(btn!=null)
            {
                TxtBlkHello.Text = btn.Name.ToString()+"== "+btn.Content.ToString();
            }
            else
            {
                //not a button
                var mwin = obj as MainWindow;
                if(mwin!=null)
                {
                    mwin.Title = $"SetBy:{this.Title.ToString()+" =="+this.GetType().ToString()}: I am a MainWindow!";
                    this.Title = "SubWindow is a Modal window, you can not switch to MainWindow when I am aliving";
                }

            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
