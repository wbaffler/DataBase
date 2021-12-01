using System;
using System.Collections.Generic;
using System.Text;
using Core;

namespace Presentation.Presenter
{

    public class PresenterCurator 
    {
        private readonly CuratorForm view;
        public PresenterCurator(CuratorForm Form)
        {
            view = Form;
        }

        public void Change(string groupId, string name, string email, string id)
        {
            try
            {
                Core.Facade facade = new Core.Facade(new Curator(groupId, name, email, id));
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

        public void Create(string groupId, string name, string email)
        {
            try
            {
                Core.Facade facade = new Core.Facade(new Curator(groupId, name, email));
                facade.CreateObject();
                view.DisplaySuccess();
            }
            catch (FormatException)
            {
                view.DisplayError("Введенные данные не корректны");
            }
            catch (ArgumentException)
            {
                view.DisplayError("у группы может быть лишь один куратор");
            }
            catch (Exception)
            {
                view.DisplayError("Данный номер группы не существует");
            }
        }

        public void Delete(string id)
        {
            try
            {
                Core.Facade facade = new Core.Facade(new Curator(id));
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
                Core.Facade facade = new Core.Facade(new Curator(id));
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

        public void CalculateAverageAge(string id)
        {
            try
            {
                Core.Facade facade = new Core.Facade();
                Curator curator = new Curator(id);
                double avg = facade.CalculateAvgAge(curator);
                view.AverageAge = Convert.ToString(avg);
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
        
    }
    
}
