using System;
using System.Collections.Generic;
using System.Text;

namespace another_enum_exercz
{
    class Bebek
    {

        public int Size
        {
            get; set;
        }

        public JenisBebek Jenis
        {
            get; set;
        }

        public Bebek (JenisBebek jen, int size)
        {
            this.Jenis = jen;
            this.Size = size;
        }
    }
}
