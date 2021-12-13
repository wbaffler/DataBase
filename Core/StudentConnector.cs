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
                temp.Add(Convert.ToString(student.Name));
                temp.Add(Convert.ToString(student.Age));
                return temp;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }

        public List<List<string>> DataMatrix()
        {
            List<List<string>> matr = new List<List<string>>();
            foreach (var student in db.Students)
            {
                List<string> list = new List<string>();
                list.Add(Convert.ToString(student.Id));
                list.Add(Convert.ToString(student.GroupId));
                list.Add(Convert.ToString(student.Name));
                list.Add(Convert.ToString(student.Age));
                matr.Add(list);
            }
            foreach (var line in matr)
            {
                line.Add(db.Groups.Single(x => x.Id == Convert.ToInt32(line[1])).Name);
            }
            return matr;  
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
            //db = new DatabaseContext.ApplicationContext();
            Group group = db.Groups.SingleOrDefault(x => x.Id == groupId);
            if (group != null)
            {
                Student student = new Student 
                { Name = name, Age = age, GroupId = groupId };
                db.Students.Add(student);
                db.SaveChanges();
            }
            else
                throw new Exception();
            
            
        }

        public void Delete(int id)
        {
            Student student = db.Students.SingleOrDefault(x => x.Id == id);
            db.Students.Remove(student);
            db.SaveChanges();
        }

        
    }
}
