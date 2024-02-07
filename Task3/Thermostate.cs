namespace Task3;

public class Thermostate : IDevice
{
    public void TurnOff()
    {
        System.Console.WriteLine("Thermostat is Turn Off");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("ThermoState is Turn On");
    }
}
