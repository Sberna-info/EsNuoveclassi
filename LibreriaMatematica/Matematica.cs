using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMatematica
{
    public class Matematica
    {
        /// <summary>
        /// Questo metodo calcola la somma tra due int.
        /// </summary>
        /// <param name="n1">primo numero</param>
        /// <param name="n2">secondo numero</param>
        /// <returns> n1 + n2 </returns>
        public static int Somma(int n1, int n2)
        {
            return n1 + n2;
        }

        /// <summary>
        /// Questo metodo calcola la somma tra due double.
        /// </summary>
        /// <param name="n1">primo numero double</param>
        /// <param name="n2">secondo numero double</param>
        /// <returns>n1 + n2</returns>
        public static double DoubleSomma(double n1, double n2)
        {
            double somma = n1 + n2;
            return somma;
        }

        /// <summary>
        /// Questo metodo calcola la sottrazione tra due double.
        /// </summary>
        /// <param name="n1">primo numero</param>
        /// <param name="n2">secondo numero</param>
        /// <returns>n1 - n2</returns>
        public static double DoubleSottrazione(double n1, double n2)
        {
            double sottrazione = n1 - n2;
            return sottrazione;
        }


        /// <summary>
        /// Questo metodo calcola la moltiplicazione tra due double.
        /// </summary>
        /// <param name="n1">primo numero</param>
        /// <param name="n2">secondo numero</param>
        /// <returns>n1 * n2</returns>
        public static double DoubleMoltiplicazione(double n1, double n2)
        {
            double moltiplicazione = n1 * n2;
            return moltiplicazione;
        }

        /// <summary>
        /// Questo metodo calcola la divisione tra due double.
        /// </summary>
        /// <param name="n1">dividendo</param>
        /// <param name="n2">divisore</param>
        /// <returns>n1 / n2</returns>
        public static double DoubleDivisione(double n1, double n2)
        {
            double divisione = n1 / n2;
            return divisione;
        }

        /// <summary>
        /// Questo metodo calcola la potenza.
        /// </summary>
        /// <param name="n1">base</param>
        /// <param name="n2">esponente</param>
        /// <returns>n1^n2</returns>
        public static long LongPotenza(long n1, long n2)
        {
            long potenza = 1;
            for(int c = 0; c < n2; c++)
            {
                potenza *= n1;
            }
            return potenza;
        }

        /// <summary>
        /// Questo metodo calcola il fattoriale.
        /// </summary>
        /// <param name="n1">numero</param>
        /// <returns>fattoriale *= c</returns>
        public static long CalcolaFattoriale(int n1)
        {
            long fattoriale = 1;
            for(int c = 2; c <= n1; c++)
            {
                fattoriale *= c;
            }
            return fattoriale;
        }

        /// <summary>
        /// Questo metodo calcola il minore tra 3 numeri
        /// </summary>
        /// <param name="n1">primo numero</param>
        /// <param name="n2">secondo numero</param>
        /// <param name="n3">terzo numero</param>
        /// <returns>nmin = Math.Min(n1, Math.Min(n2, n3));</returns>
        public static int MinoreTra(int n1, int n2, int n3)
        {
            int nmin;
            nmin = Math.Min(n1, Math.Min(n2, n3));
            return nmin;
            
        }

        /// <summary>
        /// Questo metodo calcola il maggiore tra 3 numeri
        /// </summary>
        /// <param name="n1">primo numero</param>
        /// <param name="n2">secondo numero</param>
        /// <param name="n3">terzo numero</param>
        /// <returns>nmax = Math.Max(n1, Math.Max(n2, n3));</returns>
        public static int MaggioreTra(int n1, int n2, int n3)
        {
            int nmax;
            nmax = Math.Max(n1, Math.Max(n2, n3));
            return nmax;
        }

        /// <summary>
        /// Questo metodo calcola il numero inverso che hai inserito.
        /// </summary>
        /// <param name="n1">numero</param>
        /// <returns>-n1</returns>
        public static double Inverso(double n1)
        {
            return -n1;
        }

        /// <summary>
        /// Questo metodo verifica se il numero è pari.
        /// </summary>
        /// <param name="n1">numero</param>
        /// <returns>npari = true or npari = false</returns>
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

        /// <summary>
        /// Questo metodo verifica se il numero è dispari.
        /// </summary>
        /// <param name="n1">numero</param>
        /// <returns>ndispari = true or ndispari = false</returns>
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

        /// <summary>
        /// Questo metodo verifica se il numero è positivo.
        /// </summary>
        /// <param name="n1">numero</param>
        /// <returns>npos = true or npos = false</returns>
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

        /// <summary>
        /// Questo metodo verifica se il numero è negativo.
        /// </summary>
        /// <param name="n1">numero</param>
        /// <returns>nneg = true or nneg = false</returns>
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

        /// <summary>
        /// Questo metodo verifica se il numero è intero.
        /// </summary>
        /// <param name="n1">numero</param>
        /// <returns>intero = true or intero = false</returns>
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
