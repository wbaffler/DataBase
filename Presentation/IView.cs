using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation
{
    public interface IView
    {
        void DisplayData(string groupId, string name, string age);
        void DisplayError(string errorText);
        //public void FillGrid(List<List<string>> matrix);
    }
}
