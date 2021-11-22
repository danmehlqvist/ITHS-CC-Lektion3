Katalogen Start innehåller koden vi börjar med.

Vi har en del issues vi ska rätta till. Jag tänkte att vi gör det tillsammans, men för den nyfikne 
så ligger den färdiga koden i katalogen Finished.

Nedan kommer jag nämna stegen jag gjorde för att komma från Start till Finished.

1.	FileDataReader gör lite för mycket. Namnet anger att den läser data från en fil, men vi har också
	lagt logiken för att vända strängen här. Vi tar och flyttar ut den till en egen klass.

2.	Så vad ska den nya klassen heta? Kan ju diskuteras men jag tänkte mig StringReverser.

3.	Nästa steg är att vi skapar ett interface som vi ska använda för att abstrahera bort 
	FileDataReader med.Vi döper det först till IFileDataReader som innehåller en metod ReadStringFromFile

4.	Vi ser till att FileDataReader implementerar interfacet IFileDataReader


Så vad har vi nu gjort? Vi har gömt implementationen av FileDataReader bakom ett interface.
Vad är det bra för då? För testningen så har vi nu ett enkelt sätt att byta ut vad FileDataReader
returnerar genom att mocka interfacet. Då har vi något vi kan testa på.

Det löser ju uppgiften med testningen men det finns andra fördelar. Föreställ er att projektledaren 
nu önskar att den där strängen inte alltid ska läsas från filen. Den ska läsas från databasen ibland.

5.	Vi tar och ändrar initialiseringen av FileDataReadern lite
		FileDataReader fileDataReader = new FileDataReader() blir
		IFileDataReader fileDataReader = new FileDataReader()

6.	Vi kan nu bygga en DatabaseDataReader som implementerar IFileDataReader. Vi gör det men vi 
	märker att de namnen vi valt på både metoden och interfacet kanske var mindre lyckat.

	Kanske bättre att vi döper om IFileDataReader till IGetStringReader. Vi är ju inte längre låsta till 
	att hämta datafrån en fil. IGetStringReader bryr sig inte om var datat kommer ifrån.

	På samma sätt kan vi resonera med metod-namnet ReadStringFromFile(). Kanske bättre med ReadString()
	eller GetString?

Vad vi nu har åstadkommit är att vi har kod som är löst kopplat till datakällan.

7.  Vi moddar nu StringReverser så att den tar emot interfacet i konstruktorn. Vi tar vidare bort parametern till 
	GetString. Vi hämtar datat från interfacet istället.
