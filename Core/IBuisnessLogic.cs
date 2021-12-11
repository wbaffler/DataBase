using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IBuisnessLogic
    {
        void CountStudentsInGroup(int id);
        void FindCurator(int id);
        void FindAvgAge(int id);
        int NumOfStudents { get; }
        string CuratorName { get; }
        double AvgAge { get; }

    }
}
