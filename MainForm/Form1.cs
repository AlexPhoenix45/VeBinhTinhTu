
namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            KhoiTaoDataGridView();

            NapDuLieuVaoDataGridView();
        }

        private void KhoiTaoDataGridView()
        {
            this.Controls.Add(BangData);

            // Định nghĩa các cột
            BangData.Columns.Add("Id", "ID");
            BangData.Columns.Add("TaiKhoan", "Tài Khoản");
            BangData.Columns.Add("MatKhau", "Mật Khẩu");
            BangData.Columns.Add("Role", "Quyền");
            BangData.Columns.Add("DiaChi", "Địa Chỉ");
            BangData.Columns.Add("CanCuoc", "Căn Cước");
            BangData.Columns.Add("NgaySinh", "Ngày Sinh");
            BangData.Columns.Add("Email", "Email");
            BangData.Columns.Add("SoDienThoai", "Số Điện Thoại");
            BangData.Columns.Add("AnhDaiDien", "Ảnh Đại Diện");
            BangData.Columns.Add("Status", "Trạng Thái");
            // Thêm các cột khác nếu cần

            // Thiết lập các thuộc tính cho DataGridView
            BangData.Dock = DockStyle.Fill;
            BangData.ReadOnly = true;
        }

        private void NapDuLieuVaoDataGridView()
        {
            List<Models.Users> danhSachNguoiDung = new DAO.SqlToLinq.Users().timKiem();

            foreach (var nguoiDung in danhSachNguoiDung)
            {
                // Thêm một dòng vào DataGridView
                BangData.Rows.Add(
                    nguoiDung.Id,
                    nguoiDung.TaiKhoan,
                    nguoiDung.MatKhau,
                    nguoiDung.Role,
                    nguoiDung.DiaChi,
                    nguoiDung.CanCuoc,
                    nguoiDung.NgaySinh,
                    nguoiDung.Email,
                    nguoiDung.SoDienThoai,
                    nguoiDung.AnhDaiDien
                );
            }
        }

    }
}

