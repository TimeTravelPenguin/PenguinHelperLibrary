#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper.Demos
// File Name: FactoryDemo.cs
// 
// Current Data:
// 2021-07-22 7:54 PM
// 
// Creation Date:
// 2020-04-25 1:31 PM

#endregion

#region usings

using System;
using PenguinHelper.Demos.Factory.Objects;

#endregion

namespace PenguinHelper.Demos.Factory
{
  /// <summary>
  ///   Demo showing how to use the generic factory, including how to register own objects to the factory.
  /// </summary>
  public static class FactoryDemo
  {
    // Private class separate to factory defaults
    private class Bird : IAnimal
    {
      public string GetSound()
      {
        return "Tweet";
      }
    }

    /// <summary>
    ///   Create an IAnimal with a method called Sound() which performs a different action dependent on the class (dog, cat,
    ///   etc)
    /// </summary>
    public static void RunDemo()
    {
      // Create factory
      var animalFactory = new AnimalFactory();

      // Create default objects
      var dog = animalFactory.Create(Animals.Dog);
      var cat = animalFactory.Create(Animals.Cat);

      // Register new object and then create it
      animalFactory.Register("Bird", () => new Bird());
      var bird = animalFactory.Create("Bird");

      // Use IAnimal Interface to test
      foreach (var animal in new[] {dog, cat, bird})
      {
        Console.WriteLine(animal.GetSound());
      }
    }
  }
}