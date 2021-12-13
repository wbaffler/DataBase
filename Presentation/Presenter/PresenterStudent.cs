using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Presenter
{
    public class PresenterStudent 
    {        
        public PresenterStudent(StudentForm Form, DatabaseContext.ApplicationContext d)
        {
            view = Form;
            db = d;
            facade = new Facade(d);
        }
        private DatabaseContext.ApplicationContext db;
        private Facade facade;
        private readonly StudentForm view;
        private bool CheckData(string group, string name, string age)
        {
            if (int.TryParse(age, out int d2) && group.Length != 0 && name.Length != 0)
                return true;
            else
                throw new FormatException();
        }
        private bool CheckId(string id)
        {
            if (int.TryParse(id, out int d2))
                return true;
            else
                throw new FormatException();
        }
        public void Change(string groupName, string name, string age, string id)
        {
            try
            {                
                if (CheckData(groupName, name, age) && CheckId(id))
                {
                    int idGroup = facade.GroupId(groupName);
                    facade.ChangeStudent(idGroup, name, Convert.ToInt32(age), Convert.ToInt32(id));
                    
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

        public void Create(string groupName, string name, string age)
        {
            try
            {
                if(CheckData(groupName, name, age))
                {
                    int idGroup = facade.GroupId(groupName);
                    facade.CreateStudent(idGroup, name, Convert.ToInt32(age));
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
                    facade.DeleteObject(Convert.ToInt32(id), new StudentConnector(db));
                    UpdateDataGrid();
                }
                
            }
            catch (ArgumentOutOfRangeException)
            {
                view.DisplayError("Неверный ID");
                UpdateDataGrid();
            }
        }

        public void Show(string id)
        {           
            try
            {
                if(CheckId(id))
                {
                    view.DisplayData(facade.showObjectData(Convert.ToInt32(id), new StudentConnector(db))[1],
                        facade.showObjectData(Convert.ToInt32(id), new StudentConnector(db))[2], 
                        facade.showObjectData(Convert.ToInt32(id), new StudentConnector(db))[3]);
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

        public void CalculateNumberOfStudents(string id)
        {
            try
            {
                if(CheckId(id))
                {
                    int num = facade.NumOfStudentsInGroup(Convert.ToInt32(id));
                    view.NumberOfStudents = Convert.ToString(num);
                }
                
            }
            catch (ArgumentNullException)
            {
                view.DisplayError("Неверный ID");
            }
            catch (FormatException)
            {
                view.DisplayError("Введенные данные не корректны");
            }
        }
        public void NameOfCurator(string id)
        {
            try
            {
                if (CheckId(id))
                {
                    string curName = facade.FindCuratorByStudent(Convert.ToInt32(id));
                    if (curName != null)
                        view.CuratorName = curName;
                    else
                        view.CuratorName = "Куратор отсутствует";
                }               
            }           
            catch (ArgumentNullException)
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
            view.UpdGrid(facade.showAllObjectsData(new StudentConnector(db)));
        }

        public void FindAllGroups()
        {
            view.SetComboBox(facade.GroupNames());
        }

    }
}
