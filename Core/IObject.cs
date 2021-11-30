using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IObject
    {
        List<string> Row { get; }
        void Create();
        void Change();
        void Delete();
    }
}
