using Infragistics.Documents.Excel;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace cover
{
    /// <summary>
    /// Interaction logic for InvoiceView.xaml
    /// </summary>
    public partial class InvoiceView : UserControl
    {
        private string _filePath = System.IO.Path.Combine(@"C:\Users\adria\OneDrive\Pulpit\DanfossProject", "DataExcel.xlsx");
        public List<Model> AssetManager = new List<Model>
        {
           new Model("Gas Boiler", 5.0, 0, 500, 215, 1.1, false),
           new Model("Oil boiler", 4.0, 0, 700, 265, 1.2, false),
           new Model("Gas Motor", 3.6, 2.7, 1100, 640, 1.9, false),
           new Model("Electric Boiler", 8.0, -8.0, 50, 0, 0, false)
        };

    public InvoiceView()
        {

            InitializeComponent();
            // change it to List from asset manager
            ListBoxNames.ItemsSource = AssetManager;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var stream = File.Open(_filePath, FileMode.Open))
            {
                _spreedsheet.Workbook = Workbook.Load(stream);
            }

        }

        private void Button_Click_1()
        {

        }
    }
}
