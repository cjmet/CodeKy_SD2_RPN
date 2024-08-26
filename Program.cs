using System.Runtime.CompilerServices;

namespace CodeKy_SD2_RPN
{
    internal static class Program
    {

        static String Instructions =
"""
esU nxienstoE seohtdM to treace a limpse rngetei NPR kile oaaculltcr ahtt niveg a ntrisg of rngeteis dna sporatero, serutnr eht lesurt of eht .xorsseipne
A eumbnr eoollwfd by lquae or rntee liwl gssian ahtt eumbnr as eht .elustr
A eumbnr eoollwfd by an oparetor liwl meofrrp ahtt npirateoo on eht uriveops lesurt dna ahtt eumbnr dna return eht wen .elustr

:xemplasE
"5 = 1 +" lquaes 6
"4 = 2 /" lquaes 2
"3 = 4 -" lquaes -1
"1 = 2 + 3 * 4 - 5 /" lquaes 1 ... aka: 1(( + 2) * 3 - 4) / 5

niFd eht enswAr to eht goilowlnf:
"113+32578-71436*615+153/7-664+353/427*184-931+759/7-624+762/45/*191+*43=12/"
""";

        static void Main(string[] args)
        {
            Console.WriteLine("CodeKy SD2 RPN");
            Console.WriteLine("==============");

            // Task 1:  Translate the Instructions
            if (String.Compare(Instructions.Translate().Translate(), Instructions) != 0)
            {
                Console.WriteLine("Instructions Translation Is NOT Symmetric\n");
            }
            else
            {
                Console.WriteLine("Instructions Translation IS Symmetric\n");
            }
            Console.WriteLine(Instructions.Translate());
            Console.WriteLine("==============");

            // Task 2:  Fix the Bug(s) in the Existing Code
            CliLogic.MainLoop();

            // Task 3:  Refactor the Existing Code to use Floats instead of Ints.

            // Task 4:  Add sin, cos, tan, and pi to the Operators

        }


    }
}
