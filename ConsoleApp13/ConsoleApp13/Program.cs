namespace BasicsOfProgramming
{
    public class Student
    {
        public string Name;
        public string Surname;
        public DateTime Birthday;

        public void SayHello()
        {
            Console.WriteLine($"Меня зовут {Name} {Surname}");
        }

        public Student()
        {
            var rand = new Random();
            var nameGenerator = new NameGenerator();
            this.Name = nameGenerator.GenerateName();
            this.Surname = nameGenerator.GenerateSurname();
            this.Birthday = new DateTime(rand.Next(1999, 2005), rand.Next(1, 13), rand.Next(1, 28));
        }
    }
}