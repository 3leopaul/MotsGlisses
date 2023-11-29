using System.Collections.Generic;
using Internal;
using System;

namespace MotsGlisses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionaire dicoT = new Dictionnaire("Dico1", {"Aaa","Aab","Aba","Caa","Zo"});
            Console.WriteLine(RechDichoRecursif(0,4,dicoT.DicoTemp,"Aba"));
        }
    }
}