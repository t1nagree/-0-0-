using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pw6
    {
        public class Class1
        {
            public string Name;
            public int Age;
            public int Height;

            public static Class1 Raul = new Class1();
            public static Class1 Yusif = new Class1();
            public static Class1 Mansum = new Class1();
            public static void Init()
            {

                Raul.Name = "Raul";
                Raul.Age = 16;
                Raul.Height = 170;
                Yusif.Name = "Yusif";
                Yusif.Age = 17;
                Yusif.Height = 182;
                Mansum.Name = "Mansum";
                Mansum.Age = 16;
                Mansum.Height = 180;
                convert.class1s.Add(Raul);
                convert.class1s.Add(Yusif);
                convert.class1s.Add(Mansum);
            }
            public Class1()
            {

            }
            public Class1(string option, dynamic dlina, dynamic dlina2)
            {
                this.Name = option;
                this.Age = dlina;
                this.Height = dlina2;
            }
        }
    }
