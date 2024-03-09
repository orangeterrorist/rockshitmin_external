using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Hooker
{
    [CompilerGenerated]
    internal static class AssemblyLoader
    {
        private static string CultureToString(CultureInfo culture)
        {
            bool flag = culture == null;
            string result;
            if (flag)
            {
                result = "";
            }
            else
            {
                result = culture.Name;
            }
            return result;
        }

        private static Assembly ReadExistingAssembly(AssemblyName name)
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            Assembly[] assemblies = currentDomain.GetAssemblies();
            foreach (Assembly assembly in assemblies)
            {
                AssemblyName name2 = assembly.GetName();
                bool flag = string.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(AssemblyLoader.CultureToString(name2.CultureInfo), AssemblyLoader.CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase);
                if (flag)
                {
                    return assembly;
                }
            }
            return null;
        }

        private static void CopyTo(Stream source, Stream destination)
        {
            byte[] array = new byte[81920];
            int count;
            while ((count = source.Read(array, 0, array.Length)) != 0)
            {
                destination.Write(array, 0, count);
            }
        }

        private static Stream LoadStream(string fullName)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            bool flag = fullName.EndsWith(".compressed");
            if (flag)
            {
                using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(fullName))
                {
                    using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
                    {
                        MemoryStream memoryStream = new MemoryStream();
                        AssemblyLoader.CopyTo(deflateStream, memoryStream);
                        memoryStream.Position = 0L;
                        return memoryStream;
                    }
                }
            }
            return executingAssembly.GetManifestResourceStream(fullName);
        }

        private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
        {
            string fullName;
            bool flag = resourceNames.TryGetValue(name, out fullName);
            Stream result;
            if (flag)
            {
                result = AssemblyLoader.LoadStream(fullName);
            }
            else
            {
                result = null;
            }
            return result;
        }

        private static byte[] ReadStream(Stream stream)
        {
            byte[] array = new byte[stream.Length];
            stream.Read(array, 0, array.Length);
            return array;
        }

        private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
        {
            string text = requestedAssemblyName.Name.ToLowerInvariant();
            bool flag = requestedAssemblyName.CultureInfo != null && !string.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name);
            if (flag)
            {
                text = requestedAssemblyName.CultureInfo.Name + "." + text;
            }
            byte[] rawAssembly;
            using (Stream stream = AssemblyLoader.LoadStream(assemblyNames, text))
            {
                bool flag2 = stream == null;
                if (flag2)
                {
                    return null;
                }
                rawAssembly = AssemblyLoader.ReadStream(stream);
            }
            using (Stream stream2 = AssemblyLoader.LoadStream(symbolNames, text))
            {
                bool flag3 = stream2 != null;
                if (flag3)
                {
                    byte[] rawSymbolStore = AssemblyLoader.ReadStream(stream2);
                    return Assembly.Load(rawAssembly, rawSymbolStore);
                }
            }
            return Assembly.Load(rawAssembly);
        }

        public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
        {
            object obj = AssemblyLoader.nullCacheLock;
            object obj2 = obj;
            lock (obj2)
            {
                bool flag2 = AssemblyLoader.nullCache.ContainsKey(e.Name);
                if (flag2)
                {
                    return null;
                }
            }
            AssemblyName assemblyName = new AssemblyName(e.Name);
            Assembly assembly = AssemblyLoader.ReadExistingAssembly(assemblyName);
            bool flag3 = assembly != null;
            Assembly result;
            if (flag3)
            {
                result = assembly;
            }
            else
            {
                assembly = AssemblyLoader.ReadFromEmbeddedResources(AssemblyLoader.assemblyNames, AssemblyLoader.symbolNames, assemblyName);
                bool flag4 = assembly == null;
                if (flag4)
                {
                    object obj3 = AssemblyLoader.nullCacheLock;
                    object obj4 = obj3;
                    lock (obj4)
                    {
                        AssemblyLoader.nullCache[e.Name] = true;
                    }
                    bool flag6 = (assemblyName.Flags & AssemblyNameFlags.Retargetable) > AssemblyNameFlags.None;
                    if (flag6)
                    {
                        assembly = Assembly.Load(assemblyName);
                    }
                }
                result = assembly;
            }
            return result;
        }

        static AssemblyLoader()
        {
            AssemblyLoader.symbolNames.Add("GameAssembly.dll", "Assembly-CSharp.dll");
        }

        public static void Attach()
        {
            bool flag = Interlocked.Exchange(ref AssemblyLoader.isAttached, 1) == 1;
            if (!flag)
            {
                AppDomain currentDomain = AppDomain.CurrentDomain;
                currentDomain.AssemblyResolve += AssemblyLoader.ResolveAssembly;
            }
        }

        private static object nullCacheLock = new object();
        private static Dictionary<string, bool> nullCache = new Dictionary<string, bool>();
        private static Dictionary<string, string> assemblyNames = new Dictionary<string, string>();
        private static Dictionary<string, string> symbolNames = new Dictionary<string, string>();
        private static int isAttached;
    }
}
