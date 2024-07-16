using MGR.sets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;
using Aspose.Words;
using Aspose.Words.Tables;

namespace MGR
{
    internal class WordWriter
    {
        private List<Headache> headaches;
        private string path;
        public WordWriter(List<Headache> headaches)
        {
            path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                "Мои мигрени.docx");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            this.headaches = headaches;
        }
        public void Write()
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                Document doc = new Document();
                DocumentBuilder builder = new DocumentBuilder(doc);
                Aspose.Words.Font font = builder.Font;
                foreach (var ache in headaches)
                {
                    font.Size = 16;
                    font.Bold = true;
                    font.Color = System.Drawing.Color.Black;
                    font.Name = "Times New Roman";

                    builder.Writeln($"{ache.Date}");
                    font.Size = 14;
                    builder.Writeln($"Продолжительность: {ache.Timecount} минут.");

                    font.Size = 12;
                    font.Bold = false;
                    builder.Writeln($"Что предшествовало:");
                    builder.Writeln(ache.Description);
                    builder.Writeln();
                    builder.Writeln();
                }
                doc.Save(path);
                if (File.Exists(path))
                {
                    MessageBox.Show("Файл успешно сохранен!");
                }
                else
                {
                    throw new Exception("Файл не найден");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка при сохранении docx-файла: {e.Message}");
            }
        }
    }
}
