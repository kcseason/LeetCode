using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _620.Not_Boring_Movies_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql = @"Select * from cinema 
                            where description != 'boring' and mod(id,2)=1
                            order by rating desc";
        }
    }
}
