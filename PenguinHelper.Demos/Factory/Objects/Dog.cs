#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Demos
// File Name: Dog.cs
// 
// Current Data:
// 2019-12-30 5:51 PM
// 
// Creation Date:
// 2019-12-30 5:51 PM

#endregion

namespace PenguinHelperLibrary.Demos.Factory.Objects
{
  internal class Dog : IAnimal
  {
    public string GetSound()
    {
      return "Woof";
    }
  }
}