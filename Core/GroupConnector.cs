using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseModels;

namespace Core
{
    public class GroupConnector : IConnector
    {
        public GroupConnector()
        {
            db = new DatabaseContext.ApplicationContext();
        }
        private DatabaseContext.ApplicationContext db;
        public List<string> Row (int id)
        {          
            Group group = db.Groups.SingleOrDefault(x => x.Id == id);

            if (group != null)
            {
                List<string> temp = new List<string>();
                temp.Add(Convert.ToString(group.Id));
                temp.Add(Convert.ToString(group.Name));
                temp.Add(Convert.ToString(group.CreationDate));
                return temp;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
        public void Change(string name, int id)
        {
            Group group = db.Groups.SingleOrDefault(x => x.Id == id);

            if (group != null)
            {
                group.Name = name;
                db.SaveChanges();
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void Create(string name, DateTime creationDate)
        {
            DatabaseModels.Group group = new DatabaseModels.Group { Name = name, CreationDate = creationDate };
            db.Groups.Add(group);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            Group group = db.Groups.SingleOrDefault(x => x.Id == id);
            Curator curator = db.Curators.SingleOrDefault(x => x.GroupId == id);
            List<Student> students = db.Students.Where(x => x.GroupId == id).ToList();

            if (group != null)
            {
                db.Students.RemoveRange(students);
                if (curator != null)
                    db.Curators.Remove(curator);
                db.Groups.Remove(group);
                db.SaveChanges();
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
