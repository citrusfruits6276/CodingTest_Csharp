using System;

class Program{
    static void Main(String[] args){
        String[] read = Console.ReadLine().Split(' ');
        int A = int.Parse(read[0]);
        int B = int.Parse(read[1]);
        
        Console.WriteLine(A - B);
    }
}