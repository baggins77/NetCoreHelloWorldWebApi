using AutoMapper;

namespace NETCoreHelloWorldWebApi.Domain
{
    public abstract class AbstractTypeConverter<TSource, TDestination> : ITypeConverter<TSource, TDestination>
    {
        public virtual TDestination Convert(TSource source, TDestination destination, ResolutionContext context)
        {
            return Convert(source);
        }

        protected abstract TDestination Convert(TSource source);
    }
}