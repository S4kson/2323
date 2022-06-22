namespace Constructor
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student[0] = new Pet { Name = "Бобик" };
            student[1] = new Pet { Name = "Мухтар" };
        }
    }
}