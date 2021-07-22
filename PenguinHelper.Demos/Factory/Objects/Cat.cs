#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Demos
// File Name: Cat.cs
// 
// Current Data:
// 2019-12-30 5:51 PM
// 
// Creation Date:
// 2019-12-30 5:51 PM

#endregion

namespace PenguinHelper.Demos.Factory.Objects
{
  internal class Cat : IAnimal
  {
    public string GetSound()
    {
      return "Meow";
    }
  }
}