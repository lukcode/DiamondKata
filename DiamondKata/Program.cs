namespace DiamondKata;

public static class Program
{
    static void Main(string[] args)
    {
        try
        {
            var diamondMaker = new DiamondMaker();
            var createdDiamond = diamondMaker.CreateDiamond(args);
            diamondMaker.PrintDiamond(createdDiamond);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}