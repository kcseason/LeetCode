using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _627.Swap_Salary_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql = @"update salary 
                        set sex =if(sex='f','m','f');";
        }
    }
}
