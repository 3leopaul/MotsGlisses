using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace joueur
{
    public class Joueur
    {
        string nom;
        List<string> mots;
        int score;
        public Joueur (string n)
        {
            this.nom=n;
            this.mots = new List<string>();
            this.score=0;
        }
                
        public string Nom{         //PROPRIETES
            get{return this.nom;}
        }
        public List<string> Mots{
            get{return this.mots;}
        }
        public int Score{
            get{return this.score;}

        }
        public void Add_Mot(string mot)            //METHODES
        {
            Mots.Add(mot);
        }
        public string toString()
        {
            return("Joueur : "+this.nom+" Points : "+this.score);
        }
        public void Add_Score(string mot)     
        {
            int val=0;
            for(int i=0;i<mot.Length;i++)
            {
                if ("AEISNORTUL".IndexOf(mot[i])>=0)
                {
                    val+=1;
                }
                if ("DGM".IndexOf(mot[i])>=0)
                {
                    val+=2;
                }
                if ("BCP".IndexOf(mot[i])>=0)
                {
                    val+=3;
                }
                if ("FHU".IndexOf(mot[i])>=0)
                {
                    val+=4;
                }
                if ("JQ".IndexOf(mot[i])>=0)
                {
                    val+=8;
                }
                if ("KWXYZ".IndexOf(mot[i])>=0)
                {
                    val+=10;
                }
            }
            this.score=val;
        }
        public bool Contient(string mot)
        {
            return Mots.Contains(mot);
        }
    }
}