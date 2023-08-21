//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

//Method

string[] FindGivenLengthStrings(int stringLength, string[] stringArray){
    
    string[] tempArray = new string[stringArray.Length];//временный массив достаточной длины

    int j = 0;//индекс элемента в заполняемом массиве

    //поиск строк нужной длины и заполнение временного массива
    //с параллельным определением размера результирующего массива
    for(int i=0; i < stringArray.Length; i++){
        if (stringArray[i].Length <= stringLength){
            tempArray[j] = stringArray[i];
            j++;
        }
    }
    
    string[] resultArray = new string[j];//заготовка под результирующий массив

    //копирование значащей части из временного массива в результирующий
    Array.Copy(tempArray,0,resultArray,0,j);

    return resultArray;
}
//////////////////////////////////
Console.Clear();

//example1
string[] inputString = {"Hello", "2", "world", ":-)"};
var str = string.Join(" ,", inputString);
Console.WriteLine("[ "+ str + " ]");
string tempStr = string.Join(", ", FindGivenLengthStrings(3, inputString));
Console.WriteLine("[ "+tempStr+" ]");

//example2
string[] inputString1 = {"1234", "1567", "-2", "computer science"};
var str1 = string.Join(" ,", inputString1);
Console.WriteLine("[ "+ str1 + " ]");
tempStr = string.Join(", ", FindGivenLengthStrings(3, inputString1));
Console.WriteLine("[ "+tempStr+" ]");

//example3
string[] inputString2 = {"Russia", "Denmark", "Kazan"};
var str2 = string.Join(" ,", inputString2);
Console.WriteLine("[ "+ str2 + " ]");
tempStr = string.Join(", ", FindGivenLengthStrings(3, inputString2));
Console.WriteLine("[ "+tempStr+" ]");
