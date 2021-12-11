using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class BuisnessLogic : IBuisnessLogic
    {
        
        public BuisnessLogic(DatabaseContext.ApplicationContext d)
        {
            db = d;
        }
        private DatabaseContext.ApplicationContext db;
        private int _count = 0;
        private double _avg = 0;
        private string _curatorName;
        public int NumOfStudents => _count;

        public string CuratorName => _curatorName;

        public double AvgAge => _avg;

        public void CountStudentsInGroup(int studentId)
        {
            Student student = db.Students.FirstOrDefault(x => x.Id == studentId);
            
            if (student != null)
                _count = (from s in db.Students
                          where s.GroupId == student.GroupId
                          select s).Count();               
            else
                throw new ArgumentNullException();
        }

        public void FindAvgAge(int curatorId)
        {
            Curator curator = db.Curators.FirstOrDefault(x => x.Id == curatorId);
            if (curator != null)
            {
                Student student = db.Students.FirstOrDefault(x => x.GroupId == curator.GroupId);
                if (student != null)
                    _avg = (from s in db.Students
                            where s.GroupId == curator.GroupId
                            select s).Average(st => st.Age);
                else
                    throw new ArgumentNullException();
            }
            else
                throw new ArgumentOutOfRangeException();


        }

        public void FindCurator(int studentId)
        {
            Student student = db.Students.FirstOrDefault(x => x.Id == studentId);            
            if (student != null)
            {
                Curator curator = db.Curators.SingleOrDefault(x => x.GroupId == student.GroupId);
                if (curator != null)
                    _curatorName = curator.Name;
            }                           
            else
                throw new ArgumentNullException();
        }
    }
}
