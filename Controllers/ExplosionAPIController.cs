using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionAPIController : ControllerBase
    {
        [HttpGet("{word}")]
        public string Process(string word)
        {
            char[] reverseString = word.ToCharArray();
            Array.Reverse(reverseString);
            return new string(reverseString);
        }


    }
}
// public class ExplosionAPIController : ControllerBase
// {
//     [HttpGet("{word")]
//     {

//     public string Process(string word)
//     for (var i = 0; i < s.Length; i++)
//     {
//         var numChar = s[i].ToString();
//         var num = Int32.Parse(numChar);
//         for (var j = 0; j < num; j++)
//         {
//             answer = answer + numChar;
//         }
//     }
//     return answer;
//     }
// }

//     public class Accumul 
// {
// 	public static String Accum(string s) 
//   {
//     var accumStr = "";
//     var charList = new List<char>(s);
//     for (var i = 0; i < charList.Count; i++)
//       {
//       for (var j = 0; j <= i; j++){
//         if (j == 0)
//           {
//           accumStr += char.ToUpper(charList[i]);
//           }
//         else
//           {
//           accumStr += char.ToLower(charList[i]);
//           }
//       }
//       if (i != charList.Count -1)
//         {
//         accumStr += "-";
//         }
//     }
//     return accumStr;
//   }
// }
// dotnet aspnet-codegenerator controller -api -name mumblingController --relativeFolderPath Controllers