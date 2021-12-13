using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseModels;

namespace Core
{
    public class CuratorConnector : IConnector
    {
        public CuratorConnector(DatabaseContext.ApplicationContext d)
        {
            db = d;
        }
        private DatabaseContext.ApplicationContext db;
        public List<string> Row (int id)
        {           
            Curator curator = db.Curators.SingleOrDefault(x => x.Id == id);

            if (curator != null)
            {
                List<string> temp = new List<string>();
                temp.Add(Convert.ToString(curator.Id));
                temp.Add(Convert.ToString(curator.GroupId));
                temp.Add(Convert.ToString(curator.Name));
                temp.Add(Convert.ToString(curator.Email));
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
            foreach (var curator in db.Curators)
            {
                List<string> list = new List<string>();
                list.Add(Convert.ToString(curator.Id));
                list.Add(Convert.ToString(curator.GroupId));
                list.Add(Convert.ToString(curator.Name));
                list.Add(Convert.ToString(curator.Email));
                matr.Add(list);
            }
            foreach (var line in matr)
            {
                line.Add(db.Groups.Single(x => x.Id == Convert.ToInt32(line[1])).Name);
            }
            return matr;
        }
        public void Change(int groupId, string name, string email, int id)
        {            
            Curator curator = db.Curators.SingleOrDefault(x => x.Id == id);
            if (curator != null)
            {
                curator.Name = name;
                curator.GroupId = groupId;
                curator.Email = email;
                db.SaveChanges();
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void Create(int groupId, string name, string email)
        {
            Group group = db.Groups.SingleOrDefault(x => x.Id == groupId);
            if (group != null)
            {
                Curator curator = new Curator { Name = name, GroupId = groupId, Email = email };
                db.Curators.Add(curator);
                db.SaveChanges();
            }
            else
                throw new Exception();
        }

        public void Delete(int id)
        {
            Curator curator = db.Curators.SingleOrDefault(x => x.Id == id);

            if (curator != null)
            {
                db.Curators.Remove(curator);
                db.SaveChanges();
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

    }
}
