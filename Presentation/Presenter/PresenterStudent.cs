using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Presenter
{
    public class PresenterStudent 
    {
        private readonly StudentForm view;
        public PresenterStudent(StudentForm Form)
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
                Core.Facade facade = new Core.Facade(new Student(groupId, name, age));
                facade.CreateObject();
                view.DisplaySuccess();
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
                Core.Facade facade = new Core.Facade(new Student(id));
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
                Core.Facade facade = new Core.Facade(new Student(id));
                view.DisplayData(facade.showObjectData()[1], facade.showObjectData()[2], facade.showObjectData()[3]);
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
                Core.Facade facade = new Core.Facade();
                Student student = new Student(id);
                int num = facade.NumOfStudentsInGroup(student);
                view.NumberOfStudents = Convert.ToString(num);
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
                Core.Facade facade = new Core.Facade();
                string curName = facade.FindCuratorByStudent(new Student(id));
                view.CuratorName = curName;
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

        /*public void AverageAge(string id)
        {
            Core.Facade facade = new Core.Facade();
            double avg = facade.CalculateAvgAge(new Curator(id));
        }*/
    }
}
