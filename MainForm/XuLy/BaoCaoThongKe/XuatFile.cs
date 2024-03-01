using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO; // Thêm khai báo này

namespace XuLy.BaoCaoThongKe
{
    public class XuatFile
    {
        public static void ExportToWord(Control pnND, string filePath)
        {
            try
            {
                // Tạo một ứng dụng Word mới
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.Visible = false; // Đặt thành true nếu bạn muốn xem ứng dụng Word

                // Tạo một tài liệu mới
                Document doc = wordApp.Documents.Add();

                // Thêm nội dung vào tài liệu
                // Ví dụ, bạn có thể thêm văn bản từ các điều khiển biểu đồ của bạn
                foreach (Control control in pnND.Controls)
                {
                    if (control is System.Windows.Forms.DataVisualization.Charting.Chart)
                    {
                        System.Windows.Forms.DataVisualization.Charting.Chart chart = (System.Windows.Forms.DataVisualization.Charting.Chart)control;
                        // Thêm tiêu đề biểu đồ
                        Paragraph titleParagraph = doc.Content.Paragraphs.Add();
                        titleParagraph.Range.Text = chart.Titles[0].Text;
                        titleParagraph.Range.Font.Bold = 1;
                        titleParagraph.Range.InsertParagraphAfter();

                        // Thêm hình ảnh biểu đồ
                        string chartImagePath = Path.Combine(Path.GetTempPath(), "chart.png");
                        chart.SaveImage(chartImagePath, ChartImageFormat.Png);
                        InlineShape shape = titleParagraph.Range.InlineShapes.AddPicture(chartImagePath);
                        shape.Width = 500;
                        shape.Height = 300;
                    }
                }

                // Lưu tài liệu với tên và đường dẫn mới
                doc.SaveAs2(filePath);
                doc.Close();

                // Thoát ứng dụng Word
                wordApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }

        }
    }
}
