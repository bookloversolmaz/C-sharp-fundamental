namespace CSharp.Strings;

class Order {
internal string total;
    
    internal Order(string total) {
        this.total = total;
    }

    public string FriendlyTotal() {
        return $"Hello there! The total is {total}";
    }
    static void Main(string[] args)
    {
        Order message = new Order("£50");
        Console.WriteLine(message.FriendlyTotal());
    }
}