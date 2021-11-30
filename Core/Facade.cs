using System;
using System.Collections.Generic;

namespace Core
{
    public class Facade : IFacade
    {
        private IObject obj;

        public Facade(IObject s)
        {
            obj = s;
        }
        public Facade()
        {
        }

        public double CalculateAvgAge(Curator curator)
        {
            BuisnessLogic logic = new BuisnessLogic();
            logic.FindAvgAge(curator);
            return logic.AvgAge;
        }

        public void ChangeObject()
        {
            obj.Change();
        }
        public void CreateObject()
        {
            obj.Create();
        }
        public void DeleteObject()
        {
            obj.Delete();
        }

        public string FindCuratorByStudent(Student student)
        {
            BuisnessLogic logic = new BuisnessLogic();
            logic.FindCurator(student);
            return logic.CuratorName;
        }

        public int NumOfStudentsInGroup(Student st)
        {
            BuisnessLogic logic = new BuisnessLogic();
            logic.CountStudentsInGroup(st);
            return logic.NumOfStudents;
        }

        public List<string> showObjectData()
        {
            return obj.Row;
        }
    }
}
