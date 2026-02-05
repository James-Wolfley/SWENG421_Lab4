using SWENG421_Lab4.p1;

namespace SWENG421_Lab4.p2;

public class SortUtility<T> where T : ProductIF {
    private string sortName = "bubblesort";

    public SortUtility(string sortName) {
        this.sortName = sortName;
    }
    
    public string getName() => sortName;
    
    public void setName(string newName) {
        sortName = newName;
    }

    public virtual List<T> sort(List<T> data) {
        for (int i = 0; i < data.Count - 1; i++) {
            for (int j = 0; j < data.Count - i - 1; j++) {
                if (data[j].Price > data[j + 1].Price) {
                    (data[j], data[j + 1]) = (data[j + 1], data[j]);
                }
            }
        }
        return data;
    }
    
    public virtual void print(List<T> data) { }
}