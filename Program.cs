using System.Collections.Generic;
using Internal;
using System;

namespace MotsGlisses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] st = {"Aaa","Aab","Aba","Caa","Zo"};
            Dictionaire dicoT = new Dictionnaire("Dico1", st);
            Console.WriteLine(RechDichoRecursif(0,4,dicoT.DicoTemp,"Aba"));
        }
    }
}