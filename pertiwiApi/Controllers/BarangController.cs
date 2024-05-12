using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pertiwiApi.Models;

namespace pertiwiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BarangController : ControllerBase
    {
        private readonly MyDbContext myDbContext;
        
        public BarangController(MyDbContext _myDbContext)
        {
            myDbContext = _myDbContext;
        }

        /*
            Get Data Barang
         */
        [HttpGet]
        public async Task <ActionResult<IEnumerable<tbl_barang>>> getBarang()
        {
            if (myDbContext.tbl_barang == null)
            {
                return NotFound();
            }

            var barang = await myDbContext.tbl_barang.ToListAsync();

            return barang;
        }


        [HttpGet("nama_barang")]
        public async Task <ActionResult<IEnumerable<tbl_barang>>> searchBarang(string namaBarang)
        {
            //var barang = new tbl_barang();
            if (myDbContext.tbl_barang == null)
            {
                return NotFound();
            }

            var barang = await myDbContext.tbl_barang.Where(x => x.nama_barang.Contains(namaBarang)).ToListAsync();
            //barang = myDbContext.tbl_barang.Where(x => x.nama_barang.Contains(namaBarang)).FirstOrDefault();
            if (barang  == null)
            {
                return NotFound();
            }

            return barang;
        }

    }
}
