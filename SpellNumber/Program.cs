using Maersk_kiran;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellNumber
{
   public class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Spell The Number Assessment");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter the Number to Spell or Type 'exit' to Close: ");
            var Numnput= Console.ReadLine();
            //GetSpellTheNumber(Numnput);
            while (Numnput != "exit")
            {
                var speller = NumberToStringConverter.ConvertString2Number(Numnput);
                Console.WriteLine("The Number is: " + speller);
                Numnput = Console.ReadLine();
            }

        }

        //public static string ConvertString2Number(string input)
        //{
        //    string spell = "";
        //    try
        //    {
        //        string[] digits = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine","ten","Eleven",
        //                            "Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventen","Eighteen","Ninteen"};
        //        string[] tens = { "ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
        //        string[] Notations = { "Hundred", "Thousand", "Lakhs", "Crores" };
        //        int[] numbers = {1, 10, 100, 1000, 10000 ,100000 , 1000000,  10000000 };

        //        if (!string.IsNullOrEmpty(input) && input.Length<10)
        //        {
        //            var num = Int32.Parse(input);
                    
        //            while (num.ToString().Length !=0 && num !=0)
        //            {
        //                var numlength = num.ToString().Length;
        //                if (num<20 && num!=0)
        //                {
        //                    spell = spell + " "+digits[num - 1];
        //                    num = 0;
        //                }
        //                else if (numlength==2)
        //                {
        //                    var doubledig = num / 10;
        //                    if(input.Length==2)
        //                    {
        //                        spell = spell + tens[doubledig - 1] + "  " + (((num % 10) > 0) ? (digits[(num - (doubledig * 10) - 1)]) : "");
        //                    }
        //                    else
        //                    {
        //                        spell = spell + " and " + tens[doubledig - 1] + "  " + (((num % 10) > 0) ? (digits[(num - (doubledig * 10) - 1)]) : "");
        //                    }
        //                    num = 0;
        //                }
        //                else if (numlength == 3)
        //                {
        //                    var threes = num / numbers[numlength - 1];
        //                    spell =spell+" "+ digits[threes - 1] + " " + Notations[0]; 
        //                    num -= (threes * numbers[numlength - 1]);
        //                }
        //                else if (numlength == 4)
        //                {
        //                    var fourdig = num / numbers[numlength - 1];
        //                    spell =spell+" "+ digits[fourdig - 1] + " " + Notations[1];
        //                    num -= (fourdig * numbers[numlength - 1]);
        //                }
        //                else if (numlength == 5)
        //                {
        //                    var fivdig = num / numbers[numlength - 2];
        //                    if(fivdig<19)
        //                    {
        //                        spell = spell + " " + digits[fivdig - 1] + " " + Notations[1];
        //                    }
        //                    else
        //                    {
        //                        var depf = fivdig / 10;
        //                        spell = spell + " " + tens[depf - 1] + "  " + (((fivdig % 10) > 0) ? (digits[(fivdig - (depf * 10) - 1)]) : "") + " " + Notations[1];
        //                    }
                           
        //                    num -= (fivdig * numbers[numlength - 2]);
        //                }
        //                else if (numlength == 6)
        //                {
        //                    var sixdig = num / numbers[numlength - 1];
        //                    spell =spell+" "+ digits[sixdig - 1] + " " + Notations[2];
        //                    num -= (sixdig * numbers[numlength - 1]);
        //                }
        //                else if (numlength == 7)
        //                {
        //                    var sevendig = num / numbers[numlength - 2];
        //                    //spell =spell+" "+ tens[sevendig - 1] + " " + digits[(num - (sevendig * 10))] + " " + Notations[2];
        //                    if (sevendig < 19)
        //                    {
        //                        spell = spell + " " + digits[sevendig - 1] + " " + Notations[2];
        //                    }
        //                    else
        //                    {
        //                        var depf = sevendig / 10;
        //                        spell = spell + " " + tens[depf - 1] + "  " + (((sevendig % 10) > 0) ? (digits[(sevendig - (depf * 10) - 1)]) : "") + " " + Notations[2];
        //                    }
        //                    num -= (sevendig * numbers[numlength - 2]);
        //                }
        //                else if (numlength == 8)
        //                {
        //                    var eightdig = num / numbers[numlength - 1];
        //                    spell =spell +" "+ digits[eightdig - 1] + " " + Notations[3];
        //                    num -= (eightdig * numbers[numlength - 1]);
        //                }
        //                else if (numlength == 9)
        //                {
        //                    var ninedig = num / numbers[numlength - 2];
        //                    //spell = tens[ninedig - 1] + " " + digits[(num - (ninedig * 10))] + " " + Notations[3];
        //                    if (ninedig < 19)
        //                    {
        //                        spell = spell + " " + digits[ninedig - 1] + " " + Notations[3];
        //                    }
        //                    else
        //                    {
        //                        var depf = ninedig / 10;
        //                        spell = spell + " " + tens[depf - 1] + "  " + (((ninedig % 10) > 0) ? (digits[(ninedig - (depf * 10) - 1)]) : "") + " " + Notations[3];
        //                    }
        //                    num -= (ninedig * numbers[numlength - 2]);
        //                }
        //                else 
        //                {

        //                    spell = "!... Number out of the Box";
        //                    num = 0;
        //                }
        //            }


        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //
        //        Console.WriteLine("Sorry ! Invalid number  or number is too big.");
        //    }
        //    spell = spell.Replace("  ", " ");
        //    return spell;
        //}
      }
}
