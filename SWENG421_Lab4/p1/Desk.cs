namespace SWENG421_Lab4.p1;

public class Desk : ProductIF {
    public int ID { get; private set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Desk(int id, string name, double price) {
        ID = id;
        Name = name;
        Price = price;
    }
}