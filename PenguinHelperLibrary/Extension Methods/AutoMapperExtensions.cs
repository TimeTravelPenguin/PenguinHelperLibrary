#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: AutoMapperExtensions.cs
// 
// Current Data:
// 2019-12-08 12:56 AM
// 
// Creation Date:
// 2019-12-08 12:27 AM

#endregion

using AutoMapper;

namespace PenguinHelperLibrary.Extension_Methods
{
    public static class AutoMapperExtensions
    {
        public static TDestination MapTo<TDestination, TSource>(this TSource source, TDestination destination)
            where TSource : class
            where TDestination : class
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<TSource, TDestination>(); });

            var iMapper = config.CreateMapper();
            return iMapper.Map<TSource, TDestination>(source);
        }
    }
}