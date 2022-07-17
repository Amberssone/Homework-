string numbers = Console.ReadLine();

string[] numbersArray = numbers.Split(' ');

string number1 = numbersArray[0];
string number2 = numbersArray[1];
string number3 = numbersArray[2];
int number1Int = Int32.Parse(number1);
int number2Int = Int32.Parse(number2);
int number3Int = Int32.Parse(number3);

if (number1Int > number2Int) {
    if (number1Int > number3Int) {
        Console.WriteLine(number1Int);
    }
    else {
        Console.WriteLine(number3Int);
    }
}
else {
    if (number2Int > number3Int) {
        Console.WriteLine(number2Int);
    }
    else {
        Console.WriteLine(number3Int);
    }
}
