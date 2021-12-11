using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Presenter
{
    public class PresenterStudent 
    {        
        public PresenterStudent(StudentForm Form)
        {
            view = Form;
        }
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
                throw new ArgumentOutOfRangeException();
        }
        public void Change(string groupId, string name, string age, string id)
        {
            try
            {                
                if (CheckData(groupId, name, age) && CheckId(id))
                {
                    Facade facade = new Facade();
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
                    Facade facade = new Facade();
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
                if (e.Message == "Invalid group")
                    view.DisplayError("Данный номер группы не существует");
                if (e.Message == "Invalid Curator")
                    view.DisplayError("Сперва добавьте куратора");
                Console.WriteLine(e.Message);
            }
        }

        public void Delete(string id)
        {
            try
            {
                if(CheckId(id))
                {
                    Facade facade = new Facade();
                    facade.DeleteObject(Convert.ToInt32(id), new StudentConnector());
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
                    Facade facade = new Facade();
                    view.DisplayData(facade.showObjectData(Convert.ToInt32(id), new StudentConnector())[1],
                        facade.showObjectData(Convert.ToInt32(id), new StudentConnector())[2], 
                        facade.showObjectData(Convert.ToInt32(id), new StudentConnector())[3]);
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
                    Facade facade = new Facade();
                    int num = facade.NumOfStudentsInGroup(Convert.ToInt32(id));
                    view.NumberOfStudents = Convert.ToString(num);
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
        public void NameOfCurator(string id)
        {
            try
            {
                if (CheckId(id))
                {
                    Facade facade = new Facade();
                    string curName = facade.FindCuratorByStudent(Convert.ToInt32(id));
                    view.CuratorName = curName;
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
