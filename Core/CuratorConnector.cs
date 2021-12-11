using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseModels;

namespace Core
{
    public class CuratorConnector : IConnector
    {
        public CuratorConnector()
        {
            db = new DatabaseContext.ApplicationContext();
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
        public int GroupId(int id)
        {
            Curator curator = db.Curators.SingleOrDefault(x => x.Id == id);

            if (curator != null)
            {
                return curator.GroupId;
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
            Group group = db.Groups.SingleOrDefault(x => x.Id == groupId);
            Curator findCurator = db.Curators.FirstOrDefault(x => x.GroupId == groupId);

            if (group != null && findCurator == null)
            {
                Curator curator = new Curator { Name = name, GroupId = groupId, Email = email };
                db.Curators.Add(curator);
                db.SaveChanges();
            }
            else if (findCurator != null && group != null)
                throw new ArgumentException();
            else
                throw new Exception();
        }

        public void Delete(int id)
        {
            Curator curator = db.Curators.SingleOrDefault(x => x.Id == id);
            Group group = db.Groups.SingleOrDefault(x => x.Id == curator.Id);

            if (curator != null)
            {
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
