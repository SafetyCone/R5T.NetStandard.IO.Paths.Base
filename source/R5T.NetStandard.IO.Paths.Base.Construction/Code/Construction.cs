using System;


namespace R5T.NetStandard.IO.Paths.Base.Construction
{
    public static class Construction
    {
        public static void SubMain()
        {
            Construction.TestExecutablePathMethods();
        }

        /// <summary>
        /// There are two ways to getting the currently executing executable file's path: <see cref="Utilities.ExecutablePathCommandLineArgumentValue"/> using the first argument of the command-line incantation, and <see cref="Utilities.ExecutablePathEntryAssemblyValue"/> using the location of the entry assembly.
        /// A question arises: with .NET Core, are both locations the same? One could imaging the first value of the command line incantation being the location of the dotnet executable, and the entry assembly being the desired "executable" location.
        /// Fortunately, both locations are the same, no doubt due to some trickery in the dotnet executable.
        /// </summary>
        private static void TestExecutablePathMethods()
        {
            Console.WriteLine($"{nameof(Utilities.ExecutablePathCommandLineArgumentValue)}: {Utilities.ExecutablePathCommandLineArgumentValue}");
            // Result: ..\R5T.NetStandard.IO.Paths.Base\source\R5T.NetStandard.IO.Paths.Base.Construction\bin\Debug\netcoreapp2.2\R5T.NetStandard.IO.Paths.Base.Construction.dll

            Console.WriteLine($"{nameof(Utilities.ExecutablePathEntryAssemblyValue)}: {Utilities.ExecutablePathEntryAssemblyValue}");
            // Result: ..\R5T.NetStandard.IO.Paths.Base\source\R5T.NetStandard.IO.Paths.Base.Construction\bin\Debug\netcoreapp2.2\R5T.NetStandard.IO.Paths.Base.Construction.dll
        }
    }
}
