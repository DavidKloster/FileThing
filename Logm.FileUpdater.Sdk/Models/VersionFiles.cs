using System;
namespace Logm.FileUpdater.Sdk.Models
{
    /// <summary>
    /// Database Entity which stores Version associated files
    /// </summary>
    public class VersionFile
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string ContentDisposition { get; set; }

        public string Checksum { get; set; }

        public int FileSize { get; set; }
    }
}

