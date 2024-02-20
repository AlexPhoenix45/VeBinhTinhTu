using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace View.BaoCaoThongKe
{
    public partial class BaoCaoThongKe : UserControl
    {
        private DateTime Start;
        private DateTime End;

        public BaoCaoThongKe()
        {
            InitializeComponent();

            dateStart.Value = DateTime.Now.AddMonths(-6);
            dateEnd.Value = DateTime.Now;

        }

        private void DrawDoubleBarChart()
        {
            var nhanVien = new DAO.SqlToLinq.NhanVien().getAll().Where(x => x.Status == 1).ToList();

            List<int> taoP = new List<int>();
            List<int> ttP = new List<int>();

            foreach (var x in nhanVien)
            {
                taoP.Add(new DAO.SqlToLinq.PhieuMuon().getThongKeTaoByIdNVAndDay(x.Id, this.Start, this.End));
            }

            foreach (var x in nhanVien)
            {
                ttP.Add(new DAO.SqlToLinq.PhieuMuon().getThongKeThanhToanByIdNVAndDay(x.Id, this.Start, this.End));
            }

            // Dữ liệu mẫu
            Dictionary<string, List<int>> data = new Dictionary<string, List<int>>
            {
                {"Tạo phiếu", taoP},
                {"Thanh toán", ttP}
            };

            // Tạo biểu đồ
            Chart chart = new Chart();
            chart.Size = new System.Drawing.Size(1200, 400);

            // Tạo và thêm ChartArea vào biểu đồ
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);
            Title title = new Title("Năng suất làm việc", Docking.Top, new System.Drawing.Font("Arial", 16f), Color.Black);
            chart.Titles.Add(title);

            // Tạo series cho từng nhóm
            foreach (var groupData in data)
            {
                Series series = new Series(groupData.Key);
                series.ChartType = SeriesChartType.Column;

                // Thêm dữ liệu vào series
                for (int i = 0; i < nhanVien.Count; i++)
                {
                    series.Points.AddXY(new DAO.SqlToLinq.Users().getById(nhanVien[i].IdUser).TaiKhoan, groupData.Value[i]);
                }

                // Thêm series vào biểu đồ
                chart.Series.Add(series);
            }

            // Đặt tên cho trục X và Y
            chartArea.AxisX.Title = "Nhân viên";
            chartArea.AxisY.Title = "Số phiếu";

            // Hiển thị chú thích
            chart.Legends.Add(new Legend("Legend"));

            chart.Legends[0].Docking = Docking.Right;

            // Hiển thị biểu đồ trên form
            pnND.Controls.Add(chart);
        }
        private void DrawPieChart()
        {
            try
            {
                // Dữ liệu giả định
                var TheLoai = new DAO.SqlToLinq.TheLoai().getAll().Where(x => x.Status == 1).Select(x => x.TenTheLoai).ToList();
                var LuotMuon = new List<int>();
                int tongLuotMuon = 0;
                foreach (var h in new DAO.SqlToLinq.TheLoai().getAll().Where(x => x.Status == 1))
                {
                    var muon = new DAO.SqlToLinq.PhieuMuon().getThongKeMuonByIdTLAndDay(h.Id, this.Start, this.End);
                    tongLuotMuon += muon;
                    LuotMuon.Add(muon);
                }

                // Tạo biểu đồ
                Chart chart = new Chart();
                chart.Size = new System.Drawing.Size(600, 400);

                // Tạo và thêm ChartArea vào biểu đồ
                ChartArea chartArea = new ChartArea();
                chart.ChartAreas.Add(chartArea);

                // Tạo series cho biểu đồ tròn
                Series series = new Series("Tạo phiếu");
                series.ChartType = SeriesChartType.Pie;

                // Thêm dữ liệu vào series
                for (int i = 0; i < TheLoai.Count; i++)
                {
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.SetValueY(LuotMuon[i]);
                    dataPoint.Label = $"{Convert.ToInt32(((double)LuotMuon[i] / tongLuotMuon) * 100)}%";
                    dataPoint.IsValueShownAsLabel = false; // Tắt hiển thị giá trị làm nhãn
                    dataPoint.LegendText = TheLoai[i]; // Thiết lập chú thích thành chuỗi trống

                    series.Points.Add(dataPoint);
                }

                // Thêm series vào biểu đồ
                chart.Series.Add(series);

                Title title = new Title("Tỉ lệ mượn theo đầu sách", Docking.Top, new System.Drawing.Font("Arial", 16f), Color.Black);
                chart.Titles.Add(title);

                // Hiển thị chú thích
                chart.Legends.Add(new Legend("Legend"));
                chart.Legends[0].Docking = Docking.Right;

                // Hiển thị biểu đồ tròn trên panel
                pnND.Controls.Add(chart);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void DrawPieChart2()
        {
            try
            {
                // Dữ liệu giả định
                var TheLoai = new DAO.SqlToLinq.TheLoai().getAll().Where(x => x.Status == 1).Select(x => x.TenTheLoai).ToList();
                var LuotMuon = new List<int>();
                int tongLuotMuon = 0;
                foreach (var h in new DAO.SqlToLinq.TheLoai().getAll().Where(x => x.Status == 1))
                {
                    var muon = new DAO.SqlToLinq.Sach().GetAll().Where(x => x.Status == 1 && x.IdTheLoai == h.Id).ToList();
                    tongLuotMuon += muon.Count;
                    LuotMuon.Add(muon.Count);
                }

                // Tạo biểu đồ
                Chart chart = new Chart();
                chart.Size = new System.Drawing.Size(600, 400);

                // Tạo và thêm ChartArea vào biểu đồ
                ChartArea chartArea = new ChartArea();
                chart.ChartAreas.Add(chartArea);

                // Tạo series cho biểu đồ tròn
                Series series = new Series("Tạo phiếu");
                series.ChartType = SeriesChartType.Pie;

                // Thêm dữ liệu vào series
                for (int i = 0; i < TheLoai.Count; i++)
                {
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.SetValueY(LuotMuon[i]);
                    dataPoint.Label = $"{Convert.ToInt32(((double)LuotMuon[i] / tongLuotMuon) * 100)}%";
                    dataPoint.IsValueShownAsLabel = false; // Tắt hiển thị giá trị làm nhãn
                    dataPoint.LegendText = TheLoai[i]; // Thiết lập chú thích thành chuỗi trống

                    series.Points.Add(dataPoint);
                }

                // Thêm series vào biểu đồ
                chart.Series.Add(series);

                Title title = new Title("Tỉ lệ sách theo đầu sách", Docking.Top, new System.Drawing.Font("Arial", 16f), Color.Black);
                chart.Titles.Add(title);

                // Hiển thị chú thích
                chart.Legends.Add(new Legend("Legend"));
                chart.Legends[0].Docking = Docking.Right;

                // Hiển thị biểu đồ tròn trên panel
                pnND.Controls.Add(chart);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            this.Start = dateStart.Value;
            this.End = dateEnd.Value;

            pnND.Controls.Clear();

            DrawPieChart2();
            DrawPieChart();
            var ACT = new DAO.SqlToLinq.Action().getAll();
            var RACT = new DAO.SqlToLinq.RoleAction().getAll();

            var xoa = ACT.Where(x => x.Status == 1 && x.Name.Equals("ThongKeChatLuongNhanVien")).FirstOrDefault();

            var roleX = RACT.Where(x => x.Status == 1 && x.IdAction == xoa.Id && x.IdRole == Models.Session.Role.Id).FirstOrDefault();

            if (roleX != null)
            {
                DrawDoubleBarChart();
            }
        }

        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            btnTK_Click(sender, e);
        }
    }
}
