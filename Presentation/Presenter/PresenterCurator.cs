using System;
using System.Collections.Generic;
using System.Text;
using Core;

namespace Presentation.Presenter
{

    public class PresenterCurator 
    {
        public PresenterCurator(CuratorForm Form, DatabaseContext.ApplicationContext d)
        {
            view = Form;
            db = d;
            facade = new Facade(db);
        }
        private Facade facade;
        private DatabaseContext.ApplicationContext db;
        private readonly CuratorForm view;
        private bool CheckData(string group, string name, string email)
        {
            if (group.Length != 0 && name.Length != 0)
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

        public void Change(string groupName, string name, string email, string id)
        {
            try
            {
                if (CheckData(groupName, name, email) && CheckId(id))
                {
                    int idGroup = facade.GroupId(groupName);
                    facade.ChangeCurator(idGroup, name, email, Convert.ToInt32(id));
                }     
            }
            catch (ArgumentOutOfRangeException)
            {
                view.DisplayError("Неверное назввание группы");
                UpdateDataGrid();
            }
            catch (FormatException)
            {
                view.DisplayError("Введенные данные не корректны");
                UpdateDataGrid();
            }
            catch (Exception)
            {
                view.DisplayError("Данный номер группы не существует");
                UpdateDataGrid();
            }

        }

        public void Create(string groupName, string name, string email)
        {
            try
            {
                if(CheckData(groupName, name, email))
                {
                    int idGroup = facade.GroupId(groupName);
                    facade.CreateCurator(idGroup, name, email);
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
                view.DisplayError("Данный номер группы не существует");
                Console.WriteLine(e.Message);
            }
        }

        public void Delete(string id)
        {
            try
            {
                if(CheckId(id))
                {
                    facade.DeleteObject(Convert.ToInt32(id), new CuratorConnector(db));
                    UpdateDataGrid();
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
                    
                    view.DisplayData(facade.showObjectData(Convert.ToInt32(id), new CuratorConnector(db))[1],
                        facade.showObjectData(Convert.ToInt32(id), new CuratorConnector(db))[2],
                        facade.showObjectData(Convert.ToInt32(id), new CuratorConnector(db))[3]);
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

        public void CalculateAverageAge(string id)
        {
            try
            {
                if(CheckId(id))
                {
                    double avg = facade.CalculateAvgAge(Convert.ToInt32(id));
                    view.AverageAge = Convert.ToString(avg);
                }
                
            }
            catch (ArgumentNullException)
            {
                view.DisplayError("В группе отсутствуют студенты");
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
            view.UpdGrid(facade.showAllObjectsData(new CuratorConnector(db)));
        }

        public void FindAllGroups()
        {
            view.SetComboBox(facade.GroupNames());
        }
    }
    
}
