

namespace Project_OOP.ViewModels
{
    public static class NotificationService
    {
        public static void SendError(string message)
        {
            MessageBox.Show(message, "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void SendWarrning(string message)
        {
            MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
