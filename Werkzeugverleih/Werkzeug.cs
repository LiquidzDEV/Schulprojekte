using System;

namespace Werkzeugverleih
{
    class Werkzeug
    {
        public string bezeichnung;
        public int tageKurzausleihe;
        public int preisKurzausleihe;
        public int tageLangausleihe;
        public int preisLangausleihe;

        public Werkzeug(string bezeichnung, string tageKurzausleihe, string preisKurzausleihe, string tageLangausleihe, string preisLangausleihe)
        {
            this.bezeichnung = bezeichnung;
            this.tageKurzausleihe = Int32.Parse(tageKurzausleihe);
            this.preisKurzausleihe = Int32.Parse(preisKurzausleihe);
            this.tageLangausleihe = Int32.Parse(tageLangausleihe);
            this.preisLangausleihe = Int32.Parse(preisLangausleihe);
        }

    }
}
