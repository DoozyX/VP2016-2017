using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4
{
    class Program
    {
        enum PasswordStrenght
        {
            eazy,
            normal,
            hard
        }

        private static Random random = new Random();


        // Funkcija za generiranje sluchajna lozinka 
        // PasswordStrenght e tip enumeracija (easy, normal , hard)
        static string generatePassword ( PasswordStrenght passwordStrenght ) {
            // easy lozinkata treba da ima do 6 znaci (samo mali bukvi) 
            // normal lozinkata treba da ima od 6 do 10 znaci (da sodrzhi golemi bukvi i 
            // brojki
            // hard loznikata treba da ima povekje od 10 znaci i da sodrzhi mali, golemi
            // bukvi i specijalni znaci
            if (passwordStrenght == PasswordStrenght.eazy) {
                int length = random.Next(1, 7);
                const string chars = "abcdefghijklmnopqrstuvwxyz";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            } else if (passwordStrenght == PasswordStrenght.normal) {
                int length = random.Next(6, 11);
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }else {
                int length = random.Next(10, 20);
                const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());

            }
        }
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();
            char[] separator = { ' ' };
            string[] myWords;
            myWords = myString.Split(separator);
            bool guess = false;
            foreach (string word in myWords) {
                if (word == generatePassword(PasswordStrenght.eazy)) {
                    guess = true;
                }
            }
            if (guess) {
                Console.WriteLine("You guessed.");
            } else {
                Console.WriteLine("You didn't guess.");
            }
            Console.ReadKey();
        }
    }
}
