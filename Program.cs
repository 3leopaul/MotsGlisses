using System;

namespace MotsGlisses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string nomFichier = "Mots_Français.txt";
            Dictionnaire dico = new Dictionnaire(nomFichier, "Francais");
            Console.Write(dico.DicoToString());
            Console.WriteLine(dico.RechDichoRecursifInstance("jygyjgy"));
        }
    }
}