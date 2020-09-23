using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace xml
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef c = new Chef();

            System.Console.WriteLine("Hello, you are going to help me create a chef. First write the chefs name.");

            c.name = Console.ReadLine();

            System.Console.WriteLine("Thank you, now write how good the chef is at making soup, please write a number between 1 and 10.");

            string soupSkill = Console.ReadLine();

            int i = int.Parse(soupSkill);

            c.soupSkill = i;

            System.Console.WriteLine("Thank you, now write how good the chef is at cooking meats, please write a number again.");

            string meatSkill = Console.ReadLine();

            int f = int.Parse(meatSkill);

            c.meatSkill = f;

            XmlSerializer chefSerializer = new XmlSerializer(typeof(Chef));

            FileStream file = File.Open(@"chef.xml", FileMode.OpenOrCreate);

            chefSerializer.Serialize(file, c);

            System.Console.WriteLine("Thank you, the chefs name is " + c.name + ", his soup skill is " + c.soupSkill + " and his meat skill is " + c.meatSkill + ".");







            Console.ReadLine();
        }
    }
}
