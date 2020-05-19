using Maersk_kiran;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace SpellNumber.Test
{
    [TestClass]
    public class SpellNumberTestCases
    {
        [TestMethod]
        public void ConvertString2Number_OneDigit_ReturnString()
        {
            var input = "8";
            var expectOutput = "Eight";
            var ActualOutput= NumberToStringConverter.ConvertString2Number(input);
            Assert.AreEqual(expectOutput.Trim().ToLower().ToString(), ActualOutput.Trim().ToLower().ToString());
            //return true;
        }
        [TestMethod]
        public void ConvertString2Number_TwoDigit_ReturnString()
        {
            var input = "21";
            var expectOutput = "Twenty One";
            var ActualOutput = NumberToStringConverter.ConvertString2Number(input);
            Assert.AreEqual(expectOutput.Trim().ToLower().ToString(), ActualOutput.Trim().ToLower().ToString());
            //return true;
        }
        [TestMethod]
        public void ConvertString2Number_ThreeDigit_ReturnString()
        {
            var input = "435";
            var expectOutput = "Four Hundred and thirty five";
            var ActualOutput = NumberToStringConverter.ConvertString2Number(input);
            Assert.AreEqual(expectOutput.Trim().ToLower().ToString(), ActualOutput.Trim().ToLower().ToString());
            //return true;
        }
        [TestMethod]
        public void ConvertString2Number_FourDigit_ReturnString()
        {
            var input = "4037";
            var expectOutput = "Four Thousand and thirty seven";
            var ActualOutput = NumberToStringConverter.ConvertString2Number(input);
            Assert.AreEqual(expectOutput.Trim().ToLower().ToString(), ActualOutput.Trim().ToLower().ToString());
            //return true;
        }
        [TestMethod]
        public void ConvertString2Number_FiveDigit_ReturnString()
        {
            var input = "45759";
            var expectOutput = "fourty five thousand seven hundred and fifty nine";
            var ActualOutput = NumberToStringConverter.ConvertString2Number(input);
            Assert.AreEqual(expectOutput.Trim().ToLower().ToString(), ActualOutput.Trim().ToLower().ToString());
            //return true;
        }
        [TestMethod]
        public void ConvertString2Number_SixDigit_ReturnString()
        {
            var input = "245869";
            var expectOutput = "two lakhs fourty five thousand eight hundred and sixty nine";
            var ActualOutput = NumberToStringConverter.ConvertString2Number(input);
            Assert.AreEqual(expectOutput.Trim().ToLower().ToString(), ActualOutput.Trim().ToLower().ToString());
            //return true;
        }
        [TestMethod]
        public void ConvertString2Number_SevenDigit_ReturnString()
        {
            var input = "2645800";
            var expectOutput = "twenty six lakhs fourty five thousand eight hundred";
            var ActualOutput = NumberToStringConverter.ConvertString2Number(input);
            Assert.AreEqual(expectOutput.Trim().ToLower().ToString(), ActualOutput.Trim().ToLower().ToString());
            //return true;
        }

        [TestMethod]
        public void ConvertString2Number_EightDigit_ReturnString()
        {
            var input = "52645800";
            var expectOutput = "five crores twenty six lakhs fourty five thousand eight hundred";
            var ActualOutput = NumberToStringConverter.ConvertString2Number(input);
            Assert.AreEqual(expectOutput.Trim().ToLower().ToString(), ActualOutput.Trim().ToLower().ToString());
            //return true;
        }
        [TestMethod]
        public void ConvertString2Number_NineDigit_ReturnString()
        {
            var input = "452645800";
            var expectOutput = "fourty five crores twenty six lakhs fourty five thousand eight hundred";
            var ActualOutput = NumberToStringConverter.ConvertString2Number(input);
            Assert.AreEqual(expectOutput.Trim().ToLower().ToString(), ActualOutput.Trim().ToLower().ToString());
            //return true;
        }

        [TestMethod]
        public void ConvertString2Number_OutBoxDigit_ReturnString()
        {
            var input = "452645800565644";
            var expectOutput = "out of the Box";
            var ActualOutput = NumberToStringConverter.ConvertString2Number(input);
            Assert.AreEqual(expectOutput.Trim().ToLower().ToString(), ActualOutput.Trim().ToLower().ToString());
            //return true;
        }

        [TestMethod]
        public void ConvertString2Number_NonNumberDigit_ReturnString()
        {
            var input = "v5gd4fg";
            var expectOutput = "Invalid number";
            var ActualOutput = NumberToStringConverter.ConvertString2Number(input);
            Assert.AreEqual(expectOutput.Trim().ToLower().ToString(), ActualOutput.Trim().ToLower().ToString());
            //return true;
        }

        
    }
}
