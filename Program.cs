namespace DATASTRUCTPR1;
using System.Data.SqlClient;
using Amazon.Runtime;
using cmd;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {

        Data data = new Data();

       List <info> infos = data.GetInfo();

        //foreach (info info in infos) 
        //{

        //    Console.WriteLine($"\nCUSTOMER NAME: \t{info.CustomerName}");
        //    Console.WriteLine($"Customer Number: {info.CusNum}");
        //    Console.WriteLine($"Dine-in or Takeout: {info.DineorTake}");


        //List<info> dinein = infos.Where(x => x.DineorTake == "Dine-in").ToList();
        //Console.WriteLine($"The number of dine in customers are: {infos.Count()}");

        //foreach (info info in infos) 
        //{
        //    Console.WriteLine($"Name: {info.CustomerName} - Customer Number: {info.CusNum}");


        //ORDER BY
        List<info> orderedCustomers = infos.OrderBy(x => x.CustomerName).OrderBy(x => x.CusNum).ToList();
        List<info> dineincustomers = infos.Where(x => x.DineorTake == "Dine-In").ToList();
        Console.WriteLine($"The number of dine in customers is {dineincustomers.Count}");
        foreach (info info in orderedCustomers)
        {
            Console.WriteLine($"Name: {info.CustomerName} {info.CusNum} - {info.DineorTake}");
        }

        //FILTER
        List<info> dineincustomerss = infos.Where(x => x.DineorTake == "Take-out").ToList() ;   
        Console.WriteLine($"The number of take-out customers is {infos.Count}");      
        foreach(info info in dineincustomers)
        {
            Console.WriteLine($"Name: {info.CustomerName} {info.DineorTake}-{info.CusNum}");
        }
        
        //GROUP
        var grouped = infos.GroupBy(x => x.DineorTake);
        foreach (var item in grouped)
        {
            Console.WriteLine ($"DINEIN: {item.Key}");  
        }
                   




            //LinQ - capability to manipulate 


            //  //instantiate

            // // menu espressobased = new menu(); //instantiation
            ////  espressobased.ProdName = "Mocha Breve"; //dot or period access operator
            //  espressobased.Price = 139;
            //  espressobased.IsBestSeller = true;

            //  menu noncoffee = new menu(); //instantiation
            //  noncoffee.ProdName = "Matcha Latte";
            //  noncoffee.Price = 149;
            //  noncoffee.IsBestSeller = true;


            //  menu frappuccino = new menu(); //instantiation
            //  frappuccino.ProdName = "Oreo Cheesecake";
            //  frappuccino.Price = 149;
            //  frappuccino.IsBestSeller = true;


            //  menu croffles = new menu(); //instantiation
            //  croffles.ProdName = "Biscoff Croffles";
            //  croffles.Price = 119;
            //  croffles.IsBestSeller = false;


            //  List<menu> menu = new List<menu>();
            //  menu.Add(espressobased);
            //  menu.Add(noncoffee);
            //  menu.Add(frappuccino);
            //  menu.Add(croffles);

            //  menu meow = new menu()
            //  {
            //      ProdName = "Carbonara",
            //      Price = 145,
            //      IsBestSeller = false,
            //  };

            //  menu.Add(meow);

            //  //instantation while adding in a list
            //  menu.Add(new menu { ProdName = "Strawberry Oreo", Price = 145, IsBestSeller = true });

            //  //foreach (var subjectGrade in subjectGrades)
            //  //{
            //  //    Console.WriteLine($"Subject: {subjectGrade.SubjectCode}\tGrade: {subjectGrade.Grade}\tMajor:{subjectGrade.IsSubjectMajor}");
            //  //}

            //  info customer = new info()
            //  {
            //      CustomerName = "John Marc Gabuyo",
            //      CusNum = "00012345",
            //      DineorTake = "Dine-In",
            //      ror = menu
            //  };

            //  List<info> SatiyaCust = new List<info>();
            //  SatiyaCust.Add(customer);

            //  List<menu> menudo = new List<menu>()
            //  {
            //      new menu {ProdName = "Mocha Breve", Price = 139, IsBestSeller = true},
            //      new menu {ProdName = "Matcha Latte", Price = 149, IsBestSeller = true},
            //      new menu {ProdName = "Oreo Cheesecake", Price = 149, IsBestSeller = true},
            //      new menu {ProdName = "Biscoff Croffles", Price = 119, IsBestSeller = false},
            //  };

            //  SatiyaCust.Add(new info
            //  {
            //      CustomerName = "Keiann Kelly Gonzales",
            //      CusNum = "00012346",
            //      DineorTake = "Take out",
            //      ror = menudo
            //  });

            //  Console.WriteLine("<< SATIYA CAFE >>\n");

            //  foreach (var customers in SatiyaCust)
            //  {
            //      Console.WriteLine($"\nCUSTOMER NAME: \t{customers.CustomerName}");
            //      Console.WriteLine($"Customer Number: \t{customers.CusNum} ");
            //      Console.WriteLine($"DINE-IN OR TAKEOUT: \t{customers.DineorTake} ");
            //      Console.WriteLine("\n....MENU....");

            //      foreach (var menuu in customers.ror)
            //      {
            //          Console.WriteLine($"Product Name: {menuu.ProdName}\tPrice: {menuu.Price}\tisBestSeller?:{menuu.IsBestSeller}");
            //      }
    }
}
