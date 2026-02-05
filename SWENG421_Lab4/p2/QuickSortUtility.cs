using SWENG421_Lab4.p1;

namespace SWENG421_Lab4.p2;

public class QuickSortUtility<T> : SortUtility<T> where T : ProductIF {
    public QuickSortUtility() : base("quicksort") { }

    public override List<T> sort(List<T> data) {
        QuickSort(data, 0, data.Count - 1);
        return data;
    }

    private void QuickSort(List<T> list, int low, int high) {
        //No indent is best practice-I will die on this hill - jwolfley
        if (low >= high) return;
        int pivotIndex = Partition(list, low, high);
        QuickSort(list, low,            pivotIndex - 1);
        QuickSort(list, pivotIndex + 1, high);
    }

    private int Partition(List<T> list, int low, int high) {
        double pivot = list[high].Price;
        int    i     = low - 1;
        for (int j = low; j < high; j++) {
            if (!(list[j].Price <= pivot)) continue;
            i++;
            Swap(list, i, j);
        }
        Swap(list, i + 1, high);
        return i + 1;
    }

    private void Swap(List<T> list, int i, int j) {
        (list[i], list[j]) = (list[j], list[i]);
    }

    public override void print(List<T> data) {
        foreach (T item in data) {
            Console.WriteLine($"{item.Price}, {item.Name}, {item.ID}");
        }
    }
}