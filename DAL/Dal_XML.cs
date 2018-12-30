using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BE;

namespace DAL
{
    internal class Dal_XML : Idal
    {
        XElement traineeRoot;
        XElement testerRoot;
        XElement drivingtestRoot;

        string traineePath = @"TraineeXml.xml";
        string testerPath = @"TesterXml.xml";
        string drivingtestPath = @"DrivingtestXml.xml";

        public Dal_XML()
        {
            if (!File.Exists(traineePath) || !File.Exists(testerPath) || !File.Exists(drivingtestPath))
                CreateFiles();
            else
                LoadData();
        }

        private void CreateFiles()
        {
            traineeRoot = new XElement("trainees");
            testerRoot = new XElement("testers");
            drivingtestRoot = new XElement("drivingtests");

            traineeRoot.Save(traineePath);
            testerRoot.Save(testerPath);
            drivingtestRoot.Save(drivingtestPath);

        }

        private void LoadData()
        {
            try
            {
                traineeRoot = XElement.Load(traineePath);
                testerRoot = XElement.Load(testerPath);
                drivingtestRoot = XElement.Load(drivingtestPath);
            }
            catch
            {
                throw new Exception("File upload problem");
            }
        }

        public bool AddDrivingTest(DrivingTest drivingTest)
        {
            LoadData();
            drivingtestRoot.Add(drivingTest.ToXML());
            return true;
        }

        public bool AddTester(Tester tester)
        {
            throw new NotImplementedException();
        }

        public bool AddTrainee(Trainee trainee)
        {
            throw new NotImplementedException();
        }

        public List<DrivingTest> GetDrivingTests()
        {
            throw new NotImplementedException();
        }

        public List<Tester> GetTesters()
        {
            var result = from t in testerRoot.Elements()
                         select new Tester
                         {
                             ID = t.Element("ID").Value,
                             Name = new Name
                             {
                                 FirstName = t.Element("Name").Element("FirtsName").Value,
                                 LastName = t.Element("Name").Element("LastName").Value
                             }
                             //.....

                         };
            return result.ToList();

        }

        public List<Trainee> GetTrainees(Func<Trainee, bool> p)
        {
            var result = from t in traineeRoot.Elements()
                         select new Trainee
                         {
                             ID = t.Element("ID").Value,
                             Name = new Name
                             {
                                 FirstName = t.Element("Name").Element("FirtsName").Value,
                                 LastName = t.Element("Name").Element("LastName").Value
                             }
                             //.....

                         };
            return (from tr in result
                    where p(tr)
                    select tr).ToList();
        }

        public bool RemoveDrivingTest(DrivingTest drivingTest)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTester(Tester tester)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTrainee(Trainee trainee)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDrivingTest(DrivingTest drivingTest)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTester(Tester tester)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTrainee(Trainee trainee)
        {
            throw new NotImplementedException();
        }
    }
}
