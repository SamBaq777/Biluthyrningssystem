public class Fordon
{
    public string registreringsnummer;
    public string märke;
    protected string typAvFordon;

    public void visaInfo()
    {
        Console.WriteLine("Fordon: " + märke + ", " + registreringsnummer);
    }
}
