#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Demos
// File Name: AnimalFactory.cs
// 
// Current Data:
// 2019-12-30 6:04 PM
// 
// Creation Date:
// 2019-12-30 5:38 PM

#endregion

using System;
using System.Collections.Generic;
using PenguinHelperLibrary.Demos.Factory.Objects;
using PenguinHelperLibrary.Generic_Factory;

namespace PenguinHelperLibrary.Demos.Factory
{
  /// <summary>
  ///   A demo factory containing two default objects in the Registry
  /// </summary>
  internal class AnimalFactory : FactoryBase<IAnimal>
  {
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