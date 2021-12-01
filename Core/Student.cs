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

        public List<string> Row
        {
            get
            {
                DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
                DatabaseModels.Student student = db.Students.SingleOrDefault(x => x.Id == _id);

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
        }

        public int GroupId
        {
            get
            {
                DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
                DatabaseModels.Student student = db.Students.SingleOrDefault(x => x.Id == _id);

                if (student != null)
                {
                    return student.GroupId;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void ConvertInputId(string id)
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            if (int.TryParse(id, out int a))
            {
                _id = Convert.ToInt32(id);
                DatabaseModels.Student student = db.Students.SingleOrDefault(x => x.Id == _id);
                if (student == null)
                    throw new ArgumentOutOfRangeException();
            }
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
            DatabaseModels.Group group = db.Groups.SingleOrDefault(x => x.Id == _groupId);

            if (group != null)
            {
                student.Age = _age;
                student.GroupId = _groupId;
                student.Name = _name;
                db.SaveChanges();
            }
            else
            {
                throw new Exception("Invalid group");
            }
        }

        public void Create()
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            DatabaseModels.Group group = db.Groups.SingleOrDefault(x => x.Id == _groupId);
            DatabaseModels.Curator curator = db.Curators.SingleOrDefault(x => x.GroupId == _groupId);

            if (group != null && curator != null)
            {
                DatabaseModels.Student student = new DatabaseModels.Student { Name = _name, Age = _age, GroupId = _groupId };
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

        public void Delete()
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();

            DatabaseModels.Student student = db.Students.SingleOrDefault(x => x.Id == _id);

            db.Students.Remove(student);
            db.SaveChanges();

        }
    }
}
