using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; //Izveidojot telefona parametrus;
            
            //Izveidot Object no Class Phone
            Phone phone = new Phone();

            
            string Brand;
            Console.WriteLine("Phone Brand name: ");
            Brand = Console.ReadLine();
            string Model;
            Console.WriteLine("Phone Model name: ");
            Model = Console.ReadLine();

            Console.WriteLine("Enter Length: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height: ");
            int n3 = int.Parse(Console.ReadLine());

            //Ielikt derīgus objekta izmērus
            phone.Length = n1;
            phone.Breadth = n2;
            phone.Height = n3;

            //Saņemt derīgus parametrus no objekta Phone
            Console.WriteLine($"Phone Dimensions Are: {phone.Length},{phone.Breadth},{phone.Height}");
            //--------------------------------------------------------------------------------------;
            

        }
    }
    //-------------------------------------------------------;
    public class Person
    {
        string FirstName = Console.WriteLine("Whats Your name?");
        Firstname = Console.ReadLine();
        string LastName = Console.WriteLine("Whats Your Last name?");
        
        string NamesTogether = FirstName + " " + Lastname;

        public int Age;
        public bool IsMale;

        public void Greeting()
        {
            Console.WriteLine("Hi! My name is " + FirstName);
        }
    }
    class 






}
