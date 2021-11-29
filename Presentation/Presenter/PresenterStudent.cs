using Core;
using System;
using System.Collections.Generic;
using System.Text;
using Core;

namespace Presentation.Presenter
{
    public class PresenterStudent 
    {
        private readonly IView view;
        public PresenterStudent(IView Form)
        {
            view = Form;
        }

        public void Change(string groupId, string name, string age, string id)
        {
            try
            {
                Core.Facade facade = new Core.Facade(new Student(groupId, name, age, id));
                facade.ChangeObject();
            }
            catch
            {
                view.DisplayError("");
            }
            
        }

        public void Create(string groupId, string name, string age)
        {
            try
            {
                Core.Facade facade = new Core.Facade(new Student(groupId, name, age));
                facade.CreateObject();
            }
            catch
            {
                view.DisplayError("");
            }
        }

        public void Delete(string id)
        {
            try
            {
                Core.Facade facade = new Core.Facade(new Student(id));
                facade.DeleteObject();
            }
            catch
            {
                view.DisplayError("");
            }
        }

        public void Show(string id)
        {           
            try
            {
                Core.Facade facade = new Core.Facade(new Student(id));
                view.DisplayData(facade.showObjectData());
            }
            catch
            {
                view.DisplayError("");
            }
        }
    }
}
