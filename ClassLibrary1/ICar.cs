namespace ClassLibrary1
{
    public interface ICar
    {
        int GetPrice(string name);
    }

    class BMW : ICar
    {
        public string Name { get; set; }
        public int GetPrice(string name)
        {
            if (name == "M3")
                return 13000000;
            else if (name == "X7")
                return 1000000;
            else
                return 9000000;
        }

    }

    class Hundai : ICar
    {
        public string Name { get; set; }
        public int GetPrice(string name)
        {
            if (name == "Creta")
                return 1000000;
            else if (name == "tucson")
                return 2500000;
            else
                return 1000000;
        }
    }

    //class TestICar
    //{
    //    public static void Main()
    //    {
    //        BMW a = new BMW { Name = "bmw" };
    //        Hundai sa = new Hundai { Name = "hundai" };

    //        Console.WriteLine(a.GetPrice("M3"));

    //        Console.WriteLine(sa.GetPrice("santro"));
    //    }
    //}
}