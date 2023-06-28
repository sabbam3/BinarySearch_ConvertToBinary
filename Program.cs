using System;
int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int enteredNumber;
string convertedNumber;
long toBeConvertedNumber;
void BinarySearch(int[] array,int enteredNumber)
{
    int high = array.Length - 1, low = 0, middle;
    int count = 0;
    while (low <= high)
    {
        count++;
        middle = (high + low) / 2;
        if (array[middle] == enteredNumber)
        {
            Console.WriteLine("Number is found");
            break;
        }
        else if(enteredNumber < array[middle])
        {
            high = middle - 1;

        }
        else if(enteredNumber > array[middle])
        {
            low = middle + 1;
        }
        if(array.Length <= count)
        {
            Console.WriteLine("Number is not in array");
          
        }
    }

}
string LongToBinary(long number)
{
    string result = "";
    while (number > 0)
    {
        result = (number % 2) + result;
        number =number / 2;
    }
    return result;
}
Console.Write("Enter number: ");
enteredNumber = Convert.ToInt16(Console.ReadLine());
BinarySearch(array, enteredNumber);
Console.Write("Enter number to convert: ");
toBeConvertedNumber = (long)Convert.ToDouble(Console.ReadLine());
convertedNumber = LongToBinary(toBeConvertedNumber);
Console.Write(convertedNumber);
Console.ReadLine();