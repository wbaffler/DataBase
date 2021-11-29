using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Presenter
{
    public interface IPresenter
    {
        void Create(Core.IObject obj);
        void Change(Core.IObject obj);
        void Delete(Core.IObject obj);
        void Show(Core.IObject obj);
    }
}
