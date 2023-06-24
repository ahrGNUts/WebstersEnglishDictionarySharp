using System;
using System.Collections.Generic;
using System.Text;

namespace WebstersEnglishDictionarySharp.Core.Models
{
    public class ParserModel
    {
        public string InputFilePath { get; set; }
        public string OutputFolderPath { get; set; }
        public string OutputFilename { get; set; }
        public OutputFileOptions OutputFileOptions { get; set; }

    }
}
