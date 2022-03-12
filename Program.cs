using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_MOD3_1302204079_SE4403_KPL
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("================== Posisi Karakter Game ================");
            PosisiKarakterGame pintu = new PosisiKarakterGame();
            pintu.kunci();
        }
    }
    public class KodeBuah
    {
        enum State
        {
            EXIT, Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry,
            Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka
        };

        public void getKodeBuah()
        {
            State state = State.Apel;
            State buah = State.Apel;
            string[] screenName = {"A00", "B00", "C00", "D00", "E00","F00",
            "H00", "I00", "J00", "K00", "L00", "M00", "N00", "000"
        };
            while (state != State.Pisang)
            {
                Console.WriteLine("Ketik Nama Buah");
                Console.Write("Buah :");
                string command = Console.ReadLine();
                switch (state)
                {
                    case State.Apel:
                        if (command == "Apel")
                        {
                            buah = State.Apel;
                        }
                        else if (command == "Aprikot")
                        {
                            buah = State.Aprikot;
                        }
                        else if (command == "Alpukat")
                        {
                            buah = State.Alpukat;
                        }
                        else if (command == "Pisang")
                        {
                            buah = State.Pisang;
                        }
                        else if (command == "Paprika")
                        {
                            buah = State.Paprika;
                        }
                        else if (command == "Blackberry")
                        {
                            buah = State.Blackberry;
                        }
                        else if (command == " Ceri")
                        {
                            buah = State.Ceri;
                        }
                        else if (command == "Kelapa")
                        {
                            buah = State.Kelapa;
                        }
                        else if (command == "Jagung")
                        {
                            buah = State.Jagung;
                        }
                        else if (command == "Kurma")
                        {
                            buah = State.Kurma;
                        }
                        else if (command == "Durian")
                        {
                            buah = State.Durian;
                        }
                        else if (command == "Anggur")
                        {
                            buah = State.Anggur;
                        }
                        else if (command == "Melon")
                        {
                            buah = State.Melon;
                        }
                        else if (command == "Semangka")
                        {
                            buah = State.Semangka;
                        }
                        else
                        {
                            state = State.Apel;
                            command = "QUIT";

                        }
                        break;
                }
                if (command != "QUIT")
                    Console.WriteLine("Kode Buah" + command + " : " + screenName[(int)buah]);
            }
            Console.WriteLine("Close");
        }
    }
    namespace Jurnal_MOD3_1302204079_SE4403_KPL
    {
        public class Program
        {
            static void Main(string[] args)
            {
                KodeBuah kode = new KodeBuah();
                Console.WriteLine();
                kode.getKodeBuah();
            }
        }
    }
    class PosisiKarakterGame
    {
        enum State { atas, bawah };
        public void kunci()
        {
            State state = State.atas;

            String[] screenName = { "atas", "bawah" };
            do
            {
                Console.WriteLine("tombol arah " + screenName[(int)state] + " ditekan");
                Console.Write("Enter Command : ");
                String command = Console.ReadLine();
                switch (state)
                {
                    case State.atas:
                        if (command == "S")
                        {
                            state = State.bawah;
                        }
                        break;
                    case State.bawah:
                        if (command == "W")
                        {
                            state = State.atas;
                        }
                        break;
                }
            } while (state != State.atas);
        }
    }
}