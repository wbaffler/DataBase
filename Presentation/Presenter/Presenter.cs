using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Presenter
{
    public class Presenter : IPresenter
    {
        private readonly IView view;
        public Presenter(IView demographicForm)
        {
            view = demographicForm;
        }
    }
}
