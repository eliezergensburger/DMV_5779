using BE;
using BL;
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

namespace PL_WpfApp
{
    /// <summary>
    /// Interaction logic for AddTrainee.xaml
    /// </summary>
    public partial class AddTrainee : Window
    {
        private Trainee mytrainee;
        public AddTrainee()
        {
            InitializeComponent();
            mytrainee = new Trainee { Address = new Address(), Name = new BE.Name(), Instructor = new BE.Name() };
            this.DataContext = mytrainee;
            gearTypeTextBox.ItemsSource = Enum.GetValues(typeof(GearType));
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IBL mybl = BL.FactorySingletonBL.getInstance();
                mybl.AddTrainee(mytrainee);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
