// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, Github!");
using Batch1_DET_2022_;




class MyClass
{
    public static void Main()
    {
        //Emp m = new Manager(7777, "Ananya", new DateOnly(2013,08,04), "DET", 10);
        //Console.WriteLine(m.Print());

        //Emp e1 = new Emp(2, "Ananya", new DateOnly(2020, 3, 5));
        //Console.WriteLine(e1.Print());

        /*List<Emp> list = new List<Emp>();
        list.Add(m);
        list.Add(e1);
        foreach (Emp e in list)
            Console.WriteLine(e.Print());

       
        try
        {
            Console.WriteLine("ENTER EMPID B/W 1001 - 25000");
            int id = Convert.ToInt32(Console.ReadLine());
            if (id < 1001 || id > 25000)
                throw new InvalidEmpIdException("Id not in range");


            Console.WriteLine("enter emp name");
            string name = Console.ReadLine();

            Console.WriteLine("enter doj");
            DateTime doj = DateTime.Parse(Console.ReadLine());
            Emp e1 = new(id, name, doj);
        }

        catch (InvalidEmpIdException e)
        {
            Console.WriteLine(e.Message);
        }

        List<Animal> list = new List<Animal>();
        list.Add(new Dog());
        list.Add(new Cat());

        foreach (Animal a in list)
            Console.WriteLine(a.Sound());*/

        Science Student = new Science { regno = 1, Name = "ananya" };
        Science sciencesubject = new Science { physics = 90, chemistry = 89, maths = 74 };
        Commerce Commercessubject = new Commerce { economics = 45, accounts = 66, banking = 88 };

        Console.WriteLine(sciencesubject.GetAvgMarks());
        Console.WriteLine(Commercessubject.GetAvgMarks());

    }
 
}
