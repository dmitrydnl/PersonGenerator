using System.Collections.Generic;

namespace PersonGenerator.WorkWithData
{
    internal class LanguageInResourcePath
    {
        private readonly Dictionary<Languages, string> languageInResourcePath = new Dictionary<Languages, string>();

        internal LanguageInResourcePath()
        {
            languageInResourcePath.Add(Languages.English, "english");
        }

        internal string GetResourcePath(Languages language)
        {
            return languageInResourcePath[language];
        }
    }
}
