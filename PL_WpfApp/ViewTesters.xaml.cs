using System;
using System.Collections.Generic;
using System.Linq;
using BE;
using BL;
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
    /// Interaction logic for ViewTesters.xaml
    /// </summary>
    public partial class ViewTesters : Window
    {
        public ViewTesters()
        {
            InitializeComponent();
           
            IBL instance = FactorySingletonBL.getInstance();
            //List<Tester> res = instance.Get_testers_list_grouping_by_CarType(false).SelectMany(item => item).ToList();
            List<Tester> res = instance.GetTesters();
            lvUsers.ItemsSource = res;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Expertise");
            view.GroupDescriptions.Add(groupDescription);
       }
    }
}
