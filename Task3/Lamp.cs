namespace Task3;

public class Lamp : IDevice
{
    public void TurnOff()
    {
        System.Console.WriteLine("Lamp turn off");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("Lamp turn on ");
    }
}
