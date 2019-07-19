using System;

namespace library
{
    internal abstract class Digital
    {

        private string name;
        private bool downloadable;

        public Digital(string name, bool downloadable)
        {
            this.name = name;
            this.downloadable = downloadable;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Downloadable
        {
            get { return downloadable; }
            set { downloadable = value; }
        }

    }
}
