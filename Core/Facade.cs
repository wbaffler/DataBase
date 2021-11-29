using System;
using System.Collections.Generic;

namespace Core
{
    public class Facade : IFacade
    {
        private IObject obj;

        public Facade(IObject s)
        {
            obj = s;
        }
        public void ChangeObject()
        {
            obj.Change();
        }
        public void CreateObject()
        {
            obj.Create();
        }
        public void DeleteObject()
        {
            obj.Delete();
        }

        public int NumOfStudentsInGroup()
        {
            throw new NotImplementedException();
        }

        public List<string> showObjectData()
        {
            return obj.Data;
        }
    }
}
