namespace CSharp.Strings;
// class Order {
// internal string total;
    
//     internal Order(string total) {
//         this.total = total;
//     }

//     public string FriendlyTotal() {
//         return $"Hello there! The total is {total}";
//     }
//     static void Main(string[] args)
//     {
//         Order message = new Order("£50");
//         Console.WriteLine(message.FriendlyTotal());
//     }
// }

class StoryBuilder {
    internal string plot;
    internal StoryBuilder(string plot) {
        this.plot = plot;
    }

    public string AddPlotline(string idea) {
        return plot + idea;
    }
    public string GetPlot() {
        return plot;
    }
    static void Main(string[] args) {
        StoryBuilder fairytale = new StoryBuilder("Once upon a time, ");
        string snowWhite = fairytale.AddPlotline("there was a girl called Snow White");
        Console.WriteLine(snowWhite);
    }
}