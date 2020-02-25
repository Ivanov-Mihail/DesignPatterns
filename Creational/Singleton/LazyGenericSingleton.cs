using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class LazyGenericSingleton
    {
        private static readonly Lazy<LazyGenericSingleton> lgs =
            new Lazy<LazyGenericSingleton>(()=>new LazyGenericSingleton());

        private LazyGenericSingleton()
        {

        }

        private static LazyGenericSingleton Source
        {
            get
            {
                return lgs.Value;
            }
        }


    }
}
