// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Collection Expressions");

//Initializing arrays, collections and span variables

//Arrays
int[] array1 = new int[] { 1, 2, 3, 4, 5 };
var array2 = new[] { 1, 2, 3, 4, 5 };
int[] array3 = { 1, 2, 3, 4, 5 };


//List
var list1 = new List<int>() { 1, 2, 3, 4, 5 };
List<int> list2 = new() { 1, 2, 3, 4, 5 };

//newer ways
int[] array4 = [1, 2, 3, 4, 5];

List<int> list3 = [1, 2, 3, 4, 5];

//Instantiate an empty collection or array
int[] emptyArrays = Array.Empty<int>();
List<int> emptyLists = new();

//newer ways
int[] array5 = [];
List<int> emptyLists2 = [];

//Spread Operator
List<int> appendedlist = [.. list1, ..list3];

foreach (var number in appendedlist)
{
    Console.WriteLine(number);
}


