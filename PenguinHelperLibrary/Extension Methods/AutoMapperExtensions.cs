#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: AutoMapperExtensions.cs
// 
// Current Data:
// 2019-12-08 2:04 AM
// 
// Creation Date:
// 2019-12-08 12:27 AM

#endregion

using AutoMapper;

namespace PenguinHelperLibrary.Extension_Methods
{
    /// <summary>
    ///     Extension methods for <see cref="AutoMapper" />.
    /// </summary>
    public static class AutoMapperExtensions
    {
        /// <summary>
        ///     Maps <paramref name="source" /> to a new object of type <typeparamref name="TDestination" />.
        /// </summary>
        /// <typeparam name="TSource">
        ///     The type of <paramref name="source" />.
        /// </typeparam>
        /// <typeparam name="TDestination">
        ///     The type to map <paramref name="source" /> to.
        /// </typeparam>
        /// <param name="source">
        ///     A <typeparamref name="TSource" /> containing data to be mapped to <typeparamref name="TDestination" />.
        /// </param>
        /// <returns></returns>
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
            where TSource : class
            where TDestination : class
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<TSource, TDestination>(); });

            var iMapper = config.CreateMapper();
            return iMapper.Map<TSource, TDestination>(source);
        }
    }
}