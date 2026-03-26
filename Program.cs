// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Security.Claims;
using dotnet_recaver;

Perant perant = new Perant(10, 20);
int result = perant.Add(perant.num, perant.num1);
Console.WriteLine($"The result of adding {perant.num} and {perant.num1} is: {result}");
// ovberloaded method
perant.Add(10, 20, 5);
Console.WriteLine($"The result of adding {perant.num} and {perant.num1} with multiplier 5 is: {perant.Add(10, 20, 5)}");




System.Console.WriteLine("-----------------------------");
Child child = new Child(5, 4);
int result1 = child.Multiply(child.Num, child.num1);
Console.WriteLine($"The result of multiplying {child.Num} and {child.num1} is: {result1}");

child.DisplayPerant();
Console.WriteLine("-----------------------------");
// Collections and data structures

LinkedList<int> linkedList = new LinkedList<int>();
linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddLast(4);
linkedList.AddLast(5);
Console.WriteLine("Linked List:");
foreach (int item in linkedList)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------");

Stack<int> stack = new Stack<int>();
stack.Push(10);
stack.Push(20);
stack.Push(30);
Console.WriteLine("Stack:");
while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop());
}
Console.WriteLine("-----------------------------");
Queue<int> queue = new Queue<int>();
queue.Enqueue(100);
queue.Enqueue(200);
queue.Enqueue(300);
int front = queue.Dequeue();
Console.WriteLine($"Front of the queue: {front}");

Console.WriteLine("Queue:");
while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}




Console.WriteLine("-----------------------------");
Dictionary<string, int> dictionary = new Dictionary<string, int>();
dictionary.Add("One", 1);
dictionary.Add("Two", 2);
dictionary.Add("Three", 3);
dictionary["Two"] = 22; // Update value for key "Two"
dictionary.Remove("One"); // Remove key "One"
Console.WriteLine("Dictionary:");
foreach (KeyValuePair<string, int> kvp in dictionary)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

Console.WriteLine("-----------------------------");
HashSet<int> hashSet = new HashSet<int>();
hashSet.Add(1);
hashSet.Add(2);
hashSet.Add(3);
hashSet.Add(2);

Console.WriteLine("HashSet:");
foreach (int item in hashSet)
{
    Console.WriteLine(item);
}


Console.WriteLine("-----------------------------");
SortedSet<int> sortedSet = new SortedSet<int>();
sortedSet.Add(5);
sortedSet.Add(3);
sortedSet.Add(8);
sortedSet.Add(1);

Console.WriteLine("SortedSet:");
foreach (int item in sortedSet)
{
    Console.WriteLine(item);
}


Console.WriteLine("-----------------------------");
//delegates and lambda expressions
Func<int, int, int, int> myDelegate = (a, b, n) => a - b + n;
Func<int, int, int> myDelegate2 = (a, b) => a * b;

int delegateResult = myDelegate(10, 5, 2);
int delegateResult2 = myDelegate2(10, 5);
Console.WriteLine($"The result of the delegate operation {10} * {5} is: {delegateResult2}");
Console.WriteLine("-----------------------------");
Console.WriteLine($"The result of the delegate operation {10} - {5} + {2} is: {delegateResult}");

Console.WriteLine("-----------------------------");

child.DisplayChild();


Console.WriteLine("-----------------------------");

//linq queries

Console.WriteLine("LINQ Query:");
var list = from item in linkedList
           where item > 1
           select item;
Console.WriteLine("LINQ Query Result:");
foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------");

var list1 = linkedList.Where(x => x > 1).Select(x => x);
Console.WriteLine("LINQ Method Syntax Result:");
foreach (var item in list1)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------");
var sortedList = linkedList.Where(x => x > 2).OrderBy(x => x);
Console.WriteLine("Sorted LINQ Result:");
foreach (var item in sortedList)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------");
var firstList = linkedList.First(x => x % 2 == 0).ToString();
Console.WriteLine($"First even number in the linked list: {firstList}");
foreach (var item in firstList)
{
    Console.WriteLine(item);
}