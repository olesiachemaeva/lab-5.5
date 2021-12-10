using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            { int[,] f = new int[4, 4];
                for (int i = 0; i < 4;i++)
                {
                    for(int j=0; j<4; j++)
                    {
                        if ((i + j) % 2 == 1)
                            f[i, j] = 1;
                        else { f[i, j] = 0; }
                                datagridvieewl[i, j].Value = f[i, j];
                        
                        
                    }
                }
            }
        }
    }
}
