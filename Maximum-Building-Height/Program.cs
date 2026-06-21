using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Building_Height
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 5;

            int[][] restrictions = new int[][]
            {
                new int[] { 5, 3 },
                new int[] { 2, 5 },
            };

            int result = MaxBuilding(n, restrictions);

            Console.WriteLine("Max height: " + result);
        }

        static int MaxBuilding(int n, int[][] restrictions)
        {
            List<int[]> res = new List<int[]>();

            res.Add(new int[] { 1, 0 });

            foreach (var r in restrictions)
            {
                res.Add(new int[] { r[0], r[1] });
            }

            res = res.OrderBy(x => x[0]).ToList();

            for (int i = 1; i < res.Count; i++)
            {
                int dist = res[i][0] - res[i - 1][0];
                res[i][1] = Math.Min(res[i][1], res[i - 1][1] + dist);
            }

            for (int i = res.Count - 2; i >= 0; i--)
            {
                int dist = res[i + 1][0] - res[i][0];
                res[i][1] = Math.Min(res[i][1], res[i + 1][1] + dist);
            }

            int maxHeight = 0;

            for (int i = 1; i < res.Count; i++)
            {
                int x0 = res[i - 1][0];
                int h0 = res[i - 1][1];
                int x1 = res[i][0];
                int h1 = res[i][1];

                int dist = x1 - x0;

                int peak = (h0 + h1 + dist) / 2;

                maxHeight = Math.Max(maxHeight, peak);
            }

            int lastPos = res.Last()[0];
            int lastHeight = res.Last()[1];

            maxHeight = Math.Max(maxHeight, lastHeight + (n - lastPos));

            return maxHeight;
        }
    }
}
