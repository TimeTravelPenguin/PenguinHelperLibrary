#region Title Header

// Name: Phillip Smith
// 
// Solution: Amicability
// Project: Amicability
// File Name: ThreadSafeRandom.cs
// 
// Current Data:
// 2021-06-24 9:40 AM
// 
// Creation Date:
// 2021-06-24 9:40 AM

#endregion

#region usings

using System;
using System.Security.Cryptography;
using System.Threading;

#endregion

namespace PenguinHelper.Helper
{
  public static class ThreadSafeRandom
  {
    private static readonly ThreadLocal<Random> Local = new(() =>
    {
      var rngCryptoServiceProvider = new RNGCryptoServiceProvider();

      var buffer = new byte[4];
      rngCryptoServiceProvider.GetBytes(buffer);

      var seed = BitConverter.ToInt32(buffer, 0);
      return new Random(seed);
    });


    public static int Next()
    {
      return Local.Value.Next();
    }

    public static int Next(int min, int max)
    {
      return Local.Value.Next(min, max);
    }

    public static double NextDouble()
    {
      return Local.Value.NextDouble();
    }

    public static double RandomInRange(double inclusiveMin, double exclusiveMax)
    {
      return Local.Value.NextDouble() * (exclusiveMax - inclusiveMin) + inclusiveMin;
    }
  }
}