using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _074_Tugas2_B
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Create();

            new Program().InsertData();

        }

        public void Create()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-OEG29RPO\\DEVINAS; database=Apotek2; Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Stok (kode_barang char(10) primary key, nama_barang varchar(40), jml_stok char(5))"
                   + "create table Pembelian (kode_msk char(10) primary key, kode_barang char(10) foreign key references Stok (kode_barang), tgl_msk varchar(50),jam varchar(30), jml_msk char(5)) "
                   + "create table Penjualan (kode_klr char(10) primary key, kode_barang char(10) foreign key references Stok (kode_barang), jml_klr char(5), tgl_klr varchar(50))", con);

                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses di buat");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal membuat tabel." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-OEG29RPO\\DEVINAS; database=Apotek2; Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Stok(kode_barang, nama_barang, jml_stok) values('32154d', 'antalgin', '9')" +
                    "insert into Stok (kode_barang, nama_barang, jml_stok) values ('36894h','antangin','10')" +
                    "insert into Stok (kode_barang, nama_barang, jml_stok) values ('5325h5','paratusin','11')" +
                    "insert into Stok (kode_barang, nama_barang, jml_stok) values ('57321f','paracetamol','12')" +
                    "insert into Stok (kode_barang, nama_barang, jml_stok) values ('48312g','vitamin C','13')" + 
                    "insert into Pembelian (kode_msk, kode_barang, tgl_msk, jam, jml_msk) values ('098765','32154d','12-03-2022','14:32:33','2')" +
                    "insert into Pembelian (kode_msk, kode_barang, tgl_msk, jam, jml_msk) values ('098766','36894h','15-03-2022','15:33:23','3')" +
                    "insert into Pembelian (kode_msk, kode_barang, tgl_msk, jam, jml_msk) values ('098767','5325h5','18-03-2022','12:31:22','4')" +
                    "insert into Pembelian (kode_msk, kode_barang, tgl_msk, jam, jml_msk) values ('098768','57321f','21-03-2022','16:32:11','5')" +
                    "insert into Pembelian (kode_msk, kode_barang, tgl_msk, jam, jml_msk) values ('098769','48312g','24-03-2022','19:44:32','6')" +
                    "insert into Penjualan (kode_klr, kode_barang, jml_klr, tgl_klr) values ('13320','32154d','1','13-03-2022')" +
                    "insert into Penjualan (kode_klr, kode_barang, jml_klr, tgl_klr) values ('13321','36894h','2 ','16-03-2022')" +
                    "insert into Penjualan (kode_klr, kode_barang, jml_klr, tgl_klr) values ('13322','5325h5','1','19-03-2022')" +
                    "insert into Penjualan (kode_klr, kode_barang, jml_klr, tgl_klr) values ('13323','57321f','2','22-03-2022')" +
                    "insert into Penjualan (kode_klr, kode_barang, jml_klr, tgl_klr) values ('13324','48312g','2','25-03-2022')", con);

                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
