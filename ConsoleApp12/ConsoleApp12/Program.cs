using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student[0] = new Pet { Name = "Бобик" };
            student[1] = new Pet { Name = "Мухтар" };
        }
    }

    public class Pet
    {
        public string Name { get; set; }
    }

    public class Student
    {
        private Pet[] pets;

        public Student()
        {
            Console.WriteLine("Я обычный студент");
            pets = new Pet[3];
        }

        public Pet this[int index]
        {
            get { return pets[index]; }
            set { pets[index] = value; }
        }

        ~Student()
        {
            Console.WriteLine("Теперь я солдат");
            foreach (Pet pet in pets)
            {
                if (pet == null)
                    continue;
                Console.WriteLine($"{pet.Name} Остался без хозяина");
            }
        }
    }


}




    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student["name"] = "Николай";
            Console.WriteLine(student["name"]);
        }
    }

    public class Student
    {
        private string name;
        private string surname;
        private string group;

        public string this[string field]
        {
            get
            {
                switch (field)
                {
                    case "name": return name;
                    case "surname": return $"Господин {surname}";
                    case "group": return group;
                    default: return null;
                }
            }
            set
            {
                switch (field)
                {
                    case "name":
                        name = value;
                        break;
                    case "surname":
                        surname = value;
                        break;
                    case "group":
                        group = value;
                        break;
                }
            }
        }
    }
