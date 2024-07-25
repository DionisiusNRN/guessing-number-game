using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public interface ILevel
    {
        // Mendefinisikan metode Play yang harus diimplementasikan oleh kelas turunan untuk logika permainan.
        void Play(Player player);

        // Mendefinisikan metode DisplayRules yang harus diimplementasikan oleh kelas turunan untuk menampilkan aturan permainan.
        void DisplayRules();
    }
}
