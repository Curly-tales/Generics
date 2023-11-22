using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Genericsss
{
   class PracticeList
    {
        static void Main(string[] args)
        {
            GBasics<object> gBasics = new GBasics<object>(1, "Namrata", "Mint", "Yolo@gmail.com");
            GBasics<object> gint = new GBasics<object>(01, 02, 03, 04);
            ListPractice listPractice = new ListPractice();
            listPractice.ListEmployee();
            gint.Student();
            gint.Student_Display();
        }
    }
}
