using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.XmlDiffPatch;
using System.IO;

namespace APITesting.Common
{
    public class XMLHelper
    {
        public static bool result=false;
        public static void GenerateDiffGram(string originalFile, string finalFile,
           XmlWriter diffGramWriter)
        {
            var xmldiff = new XmlDiff(XmlDiffOptions.IgnoreChildOrder |
                                      XmlDiffOptions.IgnoreNamespaces |
                                      XmlDiffOptions.IgnorePrefixes);
            var bIdentical = xmldiff.Compare(originalFile, finalFile, false, diffGramWriter);
            diffGramWriter.Close();
        }

        public static bool GenerateDiffGram2(string originalFile, string finalFile)
        {
            var xmldiff = new XmlDiff();
            var r1 = XmlReader.Create(new StringReader(originalFile));
            var r2 = XmlReader.Create(new StringReader(finalFile));
            var sw = new StringWriter();
            var xw = new XmlTextWriter(sw) { Formatting = Formatting.Indented };
            var bIdentical = xmldiff.Compare(r1, r2, xw);
            return bIdentical;
        }

        public static void VerifyXmlElement(string url, string elementType, string elementValue)
        {
           
            XmlTextReader reader = new XmlTextReader(url);
            while (reader.Read())
            {
                if (reader.Value.Equals(elementValue))
                {
                    result = true;
                }
                
            }
            

        }
        public static bool ConfirmXML()
        {
            return result;
        }
    }
}
