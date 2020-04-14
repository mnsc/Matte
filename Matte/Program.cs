using System;

namespace Matte
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Högsta siffran?");

			var maximalt = int.Parse(Console.ReadLine());

			Console.WriteLine("Det blir siffror mellan 1 och " + maximalt);

			var antalrätt = 0;
			var starttid = DateTime.Now;
			while (true)
			{
				var rand = new Random();
				var slumpsiffra1 = rand.Next(1, maximalt);
				var slumpsiffra2 = rand.Next(1, maximalt);

				Console.WriteLine($"Vad blir {slumpsiffra1} * {slumpsiffra2}?");

				var rättsvar = (slumpsiffra1 * slumpsiffra2);
				


				var detärensiffra = int.TryParse(Console.ReadLine(), out var svaret);
				if (detärensiffra == false)
				{
					Console.WriteLine("Skriv en siffra!");
				}
				else if (svaret == rättsvar)
				{
					antalrätt = antalrätt + 1;
					var sekunder = (DateTime.Now - starttid).TotalSeconds;
					Console.WriteLine($"{sekunder} sekunder sen du startade");
					Console.WriteLine($"Rätt (totalt {antalrätt} rätt)");
					Console.WriteLine($"{antalrätt/sekunder*60} rätt per minut");
				}
				else
				{
					Console.WriteLine($"Fel! 😣 Rätt svar var ju {rättsvar}! Klantigt! Nu är du död!");
					Environment.Exit(0);
				}
			}
		}
	}
}
