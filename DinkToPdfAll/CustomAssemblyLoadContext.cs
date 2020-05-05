using System;

namespace DinkToPdfAll
{
    internal class CustomAssemblyLoadContext : System.Runtime.Loader.AssemblyLoadContext
    {
        public IntPtr LoadUnmanagedLibrary(string absolutePath)
        {
            return LoadUnmanagedDll(absolutePath);
        }
        protected override IntPtr LoadUnmanagedDll(string unmanagedDllName)
        {
            return LoadUnmanagedDllFromPath(unmanagedDllName);
        }
        protected override System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyName)
        {
            throw new NotImplementedException();
        }
    }
}
