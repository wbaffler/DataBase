using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Presenter
{
    public class PresenterGroup
    {
        public PresenterGroup(GroupForm Form)
        {
            view = Form;
        }
        private readonly GroupForm view;
        private bool CheckData(string name)
        {
            if (name.Length != 0)
                return true;
            else
                throw new FormatException();
        }
        private bool CheckId(string id)
        {
            if (int.TryParse(id, out int d2))
                return true;
            else
                throw new ArgumentOutOfRangeException();
        }

        public void Change(string name, string id)
        {
            try
            {
                if(CheckData(name) && CheckId(id))
                {
                    Facade facade = new Facade();
                    facade.ChangeGroup(name, Convert.ToInt32(id));
                }
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
            }

        }

        public void Create(string name)
        {
            try
            {
                if(CheckData(name))
                {
                    Facade facade = new Facade();
                    facade.CreateGroup(name, DateTime.Now);
                    view.DisplaySuccess();
                }                
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
                if (CheckId(id))
                {
                    Facade facade = new Facade();
                    facade.DeleteObject(Convert.ToInt32(id), new GroupConnector());
                }
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
                if (CheckId(id))
                {
                    Facade facade = new Facade();
                    view.DisplayData(facade.showObjectData(Convert.ToInt32(id), new GroupConnector())[1]);
                }
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
