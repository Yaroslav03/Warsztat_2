using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System.Data.SQLite;

namespace Warsztat_2
{
    internal class GeneretePDF
    {
        private readonly string connectionString = "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;";
        private string VIN ="";
        private string[] sqlcommand = {
            "SELECT Imię, Nazwisko, NrTelefonu, AdresFirmy FROM Klienty",
            "SELECT Marka, Model, Silnik, RokProdukcji FROM Samochód",
            "SELECT DataPrzyjęcia, NrRejestracji, Przebieg, DokumentySamochodu, KluczykiSamochodu, TestDrive, Zlecenie, Diagnostyka, Naprawa FROM HistoriaNapraw",
            "SELECT Opis, NumerCzęści, Cena, Ilość FROM NaprawaSamochodu",
            "SELECT Przyjęty, OczekujeNaOdbiór, DataPrzyjęcie, DataOczekiwaniaOdbioru, DataPłatności, MetodaPłatności, KosztSzacunkowy, KosztKońcowy, KosztZMarżą, WykonanaPraca, WykonawcaPracy FROM ZarządzanieZleceniami",


        };
        private List<string> repairData = new();
        private List<string> data = new();

        private string[] companyColumn = { "NazwaFirmy", "AdresFirmy" };
        private string[] clientColumn = { "Imię", "Nazwisko", "NrTelefonu", "AdresFirmy" };
        private string[] carColumn = { "Marka", "Model", "Silnik", "RokProdukcji", };//10-1
        private string[] historyColumn = { "DataPrzyjęcia", "NrRejestracji", "Przebieg", "DokumentySamochodu", "KluczykiSamochodu", "TestDrive", "Zlecenie", "Diagnostyka", "Naprawa" }; //18-1
        private string[] repairColumn = { "Opis", "NumerCzęści", "Cena", "Ilość" };
        private string[] orderManagementColumn = {"Przyjęty", "OczekujeNaOdbiór", "DataPrzyjęcie", "DataOczekiwaniaOdbioru", "DataPłatności", "MetodaPłatności", "KosztSzacunkowy", "KosztKońcowy", "KosztZMarżą", "WykonanaPraca", "WykonawcaPracy" };//27

        private string directory = "pdf\\";
        public void Create(string vin)
        {
            VIN = vin;
            string path = directory + vin;
            read(); //read Data
            WritePDF();
            MessageBox.Show("PDF generated successfully!");
            /*if (Directory.Exists(path))
            {
                Process.Start($"{path}\\PDF.pdf");
            }            
*/
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
                data.Add($"{reader[companyColumn[0]]}");
                data.Add($"{reader[companyColumn[1]]}");
            }

