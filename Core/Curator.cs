using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class Curator : IObject
    {
        private int _id;
        private int _groupId;
        private string _name;
        private string _email;

        public List<string> Row
        {
            get
            {
                DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
                DatabaseModels.Curator curator = db.Curators.SingleOrDefault(x => x.Id == _id);

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
        }
        public int GroupId
        {
            get
            {
                DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
                DatabaseModels.Curator curator = db.Curators.SingleOrDefault(x => x.Id == _id);

                if (curator != null)
                {
                    return curator.GroupId;
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

        private void ConvertInputData(string groupId, string name, string email)
        {
            if (int.TryParse(groupId, out int a))
            {
                _groupId = Convert.ToInt32(groupId);
                _email = email;
                _name = name;
            }
            else
                throw new FormatException();
        }


        public Curator(string id)
        {
            ConvertInputId(id);
        }
        public Curator(string groupId, string name, string email)
        {
            ConvertInputData(groupId, name, email);
        }

        public Curator(string groupId, string name, string email, string id)
        {
            ConvertInputData(groupId, name, email);
            ConvertInputId(id);
        }
        public void Change()
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            DatabaseModels.Curator curator = db.Curators.SingleOrDefault(x => x.Id == _id);

            if (curator != null)
            {
                curator.Name = _name;
                curator.GroupId = _groupId;
                curator.Email = _email;
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
            if ((from c in db.Curators
                 where c.GroupId == _groupId
                 select c).SingleOrDefault() == null)
            {
                DatabaseModels.Curator curator = new DatabaseModels.Curator { Name = _name, GroupId = _groupId, Email = _email };
                db.Curators.Add(curator);
                db.SaveChanges();
            }
            else
                throw new Exception();
        }

        public void Delete()
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            DatabaseModels.Curator curator = db.Curators.SingleOrDefault(x => x.Id == _id);

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
