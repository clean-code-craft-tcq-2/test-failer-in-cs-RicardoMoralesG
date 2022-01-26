using misaligned;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {

       
        static void Main(string[] args) {

            List<PrintColor> printData = printColorsMap();

            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };

            int totalToPrint = majorColors.Length * minorColors.Length;

           
            //Check  alignment 
            Debug.Assert(printData[0].print.Length == printData[totalToPrint - 1].print.Length);
            //verifi total colors
            Debug.Assert(printData.Count == totalToPrint);
            //validate print data
            Debug.Assert(printColorsValid(printData));

            Console.WriteLine("All is well (maybe!)");
        }



       

        static List<PrintColor> printColorsMap()
        {

            List<PrintColor> listColorsPrinted = new List<PrintColor>();

            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
            int i = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {

                    listColorsPrinted.Add(
                        new PrintColor
                        {
                            majorColor = majorColors[i],
                            minorColor = minorColors[i],
                            print = String.Format("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[i])

                        });
                    Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[i]);
                }
            }
            return listColorsPrinted;
        }


        static bool printColorsValid(List<PrintColor> printColor)
        {
            string ColorMinor = "";

            bool printValid = true;

            int l = 0;
            do
            {
                l++;

                if (ColorMinor == printColor[l].minorColor)
                {
                    printValid = false;

                    break;
                }

                ColorMinor = printColor[l].minorColor;

            } while (l < printColor.Count);


           

            return printValid;
        }
    }
}
