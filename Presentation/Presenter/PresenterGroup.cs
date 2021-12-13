using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Presenter
{
    public class PresenterGroup
    {
        public PresenterGroup(GroupForm Form, DatabaseContext.ApplicationContext d)
        {
            view = Form;
            db = d;
            facade = new Facade(db);
        }
        private Facade facade;
        private DatabaseContext.ApplicationContext db;
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
                    facade.ChangeGroup(name, Convert.ToInt32(id));
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                view.DisplayError("Неверный ID");
                UpdateDataGrid();
            }
            catch (FormatException)
            {
                view.DisplayError("Введенные данные не корректны");
                UpdateDataGrid();
            }
            catch (Exception e)
            {
                view.DisplayError("Введенная группа уже существует");
                UpdateDataGrid();
                //view.DisplayError(e.Message);
            }

        }

        public void Create(string name)
        {
            try
            {
                if(CheckData(name))
                {
                    facade.CreateGroup(name, DateTime.Now);
                    view.DisplaySuccess();
                    UpdateDataGrid();
                    view.ClearFields();
                }                
            }
            catch (FormatException)
            {
                view.DisplayError("Введенные данные не корректны");
            }
            catch (Exception e)
            {
                view.DisplayError("Введенная группа уже существует");
                //view.DisplayError(e.Message);
            }
        }

        public void Delete(string id)
        {
            try
            {
                if (CheckId(id))
                {
                    facade.DeleteObject(Convert.ToInt32(id), new GroupConnector(db));
                    UpdateDataGrid();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                view.DisplayError("Неверный ID");
                UpdateDataGrid();
            }
            catch (FormatException)
            {
                view.DisplayError("Введенные данные не корректны");
                UpdateDataGrid();
            }
        }

        public void Show(string id)
        {
            try
            {
                if (CheckId(id))
                {                    
                    view.DisplayData(facade.showObjectData(Convert.ToInt32(id), new GroupConnector(db))[1]);
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

        public void UpdateDataGrid()
        {
            view.UpdGrid(facade.showAllObjectsData(new GroupConnector(db)));
        }

    }
}
