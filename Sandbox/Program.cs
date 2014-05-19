using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Sandbox.user;

namespace Sandbox {
   class Program {
      static void Main(string[] args) {
         Test();
         Console.ReadLine();
      }

      private static async void Test() {
         
         var client = new HttpClient();
         var data = await client.GetByteArrayAsync("http://beta.toteswishlist.com/profilePhotos/user_1.png");
         var temp = data;
      }
   }
}
