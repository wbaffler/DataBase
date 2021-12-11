using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseModels;

namespace Core
{
    public class StudentConnector : IConnector
    {
        public StudentConnector(DatabaseContext.ApplicationContext d)
        {
            db = d;
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
            if (student != null)
            {
                student.Age = age;
                student.GroupId = groupId;
                student.Name = name;
                db.SaveChanges();
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void Create(int groupId, string name, int age)
        {

            Student student = new Student { Name = name, Age = age, GroupId = groupId };
            db.Students.Add(student);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Student student = db.Students.SingleOrDefault(x => x.Id == id);
            db.Students.Remove(student);
            db.SaveChanges();
        }
 
    }
}
