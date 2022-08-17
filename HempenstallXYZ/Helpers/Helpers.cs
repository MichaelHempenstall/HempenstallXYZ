namespace HempenstallXYZ.Helpers
{
    public class Helpers
    {
        private string? _gitHash = null;
        //Gets the GitHash from the build
        public string GitHash
        {
            get
            {
                if (string.IsNullOrEmpty(_gitHash))
                {
                    var version = "1.0.0+LOCALBUILD"; // Dummy version for local dev
                    //var appAssembly = typeof(AppVersionInfo).Assembly;
                    //var infoVerAttr = (AssemblyInformationalVersionAttribute)appAssembly
                    //.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute)).FirstOrDefault();

                    //if (infoVerAttr != null && infoVerAttr.InformationalVersion.Length > 6)
                    //{
                    //    // Hash is embedded in the version after a '+' symbol, e.g. 1.0.0+a34a913742f8845d3da5309b7b17242222d41a21
                    //    version = infoVerAttr.InformationalVersion;
                    //}
                    _gitHash = version.Substring(version.IndexOf('+') + 1);

                }

                return _gitHash;
            }
        }
    }
}
