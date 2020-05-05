using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DinkToPdfAll
{
    public static class LibraryLoader
    {
        /// <summary>
        /// Load libwkhtmltox.dll x86 or x64
        /// </summary>
        public static void Load()
        {
            var bitprocess = Environment.Is64BitProcess ? "x64" : "x86";
            var libName = "libwkhtmltox.dll";
            var loader = new CustomAssemblyLoadContext();

            var assembly = Assembly.GetExecutingAssembly();
            var libAssamblyPath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), libName);

            var resourceName = Assembly.GetExecutingAssembly()
                                            .GetManifestResourceNames()
                                            .FirstOrDefault(p => p.EndsWith($"{bitprocess}.{libName}"));

            if (string.IsNullOrEmpty(resourceName)) return;

            File.Exists(Path.Combine(Path.GetDirectoryName(assembly.Location), libName));
            using (var steam = assembly.GetManifestResourceStream(resourceName))
            {
                byte[] data = new BinaryReader(steam).ReadBytes((int)steam.Length);
                File.WriteAllBytes(libAssamblyPath, data);
            }

            loader.LoadUnmanagedLibrary(libAssamblyPath);
        }

    }
}
