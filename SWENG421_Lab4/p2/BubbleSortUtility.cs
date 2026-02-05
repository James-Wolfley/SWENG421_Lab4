using SWENG421_Lab4.p1;

namespace SWENG421_Lab4.p2;

public class BubbleSortUtility<T> : SortUtility<T> where T : ProductIF
{
    public BubbleSortUtility() : base("bubblesort") { }

    public override void print(List<T> data) {
        foreach (var item in data) {
            Console.WriteLine($"{item.ID}, {item.Name}, {item.Price}");
        }
    }
}