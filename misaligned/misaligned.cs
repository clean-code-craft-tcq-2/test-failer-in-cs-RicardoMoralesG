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

           
            //verifi total colors
            Debug.Assert(printData.Count == totalToPrint);
            //validate print data
            Debug.Assert(printColorsValid(printData) == true);


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

            bool printValid = false;

            int j = 0;
            do
            {
                j++;

                if (ColorMinor == printColor[j].minorColor)
                {
                    printValid = true;

                    break;
                }

                ColorMinor = printColor[j].minorColor;

            } while (j < printColor.Count);





            return printValid;
        }
    }
}
