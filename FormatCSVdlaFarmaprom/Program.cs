using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace testy_listowania
{
    class Program
    {
       static string sciecha = @"M:\Kuba-Arek-Aflofarm Plus - pliki\Farmaprom - zgłoszenia\" + DateTime.Now.ToString("yyyy-MM-dd") + " Apteki w Aflofarm Plus (tak-nie).csv";
       static string sciecha3 = @"M:\Kuba-Arek-Aflofarm Plus - pliki\Farmaprom - zgłoszenia\" + DateTime.Now.ToString("yyyy-MM-dd") + " Apteki w Aflofarm Plus (tak-nie).csv";
       // static string sciecha = @"C:\Users\Tomek\Documents\" + DateTime.Now.ToString("yyyy-MM-dd") + " Apteki w Aflofarm Plus (tak-nie).csv";
       //static string sciecha3 = @"C:\Users\Tomek\Documents\" + DateTime.Now.ToString("yyyy-MM-dd") + " Apteki w Aflofarm Plus (tak-nie).csv";
       
        static void Main(string[] args)
        {
            loadcsv();
        }

        public static void loadcsv()
        {
            List<string> linie = new List<string>();
            try
            {
                var lines = File.ReadAllLines(sciecha).ToList();


               // lines.Insert(0, "sep=;");

               List<string> nowa = new List<string>();
                foreach (var line in lines)
                {
                    string output = line.Replace(",", ";");
                    Console.WriteLine(output);
                    nowa.Add(output);
                }             
                File.WriteAllLines(sciecha3, nowa);
            }
            catch 
            {
                Console.WriteLine($"\n\n\n\n" + "##############################################"+ "\n\n" +
                                   "Nie znaleziono pliku do przeformatowania!"+ 
                                   "\n"+ "Prawidła nazwa pliku to 'aktualna data <yyyy-mm-dd> Apteki w Aflofarm Plus (tak-nie).csv '" +
                                   "\n"+"Ewentualnie powiadom Tomka!"+
                                   "\n\n" + "##############################################" +"\n\n\n" + "Enter, żeby zamknąć okno.");
                Console.ReadLine();
            }
        }
    }
}
