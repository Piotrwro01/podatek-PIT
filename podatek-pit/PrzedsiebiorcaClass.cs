using System;

public class Przedsiebiorca
{
	public String nazwa;

	public void zbierzDane()
    {
		Console.WriteLine("Jak nazywa się przedsiębiorstwo?");
		nazwa = Console.ReadLine();
    }

	public void wyswietlNazwe()
    {
		Console.WriteLine("Przedsiebiorca " + nazwa);
    }
}