            for (int i = 0; i < sqlcommand.Length; i++)
            {
                using SQLiteCommand cmd = new(sqlcommand[i] + $" WHERE VIN LIKE '%{VIN}'", conn);
                using SQLiteDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    foreach (string column in columnArrays[i])
                    {
                        if (i == 3)
                        {
                            repairData.Add($"{read[column]}");
                        }
                        else if(i != 3)
                        {
                        data.Add($"{read[column]}");
                        }
                        
                    }
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
            companyName.Format.Font.Name = "Courier New"; // Задати назву шрифта
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
            clientInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            clientInfo.AddFormattedText("Dane klienta:", TextFormat.Bold);
            clientInfo.AddLineBreak();
            clientInfo.AddText($"Imię: {data[2]}");
            clientInfo.AddLineBreak();
            clientInfo.AddText($"Nazwisko: {data[3]}");
            clientInfo.AddLineBreak();
            clientInfo.AddText($"Nr. kontaktowy: {data[4]}");
            clientInfo.AddLineBreak();
            clientInfo.AddText($"Adres: {data[5]}");
            #endregion
            #region car
            // Дані автомобіля
            Paragraph carInfo = infoRow.Cells[1].AddParagraph();
            carInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            carInfo.AddFormattedText("Dane samochodu:", TextFormat.Bold);
            carInfo.AddLineBreak();
            carInfo.AddText($"Marka: {data[6]}");
            carInfo.AddLineBreak();
            carInfo.AddText($"Model: {data[7]}");
            carInfo.AddLineBreak();
            carInfo.AddText($"Engine: {data[8]}");
            carInfo.AddLineBreak();
            carInfo.AddText($"Numer nadwozia: {VIN}");
            #endregion
            #endregion

            #region table history
            // Додавання простору
            section.AddParagraph();

            // Додавання заголовку "Історія машини"
            Paragraph carHistoryTitle = section.AddParagraph("Historia samochodu u " + data[0]);
            carHistoryTitle.Format.Font.Name = "Courier New"; // Задати назву шрифта
            carHistoryTitle.Format.Font.Size = 14;
            #region create a table of history
            // Додавання таблиці "Історія машини"
            Table historyTable = section.AddTable();
            historyTable.Format.Font.Name = "Courier New"; // Задати назву шрифта
            historyTable.Borders.Width = 0.75;
            historyTable.Format.Alignment = ParagraphAlignment.Center;

            // Додаємо колонки до таблиці
            for (byte i = 0; i < 6; i++)
            {
                Column column = historyTable.AddColumn();
                column.Width = 80; // Зменшуємо ширину колонок
                if (i == 5)
                    column.Width = 120;
            }

            Row headerRow = historyTable.AddRow();
            headerRow.Format.Font.Name = "Courier New"; // Задати назву шрифта
            headerRow.HeadingFormat = true;
            headerRow.Cells[0].AddParagraph("Data przyjęcia");
            headerRow.Cells[1].AddParagraph("Nr Rejestracji");
            headerRow.Cells[2].AddParagraph("Przebieg");
            headerRow.Cells[3].AddParagraph("Zlecenie");
            headerRow.Cells[4].AddParagraph("Diagnostyka");
            headerRow.Cells[5].AddParagraph("Naprawa");
            #endregion
            #region add data to table
            Row dataRow = historyTable.AddRow();
            dataRow.Format.Font.Name = "Courier New"; // Задати назву шрифта
            dataRow.Format.Font.Size = 10;
            dataRow.Cells[0].AddParagraph(data[10]);
            dataRow.Cells[1].AddParagraph(data[11]);
            dataRow.Cells[2].AddParagraph(data[12]);
            dataRow.Cells[3].AddParagraph(data[16]);
            dataRow.Cells[4].AddParagraph(data[17]);
            dataRow.Cells[5].AddParagraph(data[18]);
            #endregion                                 // Додавання лінії для підпису клієнта
            #endregion
            #region table of repair
            // Додавання простору
            section.AddParagraph();

            Paragraph RepairTitle = section.AddParagraph("Zamówione części");
            RepairTitle.Format.Font.Name = "Courier New"; // Задати назву шрифта
            RepairTitle.Format.Font.Size = 14;
            #region create a table of repair
            // Додавання таблиці "Історія машини"
            Table RepairTable = section.AddTable();
            RepairTable.Borders.Width = 0.75;
            RepairTable.Format.Alignment = ParagraphAlignment.Center;

            // Додаємо колонки до таблиці

            for (byte i = 0; i < 4; i++)
            {
                Column columnRepair = RepairTable.AddColumn();
                columnRepair.Width = 200; // Зменшуємо ширину колонок
                if (i > 1)
                    columnRepair.Width = 60;
            }

            Row rowRepair = RepairTable.AddRow();

            rowRepair.HeadingFormat = true;
            rowRepair.Format.Font.Name = "Courier New"; // Задати назву шрифта

            rowRepair.Cells[0].AddParagraph("Opis");
            rowRepair.Cells[1].AddParagraph("Numer części");
            rowRepair.Cells[2].AddParagraph("Cena");
            rowRepair.Cells[3].AddParagraph("Ilość");
            #endregion
            #region add repair data to table
            // Перевіряємо, чи не вийшли за межі списку repairData
            int rowCount = (int)Math.Ceiling((double)repairData.Count) / 4;
            for (byte row = 0; row < rowCount; row++)
            {
                Row dataRowRepair = RepairTable.AddRow();
                dataRowRepair.Format.Font.Name = "Courier New"; // Задати назву шрифта
                dataRowRepair.Format.Font.Size = 10;
                for (byte columnIndex = 0; columnIndex < 4; columnIndex++)
                {
                    int dataIndex = row * 4 + columnIndex;// Індекс поточного елемента в списку repairData
                    // Перевіряємо, чи не вийшли за межі списку repairData
                    if (dataIndex < repairData.Count)
                    {
                        dataRowRepair.Cells[columnIndex].AddParagraph(repairData[dataIndex++]);
                    }
                }
            }

            #endregion
            #endregion
            #region OrderManagement
            string leftDocument = (data[13] == "1") ? "Klient zostawił dokumenty":"Klient nie zostawił dokumentów";
            string leftKey = (data[14] == "1") ? "Klient zostawił klucze samochodowe" : "Klient nie zostawił kluczyków samochodowych"; ;
            string TestDrive = (data[15] == "1") ? "Klient wyraża zgodę na jazdę próbną" : "Klient nie wyrażił zgody na jazdę próbną"; ;
            section.AddParagraph();
            Paragraph OrderManagementTitle = section.AddParagraph("Zlecenie");
            OrderManagementTitle.Format.Font.Name = "Courier New"; // Задати назву шрифта
            OrderManagementTitle.Format.Font.Size = 14;

            Paragraph orderManagementInfo = section.AddParagraph(); 
            orderManagementInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            orderManagementInfo.Format.Font.Size = 10;
            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"Przyjęty: {data[21]}");
            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"Oddany: {data[22]}");
            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"Data płatności: {data[23]}");
            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"Sposób płatności: {data[24]}");
            /*orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"Koszt szacunkowy: {data[23]}");*/
            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"Koszt końcowy: {data[26]}");
            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"Cena na części wraz z marżą: {data[27]}");
            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"Zostawione Dokumenty od samochodu: {leftDocument}");
            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"Zostawione kluczyki od samochodu: {leftKey}");
            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"TestDrive: {TestDrive}");
            orderManagementInfo.AddLineBreak();
            MessageBox.Show(data.Count.ToString());
            orderManagementInfo.AddText($"Kto wykonał robotę: {data[29]}");
            #endregion
            #region save pdf
            // Збереження документу

            PdfDocumentRenderer renderer = new();
            renderer.Document = document;
            renderer.RenderDocument();
            if (!Directory.Exists(directory + VIN)) // string path = directory + vin;           rivate string directory = "pdf\\";
            {
                Directory.CreateDirectory(directory + VIN);
            }
            renderer.PdfDocument.Save($"{directory + VIN}\\PDF.pdf");
            #endregion
            #region clear Data
            data.Clear();
            repairData.Clear();
            #endregion
        }
    }
}
