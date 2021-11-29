using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IFacade
    {
        List<string> showObjectData();
        void CreateObject();
        void ChangeObject();
        void DeleteObject();
        public int NumOfStudentsInGroup();


    }
}
