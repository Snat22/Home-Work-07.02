using Task3;

var lamp = new Lamp();
System.Console.WriteLine("Write <<On>> baroi lamp giroyn shava \n \n Write <<off>> baroi lamp murdan");
var clik = System.Console.ReadLine();
clik.ToUpper();
if(clik == "On")
{
    lamp.TurnOn();
}else if(clik== "off")
{
    lamp.TurnOff();
}else
{
    System.Console.WriteLine("Error");
}

var termos = new Thermostate();
System.Console.WriteLine("Write <<On>> baroi Thermostate giroyn shava \n \n Write <<off>> baroi Thermostater murdan");
var clikT = System.Console.ReadLine();
clikT.ToUpper();
if(clikT == "On")
{
    termos.TurnOn();
}else if(clik== "off")
{
    termos.TurnOff();
}else
{
    System.Console.WriteLine("Error");
}
