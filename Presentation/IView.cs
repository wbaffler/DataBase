using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation
{
    public interface IView
    {
        void DisplayData(List<string> data);
        void DisplayError(string errorText);
    }
}
