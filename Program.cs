namespace Structure
{
internal class Program
{
    private static void Main(string[] args)
    {
        Cage cage = new Cage(1,"lion");

        Cage cage2 = new Cage();
        cage2.NameOfAnimal = "Goat";
        cage2.CageNumber = 3;

        Cage cage3 = new Cage()
        {
            NameOfAnimal = "Mice",
            CageNumber = 2,
        };
       cage.PrintCage();
       cage2.PrintCage();
       cage3.PrintCage();

    }

        
    }
}
