using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IBuisnessLogic
    {
        void CountStudentsInGroup();
        void FindCurator();
        void FindAvgAge();
        int NumOfStudents { get; }
        string CuratorName { get; }
        double AvgAge { get; }

    }
}
