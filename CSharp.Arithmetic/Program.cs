namespace CSharp.Arithmetic;

class Order
{
internal int total;
    internal Order(int total) {
        this.total = total;
    }
    public void AddAmount(int amount) {
        this.total += amount;
    }

    public void ApplyDiscount(int discount) {
        this.total -= discount;
    }

    public int GetTotal() {
        return this.total;
    }
    static void Main(string[] args)
    {
        Order food = new Order(10);
        food.AddAmount(5);
        food.ApplyDiscount(1);
        Console.WriteLine(food.GetTotal());
    }

}
