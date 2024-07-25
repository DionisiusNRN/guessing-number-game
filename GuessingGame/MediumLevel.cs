using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class MediumLevel : GameLevel
    {
        public MediumLevel()
        {
            MaxAttempts = 7; // Set maksimum percobaan pada level mudah menjadi 7.
        }

        public override void GenerateNumber()
        {
            Random rand = new Random();
            NumberToGuess = rand.Next(1, 21); // Menghasilkan angka acak antara 1 hingga 20
        }

        public override void MoveToNextLevel(Player player)
        {
            Console.WriteLine("Congratulations! Moving to HardLevel."); // Pesan selamat saat pemain naik ke level Hard.
            ILevel hardLevel = new HardLevel();
            hardLevel.DisplayRules(); // Menampilkan aturan dari level Hard.
            hardLevel.Play(player); // Memulai permainan di level Hard untuk pemain.
        }

        protected override int GetMaxNumber()
        {
            return 20; // Mengembalikan nilai maksimum angka yang dapat ditebak, yaitu 20.
        }

        protected override int GetScore()
        {
            return 15; // Mengembalikan skor yang diberikan jika pemain berhasil menyelesaikan level medium.
        }
    }
}
