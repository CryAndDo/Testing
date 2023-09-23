Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите c: ");
int c = int.Parse(Console.ReadLine());
MyClass myClass = new MyClass();
Console.WriteLine();
Console.WriteLine(myClass.Equation(a,b,c));
public class MyClass {

    public bool Equation(int a, int b, int c)
    {
        int d = b * b - 4 * a * c;
        if (d >= 0) return true;
        return false;
    }

}
