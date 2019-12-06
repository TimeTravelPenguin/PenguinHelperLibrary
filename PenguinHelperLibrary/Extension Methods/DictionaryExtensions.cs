using System.Collections;
using System.Collections.Generic;

namespace PenguinHelperLibrary.Extension_Methods
{
    /// <summary>
    ///     Extension methods for type <see cref="IDictionary" />
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        ///     Returns a <typeparamref name="TValue" /> within an <see cref="IDictionary{TKey,TValue}" />, given a
        ///     <typeparamref name="TKey" /> <paramref name="key" />. If the <typeparamref name="TKey" /> does not exist, the
        ///     returned
        ///     value is the <see langword="default" /> value of <typeparamref name="TValue" />.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary">The <see cref="IDictionary" /> value to get a value.</param>
        /// <param name="key">
        ///     The <typeparamref name="TKey" /> key value of a <see cref="KeyValuePair{TKey,TValue}" /> within
        ///     <paramref name="dictionary" />.
        /// </param>
        /// <returns>
        ///     Returns a <typeparamref name="TValue" /> value paired with <paramref name="key" />, if <paramref name="key" />
        ///     exists. Otherwise, returns the default type of <typeparamref name="TValue" />.
        /// </returns>
        public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            dictionary.TryGetValue(key, out var result);

            return result;
        }

        /// <summary>
        ///     Returns a <typeparamref name="TValue" /> within an <see cref="IDictionary{TKey,TValue}" />, given a
        ///     <typeparamref name="TKey" /> <paramref name="key" />. If the <typeparamref name="TKey" /> does not exist, the
        ///     returned
        ///     value is <paramref name="defaultValue" />.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary">The <see cref="IDictionary" /> value to get a value.</param>
        /// <param name="key">
        ///     The <typeparamref name="TKey" /> key value of a <see cref="KeyValuePair{TKey,TValue}" /> within
        ///     <paramref name="dictionary" />.
        /// </param>
        /// <param name="defaultValue">
        ///     The <typeparamref name="TValue" /> to return if the <see cref="IDictionary" /> does not contain the
        ///     <paramref name="TKey" /> <paramref name="key" />.
        /// </param>
        /// <returns>
        ///     Returns a <typeparamref name="TValue" /> value paired with <paramref name="key" />, if <paramref name="key" />
        ///     exists. Otherwise, returns <paramref name="defaultValue" />.
        /// </returns>
        public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key,
            TValue defaultValue)
        {
            if (!dictionary.TryGetValue(key, out var result))
            {
                result = defaultValue;
            }

            return result;
        }

        /// <summary>
        ///     Adds a <see cref="KeyValuePair{TKey,TValue}" /> to an <see cref="IDictionary{TKey, TValue}" />.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary">
        ///     The <see cref="IDictionary{TKey,TValue}" /> to add to.
        /// </param>
        /// <param name="keyValuePair">
        ///     The <see cref="KeyValuePair{TKey,TValue}" /> to add.
        /// </param>
        public static void AddKeyValuePair<TKey, TValue>(this IDictionary<TKey, TValue> dictionary,
            KeyValuePair<TKey, TValue> keyValuePair)
        {
            dictionary.Add(keyValuePair.Key, keyValuePair.Value);
        }
    }
}