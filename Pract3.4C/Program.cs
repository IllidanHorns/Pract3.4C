using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        ConsoleKeyInfo UserChoice;
        int[] x = ConsoleOctave(new ConsoleKeyInfo(' ',ConsoleKey.F5, false, false, false));
        Console.WriteLine("Для Изменения октавы используйте F5 и F6. Для нажатия клавиш пианино ипользуйте кнопки от 1 до = (1,2,3...-,=)");
        do
        {
            UserChoice = Console.ReadKey(true);
            if ((UserChoice.Key == ConsoleKey.F5) | (UserChoice.Key == ConsoleKey.F6))
            {
                x = ConsoleOctave(UserChoice);
            }
            else { ConsoleSound(UserChoice, x); }
        } while (UserChoice.Key != ConsoleKey.Escape);
    }
    public static int[] ConsoleOctave(ConsoleKeyInfo Klavisha)
    {
        int[] firstOctave = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493};
        int[] secondOctave = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987};
        switch (Klavisha.Key)
        {
            case ConsoleKey.F5:
                Console.WriteLine("Включена 5 октава");
                return firstOctave;
            case ConsoleKey.F6:
                Console.WriteLine("Включена 6 октава");
                return secondOctave;
            default:
                return firstOctave;
        }
    }
    static void ConsoleSound(ConsoleKeyInfo a, int[] b)
    {
        int i;
        switch (a.KeyChar)
        {
            case '1':
                Console.Beep(b[0], 700);
                break;
            case '2':
                Console.Beep(b[1], 700);
                break;
            case '3':
                Console.Beep(b[2], 700);
                break;
            case '4':
                Console.Beep(b[3], 700);
                break;
            case '5':
                Console.Beep(b[4], 700);
                break;
            case '6':
                Console.Beep(b[5], 700);
                break;
            case '7':
                Console.Beep(b[6], 700);
                break;
            case '8':
                Console.Beep(b[7], 700);
                break;
            case '9':
                Console.Beep(b[8], 700);
                break;
            case '0':
                Console.Beep(b[9], 700);
                break;
            case '-':
                Console.Beep(b[10], 700);
                break;
            case '=':
                Console.Beep(b[11], 700);
                break;
        }
    }
}