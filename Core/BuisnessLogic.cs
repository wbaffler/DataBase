using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Core
{
    public class BuisnessLogic : IBuisnessLogic
    {
        private Student _student;
        private Curator _curator;
        private int _count = 0;
        private double _avg = 0;
        private string _curatorName;
        public BuisnessLogic(Student student)
        {
            _student = student;
        }
        public BuisnessLogic(Curator curator)
        {
            _curator = curator;
        }
        public int NumOfStudents => _count;

        public string CuratorName => throw new NotImplementedException();

        public double AvgAge => _avg;

        public void CountStudentsInGroup()
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            _count = (from s in db.Students
                      where s.GroupId == _student.GroupId
                      select s).Count();
        }

        public void FindAvgAge()
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            _avg = (from s in db.Students
                    where s.GroupId == _curator.GroupId
                    select s).Average(st => st.Age);
        }

        public void FindCurator()
        {
            DatabaseContext.ApplicationContext db = new DatabaseContext.ApplicationContext();
            _curatorName = (from c in db.Curators
                            where c.GroupId == _student.GroupId
                            select c.Name).ToString();
        }
    }
}
