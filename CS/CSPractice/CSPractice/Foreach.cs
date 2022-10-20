using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCalc;

namespace CSPractice
{
    internal class Foreach
    {
        public void foreachPractice()
        {
            int[] arr = new int[7] { 11, 12, 13, 14, 15, 16, 17 };     
            //foreach문    
            Console.WriteLine("@@foreach@@");    
            int index = 0;    
            foreach(int elem in arr)    
            {        
                Console.WriteLine("arr["+ index +"]:" +elem);       
                ++index;    
            }    
            
            Console.WriteLine("currenti:" + index);    
            //for문으로 작성했다면?    Console.WriteLine();   
            
            Console.WriteLine("@@for사용@@");    
            for(int i=0; i<7; ++i)    
            {        
                Console.WriteLine("arr["+i+"]:" + arr[i]);    
            } 
        }
        
    }
}
