using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Presenter
{
    public interface IPresenter
    {
        void Create(Core.IConnector obj);
        void Change(Core.IConnector obj);
        void Delete(Core.IConnector obj);
        void Show(Core.IConnector obj);
    }
}
