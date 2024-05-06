namespace DiamondKata;

public static class Program
{
    static void Main(string[] args)
    {
        var diamondMaker = new DiamondMaker();
        var createdDiamond = diamondMaker.CreateDiamond(args);
        diamondMaker.PrintDiamond(createdDiamond);
    }
}