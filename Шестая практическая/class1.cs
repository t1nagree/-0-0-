using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace pw6
{
    public class convert
    { 
        public static List<Class1> class1s = new List<Class1>();

        public static string json;
        public static void InJson()
        {

            json = JsonConvert.SerializeObject(class1s);
            File.WriteAllText("C:\\Users\\user\\Desktop\\Result.json", json);
        }
        public static List<Class1> FromJson()
        {
            var putit = File.ReadAllText(Program.PutdoFile);

            List<Class1> lis = JsonConvert.DeserializeObject<List<Class1>>(putit);
            class1s = lis;
            return lis;
        }

        public static void InXML()
        {
            var x = new XmlSerializer(typeof(List<Class1>));
            using (var fl = new FileStream("C:\\Users\\user\\Desktop\\Result.xml", FileMode.OpenOrCreate))
            {
                x.Serialize(fl, class1s);
            }
        }
        public static List<Class1> FromXML()
        {
            var x = new XmlSerializer(typeof(List<Class1>));
            using (var fl = new FileStream(Program.PutdoFile, FileMode.OpenOrCreate))
            {

                return (List<Class1>)x.Deserialize(fl);
            }
        }
        public static void InTXT(List<Class1> cllist)
        {
            foreach (var item in cllist)
            {
                if (cllist.IndexOf(item) == 0)
                {
                    File.WriteAllText("C:\\Users\\user\\Desktop\\Result.txt",
                        $"{item.Name}\n{item.Age}\n{item.Height}");
                }
                else
                {
                    File.AppendAllText("C:\\Users\\user\\Desktop\\Result.txt",
                   $"\n{item.Name}\n{item.Age}\n{item.Height}");
                }
            }
        }
        public static List<Class1> FromTXT()
        {
            List<Class1> cllist2 = new List<Class1>();
            if (File.Exists(Program.PutdoFile))
            {
                string[] str = File.ReadAllLines(Program.PutdoFile);
                cllist2.Add(new Class1(str[0], int.Parse(str[1]), int.Parse(str[2])));
                cllist2.Add(new Class1(str[3], int.Parse(str[4]), int.Parse(str[5])));
                cllist2.Add(new Class1(str[6], int.Parse(str[7]), int.Parse(str[8])));

            }
            class1s = cllist2;
            return cllist2;
        }

    }
}