#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper.Newtonsoft
// File Name: NewtonsoftExtensions.cs
// 
// Current Data:
// 2021-07-22 7:43 PM
// 
// Creation Date:
// 2021-07-22 7:42 PM

#endregion

#region usings

using Newtonsoft.Json;

#endregion

namespace PenguinHelper.Newtonsoft.Extensions
{
  /// <summary>
  ///   Extension methods using the <see cref="Newtonsoft" /> package.
  /// </summary>
  public static class NewtonsoftExtensions
  {
    /// <summary>
    ///   Extension method to simplify object serialization.
    ///   Returns JSON formatted <see cref="string" />.
    /// </summary>
    /// <typeparam name="T">
    ///   The object type of <paramref name="serializableObject" /> that will be serialized.
    /// </typeparam>
    /// <param name="serializableObject">
    ///   The object to be serialized.
    /// </param>
    /// <returns>
    ///   Returns a <see cref="string" /> value
    /// </returns>
    public static string SerializeObject<T>(this T serializableObject)
    {
      return JsonConvert.SerializeObject(serializableObject);
    }

    /// <summary>
    ///   Extension method to simplify object deserialization.
    ///   Returns a <typeparamref name="T" /> object.
    /// </summary>
    /// <typeparam name="T">
    ///   The object type of the deserialized object.
    /// </typeparam>
    /// <param name="serializedObj">
    ///   The JSON formatted <see cref="string" /> to deserialize
    /// </param>
    /// <returns>
    ///   Returns the deserialized object of type <typeparamref name="T" />
    /// </returns>
    public static T DeserializeObject<T>(this string serializedObj)
    {
      return JsonConvert.DeserializeObject<T>(serializedObj);
    }
  }
}