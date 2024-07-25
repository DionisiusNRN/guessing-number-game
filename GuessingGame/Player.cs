using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class Player
    {
        public string Name { get; set; } // Properti otomatis yang digunakan untuk menyimpan dan mengambil nama pemain.
        public int Score { get; set; } // Properti otomatis yang digunakan untuk menyimpan dan mengambil skor pemain.

        public void UpdateScore(int points)
        // Method untuk memperbarui skor pemain dengan menambahkan nilai 'points' ke properti 'Score'.
        {
            Score += points; // Menambahkan nilai 'points' ke properti 'Score' dan memperbarui nilainya.

        }
    }
}
