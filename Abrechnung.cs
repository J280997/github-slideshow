using System;

namespace Sparschwein
{
    class Program
    {
        static void Main(string[] args)
        {	
			//Variablen Definition
			string inputKabel;
			string inputArbeitszeit;
			int mathKabel= 0;
			int mathArbeitszeit= 0;
			int Trommeln = 0;
			int Meter= 0;
			int Normalstunden= 0;
			int Ueberstunden= 0;
			int euroKabel= 0;
			int euroTrommeln= 0;
			int euroArbeitszeit= 0;
			int euroUeberstunden= 0;
			bool MehrTrommel = false;
			bool MehrZeit = false;

			//Berechnung der Trommeln / kabel
			Console.WriteLine("Geben Sie die Anzahl (in Meter) der verlegten Kabeln an:");
            inputKabel = System.Console.ReadLine(); // Liest die Zeichen, von der Tastatur, bis der
													 // Benutzer die Eingabe-Taste gedrückt hat und legt
													 // die Daten in Variable input ab.
			mathKabel = System.Convert.ToInt32(inputKabel); // Konvertierte eine Zeichenfolge in eine int-Wert.
			
			//Check if biger than 500			
			if (mathKabel > 500) {
				do
				{
					mathKabel = mathKabel - 500;
					euroTrommeln = euroTrommeln + 1000;
					Trommeln = Trommeln + 1;
				} while(mathKabel > 500);
				Meter = mathKabel;
				euroKabel = mathKabel * 3;
				MehrTrommel = true;
			}
			else {
				Meter = mathKabel;
				euroKabel = mathKabel * 3;
			}
			
			//Berechnung der Arbeitszeit / Ueberstunden
			
			Console.WriteLine("Geben Sie die Arbeitszeit (in Stunden) für das Kabelverlegen an:");
            inputArbeitszeit = System.Console.ReadLine(); // Liest die Zeichen, von der Tastatur, bis der
													// Benutzer die Eingabe-Taste gedrückt hat und legt
													// die Daten in Variable input ab.
			mathArbeitszeit = System.Convert.ToInt32(inputArbeitszeit); // Konvertierte eine Zeichenfolge in eine int-Wert.
			
			//Check if biger than 40	
			if (mathArbeitszeit > 40) {
				do
				{
					mathArbeitszeit = mathArbeitszeit - 40;
					euroArbeitszeit = euroArbeitszeit + (40 * 60);
					Normalstunden = Normalstunden + 40;
				} while(mathArbeitszeit > 40);
				Ueberstunden = mathArbeitszeit;
				euroUeberstunden = mathArbeitszeit * 90;
				MehrZeit = true;
			}
			else {
				Normalstunden = mathArbeitszeit;
				euroArbeitszeit = mathArbeitszeit * 40;
			}
			
			//Start der Ausgabe

			if (MehrTrommel == true) {
				int kostenKabelGesamt = euroTrommeln + euroKabel;
				System.Console.WriteLine("Kosten für Kabeln: " + kostenKabelGesamt + "Euro");
				System.Console.WriteLine(Trommeln + " Trommeln: " + euroTrommeln + "Euro");
				System.Console.WriteLine(Meter + " Meter: " + euroKabel + "Euro");
			}
			else {
				System.Console.WriteLine("Kosten für Kabeln: " + euroKabel + "Euro");
				System.Console.WriteLine(Trommeln + " Trommeln: " + euroKabel + "Euro");
			}
            
            if (MehrZeit == true) {
				int kostenArbeitGesamt = euroArbeitszeit + euroUeberstunden;
				System.Console.WriteLine("Arbeitskosten: " + kostenArbeitGesamt + "Euro");
				System.Console.WriteLine(Normalstunden + " Normalstunden: " + euroArbeitszeit + "Euro");
				System.Console.WriteLine(Ueberstunden + " Überstunden: " + euroUeberstunden + "Euro");
			}
			else {
				System.Console.WriteLine("Arbeitskosten: " + euroUeberstunden + "Euro");
				System.Console.WriteLine(Ueberstunden + " Überstunden: " + euroUeberstunden + "Euro");
			}

        }
    }
}
