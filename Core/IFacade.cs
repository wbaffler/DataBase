using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IFacade
    {
        List<string> showObjectData();
        void CreateObject();
        void ChangeStudent();
        void DeleteObject();
        public int NumOfStudentsInGroup(StudentConnector st);
        public double CalculateAvgAge(CuratorConnector curator);
        public string FindCuratorByStudent(StudentConnector student);


    }
}
