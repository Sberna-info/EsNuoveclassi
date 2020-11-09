using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMatematica
{
    public class Matematica
    {
        public static int Somma(int n1, int n2)
        {
            return n1 + n2;
        }

        public static double DoubleSomma(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double DoubleSottrazione(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double DoubleMoltiplicazione(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double DoubleDivisione(double n1, double n2)
        {
            return n1 / n2;
        }

        public static long LongPotenza(long n1, long n2)
        {
            long potenza = 1;
            for(int c = 0; c < n2; c++)
            {
                potenza *= n1;
            }
            return potenza;
        }

        public static long CalcolaFattoriale(int n1)
        {
            long fattoriale = 1;
            for(int c = 2; c <= n1; c++)
            {
                fattoriale *= c;
            }
            return fattoriale;
        }

        public static int MinoreTra(int n1, int n2, int n3)
        {
            int nmin;
            nmin = Math.Min(n1, Math.Min(n2, n3));
            return nmin;
            
        }

        public static int MaggioreTra(int n1, int n2, int n3)
        {
            int nmax;
            nmax = Math.Max(n1, Math.Max(n2, n3));
            return nmax;
        }

        public static double Inverso(double n1)
        {
            return -n1;
        }

        public static bool IsPari(int n1)
        {
            bool npari;
            if(n1 % 2 == 0)
            {
                npari = true;
            }
            else
            {
                npari = false;
            }
            return npari;
        }

        public static bool IsDispari(int n1)
        {
            
            bool ndispari;
            if(n1 % 2 == 1)
            {
                ndispari = true;
            }
            else
            {
                ndispari = false;
            }
            return ndispari;
            
        }

        public static bool IsPositivo(int n1)
        {
            bool npos;
            if(n1 > 0)
            {
                npos = true;
            }
            else
            {
                npos = false;
            }
            return npos;
        }

        public static bool IsNegativo(int n1)
        {
            bool nneg;
            if(n1 < 0)
            {
                nneg = true;
            }
            else
            {
                nneg = false;
            }
            return nneg;
        }
        
        public static bool IsIntero(double n1)
        {
            bool intero;
            if(n1 == (int) n1)
            {
                intero = true;
            }
            else
            {
                intero = false;
            }
            return intero;
        }


    }
}
