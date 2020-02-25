using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    // Sealed class for optimization JIT compilation
    public sealed class LazySingleton
    {

        public static LazySingleton Source
        {
            get { return NestedInstantiator.source; }
        }

        // Singular constructor should have 
        // Access modifier - private
        private LazySingleton()
        {

        }


        private sealed class NestedInstantiator
        {
            static NestedInstantiator()
            {

            }

            internal static readonly LazySingleton source = new LazySingleton();
        }

    }
}
