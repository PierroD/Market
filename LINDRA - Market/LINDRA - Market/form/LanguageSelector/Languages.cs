using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINDRA___Market.form.LanguageSelector
{
    public class Languages
    {
        public List<Language> languages { get; set; }
    }

    public class Language
    {
        public string key { get; set; }
        public string name { get; set; }
    }
}
