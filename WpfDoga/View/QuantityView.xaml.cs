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

namespace WpfDoga.View
{
    /// <summary>
    /// Interaction logic for QuantityView.xaml
    /// </summary>
    public partial class QuantityView : UserControl
    {
        public QuantityView()
        {
            InitializeComponent();
        }
        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void OnChecked(object sender, RoutedEventArgs e)
        {
        }
    }
}
