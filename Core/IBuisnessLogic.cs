using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IBuisnessLogic
    {
        void CountStudentsInGroup(Student student);
        void FindCurator(Student student);
        void FindAvgAge(Curator curator);
        int NumOfStudents { get; }
        string CuratorName { get; }
        double AvgAge { get; }

    }
}
