using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Presenter
{
    public class PresenterGroup
    {
        private readonly GroupForm view;
        public PresenterGroup(GroupForm Form)
        {
            view = Form;
        }

        public void Change(string name, string id)
        {
            try
            {
                Core.Facade facade = new Core.Facade(new Group(name, DateTime.Now, id));
                facade.ChangeObject();
            }
            catch (ArgumentOutOfRangeException)
            {
                view.DisplayError("Неверный ID");
            }
            catch (FormatException)
            {
                view.DisplayError("Введенные данные не корректны");
            }
            catch (Exception e)
            {
                view.DisplayError("Данного номера группы не существует");
                
                //Console.WriteLine(e.Message);
            }

        }

        public void Create(string name)
        {
            try
            {
                Core.Facade facade = new Core.Facade(new Group(name, DateTime.Now));
                facade.CreateObject();
                view.DisplaySuccess();
            }
            catch (FormatException)
            {
                view.DisplayError("Введенные данные не корректны");
            }
            catch (Exception e)
            {
                view.DisplayError("Данного номера группы не существует");
                //view.DisplayError(e.Message);
            }
        }

        public void Delete(string id)
        {
            try
            {
                Core.Facade facade = new Core.Facade(new Group(id));
                facade.DeleteObject();
            }
            catch (ArgumentOutOfRangeException)
            {
                view.DisplayError("Неверный ID");
            }
            catch (FormatException)
            {
                view.DisplayError("Введенные данные не корректны");
            }
        }

        public void Show(string id)
        {
            try
            {
                Core.Facade facade = new Core.Facade(new Group(id));
                view.DisplayData(facade.showObjectData()[1]);
            }
            catch (ArgumentOutOfRangeException)
            {
                view.DisplayError("Неверный ID");
            }
            catch (FormatException)
            {
                view.DisplayError("Введенные данные не корректны");
            }
        }


    }
}
