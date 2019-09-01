using System;


namespace R5T.NetStandard.IO.Paths.Base
{
    /// <summary>
    /// Operates on stringly-typed paths.
    /// </summary>
    public static class Utilities
    {
        /// <summary>
        /// Gets the current directory path.
        /// Uses <see cref="Environment.CurrentDirectory"/>.
        /// </summary>
        public static string CurrentDirectoryPathValue
        {
            get
            {
                var output = Environment.CurrentDirectory;
                return output;
            }
        }

        /// <summary>
        /// Gets the current user's profile directory path.
        /// Uses <see cref="Environment.SpecialFolder.UserProfile"/>.
        /// </summary>
        public static string UserProfileDirectoryPathValue
        {
            get
            {
                var output = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                return output;
            }
        }

        public static string ExecutablePathCommandLineArgumentValue
        {
            get
            {
                var output = Environment.GetCommandLineArgs()[0];
                return output;
            }
        }
    }
}
