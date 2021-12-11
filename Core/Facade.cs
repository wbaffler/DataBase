using System;
using System.Collections.Generic;

namespace Core
{
    public class Facade
    {
        public Facade(DatabaseContext.ApplicationContext d)
        {
            db = d;
        }
        private DatabaseContext.ApplicationContext db;

        public void ChangeStudent(int groupId, string name, int age, int id)
        {
            StudentConnector studentConnector = new StudentConnector(db);
            studentConnector.Change(groupId, name, age, id);
        }
        public void ChangeGroup(string name, int id)
        {
            GroupConnector groupConnector = new GroupConnector(db);
            groupConnector.Change(name, id);
        }
        public void ChangeCurator(int groupId, string name, string email, int id)
        {
            CuratorConnector curatorConnector = new CuratorConnector(db);
            curatorConnector.Change(groupId, name, email, id);
        }
        public void CreateStudent(int groupId, string name, int age)
        {
            StudentConnector studentConnector = new StudentConnector(db);
            studentConnector.Create(groupId, name, age);
        }
        public void CreateGroup(string name, DateTime creationDate)
        {
            GroupConnector groupConnector = new GroupConnector(db);
            groupConnector.Create(name, creationDate);
        }
        public void CreateCurator(int groupId, string name, string email)
        {
            CuratorConnector curatorConnector = new CuratorConnector(db);
            curatorConnector.Create(groupId, name, email);
        }
        public void DeleteObject(int id, IConnector connector)
        {
            connector.Delete(id);
        }

        public string FindCuratorByStudent(int id)
        {
            BuisnessLogic logic = new BuisnessLogic(db);
            logic.FindCurator(id);
            return logic.CuratorName;
        }

        public int NumOfStudentsInGroup(int id)
        {
            BuisnessLogic logic = new BuisnessLogic(db);
            logic.CountStudentsInGroup(id);
            return logic.NumOfStudents;
        }
        public double CalculateAvgAge(int id)
        {
            BuisnessLogic logic = new BuisnessLogic(db);
            logic.FindAvgAge(id);
            return logic.AvgAge;
        }

        public List<string> showObjectData(int id, IConnector connector)
        {
            return connector.Row(id);
        }
    }
}
