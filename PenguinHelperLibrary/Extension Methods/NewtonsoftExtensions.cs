#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: NewtonsoftExtensions.cs
// 
// Current Data:
// 2019-12-30 11:23 PM
// 
// Creation Date:
// 2019-12-30 6:38 PM

#endregion

using Newtonsoft.Json;

namespace PenguinHelperLibrary.Extension_Methods
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