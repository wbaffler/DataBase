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
        private bool CheckData(string groupId, string name, string age)
        {
            if (int.TryParse(groupId, out int d1) && int.TryParse(age, out int d2) && name.Length != 0)
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
        public void Change(string groupId, string name, string age, string id)
        {
            try
            {                
                if (CheckData(groupId, name, age) && CheckId(id))
                {
                    facade.ChangeStudent(Convert.ToInt32(groupId), name, Convert.ToInt32(age), Convert.ToInt32(id));
                    
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
            catch (Exception)
            {
                view.DisplayError("Данный номер группы не существует");
            }

        }

        public void Create(string groupId, string name, string age)
        {
            try
            {
                if(CheckData(groupId, name, age))
                {
                    facade.CreateStudent(Convert.ToInt32(groupId), name, Convert.ToInt32(age));                    
                    view.DisplaySuccess();
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
                    GetDataGrid();
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
                        view.CuratorName = "Куратор у заданной группы отсутствует";
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

        public void GetDataGrid()
        {
            view.UpdGrid(facade.showAllObjectsData(new StudentConnector(db)));
        }

    }
}
