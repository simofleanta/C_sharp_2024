using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class Program
    {
        static void Main(string[] args)
        {/*cerinta: ideea e ca vreau sa se parcurga printr-o lista, si sa transforme statusurile 1,3 in status =2
          * pseudocode: for loop unde statuses.Length ==2 
          Language: */

        // fac array-ul
            int[] company_status = { 1, 3, 1, 1, 2, 2, 3, 3 };
             
           for (int i = 0; i < company_status.Length;i++)
                {
                   Console.WriteLine(company_status[i]=2);    
                }
                             
            }

            
        }
        
        
           

            
          
    
}
