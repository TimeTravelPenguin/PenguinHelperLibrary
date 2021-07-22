#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper.Demos
// File Name: AnimalFactory.cs
// 
// Current Data:
// 2021-07-22 7:54 PM
// 
// Creation Date:
// 2020-04-25 1:30 PM

#endregion

#region usings

using System;
using System.Collections.Generic;
using PenguinHelper.Demos.Factory.Objects;
using PenguinHelper.Patterns.GenericFactory;

#endregion

namespace PenguinHelper.Demos.Factory
{
  /// <summary>
  ///   A demo factory containing two default objects in the Registry
  /// </summary>
  internal class AnimalFactory : FactoryBase<IAnimal>
  {
    protected override IDictionary<string, Func<IAnimal>> Registry { get; }

    public AnimalFactory()
    {
      // Registers default items
      Registry = new Dictionary<string, Func<IAnimal>>
      {
        [Animals.Dog] = () => new Dog(),
        [Animals.Cat] = () => new Cat()
      };
    }
  }
}