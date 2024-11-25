namespace c_sharp_event;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product(50);
        product1.Name = "Normal SSD";
        product1.StockControlEvent += NotifyEvent;

        Product product2 = new Product(50);
        product2.Name = "Nvme SSD";


        for (int i = 0; i < 5; i++)
        {
            product1.Sell(10);
            product2.Sell(10);
            Console.ReadLine();
        }
    }

    static void NotifyEvent() {
        Console.WriteLine("Danger Limit");
    }
}
