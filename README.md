# Hur många gånger förekommer orden?

## Problem
I denna uppgift ska du ska färdigställa ett påbörjat projekt. Programmet ska analysera en text som läses in från en textfil (_Regeringsformen, 1 kap och 2 kap.txt_ som finns i projektkatalogen) och skriva till en annan textfil (_Frekvenstabell.txt_ som skapas i projektkatalogen) hur många gånger de olika orden förekommer. Det mesta är klart men metoden ```CountWords``` som ska analyserar texten måste du komplettera. Idag kastas det bara ett undantag då metoden anropas. Börja med att ta en närmare titt på den kod som redan är skriven så du förstår i stora drag vad det är som händer, och vad som saknas. Du får inte ändra någon kod, metoden ```CountWords``` undantagen.
Projektet är konfigurerat så att filnamnen skickas som ett argument (se Not 1) in till programmet varför du inte behöver ange dem på annat sätt. Genom att använda ```args[0]``` och ```args[1]``` hämtas filnamnen i samband med att ```StreamReader```- respektive ```StreamWriter```-objekten skapas i medtoden Main.
Du ska komplettera den statiska metoden ```CountWords``` i klassen ```WordFactory```. Till metoden skickas en array med ord. Arrayen med ord ska undersökas; unika ord identifieras och räknas. De unika orden och antalet gånger de förekommer ska lagras i ett ```SortedList```-objekt. Metoden ska returnera referensen till ```SortedList```-objektet.

![Den statiska klassen `WordFactory`](bilder/WordFactoryClass.png)
Figur 1. Den statiska klassen WordFactory
 
Av klassdiagrammet kan du utläsa att returtypen från metoden ska vara av typen ```IDictionary```, och inte ```SortedList```, som är klassen du lämpligen använder inne i metoden. ```IDictionary``` är ett interface som klassen ```SortedList``` implementerar. (Genom att låta metoden returnera en interfacetyp kan du välja vilken klass som ska användas internt inne i metoden i denna uppgift är det dock lämpligt att du använder ```SortedList```, som automatiskt sorterar nycklarna).

Ett ”_dictionary_” består av två värden, en nyckel (_key_) och ett värde (_value_). Nyckeln kopplas till värdet, ungefär på samma sätt som ett index i en array kopplas till ett värde. Klassen ```SortedList``` har den trevliga egenskapen att den sortera nyckeln i stigande ordning automatiskt. Det finns även en klass som heter ```Dictionary```, men den sorterar inte nyckeln utan är helt osorterad.

Ett ```SortedList```-objekt skapar du med ```IDictionary<string, int> dic = new SortedList<string, int>();``` och redan här kan du använda en variabel av typen ```IDictionary``` för att referera till ```SortedList```-objektet. All funktionalitet som du behöver använda definieras av interfacet ```IDictionary```, och implementeras av klassen ```SortedList```.
Interfacet ```IDictionary``` definierar bl.a. metoderna ```ContainsKey()``` och ```Add()```, som självklart klassen ```SortedList``` implementerar. Dessa metoder använder du för att räkna hur många gånger ett ord förekommer.

+ För varje ord som hittas...
	+ Finns ordet redan i mappen? (```ContainsKey```)
		+ ...öka heltalet som är kopplat till ordet med 1. (använd operatorn []!)
	+ ...annars...
		+ ...lägg till det nya ordet och initiera heltalet till 1. (```Add```)

Komplettera metoden ```CountWords``` med den kod som krävs för att metoden ```Main``` ska fungera så att varje ord och hur många gånger det förekommer i texten skrivs ut i en tabell. 

_OBS! Du får inte ändra på någon kod utanför metoden ```CountWords```_.

___
###### Not 1. <a id="note-1"></a>
Högerklicka på projektnamnet i fönstret _Solution Explorer_, välj _Properties_ och fliken _Debug_. Du hittar kommandoradsargumenten vid _Command line arguments_.
___

## Mål

Efter att ha gjort uppgiften ska du:

- Kunna instansiera objekt av och hantera samlingsklassen ```SortedList```.
- Veta hur du använder gränssnittet (interfacet) ```IDictionary```.
- Känna till hur du använder en ```foreach```-loop (eller en ```for```-loop) för att loopa igenom en array med strängar.
- Kunna returnera en referens till ett samlingsobjekt.

## Tips

Läs om:

- ...

TODO: Komplettera med läsanvisningar!

[Lösning](losning/README.md)
