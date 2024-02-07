namespace Task3;

public class Lock : IDevice
{
    public void TurnOff()
    {
        System.Console.WriteLine("Lock Close");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("Lock Open");
    }
}
