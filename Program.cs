namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в пианино!\r\nПереключение между октавами F2-F8");

            int[] nowOctave = new int[12];

            do
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if ((key.Key == ConsoleKey.F1) || (key.Key == ConsoleKey.F2) || (key.Key == ConsoleKey.F3) || (key.Key == ConsoleKey.F4) || (key.Key == ConsoleKey.F5) || (key.Key == ConsoleKey.F6) || (key.Key == ConsoleKey.F7))
                {
                    nowOctave = Octaves(key);
                }

                if ((key.Key == ConsoleKey.Z) || (key.Key == ConsoleKey.S) || (key.Key == ConsoleKey.X) || (key.Key == ConsoleKey.D) || (key.Key == ConsoleKey.C) || (key.Key == ConsoleKey.V) || (key.Key == ConsoleKey.G) || (key.Key == ConsoleKey.B) || (key.Key == ConsoleKey.H) || (key.Key == ConsoleKey.N) || (key.Key == ConsoleKey.J) || (key.Key == ConsoleKey.M))
                {
                    SoundOutput(key, nowOctave);
                }

            }
            while (true);
        }

        static void SoundOutput(ConsoleKeyInfo key, int[] nowOctave)
        {
            if (key.Key == ConsoleKey.Z)
            {
                Console.Beep(nowOctave[0], 200);
                Console.Clear();
            }

            else if (key.Key == ConsoleKey.S)
            {
                Console.Beep(nowOctave[1], 200);
                Console.Clear();
            }

            else if (key.Key == ConsoleKey.X)
            {
                Console.Beep(nowOctave[2], 200);
                Console.Clear();
            }

            else if (key.Key == ConsoleKey.D)
            {
                Console.Beep(nowOctave[3], 200);
                Console.Clear();
            }

            else if (key.Key == ConsoleKey.C)
            {
                Console.Beep(nowOctave[4], 200);
                Console.Clear();
            }

            else if (key.Key == ConsoleKey.V)
            {
                Console.Beep(nowOctave[5], 200);
                Console.Clear();
            }

            else if (key.Key == ConsoleKey.G)
            {
                Console.Beep(nowOctave[6], 200);
                Console.Clear();
            }

            else if (key.Key == ConsoleKey.B)
            {
                Console.Beep(nowOctave[7], 200);
                Console.Clear();
            }

            else if (key.Key == ConsoleKey.H)
            {
                Console.Beep(nowOctave[8], 200);
                Console.Clear();
            }

            else if (key.Key == ConsoleKey.N)
            {
                Console.Beep(nowOctave[9], 200);
                Console.Clear();
            }

            else if (key.Key == ConsoleKey.J)
            {
                Console.Beep(nowOctave[10], 200);
                Console.Clear();
            }

            else if (key.Key == ConsoleKey.M)
            {
                Console.Beep(nowOctave[11], 200);
                Console.Clear();
            }
        }

        static int[] Octaves(ConsoleKeyInfo key)
        {
            int[] LargeOctave = new int[12] { 65, 69, 73, 78, 82, 87, 93, 98, 103, 110, 117, 124 };
            int[] SmallOctave = new int[12] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 };
            int[] FirstOctave = new int[12] { 267, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            int[] SecondOctave = new int[12] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
            int[] ThirdOctave = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] FourthOctave = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            int[] FifthOctave = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
            int[] Null = new int[1];


            if (key.Key == ConsoleKey.F1)
            {
                Console.WriteLine("Большая октава");
                return LargeOctave;
            }

            else if (key.Key == ConsoleKey.F2)
            {
                Console.WriteLine("Малая октава");
                return SmallOctave;
            }

            else if (key.Key == ConsoleKey.F3)
            {
                Console.WriteLine("Первая октава");
                return FirstOctave;
            }

            else if (key.Key == ConsoleKey.F4)
            {
                Console.WriteLine("Вторая октава");
                return SecondOctave;
            }

            else if (key.Key == ConsoleKey.F5)
            {
                Console.WriteLine("Третья октава");
                return ThirdOctave;
            }

            else if (key.Key == ConsoleKey.F6)
            {
                Console.WriteLine("Четвёртая октава");
                return FourthOctave;
            }

            else if (key.Key == ConsoleKey.F7)
            {
                Console.WriteLine("Пятая октава");
                return FifthOctave;
            }

            return Null;
        }


    }
}
