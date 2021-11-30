using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IFacade
    {
        List<string> showObjectData();
        void CreateObject();
        void ChangeObject();
        void DeleteObject();
        public int NumOfStudentsInGroup(Student st);
        public double CalculateAvgAge(Curator curator);
        public string FindCuratorByStudent(Student student);


    }
}
