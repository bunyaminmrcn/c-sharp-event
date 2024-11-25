namespace c_sharp_event;

public  delegate void StockControl();
class Product
{
    private int _stock;
    public Product(int stock)
    {
        _stock = stock;
    }
    public event StockControl StockControlEvent;
    

    public string Name { get; set; }
    public int Stock {
        get {
            return _stock;
        }
        set {
            _stock = value;
            if(value <= 15 && StockControlEvent != null) {
                StockControlEvent();
            }
        }
     }

    public void Sell(int amount) {
        Stock -= amount;
        Console.WriteLine("{1} - Remain :{0}, ", Stock, Name);
    }
}
