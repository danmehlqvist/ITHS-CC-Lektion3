// See https://aka.ms/new-console-template for more information
using System.Data;
//using RepetitionLabb1b.Start;
using RepetitionLabb1b.Finished;



#region Hur vi använder koden som ligger i Start-katalogen

//FileDataReader fileDataReader = new FileDataReader();
//string line = fileDataReader.ReadStringFromFile();

//string reversedString = fileDataReader.ReverseString(line);

//Console.WriteLine(reversedString);

#endregion

// ====================================================================

#region Hur vi använder koden som ligger i Finished-katalogen

IGetStringReader dataReader = new RepetitionLabb1b.Finished.FileDataReader();
//IGetStringReader dataReader = new DatabaseDataReader();
//IGetStringReader dataReader = new RandomDataReader();


string line = dataReader.GetString();
string reversedString = new StringReverser(dataReader).Reverse();
Console.WriteLine(reversedString);

#endregion