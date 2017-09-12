using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4; int y = 5;

            
            Console.Write(" The value  is :"+((x>4)?99.0:9));
            Console.ReadLine();

            /*
            int n,num=8;
            //Console.Write(" The month number is :");
            //num=Console.Read();

            n=2*calc(num);
            Console.WriteLine("\n The rabbits number is: {0}", n);
            Console.ReadLine();
            */

        }

        /// <summary>
        /// 计算月份兔子的总数
        /// </summary>
        /// <param name="num">月份数</param>
        /// <returns></returns>
        static int calc(int num)
        {
            int sum = 1,rnum=0;//总数；遗传代数
            if ((num+1)/3==0)
            {
                rnum = (num + 1) /3+1;
            }
            else
            {
                rnum = num / 3 + 1;
            }
            for (int i = 2; i <= rnum;i++ )
            {
                if(i==2)//第二代
                {
                    if(num-2>0)
                    {
                        for(int j=2;j<num;j++)
                        {
                            sum++;
                        }
                    }
                }
                else if (i>2)//大于二代
                {
                    for(int j =1;j<=(num-(3*(i - 1)))+1;j++)
                    {
                        sum += j;
                    }
                }
            }
            return sum;
        }
    }
}
