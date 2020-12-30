using ClassDemoRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class CupcakeUI
    {
        private CupcakeRepo _cupcakeRepo = new CupcakeRepo();
        public void Run()
        {

            while(Menu())
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Cupcake Class Demo. Select an option\n" +
                "1. Add Cupcake\n" +
                "2. Show Cupcakes\n" +
                "3. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    CreateCupcake();
                    break;
                case "2":
                    ShowCupcake();
                    break;
                case "3":
                    return false;
                default:
                    break;
            }
            return true;
        }

        public void CreateCupcake()
        {
            Console.Clear();
            Cupcake newCupcake = new Cupcake();
            Console.WriteLine("What is the Id of your cupcake? ");
            newCupcake.CupcakeID = int.Parse(Console.ReadLine());
            //int cupcakeId = int.Parse(Console.ReadLine());
            //newCupcake.CupcakeID = cupcakeId;
            Console.WriteLine("What is the flavor of your cupcake? ");
            newCupcake.Flavor = Console.ReadLine();
            _cupcakeRepo.AddCupcake(newCupcake);
        }
        public void ShowCupcake()
        {
            Console.Clear();
            List<Cupcake> allCupcakes = _cupcakeRepo.ShowCupcakes();
            foreach(Cupcake cupcake in allCupcakes)
            {
                Console.WriteLine($"{cupcake.CupcakeID}\n {cupcake.Flavor}");
            }
        }
    }
}
