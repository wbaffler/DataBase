using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class Group : IObject
    {
        private int _id;
        private DateTime _creationDate;
        private string _name;

        public List<string> Row
        {
            get
            {
                DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
                DatabaseModels.Group group = db.Groups.SingleOrDefault(x => x.Id == _id);

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
        }

        private void ConvertInputId(string id)
        {
            if (int.TryParse(id, out int a))
                _id = Convert.ToInt32(id);
            else
                throw new FormatException();
        }


        public Group(string id)
        {
            ConvertInputId(id);
        }
        public Group(string name, DateTime creationDate)
        {
            _name = name;
            _creationDate = creationDate;
        }

        public Group(string name, DateTime creationDate, string id)
        {
            ConvertInputId(id);
            _name = name;
            _creationDate = creationDate;
        }
        public void Change()
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            DatabaseModels.Group group = db.Groups.SingleOrDefault(x => x.Id == _id);

            if (group != null)
            {
                group.Name = _name;
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

            DatabaseModels.Group group = new DatabaseModels.Group { Name = _name, CreationDate = DateTime.Now };
            db.Groups.Add(group);
            db.SaveChanges();

        }

        public void Delete()
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            DatabaseModels.Group group = db.Groups.SingleOrDefault(x => x.Id == _id);

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
