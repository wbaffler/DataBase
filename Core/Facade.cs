using System;
using System.Collections.Generic;

namespace Core
{
    public class Facade : IFacade
    {
        Student student;
        public Facade(Student s)
        {
            student = s;
        }

        public void ChangeStudent()
        {
            student.Change();
        }

        public void CreateStudent()
        {
            student.Create();
        }

        public void DeleteStudent()
        {
            student.Delete();
        }

        public List<string> showStudentData()
        {
            return student.Data;
        }
    }
}
