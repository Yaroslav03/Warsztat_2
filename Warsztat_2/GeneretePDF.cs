using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System.Data.SQLite;

namespace Warsztat_2
{
    internal class GeneretePDF
    {
        private readonly string connectionString = "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;";
        private string VIN;
        private string[] sqlcommand = {
            "SELECT Imię, Nazwisko, NrTelefonu, AdresFirmy FROM Klienty",
            "SELECT Marka, Model, Silnik, RokProdukcji FROM Samochód",
            "SELECT DataPrzyjęcia, NrRejestracji, Przebieg, DokumentySamochodu, KluczykiSamochodu, TestDrive, Zlecenie, Diagnostyka, Naprawa FROM HistoriaNapraw",
            "SELECT Opis, NumerCzęści, Cena, Ilość, Stan, DataNapraw FROM NaprawaSamochodu",
            "SELECT VIN, Przyjęty, OczekujeNaOdbiór, DataPrzyjęcie, DataOczekiwaniaOdbioru, DataPłatności, MetodaPłatności, KosztSzacunkowy, KosztKońcowy, KosztZMarżą, WykonanaPraca, WykonawcaPracy FROM ZarządzanieZleceniami",


        };
        private List<string> data = new();

        private string[] companyColumn = {"NazwaFirmy", "AdresFirmy"};
        private string[] clientColumn = { "Imię", "Nazwisko", "NrTelefonu", "AdresFirmy" };
        private string[] carColumn = { "Marka", "Model", "Silnik", "RokProdukcji", };
        private string[] historyColumn = { "DataPrzyjęcia", "NrRejestracji", "Przebieg", "DokumentySamochodu", "KluczykiSamochodu", "TestDrive", "Zlecenie", "Diagnostyka", "Naprawa" };
        private string[] repairColumn = { "Opis", "NumerCzęści", "Cena", "Ilość", "Stan", "DataNapraw" };
        private string[] orderManagementColumn = { "VIN", "Przyjęty", "OczekujeNaOdbiór", "DataPrzyjęcie", "DataOczekiwaniaOdbioru", "DataPłatności", "MetodaPłatności", "KosztSzacunkowy", "KosztKońcowy", "KosztZMarżą", "WykonanaPraca", "WykonawcaPracy" };
        public void Create(string vin)
        {
            VIN = vin;
            read(); //read Data
            
            WritePDF();
            MessageBox.Show("PDF generated successfully!");
        }
        private void read()
        {
            string[][] columnArrays = { clientColumn, carColumn, historyColumn, repairColumn, orderManagementColumn };

            using SQLiteConnection conn = new(connectionString);
            conn.Open();
            using SQLiteCommand readComapny = new("SELECT NazwaFirmy, AdresFirmy FROM  DaneFirmy", conn);
            using SQLiteDataReader reader = readComapny.ExecuteReader();

            while (reader.Read())
            {
                data.Add(reader["NazwaFirmy"].ToString());
                data.Add(reader["AdresFirmy"].ToString());
            }

            for (int i = 0; i < sqlcommand.Length; i++)
            {
                using SQLiteCommand cmd = new(sqlcommand[i] + $" WHERE VIN LIKE '%{VIN}'", conn);
                using SQLiteDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    foreach (string column in columnArrays[i])
                        data.Add($"{read[column]}");
                }
            }
        }
        private void WritePDF()
        {
            #region generetePDF
            Document document = new Document();
            Section section = document.AddSection();
            #endregion
            #region title
            // Додавання тексту "Назва фірми"
            Paragraph companyName = section.AddParagraph(data[0]);
            companyName.Format.Font.Size = 22;
            companyName.Format.Font.Name = "Impact"; // Задати назву шрифта
            companyName.Format.Alignment = ParagraphAlignment.Center;
            #endregion

            #region Section Client && car
            #region set two data but in diferent sides
            // Додаємо таблицю для даних клієнта і автомобіля
            Table clientCarTable = section.AddTable();
            clientCarTable.Borders.Width = 0; // Зменшуємо товщину рамки

            // Додаємо дві колонки
            Column clientColumn = clientCarTable.AddColumn(Unit.FromCentimeter(10)); // Встановлюємо ширину у 7.5 сантиметра
            Column carColumn = clientCarTable.AddColumn(Unit.FromCentimeter(10)); // Встановлюємо ширину у 7.5 сантиметра

            // Додаємо один рядок
            Row infoRow = clientCarTable.AddRow();
            infoRow.Height = 50; // Встановлюємо висоту рядка (можна змінити за потребою)
            #endregion
            #region client
            // Дані клієнта
            Paragraph clientInfo = infoRow.Cells[0].AddParagraph();
            clientInfo.AddFormattedText("Дані клієнта:", TextFormat.Bold);
            clientInfo.AddLineBreak();
            clientInfo.AddText($"Ім'я: {data[2]}");
            clientInfo.AddLineBreak();
            clientInfo.AddText($"Прізвище: {data[3]}");
            clientInfo.AddLineBreak();
            clientInfo.AddText($"Номер телефону: {data[4]}");
            clientInfo.AddLineBreak();
            clientInfo.AddText($"Адреса: {data[5]}");
            #endregion
            #region car
            // Дані автомобіля
            Paragraph carInfo = infoRow.Cells[1].AddParagraph();
            carInfo.AddFormattedText("Дані автомобіля:", TextFormat.Bold);
            carInfo.AddLineBreak();
            carInfo.AddText($"Марка: {data[6]}");
            carInfo.AddLineBreak();
            carInfo.AddText($"Модель: {data[7]}");
            carInfo.AddLineBreak();
            carInfo.AddText($"Двигун: {data[8]}");
            carInfo.AddLineBreak();
            carInfo.AddText($"Номер кузова: {VIN}");
            #endregion
            #endregion
            #region table history
            // Додавання простору
            section.AddParagraph();

            // Додавання заголовку "Історія машини"
            Paragraph carHistoryTitle = section.AddParagraph("Історія машини");
            carHistoryTitle.Format.Font.Size = 14;
            #region create a table of history
            // Додавання таблиці "Історія машини"
            Table historyTable = section.AddTable();
            historyTable.Borders.Width = 0.75;
            historyTable.Format.Alignment = ParagraphAlignment.Center;

            // Додаємо колонки до таблиці
            for (int i = 0; i < 6; i++)
            {
                Column column = historyTable.AddColumn();
                column.Width = 80; // Зменшуємо ширину колонок
                if (i == 5)
                    column.Width = 120;
            }

            Row headerRow = historyTable.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Cells[0].AddParagraph("Дата прийняття");
            headerRow.Cells[1].AddParagraph("Пробіг");
            headerRow.Cells[2].AddParagraph("Завдання");
            headerRow.Cells[3].AddParagraph("Діагностика");
            headerRow.Cells[4].AddParagraph("Ремонт");
            headerRow.Cells[5].AddParagraph("VIN");
            #endregion
            #region add data to table
            Row dataRow = historyTable.AddRow();
            dataRow.Cells[0].AddParagraph(data[10]);
            dataRow.Cells[1].AddParagraph(data[12]);
            dataRow.Cells[2].AddParagraph(data[16]);
            dataRow.Cells[3].AddParagraph(data[17]);
            dataRow.Cells[4].AddParagraph(data[18]);
            // Зменшуємо розмір шрифту для тексту VIN
            Paragraph vinParagraph = dataRow.Cells[5].AddParagraph();
            vinParagraph.AddText(VIN);
            vinParagraph.Format.Font.Size = 10; // Зменшуємо розмір шрифту
            #endregion                                 // Додавання лінії для підпису клієнта
            #endregion
            #region save pdf
            // Збереження документу
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
            renderer.Document = document;
            renderer.RenderDocument();
            renderer.PdfDocument.Save("PDF.pdf");
            #endregion

        }
    }
}
