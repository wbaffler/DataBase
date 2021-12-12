using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IConnector
    {
        List<string> Row(int id);
        List<List<string>> DataMatrix();
        void Delete(int id);
    }
}
