using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Core
{
    public class BuisnessLogic : IBuisnessLogic
    {
        private int _count = 0;
        private double _avg = 0;
        private string _curatorName;
        public int NumOfStudents => _count;

        public string CuratorName => _curatorName;

        public double AvgAge => _avg;

        public void CountStudentsInGroup(Student student)
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            _count = (from s in db.Students
                      where s.GroupId == student.GroupId
                      select s).Count();
        }

        public void FindAvgAge(Curator curator)
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            _avg = (from s in db.Students
                    where s.GroupId == curator.GroupId
                    select s).Average(st => st.Age);
        }

        public void FindCurator(Student student)
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            DatabaseModels.Curator curator = db.Curators.SingleOrDefault(x => x.GroupId == student.GroupId);
            /*_curatorName = (from c in db.Curators
                            where c.GroupId == student.GroupId
                            select c.Name).ToString();*/
            if (curator != null)
            {
                _curatorName = curator.Name;
            }
        }
    }
}
