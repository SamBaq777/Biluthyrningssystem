public class Reservation
{
    public string datum;
    public string pris;

    public void visaReservation()
    {
        Console.WriteLine("Reservation: " + datum + ", " + pris);
    }
}
