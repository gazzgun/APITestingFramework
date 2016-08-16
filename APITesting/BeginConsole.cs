using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace APITesting.Common
{
    public class BeginConsole
    {
        static bool result;
        public static void Main(String[] args)
        {
            XmlTextReader reader = new XmlTextReader("http://localhost:8080/A00144521GaryGunning/rest/player/");

            while (reader.Read())
            {

                Thread.Sleep(5);

                Console.WriteLine(reader.Name + " " + reader.Value);

                if (reader.Value.Equals("Richardt Strauss"))
                {
                    result = true;
                }

            }
            Console.Write(result);
            Console.Read();
        }
    }
}

