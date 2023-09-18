using System;

public class Order
{
    public int Id { get; set; }
    public User User { get; set; }
    public float Price { get; set; }
    public override string ToString()
    {
        return $"{Id}, {User?.Name}, {Price}";
    }
}
