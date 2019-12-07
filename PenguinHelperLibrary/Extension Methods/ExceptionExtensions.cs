#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: ExceptionExtensions.cs
// 
// Current Data:
// 2019-12-07 5:07 PM
// 
// Creation Date:
// 2019-12-07 3:05 PM

#endregion

using System;

namespace PenguinHelperLibrary.Extension_Methods
{
    /// <summary>
    ///     Extension methods to extend <see cref="Exception" /> functionality
    /// </summary>
    public static class ExceptionExtensions
    {
        /// <summary>
        ///     Attempts to Invoke an <see cref="Action" />. If it fails, it throws exception <typeparamref name="TException" />.
        /// </summary>
        /// <typeparam name="TException">
        ///     The exception to throw if the <see cref="Action" /> fails.
        /// </typeparam>
        /// <param name="action">
        ///     The <see cref="Action" /> to try.
        /// </param>
        /// <param name="ex">
        ///     The <typeparamref name="TException" /> to throw if <paramref name="action" /> fails.
        /// </param>
        public static void TryOrThrow<TException>(this Action action, TException ex) where TException : Exception
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