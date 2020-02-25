using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    // Sealed class for optimization JIT compilation
    public sealed class LazyGenericSingleton : ISingleton
    {
        private static readonly Lazy<LazyGenericSingleton> lgs =
            new Lazy<LazyGenericSingleton>(() => new LazyGenericSingleton());

        private LazyGenericSingleton()
        {

        }
        // property -isValueCreated- for additional verification
        private static LazyGenericSingleton Source
        {
            get
            {
                return lgs.Value;
            }
        }


    }
}
