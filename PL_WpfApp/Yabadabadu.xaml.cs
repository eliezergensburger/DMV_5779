using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Yabadabadu.xaml
    /// </summary>
    public partial class Yabadabadu : Window
    {
        BE.Schedule m_schedule;
       
         public Yabadabadu()
        {

            m_schedule = new BE.Schedule();
            m_schedule.Data = new bool[5][]
                     {
                         new bool[]{ false, false, true, false, false, false},
                         new bool[]{ false, false, false, false, false, false},
                         new bool[]{ false, false, false, false, false, false},
                         new bool[]{ false, false, true, false, false, false},
                         new bool[]{ false, false, false, false, false, false}
                     };

            InitializeComponent();
           
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    //  datagrid = m_schedule.Data[i][j];
                }
            }

   
        }

        private void AddSchedule(object sender, RoutedEventArgs e)
        {
           
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                   
                   // m_schedule.Data[i][j] = 
                }
            }

            Console.WriteLine(m_schedule);
        }
    }
}
