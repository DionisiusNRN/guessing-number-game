using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(); // Membuat objek baru dari class Player
            Console.Write("Enter your name: "); // Menampilkan pesan untuk memasukkan nama pemain
            player.Name = Console.ReadLine(); // Membaca input dari pengguna dan menyimpannya sebagai nama pemain
            Console.Clear(); // Membersihkan layar konsol

            // Membuat array berisi objek dari level-level permainan
            ILevel[] levels = new ILevel[] {
                new EasyLevel(),
                new MediumLevel(),
                new HardLevel()
            };

            foreach (var level in levels)
            {
                level.DisplayRules(); // Menampilkan aturan dari level yang sedang dimainkan
                level.Play(player); // Memulai permainan pada level tersebut
            }

            // Menampilkan pesan terima kasih beserta skor akhir pemain
            Console.WriteLine($"Thank you for playing, {player.Name}. Your final score is {player.Score}.");
            
        }
    }
}
