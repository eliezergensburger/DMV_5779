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

        public static void init()
        {
            TestersList.Add(new Tester
            {
                ID = "1111",
                Name = new Name { FirstName = "jojo", LastName = "chalass" },
                Address = new Address
                {
                    City = "Jerusalem",
                    Number = 21,
                    StreetName = "havvad haleumi",
                    //                  ZipCode = 91160
                },
                DayOfBirth = DateTime.Now.AddYears(-45),
                Gender = Gender.MALE,
                Experience = 10,
                Expertise = CarType.Truck_Heavy,
                MaxDistance = 2,
                MaxTestWeekly = 1,
                Schedule = new bool[5, 6]
                     {
                        { false, false, true, false, false, false},
                        { false, false, false, false, false, false},
                        { false, false, false, false, false, false},
                        { false, false, true, false, false, false},
                        { false, false, false, false, false, false}
                      }

            });

        }
        public static List<DrivingTest> DrivingtestsList
        {
            get { return drivingtestsList; }
  //          set { drivingtestsList = value; }
        }

        public static List<Tester> TestersList
        {
            get { return testersList; }
 //           set { testersList = value; }
        }

        public static List<Trainee> TraineesList
        {
            get { return traineesList; }
//            set { traineesList = value; }
        }
    }
}
