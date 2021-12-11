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
            Curator curator = new Curator { Name = name, GroupId = groupId, Email = email };
            db.Curators.Add(curator);
            db.SaveChanges();
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
