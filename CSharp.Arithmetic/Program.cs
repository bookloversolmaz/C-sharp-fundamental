namespace CSharp.Arithmetic;

// class Order
// {
// internal int total;
//     internal Order(int total) {
//         this.total = total;
//     }
//     public void AddAmount(int amount) {
//         this.total += amount;
//     }

//     public void ApplyDiscount(int discount) {
//         this.total -= discount;
//     }

//     public int GetTotal() {
//         return this.total;
//     }
//     static void Main(string[] args)
//     {
//         Order food = new Order(10);
//         food.AddAmount(5);
//         food.ApplyDiscount(1);
//         Console.WriteLine(food.GetTotal());
//     }
// }
class Discounter {
    internal int discount;

    internal Discounter(int discount){ // The discount
        this.discount = discount;
    }
    public int ApplyTo(int originalPrice) { // The new price after subtractinng the discount from the original price
        int newPrice = originalPrice - this.discount;
        return newPrice;
    }
    static void Main(string[] args) {
        Discounter clothes = new Discounter(20);
        // clothes.ApplyTo(10);
        Console.WriteLine(clothes.ApplyTo(100));
    }
}