using System.Runtime.InteropServices;

internal class Program
{
    [DllImport("kernel32")]
    private static extern bool Beep(int freq,int duration);
    private static void Main(string[] args)
    {
        Random rand = new Random();
        
        for (int i = 0; i < 9; i++)
        {
            Beep(rand.Next(500, 1000), rand.Next(20, 20000));
        }
    }
}