using System.ComponentModel.DataAnnotations;

namespace pertiwiApi.Models
{
    public class tbl_barang
    {
        [Key]

        public int ID { get; set; }

        public string kode_barang {  get; set; }

        public string nama_barang { get; set; }

        public DateOnly expired_date { get; set; }

        public int jumlah {  get; set; }
        
        public int harga_satuan {  get; set; }

        public string satuan {  get; set; }

        public string? image2 { get; set; }

    }
}
