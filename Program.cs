using System;

class Program
{
    static void Main(string[] args)
    {
        Bil samimsBil = new Bil();
        samimsBil.registreringsnummer = "SAM415";
        samimsBil.märke = "Kia";
        samimsBil.färg = "Blå";
        samimsBil.antalDörrar = "4";

        samimsBil.beskrivBil();

        Console.WriteLine();

        Reservation bokning = new Reservation();
        bokning.datum = "2025-11-17";
        bokning.pris = "800 kr";

        bokning.visaReservation();

        Console.WriteLine();

        Kund kund1 = new Kund();
        kund1.namn = "Samim";

        kund1.boka();
    }
}
