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
using biblio_BDD_personel;
using BddpersonnelContext;

namespace appliBDDpersonel
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private C_BDD_personnel bddPersonnels = null;


        public MainWindow()
        {
            InitializeComponent();
            bddPersonnels = new C_BDD_personnel();
            List<Service> services = bddPersonnels.getAllServices();
            datagridService.ItemsSource = services;
        }
    }
}
