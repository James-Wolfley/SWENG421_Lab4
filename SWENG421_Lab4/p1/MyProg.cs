using SWENG421_Lab4.p2;

namespace SWENG421_Lab4.p1;

public class MyProg {
    public static void Main(string[] args)
    {
        Company xyz = new Company();

        xyz.sortUtility = new BubbleSortUtility<ProductIF>();
        xyz.sortUtility.print(
            xyz.sortUtility.sort(
                [
                    new Desk(1, "Writing Desk",  20.30),
                    new Desk(2, "Corner Desk",   15.25),
                    new Desk(3, "Lap Desk",      25.13),
                    new Desk(4, "Standing Desk", 15.85),
                    new Desk(5, "Floating Desk", 22.56)
                ]
            )
        );

        xyz.sortUtility = new QuickSortUtility<ProductIF>();
        xyz.sortUtility.print(
            xyz.sortUtility.sort(
                [
                    new Desk(1, "Writing Desk",  20.30),
                    new Desk(2, "Corner Desk",   15.25),
                    new Desk(3, "Lap Desk",      25.13),
                    new Desk(4, "Standing Desk", 15.85),
                    new Desk(5, "Floating Desk", 22.56)
                ]
            )
        );
    }
}