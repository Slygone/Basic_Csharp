////Array of whole numbers, containing 3 elements

//int[] arrayOfInts = new int[3];//here 3 is not an index, it represents the number of members

//arrayOfInts[0] = 4; //initialize the first member 
//arrayOfInts[1] = 7;
//arrayOfInts[2] = 9;

//Console.WriteLine(arrayOfInts);

////access a member
////second member
//Console.WriteLine("Second member: " + arrayOfInts[1]);
//Console.WriteLine("First member: " + arrayOfInts[0]);
//Console.WriteLine("Third member: " + arrayOfInts[2]);


////declare and initialize string array
//string[] arrayOfStrings = new string[] { "Hello", "SEDC", "Goodbye", "C#" };

//short[] arrayOfShorts = new short[] { 2, 5, 7 };
//int[] anotherIntArray = new int[] { 2, 66, 88, 907 };
//bool[] boolArray = new bool[] { false, true };

//bool[] anotherBoolArray = new bool[2];
//anotherBoolArray[0] = true;
//anotherBoolArray[1] = false;

//Console.WriteLine("Third member of arrayOfStrings: " + arrayOfStrings[2]);

////Methods
//double[] doubleArray = new double[] { 3.4, 6.7,8, 9.1, 100.5 };//array of 5 doubles
////length
//Console.WriteLine("Num of elements in doubleArray: " + doubleArray.Length);

////change number of members
//Array.Resize(ref doubleArray, 7);
//Console.WriteLine("Num of elements in doubleArray: " + doubleArray.Length);
//Console.WriteLine("Sixth member of doubleArray: " + doubleArray[5]);
//doubleArray[5] = 12.2;
//doubleArray[6] = 20.7;
//Console.WriteLine("Num of elements in doubleArray: " + doubleArray.Length);
//Console.WriteLine("Sixth member of doubleArray: " + doubleArray[5]);
//Console.WriteLine("=========");

//int indexOfEight = Array.IndexOf(doubleArray, 8);
//Console.WriteLine("index of 8: " + indexOfEight);
//int indexOfEleven = Array.IndexOf(doubleArray, 11);
//Console.WriteLine("index of 11: " + indexOfEleven);

//Console.WriteLine("=====Foreach====");
//string[] names = new string[] { "Ana", "Marko", "Stefan", "Kate", "Nikola" };
////foreach access the value inside the array
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

//Array.Reverse(names);
//Console.WriteLine("=====Reverse====");
//foreach(string name in names)
//{
//    Console.WriteLine(name);
//}
//Array of arrays
int[][] matrix = new int[][]
{
    new int[]{1,2},
    new int[]{6,7},
    new int[]{10,157}
};

//for (int i = 0; i < matrix.Length; i++)
//{
//    for(int j = 0 ; j < matrix[i].Length; j++)
//    {
//        Console.WriteLine(matrix[i][j]);
//    }
//}

foreach (int[] row in matrix)
{
    foreach (int num in row)
    {
        Console.WriteLine(num);
    }
}