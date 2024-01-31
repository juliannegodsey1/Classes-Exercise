namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2013;


            Car mazda = new Car()
            {
                Make = "Mazda",
                Model = "CS-15",
                Year = 2015
            };

            Car chevy = new Car("Chevy", "Impala", 2001);

        }
    }
}
