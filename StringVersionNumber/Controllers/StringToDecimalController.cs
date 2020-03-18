using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StringVersionNumber.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringToDecimalController : ControllerBase
    {
        [HttpGet("{stringNum}")]
        public string Get(string stringNum)
        {

            int[] intArray = new int[6];

            //trillion
            //intArray[0]
            //billion
            //intArray[1]
            //million
            //intArray[2]
            //thousand
            // intArray[3]
            // hundreds
            //intArray[4]
            // cents
            // intArray[5]

            return string.Empty;
        }

        public int HundredStringtoInt(string hundred)
        {
            int hundredInt = 0;

            if (string.IsNullOrEmpty(hundred))
                return 0;

            if (hundred.Contains("hundred"))
            {
                string[] hundredValues = hundred.Split("hundred");

                if (hundredValues.Length == 1)
                {
                    hundredInt = StringtoInt(hundredValues[0].Trim()) * 100;
                }
                if (hundredValues.Length == 2)
                {
                    hundredInt = StringtoInt(hundredValues[0].Trim()) * 100 + StringTenstoInt(hundredValues[1].Trim());
                }
            }
            else
            {
                hundredInt = StringtoInt(hundred.Trim());
            }

            return hundredInt;
        }

        public int StringTenstoInt(string tenString)
        {
            if (string.IsNullOrEmpty(tenString))
                return 0;

            if(tenString.Contains("-"))
            {
                string[] tensOnesSplit = tenString.Split("-");
                if (tensOnesSplit.Length >= 2)
                    return StringtoInt(tensOnesSplit[0].Trim()) + StringtoInt(tensOnesSplit[1].Trim());
                else if (tensOnesSplit.Length == 1)
                    return StringtoInt(tensOnesSplit[0].Trim());
                else
                    return 0;
            }

            else
            {
                return StringtoInt(tenString.Trim());
            }
        }

        public int StringtoInt(string ones)
        {
            switch(ones)
            {
                case "zero": return 0; 
                case "one": return 1;
                case "two": return 2;
                case "three": return 3;
                case "four": return 4;
                case "five": return 5;
                case "six": return 6;
                case "seven": return 7;
                case "eight": return 8;
                case "nine": return 9;
                case "ten": return 10;
                case "eleven": return 11;
                case "twelve": return 12;
                case "thirteen": return 13;
                case "fourteen": return 14;
                case "fifteen": return 15;
                case "sixteen": return 16;
                case "seventeen": return 17;
                case "eightteen": return 18;
                case "nineteen": return 19;
                case "twenty": return 20;
                case "thirty": return 30;
                case "forty": return 40;
                case "fifty": return 50;
                case "sixty": return 60;
                case "seventy": return 70;
                case "eighty": return 80;
                case "ninety": return 90;
                default: return 0;
            }
        }

    }
}