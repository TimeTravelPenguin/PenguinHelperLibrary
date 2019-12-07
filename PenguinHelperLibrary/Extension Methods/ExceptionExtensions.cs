#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: ExceptionExtensions.cs
// 
// Current Data:
// 2019-12-07 2:38 PM
// 
// Creation Date:
// 2019-12-07 2:18 PM

#endregion

using System;

namespace PenguinHelperLibrary.Extension_Methods
{
    public static class ExceptionExtensions
    {
        public static void TryOrThrow(this Action action, Exception ex)
        {
            try
            {
                action.Invoke();
            }
            catch
            {
                throw ex;
            }
        }
    }
}