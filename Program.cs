using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises_15._2
{
    internal class Program
    {
                    
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            object [][][] nhom = BangComX();
            do
            {
                Console.WriteLine("NHẤN PHÍM TỪ 1 - 4 ĐỂ CHỌN THAO TÁC");
                Console.WriteLine(" 1. In danh sách nhân viên\n 2. Tìm nhân viên bằng ID\n 3. Nhân viên xuất sắc nhất");
                string s = Console.ReadLine();
                int chon = 0;
                while (!int.TryParse(s, out chon))
                {
                    Console.WriteLine("Nhập lại");
                    s = Console.ReadLine();
                }
                switch (chon)
                {
                    case 1:
                        InDanhSach(nhom);
                        break;
                    case 2:
                        Console.WriteLine("Nhập ID cần tìm");
                        string x = Console.ReadLine();
                        int s_id = 0;
                        while (!int.TryParse(x, out s_id))
                        {
                            Console.WriteLine("Nhập lại");
                            x = Console.ReadLine();
                        }
                        Console.WriteLine("Thông tin nhân viên cần tìm");
                        TimBangID(nhom, s_id);
                        break;
                    case 3:
                        Console.WriteLine("Nhân viên hoàn thành nhiệm vụ là: ");
                        NhanVienTot(nhom);
                        break;
                     default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }
                Console.WriteLine("Bạn có muốn thoát khỏi chương trình (c/k)");
                string tl = Console.ReadLine();
                if (tl.ToLower().Equals("c"))
                {
                    Console.WriteLine("Tạm biệt");
                    break;

                }
            }
            while (true);
        }
        static object [][][] BangComX()
        {
            object[][][] nhom = new object[3][][];
            nhom[0] = new object[5][]
            {
                new object[]{101, new object[]{"Nick", 7} },
                new object[]{102, new object[]{"Ken", 8} },
                new object[]{103, new object[]{"Taylor", 10} },
                new object[]{104, new object[]{"John", 12} },
                new object[]{105, new object[]{"Maria", 20} },
            };
            nhom[1] = new object[3][]
            {
                new object[]{201, new object[]{"Nguyen", 5} },
                new object[]{202, new object[]{"Tran", 6} },
                new object[]{203, new object[]{"Le", 11} },
                
            };
            nhom[2] = new object[6][]
            {
                new object[]{301, new object[]{"Quin", 4} },
                new object[]{302, new object[]{"Chen", 3} },
                new object[]{303, new object[]{"Po", 14} },
                new object[]{304, new object[]{"Lin", 13} },
                new object[]{305, new object[]{"Mao", 21} },
                new object[]{306, new object[]{"Jiting", 25} },
            };
            return nhom;
        }
        static void InDanhSach(object[][][] nhom )
        {
            Console.WriteLine("DANH SÁCH NHÂN VIÊN: ");
            Console.WriteLine("ID\tTên\tNhiệm vụ");
            foreach (var stt in nhom)
            {
                foreach (var tv in stt)
                {
                    int id = (int)tv[0];
                    string ten = (string)((object[])tv[1])[0];
                    int cv = (int)((object[])tv[1])[1];
                    
                    Console.WriteLine($"{id}\t{ten}\t{cv}");
                }
            }
        }
        static void TimBangID(object[][][] nhom, int search_id)
        {
            foreach (var stt in nhom)
            {
                foreach (var tv in stt)
                {
                    int id = (int)tv[0];
                    if (id == search_id)
                    {
                        string ten = (string)((object[])tv[1])[0];
                        int cv = (int)((object[])tv[1])[1];
                        Console.WriteLine($"ID: {id}\tTên: {ten}\tNhiệm vụ: {cv}");
                        return;
                    }
                }
            }
            Console.WriteLine("Không tìm thấy nhân viên");
        }
        static void NhanVienTot(object[][][] nhom)
        {
            int maxNV = -1;
            int maxID = -1;
            string maxTen = "";
            Console.WriteLine("Thành viên hoàn thành nhiều nhiệm vụ nhất là:");
            foreach ( var stt in nhom)
            {
                foreach( var tv in stt)
                {
                    int cv = (int)((object[])tv[1])[1];
                    int id = (int)(tv[0]);
                    string ten = (string)((object[])tv[1])[0] ;
                    if (cv > maxNV)
                    {
                        maxNV = cv;
                        maxID = id;
                        maxTen = ten;
                    }
                }

            }
            Console.WriteLine($"ID: {maxID}\tTên: {maxTen}\tNhiệm vụ: {maxNV}");
        }

    }
}
