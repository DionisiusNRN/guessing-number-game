using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public abstract class GameLevel : ILevel
    {
        // Variabel untuk menyimpan angka yang harus ditebak dan maksimum percobaan
        protected int NumberToGuess;
        protected int MaxAttempts;

        public abstract void GenerateNumber(); // Metode abstrak untuk menghasilkan angka yang harus ditebak

        // Metode virtual untuk memulai permainan dengan pemain yang diberikan
        public virtual void Play(Player player)
        {
            GenerateNumber(); // Memanggil metode GenerateNumber() untuk menghasilkan angka yang harus ditebak
            int attempts = 0; // Variabel untuk menghitung percobaan
            bool guessed = false; // Variabel untuk menandai apakah angka sudah berhasil ditebak

            // Looping untuk memungkinkan pemain menebak angka sebanyak MaxAttempts kali atau sampai benar
            while (attempts < MaxAttempts && !guessed)
            {
                Console.Write("Enter your guess: ");
                int guess = int.Parse(Console.ReadLine()); // Membaca tebakan dari pemain dan mengonversinya menjadi integer

                // Memeriksa apakah tebakan pemain benar, terlalu rendah, atau terlalu tinggi
                if (guess == NumberToGuess)
                {
                    Console.WriteLine("Correct!");
                    player.UpdateScore(GetScore()); // Memperbarui skor pemain jika tebakan benar
                    guessed = true; // Menandai bahwa angka sudah berhasil ditebak
                }
                else if (guess < NumberToGuess)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("Too high!");
                }

                attempts++; // Meningkatkan jumlah percobaan
            }
            Console.Clear(); // Membersihkan layar konsol setelah permainan selesai

            // Jika pemain tidak berhasil menebak angka dalam MaxAttempts kali percobaan
            if (!guessed)
            {
                Console.WriteLine("Out of attempts!");
                GiveUp(player); // Memanggil metode GiveUp() untuk menawarkan opsi menyerah
            }
            else // Jika pemain berhasil menebak angka
            {
                MoveToNextLevel(player);  // Memanggil metode MoveToNextLevel() untuk melanjutkan ke level berikutnya
            }
        }

        // Metode virtual untuk menampilkan aturan permainan
        public virtual void DisplayRules()
        {
            Console.WriteLine($"Guess the number between 1 and {GetMaxNumber()}. You have {MaxAttempts} attempts.");
        }

        // Metode virtual untuk menawarkan opsi menyerah
        public virtual void GiveUp(Player player)
        {
            Console.Write("Do you want to finish the game? (y/n) ");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.WriteLine($"Alright! The correct number was {NumberToGuess}.");
                Console.WriteLine($"Your final score is {player.Score}. Game over.");
                Environment.Exit(0);
            }
            else
            {
                player.Score = 0; // Mengatur skor pemain menjadi 0
                Console.WriteLine("Score has been reset. Starting again from EasyLevel.");
                ILevel easyLevel = new EasyLevel();
                easyLevel.DisplayRules();
                easyLevel.Play(player);
            }
        }

        public abstract void MoveToNextLevel(Player player); // Metode abstrak untuk melanjutkan ke level berikutnya

        protected abstract int GetMaxNumber(); // Metode abstrak untuk mendapatkan angka maksimum yang dapat ditebak

        protected abstract int GetScore(); // Metode abstrak untuk mendapatkan skor yang diberikan pada level ini
    }
}
