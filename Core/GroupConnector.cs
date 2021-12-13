using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseModels;

namespace Core
{
    public class GroupConnector : IConnector
    {
        public GroupConnector(DatabaseContext.ApplicationContext d)
        {
            db = d;
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
        public int GetId(string name)
        {
            Group group = db.Groups.SingleOrDefault(x => x.Name == name);
            if (group != null)
            {
                return group.Id;
            }
            else
                throw new ArgumentOutOfRangeException();
        }
        public List<List<string>> DataMatrix()
        {
            List<List<string>> matr = new List<List<string>>();
            foreach (var group in db.Groups)
            {
                List<string> list = new List<string>();
                list.Add(Convert.ToString(group.Id));
                list.Add(Convert.ToString(group.Name));
                list.Add(Convert.ToString(group.CreationDate));
                matr.Add(list);
            }
            return matr;
        }
        public void Change(string name, int id)
        {
            Group group = db.Groups.SingleOrDefault(x => x.Id == id);
            Group grName = db.Groups.SingleOrDefault(x => x.Name == name && x.Id != id);

            if (group != null && grName == null)
            {
                group.Name = name;
                db.SaveChanges();
            }
            else if (grName != null)
            {
                throw new Exception("Uncorrect name");
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void Create(string name, DateTime creationDate)
        {
            Group gr = db.Groups.SingleOrDefault(x => x.Name == name);
            if (gr == null)
            {
                Group group = new Group { Name = name, CreationDate = creationDate };
                db.Groups.Add(group);
                db.SaveChanges();
            }
            else
                throw new Exception("Uncorrect name");

        }

        public void Delete(int id)
        {
            Group group = db.Groups.SingleOrDefault(x => x.Id == id);
            if (group != null)
            {
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
