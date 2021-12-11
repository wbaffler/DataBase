using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DatabaseModels;

namespace Core
{
    public class BuisnessLogic : IBuisnessLogic
    {
        DatabaseContext.ApplicationContext db;
        public BuisnessLogic()
        {
            db = new DatabaseContext.ApplicationContext();
        }
        private int _count = 0;
        private double _avg = 0;
        private string _curatorName;
        public int NumOfStudents => _count;

        public string CuratorName => _curatorName;

        public double AvgAge => _avg;

        public void CountStudentsInGroup(int id)
        {
            Student student = db.Students.FirstOrDefault(x => x.Id == id);
            _count = (from s in db.Students
                      where s.GroupId == student.GroupId
                      select s).Count();
        }

        public void FindAvgAge(int id)
        {
            Curator curator = db.Curators.FirstOrDefault(x => x.Id == id);
            Student student = db.Students.FirstOrDefault(x => x.GroupId == curator.GroupId);
            if (student != null)
                _avg = (from s in db.Students
                        where s.GroupId == curator.GroupId
                        select s).Average(st => st.Age);
            else
                throw new ArgumentNullException();
        }

        public void FindCurator(int id)
        {
            Student student = db.Students.FirstOrDefault(x => x.Id == id);
            Curator curator = db.Curators.SingleOrDefault(x => x.GroupId == student.GroupId);
            if (curator != null)
            {
                _curatorName = curator.Name;
            }
        }
    }
}
