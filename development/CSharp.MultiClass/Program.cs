namespace CSharp.MultiClass;
using System;
class Bagel
{
internal string seeds;
internal string filling;
internal int price;
    internal Bagel(string seeds, string filling, int price) {
        this.seeds = seeds;
        this.filling = filling;
        this.price = price;
    }
    static void Main(string[] args)
    {
        Bagel cheesy = new Bagel("Multi seed", "cheese", 5);
        Console.WriteLine(cheesy.seeds);
        Console.WriteLine(cheesy.filling);
        Console.WriteLine(cheesy.price);

    }
}
