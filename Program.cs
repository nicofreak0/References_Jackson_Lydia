namespace References_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creates myFirstSedan with an initial speed of 0
            Sedan myFirstSedan = new Sedan(0);
            IAutomobile myAutomobile = myFirstSedan;

            // creates another instance of sedan with an initial speed of 0
            Sedan myOtherSedan = new Sedan(0);

            //writes to console the automobiles and their speeds
            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            myOtherSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myOtherSedan.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            // creates an instance of the truck with speed 50, weight 500 and license plate MyTruck
            Truck myTruck = new Truck(50, 500, "MyTruck");

            // calls stringify method and describes automobiles.
            myFirstSedan.Stringify();
            myAutomobile.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();

        }
    }
}