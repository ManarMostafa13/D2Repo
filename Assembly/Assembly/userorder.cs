using System.Reflection;



public class UserOrder
{
    public static void Display()
    {
        System.Console.WriteLine("1");
        UserManager mgr
             = new UserManager();
        System.Console.WriteLine(mgr.Get()[0].ToString());
    }
}