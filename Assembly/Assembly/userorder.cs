using System.Reflection;
[assembly: AssemblyVersion("2.0.0.0")]


public class UserOrder
{
    public static void Display()
    {
        System.Console.WriteLine("V 2");
        UserManager mgr
             = new UserManager();
        System.Console.WriteLine(mgr.Get()[0].ToString());
    }
}