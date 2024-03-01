using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.QuanLyChucNang
{
    public partial class PhanCong : Form
    {
        private Models.Role r;
        public PhanCong(Models.Role r)
        {
            InitializeComponent();
            this.r = r;
            load();
        }

        private void loadDG()
        {
            //var DG = new DAO.SqlToLinq.DocGia().getAll().Where(x => x.Status == 1 && (new DAO.SqlToLinq.UserRole().GetAll().Where(y => y.IdUser == x.IdUser && y.IdRole == r.Id && y.Status == 1) != null));
            var gDG = new DAO.SqlToLinq.UserRole().GetAll().Where(x => x.IdRole == r.Id && x.Status == 1);
            var DG = new List<Models.DocGia>();
            foreach (var x in gDG)
            {
                var docGia = new DAO.SqlToLinq.DocGia().getByIdUser(x.IdUser);
                if (docGia != null)
                {
                    DG.Add(docGia);
                }
            }

            if (DG.Count == new DAO.SqlToLinq.DocGia().getAll().Where(x => x.Status == 1).ToList().Count)
            {
                checkBox4.Checked = true;
            }
            else
            {
                checkBox4.Checked = false;
            }
            DataTable dt = new DataTable();

            // Thêm các cột vào DataTable
            dt.Columns.Add("STT", typeof(int)); // Giả sử IdTacGia là kiểu int
            dt.Columns.Add("Mã độc giả", typeof(string)); // Giả sử IdTacGia là kiểu int
            dt.Columns.Add("Tên độc giả", typeof(string)); // Giả sử IdTacGia là kiểu int


            // Thêm dữ liệu từ sachList vào DataTable
            int stt = 1;
            foreach (var dg in DG)
            {
                dt.Rows.Add(stt++, dg.MaDocGia, new DAO.SqlToLinq.Users().getById(dg.IdUser).TaiKhoan);
            }


            dtDG.ReadOnly = true;
            dtDG.DataSource = dt;
            dtDG.Columns["STT"].Width = 50; // Thiết lập chiều rộng cho cột "Tác Giả" là 150
        }

        private void loadNV()
        {
            var gDG = new DAO.SqlToLinq.UserRole().GetAll().Where(x => x.IdRole == r.Id && x.Status == 1);
            var DG = new List<Models.NhanVien>();
            foreach (var x in gDG)
            {
                var docGia = new DAO.SqlToLinq.NhanVien().getByIdUser(x.IdUser);
                if (docGia != null)
                {
                    DG.Add(docGia);
                }
            }

            if (DG.Count == new DAO.SqlToLinq.NhanVien().getAll().Where(x => x.Status == 1).ToList().Count)
            {
                checkBox5.Checked = true;
            }
            else
            {
                checkBox5.Checked = false;
            }

            DataTable dt = new DataTable();

            // Thêm các cột vào DataTable
            dt.Columns.Add("STT", typeof(int)); // Giả sử IdTacGia là kiểu int
            dt.Columns.Add("Mã nhân viên", typeof(string)); // Giả sử IdTacGia là kiểu int
            dt.Columns.Add("Tên nhân viên", typeof(string)); // Giả sử IdTacGia là kiểu int


            // Thêm dữ liệu từ sachList vào DataTable
            int stt = 1;
            foreach (var dg in DG)
            {
                dt.Rows.Add(stt++, dg.MaNhanVien, new DAO.SqlToLinq.Users().getById(dg.IdUser).TaiKhoan);
            }


            dtNV.ReadOnly = true;
            dtNV.DataSource = dt;
            dtNV.Columns["STT"].Width = 50; // Thiết lập chiều rộng cho cột "Tác Giả" là 150
        }

        private void loadQT()
        {
            var gDG = new DAO.SqlToLinq.UserRole().GetAll().Where(x => x.IdRole == r.Id && x.Status == 1);
            var DG = new List<Models.Admin>();
            foreach (var x in gDG)
            {
                var docGia = new DAO.SqlToLinq.Admin().getByIdUser(x.IdUser);
                if (docGia != null)
                {
                    DG.Add(docGia);
                }
            }

            if(DG.Count == new DAO.SqlToLinq.Admin().getAll().Where(x => x.Status ==1).ToList().Count)
            {
                checkBox6.Checked = true;
            }
            else
            {
                checkBox6.Checked = false;
            }

            DataTable dt = new DataTable();

            // Thêm các cột vào DataTable
            dt.Columns.Add("STT", typeof(int)); // Giả sử IdTacGia là kiểu int
            dt.Columns.Add("Mã quản trị", typeof(string)); // Giả sử IdTacGia là kiểu int
            dt.Columns.Add("Tên quản trị", typeof(string)); // Giả sử IdTacGia là kiểu int


            // Thêm dữ liệu từ sachList vào DataTable
            int stt = 1;
            foreach (var dg in DG)
            {
                dt.Rows.Add(stt++, dg.MaAdmin, new DAO.SqlToLinq.Users().getById(dg.IdUser).TaiKhoan);
            }

            dtQT.ReadOnly = true;
            dtQT.DataSource = dt;
            dtQT.Columns["STT"].Width = 50; // Thiết lập chiều rộng cho cột "Tác Giả" là 150
        }

        private void Bt_Click(object? sender, EventArgs e, int id)
        {

        }

        private void load()
        {
            loadDG();
            loadNV();
            loadQT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var us = new DSUser(r);

            us.FormClosed += (sender, e) => load();
            us.Show();
        }
    }
}
