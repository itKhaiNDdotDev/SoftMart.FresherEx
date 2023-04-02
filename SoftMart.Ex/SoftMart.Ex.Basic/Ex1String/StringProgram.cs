using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic.Ex1String
{
    /// <summary>
    /// Triển khai các thực thi theo yêu cầu của mục 1.1 String
    /// </summary>
    /// Author: KhaiND (29/03/2023)
    public class StringProgram
    {
        /// <summary>
        /// Gọi các method tương ứng để thực hiện các yêu cầu mục 1.1 lên Console
        /// </summary>
        /// Author: KhaiND (29/03/2023)
        public static void RunConsole()
        {
            //======================================== TASK 1 to 6:
            string iputString = "";

            iputString = StringHandle.InputString();

            string outputString = "";

            // Task 1
            outputString = StringHandle.CheckInput(iputString);
            //Ex1String.OutputString(outputString);

            // Task 2
            //outputString = Ex1String.RemoveSpaceHeadLast(outputString);

            // Task 3
            //outputString = Ex1String.RemoveAllSpace(outputString);

            // Task 4
            outputString = StringHandle.FormatUpperBehindSpace(outputString);
            StringHandle.OutputString(outputString);

            // Task 5
            //Ex1String.CountSpace(outputString);

            // Task 6
            StringHandle.CountLetter(outputString);

            //=============================================TASK 7 and 8
            Console.WriteLine();
            string input1 = StringHandle.InputString();
            string input2 = StringHandle.InputString();
            //Ex1String.CompareStringTight(input1, input2);
            StringHandle.CompareStringLoose(input1, input2);

            // ================================ TASK 9 to 14:
            // Task 9
            Console.WriteLine();
            outputString = StringHandle.ReplaceABCToDEF(outputString);
            StringHandle.OutputString(outputString);

            // Task 10
            outputString = StringHandle.SayGoodToCustomer(outputString);
            StringHandle.OutputString(outputString);

            // Task 11
            outputString = StringHandle.ReverseString(outputString);
            StringHandle.OutputString(outputString);

            // Task 12, 13, 14
            int count = Convert.ToInt32(Console.ReadLine());
            if (count < 0)
            {
                Console.WriteLine("Số nhỏ hơn 0");
            }
            else
            {
                //12: Giống 13 nhưng khoảng trắng bỏ đầu ko bỏ cuối
                outputString = StringHandle.RemoveSpaceHead(outputString);
                outputString = StringHandle.GetFirstCountChar(outputString, count);
                Console.WriteLine(outputString);
                //13
                outputString = StringHandle.RemoveSpaceHeadLast(outputString);
                outputString = StringHandle.GetFirstCountChar(outputString, count);
                Console.WriteLine(outputString);
                Console.WriteLine("-----------");
                //14
                outputString = StringHandle.GetLastCountChar(outputString, count);
                Console.WriteLine(outputString);
                Console.WriteLine("============");
            }
        }
    }
}
