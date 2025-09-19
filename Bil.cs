public class Bil : Fordon
{
    public string färg;
    public string antalDörrar;

    public void beskrivBil()
    {
        typAvFordon = "Personbil";
        Console.WriteLine("Bil: " + färg + ", " + antalDörrar + " dörrar, Typ: " + typAvFordon);
        visaInfo();
    }
}
