using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotsGlisses
{
    public class Dictionnaire
    {
        string nomTemp;
        string[] dicTemp;

        public Dictionnaire(string n, string[] d){
            this.nomTemp=n;
            this.dicTemp=d;
        }

        public string NomTemp{
            get
            {
                return this.nomTemp;
            }
        }

        public string[] DicTemp{
            get
            {
                return this.dicTemp;
            }
        }


        // Methode recherche RechDichoRecursif(Pas validée encore) :
        public static bool RechDichoRecursif(int debut, int fin, string[] dico, string mot)
        {
            if(fin<debut || dico==null || dico.Length==0|| String.Compare(dico[fin],mot)==-1 || String.Compare(mot,dico[debut])==-1){
                return false;
            }if(debut<=fin){
                int c =(debut+fin)/2;
                if (dico[c]==mot){
                    return true;
                }if(String.Compare(dico[c], mot)==-1){
                    debut=c+1;
                    return RechDichoRecursif(debut, fin, dico, mot);
                }if(debut==fin){
                    if(dico[c]==mot){
                        return true;
                    }else{
                        return false;
                    }
                }else{
                    fin=c-1;
                    return RechDichoRecursif(debut, fin, dico, mot);
                }
            }else{
                return false;
            }
    
        }

        //Fin methode DicoRec

        //Methode tri dico
        

        
    }
}