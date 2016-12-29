using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace school
{
    class NotificationManager
    {

        public static void NotifyIfNeeded(int childId, int newMark, int assignedSubjectId)
        {
            schoolDataSetTableAdapters.marksReportTableAdapter ta = new schoolDataSetTableAdapters.marksReportTableAdapter();
            schoolDataSet.marksReportDataTable dt = new schoolDataSet.marksReportDataTable();
            int? averageValue = null;
            try
            {
                averageValue = Convert.ToInt32(ta.GetBySubject(DateTime.Now.Year, childId, "оценка", assignedSubjectId));
            }
            catch { }

            if (averageValue == null)
            {
                return;
            }
            Console.WriteLine("Compare " + averageValue + " ? " + newMark);
            if (averageValue - newMark > 2)
            {
                NotifyParents(childId);
            }
        }

        static void NotifyParents(int childId)
        {
            schoolDataSetTableAdapters.childsTableAdapter ta = new schoolDataSetTableAdapters.childsTableAdapter();
            schoolDataSet.childsDataTable dt = new schoolDataSet.childsDataTable();
            ta.FillById(dt, childId);
            string childName = Convert.ToString(dt.Rows[0].ItemArray[1]);

            schoolDataSetTableAdapters.relatives_notificationTableAdapter ta2 = new schoolDataSetTableAdapters.relatives_notificationTableAdapter();
            schoolDataSet.relatives_notificationDataTable dt2 = new schoolDataSet.relatives_notificationDataTable();
            ta2.FillByChildId(dt2, childId);
            List<string> mails = new List<string>();
            for (int i = 0; i < dt2.Rows.Count; ++i)
            {
                mails.Add(Convert.ToString(dt2[i].ItemArray[0]));
            }

            sendMessage(mails, childName);
        }

        static async void sendMessage(List<string> mailTo, string childName)
        {
            SmtpClient Smtp = new SmtpClient("smtp.gmail.com", 587);
            Smtp.Credentials = new NetworkCredential("schooladm16@gmail.com", "school123456");
            Smtp.EnableSsl = true;
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("schooladm16@gmail.com");
            mailTo.ForEach(c => Message.To.Add(new MailAddress(c)));
            Message.Subject = "Успеваемость " + childName;
            Message.Body = "Дорый день. Спешим обратить Ваше внимание на то, что успеваемость " + childName + " снизилась. Просим принять срочные и жесткие меры!";

            try
            {
                await Smtp.SendMailAsync(Message);
            }
            catch (SmtpException e)
            {
                Console.WriteLine("Messages not sent: " + e.Message);
                MessageBox.Show(e.Message, "Ошибка при отправке письма.", MessageBoxButtons.OK);
            }
            Console.WriteLine("Messages sent");
        }
    }
}
