using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class DataSource
    {
        private static List<Tester> testersList = new List<Tester>();
        private static List<Trainee> traineesList = new List<Trainee>();
        private static List<DrivingTest> drivingtestsList = new List<DrivingTest>();

        public static List<DrivingTest> DrivingtestsList
        {
            get { return drivingtestsList; }
            set { drivingtestsList = value; }
        }

        public static List<Tester> TestersList
        {
            get { return testersList; }
            set { testersList = value; }
        }

        public static List<Trainee> TraineesList
        {
            get { return traineesList; }
            set { traineesList = value; }
        }
    }
}
