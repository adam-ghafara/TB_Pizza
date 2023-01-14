using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Pizza.model
{
    internal class m_miscfood
    {
        string nama_makanan, jenis_makanan, harga;

        public string Nama_makanan { get => nama_makanan; set => nama_makanan = value; }
        public string Jenis_makanan { get => jenis_makanan; set => jenis_makanan = value; }
        public string Harga { get => harga; set => harga = value; }

        public m_miscfood(string nama_makanan, string jenis_makanan, string harga)
        {
            this.Nama_makanan = nama_makanan;
            this.Jenis_makanan = jenis_makanan;
            this.Harga = harga;
        }

        public m_miscfood()
        {

        }
    }
}
