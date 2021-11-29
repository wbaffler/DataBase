using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Core.Facade facade = new Core.Facade(new Core.Student("1", "Andrew", "19"));
            //facade.createStudent();

            //Core.Facade facade = new Core.Facade(new Core.Student("2"));
            //facade.deleteStudent();

            Core.Facade facade = new Core.Facade(new Core.Student("3"));

            Console.WriteLine("Объекты успешно сохранены");
            foreach (string s in facade.showStudentData())
            {
                Console.WriteLine(s);
            }

            Core.Facade facade1 = new Core.Facade(new Core.Student("2", "Andreyyy", "20", "3"));
            facade1.ChangeStudent();
            foreach (string s in facade1.showStudentData())
            {
                Console.WriteLine(s);
            }
        }
    }
}
