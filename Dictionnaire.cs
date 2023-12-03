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
        string langue;
        string[][] dicoTab = new string[26][];
        string nomFichier;        
        public Dictionnaire(string nomDuFichier, string l){
            this.nomFichier=nomDuFichier;
            this.langue=l;

            StreamReader sr = new StreamReader(nomDuFichier);
            try{
                string s;
                int i=0;
                s=sr.ReadLine();
                while(i<26){
                    if(s!=null){
                        this.dicoTab[i]=s.Split(' ');
                        TriFusionRecursif(this.dicoTab[i], 0, this.dicoTab[i].Length-1);
                    }else{
                        this.dicoTab[i]=null;
                    }
                    s=sr.ReadLine();
                    i++;
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Fichier introuvable: {nomDuFichier}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Erreur: IndexOutOfRange");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erreur convertir en double");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur non pévue: {ex.Message}");
            }


        }

        public string NomFichier{
            get
            {
                return this.nomFichier;
            }
        }


        // Methode pour decrire une instance de la classe Dictionaire
        public string DicoToString(){
            int dicoTabILongueur=0;
            string s="Langue: "+langue;
            char[] alphabet = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
            for(int i=0; i<26; i++){
                if(dicoTab[i]!=null){
                    dicoTabILongueur=dicoTab[i].Length-1;
                }
                s=s+"\n"+alphabet[i]+": "+dicoTabILongueur+" Mots";
                dicoTabILongueur=0;
            }
            return s;
        }

        //fin methode DicoToString


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
        public static void TriFusionRecursif(string[] tab, int debut, int fin)
        {
            if (debut < fin)
            {
                int m = debut + (fin - debut) / 2;

                TriFusionRecursif(tab, debut, m);
                TriFusionRecursif(tab, m + 1, fin);
                Fusion(tab, debut, m, fin);
            }
        }

        private static void Fusion(string[] tab, int debut, int milieu, int fin)
        {
            int i, j, k;
            int n1 = milieu - debut + 1;
            int n2 = fin - milieu;
            string[] L = new string[n1];
            string[] R = new string[n2];

            for (i = 0; i < n1; i++)
                L[i] = tab[debut + i];

            for (j = 0; j < n2; j++)
                R[j] = tab[milieu + 1 + j];

            i = 0;
            j = 0;
            k = debut;

            while (i < n1 && j < n2)
            {
                if (String.Compare(L[i], R[j]) < 1)
                {
                    tab[k] = L[i];
                    i++;
                }
                else
                {
                    tab[k] = R[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                tab[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                tab[k] = R[j];
                j++;
                k++;
            }
        }
        //Methode tri dico
        

        
    }
}