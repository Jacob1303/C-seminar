using System;

class Programm
{
    static void WriteSelect(string[] namesArray)
    {
        for (int i = 0; i < namesArray.Length-1; i++)
        {
            Console.Write(i+1 + " - " + namesArray[i] + ", ");
        }
        Console.WriteLine(namesArray.Length + " - " + namesArray[namesArray.Length-1] + ".");
    }
    static void SelectRace()
    {
        string[] namesRace = {"Люди", "Эльфы", "Дварфы", "Орки"};
        WriteSelect(namesRace);        
        Console.Write("Укажите вашу расу ");
        int indexRace = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша раса это - " + namesRace[indexRace-1]);
        string namePerson = namesRace[indexRace-1];
    }
    static void SelectClass()
    {
        string[] namesClass = {"Воин", "Маг", "Плут", "Варвар"};
        WriteSelect(namesClass);        
        Console.Write("Укажите ваш класс ");
        int indexClass = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш класс это - " + namesClass[indexClass-1]);
    }
    static void SelectGender()
    {
        string[] namesGender = {"Мужик", "Баба", "Чудо-Юдо"};
        WriteSelect(namesGender);        
        Console.Write("Укажите ваш пол ");
        int indexGender = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш пол это - " + namesGender[indexGender-1]);
    }
    static void Main(string[] args)
    {
         SelectRace();
         SelectClass();
         SelectGender();
         Console.WriteLine("Спасибо за то, что определились. Дальше - больше!");
    }
