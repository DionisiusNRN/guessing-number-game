using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class EasyLevel : GameLevel
    {
        public EasyLevel()
        {
            MaxAttempts = 10; // Set maksimum percobaan pada level mudah menjadi 10.
        }

        public override void GenerateNumber()
        {
            Random rand = new Random();
            NumberToGuess = rand.Next(1, 11); // Menghasilkan angka acak antara 1 hingga 10
        }

        public override void MoveToNextLevel(Player player)
        {
            Console.WriteLine("Congratulations! Moving to MediumLevel."); // Pesan selamat saat pemain naik ke level Medium.
            ILevel mediumLevel = new MediumLevel();
            mediumLevel.DisplayRules(); // Menampilkan aturan dari level Medium.
            mediumLevel.Play(player); // Memulai permainan di level Medium untuk pemain.
        }

        protected override int GetMaxNumber()
        {
            return 10; // Mengembalikan nilai maksimum angka yang dapat ditebak, yaitu 10.
        }

        protected override int GetScore()
        {
            return 10; // Mengembalikan skor yang diberikan jika pemain berhasil menyelesaikan level mudah.
        }
    }
}
