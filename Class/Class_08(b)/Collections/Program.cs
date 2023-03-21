//Arrays
using System.Collections;

int[] intArray = new int[3];//allocate memory for 3 ints
string[] stringArray = new string[] { "Hello", "Bye" };

foreach( string str in stringArray )
{
    Console.WriteLine( str );
}

//ArrayList (accepts all types, can have mixed array lists, doesn't have constraints on number of members)

ArrayList arrayList = new ArrayList();//empty ArrayList
ArrayList secondArrayList = new ArrayList { "Hello", 5, true };
secondArrayList.Add("Bye");
secondArrayList.Add('a');
secondArrayList.Remove(5);

//use var to itterate in mixed ArrayList
foreach(var i in secondArrayList)
{
    Console.WriteLine(i);
}

//List (all members must be of same type, doesn't have constraints on number of members)

List<int> emptyListOfInts = new List<int>();//emptyList of Ints
List<int> listOfInts = new List<int> { 2, 88, 9 };

listOfInts.Add(100); //add 100 to the list
listOfInts.Add(-10);
listOfInts.Remove(88); //remove 88 from the list
listOfInts.RemoveAt(0); //remove the on index 0;
Console.WriteLine(listOfInts[0]);
Console.WriteLine($"Number of members in listOfInts: {listOfInts.Count}");

foreach(int number in listOfInts)
{
    Console.WriteLine(number);
}

//Dictionary (works with key-value pairs)
Dictionary<int, string> products = new Dictionary<int, string>()
{
    {111,"potato"},
    {222,"bread"},
    {333,"milk" }
};
Console.WriteLine(products[222]); //get the value for key 222

products.Add(444, "cookies");
products.Remove(333);
foreach(var item in products)
{
    Console.WriteLine(item.Value);//item.value or item.key
}

//Que (first in first  out)
Queue<int> ourQueue = new Queue<int>();
ourQueue.Enqueue(100);// add 100 to the end of the queue
ourQueue.Enqueue(2); // add 2 to the end of the queue
ourQueue.Enqueue(25); // add 25 to the end of the queue

int firstMember = ourQueue.Dequeue(); //remove and return the first member

int readFirstMember = ourQueue.Peek();//only get the value of the first member, do not remove it

Console.WriteLine(readFirstMember);
Console.WriteLine(ourQueue.Count);

foreach(int item in ourQueue)
{
    Console.WriteLine(item);
}

//Stack (last In First Out)
Console.WriteLine("======Stack=====");
Stack<string> ourStack = new Stack<string>();
ourStack.Push("Hello");//Add member to the end of the stack
ourStack.Push("Bye");//Add member to the end of the stack
ourStack.Push("Welcome");//Add member to the end of the stack

string lastMember = ourStack.Pop(); //read and remove the last member
string currentLastMember = ourStack.Peek(); //read but don't remove the last member

Console.WriteLine(ourStack.Count);
foreach(string item in ourStack)
{
    Console.WriteLine(item);
}