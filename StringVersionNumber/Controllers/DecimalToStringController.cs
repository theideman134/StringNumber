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
    public class DecimalToStringController : ControllerBase
    {

        [HttpGet("{numberString}")]
        public string Get(string numberString)
        {
            string numberStringTemp = RemoveSpecialCharacters(numberString);
            string result = String.Empty;

            int padding = 3 - (numberStringTemp.Length % 3);

            if(padding < 3)
            {
                numberStringTemp = numberStringTemp.PadLeft(numberStringTemp.Length + padding, '0');
            }

            if (numberStringTemp == "000")
                return "zero";

            //Trillion
            if (numberStringTemp.Length > 12)
            {
                result += GetHundredString(numberStringTemp, "trillion");
                numberStringTemp = numberStringTemp.Remove(0, 3);
            }
            //Billion
           if (numberStringTemp.Length > 9)
           {
                result += GetHundredString(numberStringTemp, "billion");
                numberStringTemp = numberStringTemp.Remove(0, 3);
            }
            //Million
            if (numberStringTemp.Length > 6)
            {
                result += GetHundredString(numberStringTemp, "million");
                numberStringTemp = numberStringTemp.Remove(0, 3);
            }
            
            //Thousand
           if (numberStringTemp.Length > 3)
           {

                result += GetHundredString(numberStringTemp, "thousand");
                numberStringTemp = numberStringTemp.Remove(0, 3);
            }
   
            //hundreds
            if (numberStringTemp.Length > 0)
           {
                result += GetHundredString(numberStringTemp, string.Empty);
            }

            result = result.Trim();

            return result;
        }

        public string GetHundredString(string numberString,string numberSuffix)
        {
           string numberStringTemp = numberString.Substring(0, 3);
            numberString = numberString.Remove(0, 3);


            decimal numberDecimal = 0;

            try
            {
                numberDecimal = Convert.ToDecimal(numberStringTemp);
            }
            catch (Exception ex)
            {

            }
            if (numberDecimal == 0M)
                return string.Empty;
            else
                return $"{HundredsString(numberDecimal)} {numberSuffix}";

        }

        private string RemoveSpecialCharacters(string numberString)
        {
            if (String.IsNullOrEmpty(numberString))
                return null;

            string numberStringTemp = numberString;

            numberStringTemp = numberString.Replace(",", "");

            return numberStringTemp;

        }

        public string HundredsString(decimal hundreds)
        {
            decimal hundredTemp = hundreds;

            if (0M > hundredTemp || hundredTemp > 999M)
            {
                return String.Empty;
            }

            string hundredString = String.Empty;

            if (hundreds >= 100M)
            {
                int hundredValue = (int)hundredTemp / 100;


                hundredString += $" {Ones(hundredValue)} hundred";

                hundredTemp = (int)hundredTemp % 100;
            }

            if (hundredTemp >= 20)
            {
                int tensvalue = ((int)hundredTemp / 10) * 10;
                hundredString += $" {Tens(tensvalue)}";
                hundredTemp = (int)hundredTemp % 10;
                if (hundredTemp > 0)
                {
                    hundredString += $"-{Ones(hundredTemp)}";
                    hundredTemp = 0;
                }
            }
            if (hundredTemp > 0)
            {
                hundredString += $" {Ones(hundredTemp)}";
            }

       //     hundredString = FormatString(hundredString);

            return hundredString;

        }

        public string FormatString(string hundredString)
        {
            hundredString = hundredString.Trim();
            return hundredString;
        }

        public string Ones(decimal ones)
        {
            switch (ones)
            {
                case 1M:
                    return "one";
                case 2M:
                    return "two";
                case 3M:
                    return "three";
                case 4M:
                    return "four";
                case 5M:
                    return "five";
                case 6M:
                    return "six";
                case 7M:
                    return "seven";
                case 8M:
                    return "eight";
                case 9M:
                    return "nine";
                case 10M:
                    return "ten";
                case 11M:
                    return "eleven";
                case 12M:
                    return "twelve";
                case 13M:
                    return "thirteen";
                case 14M:
                    return "fourteen";
                case 15M:
                    return "fifteen";
                case 16M:
                    return "sixteen";
                case 17M:
                    return "seventeen";
                case 18M:
                    return "eighteen";
                case 19M:
                    return "nineteen";
                default:
                    return string.Empty;
            }
        }

        public string Tens(decimal ones)
        {
            switch (ones)
            {
                case 20M:
                    return "twenty";
                case 30M:
                    return "thirty";
                case 40M:
                    return "forty";
                case 50M:
                    return "fifty";
                case 60M:
                    return "sixty";
                case 70M:
                    return "seventy";
                case 80M:
                    return "eighty";
                case 90M:
                    return "ninety";
                default:
                    return string.Empty;
            }
        }
    }
}