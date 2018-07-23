using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Reflection;

namespace Model
{
  public  class MailService
    {
        
        public static MemoryStream GenerateExcel(Human human, Nutrition nutrition,double Tdee)
        {
            string filepath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            filepath = filepath + "/File";
            MemoryStream outputStream = new MemoryStream();
            using (ExcelPackage ep = new ExcelPackage(outputStream))
            {
                ep.Workbook.Worksheets.Add("sheet1");
                ExcelWorksheet sheet = ep.Workbook.Worksheets["sheet1"];
                sheet.Cells["A1"].Value = $"您目前的身體資訊為:身高:{human.Height}cm,體重:{human.Weight}kg,年齡:{human.Age}歲";
                sheet.Cells["A2"].Value = "計算結果如下";
                sheet.Cells["A3"].Value = "TDEE:";
                sheet.Cells["B3"].Value = string.Format("{0:F0}kcal", Tdee);
                sheet.Cells["A4"].Value = "碳水化合物";
                sheet.Cells["B4"].Value = string.Format("{0:F2}g", nutrition.Carbon);
                sheet.Cells["A5"].Value = "蛋白質";
                sheet.Cells["B5"].Value = string.Format("{0:F2}g", nutrition.Protein);
                sheet.Cells["A6"].Value = "脂肪";
                sheet.Cells["B6"].Value = string.Format("{0:F2}g", nutrition.Fat);
                sheet.Cells.AutoFitColumns();

                if (File.Exists(filepath))
                {
                    File.Delete(filepath);
                }

                FileStream fs = new FileStream(filepath + "/Tdee計算結果.xls", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                ep.SaveAs(fs);
                fs.Close();
            }
            outputStream.Position = 0;
            return outputStream;
        }


        //寄信
        public static void SendMail(string UserMail, MemoryStream fileStream)
        {
            MailMessage newMail = new MailMessage();
            SmtpClient smtpMail = new SmtpClient("smtp.gmail.com");//new SmtpClient();
            smtpMail.Port = 587;
           
            //建立使用者憑據 要設定自己帳號
            smtpMail.Credentials = new System.Net.NetworkCredential("your gmail", "your password");
            //開啟SSL
            smtpMail.EnableSsl = true;
            try
            {

                //附件
                if (fileStream != null)
                {

                    Attachment data = new Attachment(fileStream, "Tdee計算結果.xls", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                    newMail.Attachments.Add(data);
                }
                //================內文===================
                newMail.From = new MailAddress("shadow061103@gmail.com", "TdeeCalculator");  //寄件者
                newMail.Body = "請查收，歡迎多加使用，如有問題請直接回覆信箱";   //'內文
                newMail.Subject = "Tdee計算結果";//'主旨

                newMail.To.Add(new MailAddress(UserMail, "To"));
                newMail.IsBodyHtml = true;                      //'是否為HTML格式
                newMail.Priority = MailPriority.Normal; //'優先權    


                smtpMail.Send(newMail);
                newMail.Dispose();
                newMail.Dispose();
                smtpMail.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
