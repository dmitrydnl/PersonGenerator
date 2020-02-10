using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Reflection;

namespace PersonGenerator.WorkWithData
{
    internal class DataReader
    {
        private readonly LanguageInResourcePath languageInResourcePath;
        private readonly string resourceFullName;

        internal DataReader(Languages language, string fileName)
        {
            languageInResourcePath = new LanguageInResourcePath();
            resourceFullName = ResourceFullName(language, fileName);
        }

        private string ResourceFullName(Languages language, string fileName)
        {
            StringBuilder stringBuilder = new StringBuilder("PersonGenerator.Data");
            stringBuilder.Append(".");
            stringBuilder.Append(languageInResourcePath.GetResourcePath(language));
            stringBuilder.Append(".");
            stringBuilder.Append(fileName);
            return stringBuilder.ToString();
        }

        internal List<string> ReadToList()
        {
            List<string> resourceData = new List<string>();
            Assembly assembly = GetType().Assembly;
            Stream resourceStream = assembly.GetManifestResourceStream(resourceFullName);
            using (StreamReader reader = new StreamReader(resourceStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    resourceData.Add(line);
                }
            }

            return resourceData;
        }
    }
}
