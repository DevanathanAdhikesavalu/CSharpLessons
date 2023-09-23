public delegate void MethodHandlerA();
public delegate int  MethodHandlerB(int x,int y);

public class MathCalculator
{
    public void DoTask()
    {
        Console.WriteLine("Calculator DoTask");
    }
    public int  Add(int x, int y)
    {
        Console.WriteLine(x + " " + y);
        return x + y;

    }
    public double Multiply(double x, double y)
    {
        Console.WriteLine(x + " " + y);
        return x * y;
    }
    public double Divide(double x, double y)
    {
        Console.WriteLine(x + " " + y);
        return x / y;
    }
    public int Subtract(int x, int y)
    {
        Console.WriteLine(x + " " + y);
        return x - y;

    }
    public String GetModel()
    {
        return "x5000";
    }
}
public class DelegateDemo
{
    public static void TestOne()
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerA methodHandlerA = mc.DoTask; //similar to below method aka shortcut(don't need to create instance like new MethodHandlerB)
        MethodHandlerB methodHandlerB = new MethodHandlerB(mc.Add);
        MethodHandlerB methodHandlerTwo = new MethodHandlerB(mc.Subtract);
        methodHandlerA();
       // int addResult = methodHandlerB(100, 50);
       // Console.WriteLine(addResult);   
        //int multiplyResult = methodHandlerTwo(500,200);
        //Console.WriteLine(multiplyResult);
    }
    public static void TestTwo()
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerB methodHandlerB = mc.Add;
        methodHandlerB += mc.Subtract;
        int result = methodHandlerB(100, 50);
        Console.WriteLine(result);
    }
}