using System;
using System.Collections.Generic;
using System.Text;
using Core;

namespace Presentation.Presenter
{

    public class PresenterCurator 
    {
        public PresenterCurator(CuratorForm Form)
        {
            view = Form;
        }
        private readonly CuratorForm view;
        private bool CheckData(string groupId, string name, string email)
        {
            if (int.TryParse(groupId, out int d1) && name.Length != 0)
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

        public void Change(string groupId, string name, string email, string id)
        {
            try
            {
                if (CheckData(groupId, name, email) && CheckId(id))
                {
                    Facade facade = new Facade();
                    facade.ChangeCurator(Convert.ToInt32(groupId), name, email, Convert.ToInt32(id));
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

        public void Create(string groupId, string name, string email)
        {
            try
            {
                if(CheckData(groupId, name, email))
                {
                    Facade facade = new Facade();
                    facade.CreateCurator(Convert.ToInt32(groupId), name, email);
                    view.DisplaySuccess();
                }      
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
                if(CheckId(id))
                {
                    Facade facade = new Facade();
                    facade.DeleteObject(Convert.ToInt32(id), new CuratorConnector());
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
                    view.DisplayData(facade.showObjectData(Convert.ToInt32(id), new CuratorConnector())[1],
                        facade.showObjectData(Convert.ToInt32(id), new CuratorConnector())[2],
                        facade.showObjectData(Convert.ToInt32(id), new CuratorConnector())[3]);
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
                    Facade facade = new Facade();
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
        
    }
    
}
