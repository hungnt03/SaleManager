using System.Windows.Forms;

namespace SaleManager.Utils
{
    public static class MessageUtil
    {
        public static void Warning(string mess)
        {
            MessageBox.Show(mess, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Information(string mess)
        {
            MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Error(string mess)
        {
            MessageBox.Show(mess, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void UpdateSuccess()
        {
            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void UpdateFailed()
        {
            MessageBox.Show("Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
