using System;
//Ибнеев Артем 11-012
namespace kr3
{
    class Program
    {
        static Random rnd = new Random();

        static void CreateDOt(int[] x1, int[] x2, int[] y1, int[] y2, int N)
        {

            for (int i = 0; i < N; i++)
            {
                x1[i] = rnd.Next(-10, 10);
                x2[i] = rnd.Next(-10, 10);
                y1[i] = rnd.Next(-10, 10);
                y2[i] = rnd.Next(-10, 10);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            var N = 2;//Convert.ToInt32(Console.ReadLine());
            var count = 0;
            var x1 = new int[N];
            var y1 = new int[N];
            var x2 = new int[N];
            var y2 = new int[N];
            x1[0] = 1;
            y1[0] = 0;
            x2[0] = 1;
            y2[0] = 2;
            x1[1] = 0;
            y1[1] = 1;
            x2[1] = 2;
            y2[1] = 1;
            int x, y;
            double k1, k2;

            //CreateDOt(x1, x2, y1, y2, N);
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    x = ((x1[i] * y2[i] - x2[i] * y1[i]) * (x2[j] - x1[j]) - (x1[j] * y2[j] - x2[j] * y1[j]) * (x2[i] - x1[i])) / ((y1[i] - y2[i]) * (x2[j] - x1[j]) - (y1[j] - y2[j]) * (x2[i] - x1[i]));
                    y = ((y1[j] - y2[j]) * x - (x1[j] * y2[j] - x2[j] * y1[j])) / (x2[j] - x1[j]);
                    k1 = Math.Tan((x2[i] - x1[i]) / (y2[i] - y1[i]));
                    k2 = Math.Tan((x2[j] - x1[j]) / (y2[j] - y1[j])); //если k1=k2, то отрезки параллельны, а значит, не имеют точек пересечения.
                    if (((x1[i] <= x && x2[i] >= x && x1[j] <= x && x2[j] >= x) || (y1[i] <= y && y2[i] >= y && y1[j] <= y && y2[j] >= y))&& k1!=k2)
                        count++;


                }
            }
            if (count == 0)
            {
                Console.WriteLine("нет отрезков");
            }
            else
            {
                Console.WriteLine("Такие отрезки сущетсвуют");
            }
        }
    }
}