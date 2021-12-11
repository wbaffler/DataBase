using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseModels;

namespace Core
{
    public class StudentConnector : IConnector
    {
        public StudentConnector()
        {
            db = new DatabaseContext.ApplicationContext();
        }
        private DatabaseContext.ApplicationContext db;
        public List<string> Row(int id)
        {
            Student student = db.Students.SingleOrDefault(x => x.Id == id);
            if (student != null)
            {
                List<string> temp = new List<string>();
                temp.Add(Convert.ToString(student.Id));
                temp.Add(Convert.ToString(student.GroupId));
                temp.Add(Convert.ToString(student.Age));
                temp.Add(Convert.ToString(student.Name));
                return temp;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
        public void Change(int groupId, string name, int age, int id)
        {
            Student student = db.Students.SingleOrDefault(x => x.Id == id);
            Group group = db.Groups.SingleOrDefault(x => x.Id == groupId);
            if (group != null)
            {
                student.Age = age;
                student.GroupId = groupId;
                student.Name = name;
                db.SaveChanges();
            }
            else
            {
                throw new Exception("Invalid group");
            }
        }

        public void Create(int groupId, string name, int age)
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            Group group = db.Groups.SingleOrDefault(x => x.Id == groupId);
            Curator curator = db.Curators.SingleOrDefault(x => x.GroupId == groupId);

            if (group != null && curator != null)
            {
                Student student = new DatabaseModels.Student { Name = name, Age = age, GroupId = groupId };
                db.Students.Add(student);
                db.SaveChanges();
            }
            else if (curator == null && group != null)
            {
                throw new Exception("Invalid Curator");
            }
            else
            {
                throw new Exception("Invalid group");
            }

        }

        public void Delete(int id)
        {
            Student student = db.Students.SingleOrDefault(x => x.Id == id);

            db.Students.Remove(student);
            db.SaveChanges();
        }
    }
}
