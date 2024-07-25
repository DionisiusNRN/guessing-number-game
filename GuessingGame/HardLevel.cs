using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class HardLevel : GameLevel
    {
        public HardLevel()
        {
            MaxAttempts = 5; // Set maksimum percobaan pada level mudah menjadi 5.
        }

        public override void GenerateNumber()
        {
            Random rand = new Random();
            NumberToGuess = rand.Next(1, 51); // Menghasilkan angka acak antara 1 hingga 50
        }

        public override void MoveToNextLevel(Player player)
        {
            Console.WriteLine("Congratulations! You completed the game!"); // pesan selamat karena sudah meneyelesaikan permainan
            Console.WriteLine("Perfect score (50)! Game over."); // pesan Perfect Score
            GiveUp(player); // Menampilkan fungsi Giveup()
        }

        protected override int GetMaxNumber()
        {
            return 50; // Mengembalikan nilai maksimum angka yang dapat ditebak, yaitu 50.
        }

        protected override int GetScore()
        {
            return 25; // Mengembalikan skor yang diberikan jika pemain berhasil menyelesaikan level hard.
        }
    }
}
