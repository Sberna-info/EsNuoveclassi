using System;
using LibreriaMatematica;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int scelta = 0, scelta2 = 0;
            Console.Write("Inserisci 1 se vuoi eseguire: la somma, la sottrazione, la moltiplicazione, la divisione o la potenza. \ninserisci 2 se vuoi eseguire: long Fatooriale, Minimo tra 3 numeri, Massimo tra 3 numeri, double Inverso. \nInserisci 3 se vuoi eseguire: Verifica se il numero è pari, Verifica se il numero è dispari, Verifica se il numero è positivo, Verifica se il numero è negativo, Verifica se il numero è intero \n \n");
            scelta = int.Parse(Console.ReadLine());
            if(scelta == 1)
            {
                Console.Write("Inserisci il numero accanto alla operazione per svolgerla:\n1 Somma \n2 double Somma \n3 double Sottrazione \n4 double Moltiplicazione \n5 double Divisione \n6 long Potenza \n");
                scelta2 = int.Parse(Console.ReadLine());
                if(scelta2 == 1)
                {
                    int n1 = LeggiNumero();
                    int n2 = LeggiNumero();
                    int somma = Matematica.Somma(n1, n2);
                    Console.WriteLine($"la somma tra i due nuemri è: {somma}");
                }
                else if( scelta2 == 2)
                {
                    int n1 = LeggiNumero();
                    int n2 = LeggiNumero();
                    double doublesomma = Matematica.DoubleSomma(n1, n2);
                    Console.WriteLine($"la somma double tra i due nuemri è: {doublesomma}");
                }
                else if( scelta2 == 3)
                {
                    int n1 = LeggiNumero();
                    int n2 = LeggiNumero();
                    double doublesottrazione = Matematica.DoubleSottrazione(n1, n2);
                    Console.WriteLine($"la sottrazione double tra i due nuemri è: {doublesottrazione}");
                }
                else if(scelta2 == 4)
                {
                    int n1 = LeggiNumero();
                    int n2 = LeggiNumero();
                    double doublemoltiplicazione = Matematica.DoubleMoltiplicazione(n1, n2);
                    Console.WriteLine($"la moltiplicazione double tra i due nuemri è: {doublemoltiplicazione}");
                }
                else if (scelta2 == 5)
                {
                    int n1 = LeggiNumero();
                    int n2 = LeggiNumero();
                    double doubledivisione = Matematica.DoubleDivisione(n1, n2);
                    Console.WriteLine($"la divisione double tra i due nuemri è: {doubledivisione}");

                }
                else if(scelta2 == 6)
                {
                    int n1 = LeggiNumero();
                    int n2 = LeggiNumero();
                    long longpotenza = Matematica.LongPotenza(n1, n2);
                    Console.WriteLine($"la potenza long tra i due nuemri è: {longpotenza}");
                }
                
            }
            else if(scelta == 2)
            {
                Console.Write("Inserisci il numero accanto alla operazione per svolgerla: \n1 long Fatooriale \n2 Minimo tra 3 numeri \n3 Massimo tra 3 numeri \n4 double Inverso \n");
                scelta2 = int.Parse(Console.ReadLine());
                if(scelta2 == 1)
                {
                    int n1 = LeggiNumero();
                    long fattoriale = Matematica.CalcolaFattoriale(n1);
                    Console.WriteLine($"Il fattoriale del numero è: {fattoriale}");
                }
                else if(scelta2 == 2)
                {
                    int n1 = LeggiNumero();
                    int n2 = LeggiNumero();
                    int n3 = LeggiNumero();
                    int nmin = Matematica.MinoreTra(n1, n2, n3);
                    Console.WriteLine($"Il minore tra i numeri è: {nmin}");
                }
                else if(scelta2 == 3)
                {
                    int n1 = LeggiNumero();
                    int n2 = LeggiNumero();
                    int n3 = LeggiNumero();
                    int nmax = Matematica.MaggioreTra(n1, n2, n3);
                    Console.WriteLine($"Il maggiore tra i numeri è: {nmax}");
                }
                else if(scelta2 == 4)
                {
                    int n1 = LeggiNumero();
                    double inverso = Matematica.Inverso(n1);
                    Console.WriteLine($"Il numero invertito è: {inverso}");
                }

            }
            else if(scelta == 3)
            {
                Console.Write("Inserisci il numero accanto alla operazione per svolgerla:\n1 Verifica se il numero è pari \n2 Verifica se il numero è dispari \n3 Verifica se il numero è positivo \n4 Verifica se il numero è negativo \n5 Verifica se il numero è intero \n");
                scelta2 = int.Parse(Console.ReadLine());
                if(scelta2 == 1)
                {
                    int n1 = LeggiNumero();
                    bool npari = Matematica.IsPari(n1);
                    Console.WriteLine($"il numero è pari? {npari}");
                }
                else if(scelta2 == 2)
                {
                    int n1 = LeggiNumero();
                    bool ndispari = Matematica.IsDispari(n1);
                    Console.WriteLine($"il numero è dispari? {ndispari}");
                }
                else if(scelta2 == 3)
                {
                    int n1 = LeggiNumero();
                    bool npos = Matematica.IsPositivo(n1);
                    Console.WriteLine($"il numero è positivo? {npos}");
                }
                else if(scelta2 == 4)
                {
                    int n1 = LeggiNumero();
                    bool nneg = Matematica.IsNegativo(n1);
                    Console.WriteLine($"il numero è negativo? {nneg}");
                }
                else if(scelta2 == 5)
                {
                    int n1 = LeggiNumero();
                    bool intero = Matematica.IsIntero(n1);
                    Console.WriteLine($"il numero è intero? {intero}");
                }
            }
            Console.ReadLine();
        }
        static int LeggiNumero()
        {
            Console.Write("inserisci un numero: ");
            int n = int.Parse(Console.ReadLine());
            return n;

        }

    }
}
