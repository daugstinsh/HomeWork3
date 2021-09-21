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
        
        }
    }

    class Phone
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Height { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool Call { get; set; }
        public bool SMS { get; set; }

    }
}
