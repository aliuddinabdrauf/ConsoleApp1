using ConsoleApp2;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how much:");
            int loop = Convert.ToInt32(Console.ReadLine());
            Person[] persons = new Person[loop]; 

            int y = 0;
            while (y < loop)
            {
                Person person = new Person();

                 Console.WriteLine("Please insert your first name:");
                person.FirstName = Console.ReadLine();
                Console.WriteLine("Please insert your last name:");
                person.LastName = Console.ReadLine();
                Console.WriteLine("Please insert your age:");
                person.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please insert your height in meter:");
                person.Height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please insert your weight in kg:");
                person.Weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Are you smooking or not?");
                person.IsSmoking = Convert.ToBoolean(Console.ReadLine());
                persons[y] = person;
                y++;
            }

            for (int i=0; i< loop; i++)
            {
                Person person = persons[i];
                Console.WriteLine($"Full name: {person.FirstName} {person.LastName}");
                int yearOfBith = DateTime.Now.Year - person.Age;

                Console.WriteLine($"DOB: {yearOfBith}");
                Console.WriteLine($"Height: {person.Height}");
                Console.WriteLine($"Weight: {person.Weight}");

                double bmi = person.Weight / (person.Height * person.Height);
                Console.WriteLine($"bmi: {bmi}");

                Console.WriteLine($"smooking: {person.IsSmoking}");

                if (yearOfBith < 1980)
                {
                    Console.WriteLine($"boomer");
                }
                else if (yearOfBith < 1990)
                {
                    Console.WriteLine($"gen y");
                }
                else if (yearOfBith < 2000)
                {
                    Console.WriteLine($"gen z");
                }
                else
                {
                    Console.WriteLine($"millenials");
                }

                switch (bmi)
                {
                    case < 16:
                        Console.WriteLine($"underweight");
                        break;
                    case < 20:
                        Console.WriteLine($"normal");
                        break;
                    case < 22:
                        Console.WriteLine($"overweight");
                        break;
                    case > 22:
                        Console.WriteLine($"obese");
                        break;

                }
            }

            

        }
        void Mainq2()
        {
            Person[] persons = new Person[2];

        }

    }
}