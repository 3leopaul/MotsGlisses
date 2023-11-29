using System;

namespace MotsGlisses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] st = {"Aaa","Aab","Aba","Caa","Zo"};
            Dictionnaire dicoT = new Dictionnaire("Dico1", st);
            Console.WriteLine(Dictionnaire.RechDichoRecursif(0,4,dicoT.DicTemp,"Aba"));
        }
    }
}