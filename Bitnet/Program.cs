// COPYRIGHT 2011 Konstantin Ineshin, Irkutsk, Russia.
// If you like this project please donate BTC 18TdCC4TwGN7PHyuRAm8XV88gcCmAHqGNs

using System;
using System.Collections;
using System.Net;
using System.Text;
using System.IO;

using Bitnet.Client;

namespace Bitnet
{
  internal sealed class Program  
  {
    [STAThread]
    static void Main()
    {
      BitnetClient bc = new BitnetClient("http://13.125.145.98:4260");
      bc.Credentials = new NetworkCredential("hdacrpc", "1234");
      var p = bc.GetDifficulty();
      Console.WriteLine(p);

      var p1 = bc.GetBlockchainParams();
      Console.WriteLine(p1);

      Console.WriteLine(p1["address-pubkeyhash-version"]);
      Console.WriteLine(p1["address-scripthash-version"]);
      Console.WriteLine(p1["address-checksum-value"]);
      Console.WriteLine(p1["private-key-version"]);

      Console.WriteLine("엔터키를 누르십시오");
      int code = Console.Read();
    }
  }
}