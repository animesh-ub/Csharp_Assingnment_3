using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignment3
{

    class ElectrictyBill
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Consumer ID");
            int consumerID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Consumer Name");
            string consumerName = Console.ReadLine();
            Console.WriteLine("Enter Unit Consumed");
            int unitConsumed = int.Parse(Console.ReadLine());

            double chargePerUnit;

            if (unitConsumed >= 199) 
            {
                chargePerUnit = 1.20;
            }
            else if( unitConsumed >=200 &&  unitConsumed < 400)
            {
                chargePerUnit = 1.50;
            }
            else if(unitConsumed >= 400 &&  unitConsumed < 600)
            {
                chargePerUnit = 1.80;
            }
            else
            {
                chargePerUnit = 2.00;
            }

            double totalBill = unitConsumed * chargePerUnit;

           

            double netTotalBill;


            double surcharge;

            if (totalBill >= 400)
            {
                surcharge = totalBill * 0.15;
                netTotalBill = totalBill + surcharge;
            }
            else
            {
                surcharge = 0;
                netTotalBill = totalBill;
            }

            Console.WriteLine("Customer IDNO :" + consumerID);
            Console.WriteLine("Customer Name :" + consumerName);
            Console.WriteLine("Unit Consumed :" +  unitConsumed);
            Console.WriteLine($"Amount charges @Rs.{chargePerUnit} per unit : {totalBill}");
            Console.WriteLine("Surcharge Amount :" + surcharge);
            Console.WriteLine("Net Amount Paid By the Coustomer :" +  netTotalBill);

            
  
        }

        


    }





}
