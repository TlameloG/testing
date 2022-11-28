using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_subetting
{
    internal class Program
    {
        public static int BorrowedBits(int hostB)
        {
           // int hostB = 3;

            int hb1 = 1;
            int hb2 = 2;
            int hb3 = 3;
            int hb4 = 4;
            int hb5 = 5;
            int hb6 = 6;
            int hb7 = 7;
            int hb8 = 8;

             if ( hostB <= hb1 )
            {
                int borrowedB = (8 - hb1);
                return borrowedB;
            }
                else if ( hostB <= hb2 )
                {
                int borrowedB = (8 - hb2);
                return borrowedB;
            }
            else if (hostB <= hb3)
            {
                int borrowedB = (8 - hb3);
                return borrowedB;
            }

            else if (hostB <= hb4)
            {
                int borrowedB = (8 - hb4);
                return borrowedB;
            }


            else if (hostB <= hb5)
            {
                int borrowedB = (8 - hb5);
                return borrowedB;
            }


            else if (hostB <= hb6)
            {
                int borrowedB = (8 - hb6);
                return borrowedB;
            }



            else if (hostB <= hb7)
            {
                int borrowedB = (8 - hb7);
                return borrowedB;
            }


            else if (hostB <= hb8)
            {
                int borrowedB = (8 - hb8);
                return borrowedB;
            }
              
             else

            {
                int borrowedB = 0;
                return borrowedB;
            }

            // SUBNET MUSK


            
        }
            public static int SubnetM (int borr )
        {
            int bflag1 = 128;
            int bflag2 = 192;
            int bflag3 = 224;
            int bflag4 = 240;
            int bflag5 = 248;
            int bflag6 = 252;
            int bflag7 = 254;
            int bflag8 = 255;
           // Convert.ToDecimal(borr);
            if (borr == 1 )
            {
                int submusk = bflag1;
                return submusk;
            }

            else if (borr == 2 )
            {
                int submusk = bflag2;
                return submusk;
            }

            else if (borr == 3)
            {
                int submusk = bflag3;
                return submusk;
            }

            else if (borr == 4)
            {
                int submusk = bflag4;
                return submusk;
            }

            else if (borr == 5)
            {
                int submusk = bflag5;
                return submusk;
            }

            else if (borr == 6)
            {
                int submusk = bflag6;
                return submusk;
            }

            else if (borr == 7)
            {
                int submusk = bflag7;
                return submusk;
            }

            else if (borr == 8)
            {
                int submusk = bflag8;
                return submusk;
            }

            else
            {
                int submusk = 0;
                return submusk;
            }

        }

       /* public static int BlockSize (int submmm )
        {
            int blcckS = 256 - submmm;
            return blcckS;
        }*/



        static void Main(string[] args)
        {
            // int bits;


            Console.WriteLine("--------------| Subnet Calculator v1.0 |----------------");
            Console.WriteLine(" ");
            Console.Write("                  Please enter network name  - " );
            string netName = Console.ReadLine(); 

            Console.Write("                   Enter number of hosts - ");
            int  hosts  =  Convert.ToInt32(Console.ReadLine());



            // Culculate hosts 

            int h1 = 0;
            int h2 = 2;
            int h3 = 6;
            int h4 = 14;
            int h5 = 30;
            int h6 = 62;
            int h7 = 126;
            int h8 = 254;
            int h;
            if (hosts <= h1)
            {
                h = 0;
            }
            else if (hosts <= h2)
            {
                h = 2;
            }
            else if (hosts <= h3)
            {
                h = 3;
            }

            else if (hosts <= h4)
            {
                h = 4;
            }

            else if (hosts <= h5)
            {
                h = 5;
            }

            else if (hosts <= h6)
            {
                h = 6;
            }
            else if (hosts <= h7)
            {
                h = 7;
            }
            else if (hosts <= h8)
            {
                h = 8;

            }
            else h = 0;

            Console.Clear();
                int borr = BorrowedBits(h);
            Console.WriteLine("--------------| Subnet Calculator v1.0 |----------------");
            Console.WriteLine(" ");
            Console.WriteLine("***********| "+ netName + " with " + hosts + " hosts. |***********");

            Console.WriteLine(" ");
            Console.WriteLine("                    Host bits - " + h );
            Console.WriteLine("                Borrowed bits - " + borr );
           // Console.WriteLine("*********************************** ");

            int subnetm = SubnetM(borr);
            int prefixL = borr + 24;
            int blockS;
            blockS = 256 - subnetm ; 

            //Console.WriteLine("                 ");
            Console.WriteLine("                Subnetmask is - 255.255.255." + subnetm );
            Console.WriteLine("                Prefix Length - /" + prefixL);
            Console.WriteLine("                   Block size - " + blockS);
            Console.WriteLine(" ");
            Console.WriteLine("********************************************************");
            Console.WriteLine("------------------|   THANK YOU    |--------------------");
            // Console.WriteLine("--------------| Subnet Calculator v1.0 |----------------");

            //Console.WriteLine
            Console.ReadKey();





        }
    }
}
