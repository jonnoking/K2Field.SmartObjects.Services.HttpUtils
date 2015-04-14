using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.SmartObjects.Services.HttpUtils
{
    public class DownloadedFile
    {
        public string Base64 { get; set; }
        public string FileExtension { get; set; }
        public string FileName { get; set; }
        public DateTime Downloaded { get; set; }
        public string ContentType { get; set; }
        public long Size { get; set; }
        public string SizeFormatted { get; set; }
        public WebHeaderCollection ResponseHeaders { get; set; }
    }
}
