using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class Student : IObject
    {
        private int _id;
        private int _groupId;
        private int _age;
        private string _name;

        public List<string> Data
        {
            get
            {
                DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
                DatabaseModels.Student student = db.Students.SingleOrDefault(x => x.Id == _id);

                if (student != null)
                {
                    List<string> temp = new List<string>();
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
        }

        private void ConvertInputId(string id)
        {
            if (int.TryParse(id, out int a))
                _id = Convert.ToInt32(id);
            else
                throw new FormatException();
        }

        private void ConvertInputData(string groupId, string name, string age)
        {
            if (int.TryParse(groupId, out int a) && int.TryParse(age, out int b))
            {
                _groupId = Convert.ToInt32(groupId);
                _age = Convert.ToInt32(age);
                _name = name;
            }                
            else
                throw new FormatException();
        }

        
        public Student(string id)
        {
            ConvertInputId(id);
        }
        public Student(string groupId, string name, string age)
        {
            ConvertInputData(groupId, name, age);
        }

        public Student(string groupId, string name, string age, string id)
        {
            ConvertInputData(groupId, name, age);
            ConvertInputId(id);
        }
        public void Change()
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            DatabaseModels.Student student = db.Students.SingleOrDefault(x => x.Id == _id);

            if (student != null)
            {
                student.Age = _age;
                student.GroupId = _groupId;
                student.Name = _name;
                db.SaveChanges();
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void Create()
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            
            DatabaseModels.Student student = new DatabaseModels.Student { Name = _name, Age = _age, GroupId = _groupId };
            db.Students.Add(student);
            db.SaveChanges();
            
        }

        public void Delete()
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();

            DatabaseModels.Student student = db.Students.SingleOrDefault(x => x.Id == _id);

            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
