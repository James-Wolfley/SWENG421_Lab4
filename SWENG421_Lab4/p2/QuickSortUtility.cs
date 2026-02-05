using SWENG421_Lab4.p1;

namespace SWENG421_Lab4.p2;

public class QuickSortUtility<T> : SortUtility<T> where T : ProductIF
{
    public QuickSortUtility() : base("quicksort") { }

    public override List<T> sort(List<T> data)
    {
        data.Sort((a, b) => a.Price.CompareTo(b.Price));
        return data;
    }

    public override void print(List<T> data)
    {
        foreach (T item in data)
        {
            Console.WriteLine($"{item.Price}, {item.Name}, {item.ID}");
        }
    }
}
