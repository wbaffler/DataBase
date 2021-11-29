using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IFacade
    {
        void CreateStudent();
        void ChangeStudent();
        void DeleteStudent();
        List<string> showStudentData();
        /*void createGroup(string Name, DateTime CreationDate);
        void createCurator(string GroupId, string Name, string Email);
        void deleteStudent(string Id);
        void deleteGroup(string Id);
        void deleteCurator(string Id);
        void changeStudent(string Id);
        void changeGroup(string Id);
        void changeCurator(string Id);*/
    }
}
