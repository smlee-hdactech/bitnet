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
      //Console.WriteLine(p);

      var p1 = bc.GetBlockchainParams();
      //Console.WriteLine(p1);

      //Console.WriteLine(p1["address-pubkeyhash-version"]);
      //Console.WriteLine(p1["address-scripthash-version"]);
      //Console.WriteLine(p1["address-checksum-value"]);
      //Console.WriteLine(p1["private-key-version"]);

      var p2 = bc.ListUnspent("1WCRNaPb3jAjb4GE9t34uLiLtPseA8JKEvdtg5"); 
      Console.WriteLine("listunspent result : {0}", p2);

      var p3 = bc.ListStreams("stream9");
      Console.WriteLine("liststreams result : {0}", p3);

      var p4 = bc.SignMessage("V6UF7ajLq1kRHXjHMftMBaZ6VgsB2XoQdUnFesRK8BrxDdQsXAxUckNj",
                          "Hdac Technology, Solution Dev Team, Test Text.");
      Console.WriteLine("signmessage result : {0}", p4);

      var p5 = bc.VerifyMessage("18kt4KV2hVzKQKMCmwSd6KS9a72bbSxe7YN6NR",
                          "IDL0eekwkEURPeoNJOMdry1N8nmS2YrcS6no/Mnjs1pmB5G756arYY9rN8h2++K5IPxIEObk610/nTvEVtk4m1s=",
                          "Hdac Technology, Solution Dev Team, Test Text.");
      Console.WriteLine("verifymessage result : {0}", p5);

      var p6 = bc.LockUnspents(false, "f7c5e50d7673fbfc56de3ea3ac09e35868c6b992a2ad7bc4421aad60e6fbf66f", 0);
      Console.WriteLine("lockunspent : {0}", p6);

      var p7 = bc.ListLockUnspent();
      Console.WriteLine("listlockunspent result : {0}", p7);

      var p8 = bc.ListAssets("ass1");
      Console.WriteLine("listassets result : {0}", p8);

      //Console.WriteLine("엔터키를 누르십시오");
      //int code = Console.Read();
    }
  }
}