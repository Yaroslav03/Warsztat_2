using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System.Data.SQLite;

namespace Warsztat_2 {
    internal class GeneretePDF {
        private readonly string connectionString = "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;";
        private string VIN = "";
        private readonly string[] sqlcommand = {
            "SELECT Imię, Nazwisko, NrTelefonu, AdresFirmy FROM Klienty",
            "SELECT Marka, Model, Silnik, RokProdukcji FROM Samochód",
            "SELECT DataPrzyjęcia, NrRejestracji, Przebieg, DokumentySamochodu, KluczykiSamochodu, TestDrive, Zlecenie, Diagnostyka, Naprawa FROM HistoriaNapraw",
            "SELECT Opis, NumerCzęści, Cena, Ilość FROM NaprawaSamochodu",
            "SELECT DataPrzyjęcie, DataOczekiwaniaOdbioru, DataPłatności, MetodaPłatności, KosztSzacunkowy, KosztKońcowy, KosztZMarżą, KosztCałkowityCzęści, WykonanaPraca, WykonawcaPracy FROM ZarządzanieZleceniami",


        };

        readonly private string[] companyColumn = { "NazwaFirmy", "AdresFirmy" };
        readonly private string[] clientColumn = { "Imię", "Nazwisko", "NrTelefonu", "AdresFirmy" };
        readonly private string[] carColumn = { "Marka", "Model", "Silnik", "RokProdukcji", };
        readonly private string[] historyColumn = { "DataPrzyjęcia", "NrRejestracji", "Przebieg", "DokumentySamochodu", "KluczykiSamochodu", "TestDrive", "Zlecenie", "Diagnostyka", "Naprawa" };
        readonly private string[] repairColumn = { "Opis", "NumerCzęści", "Cena", "Ilość" };
        readonly private string[] orderManagementColumn = { "DataPrzyjęcie", "DataOczekiwaniaOdbioru", "DataPłatności", "MetodaPłatności", "KosztSzacunkowy", "KosztKońcowy", "KosztZMarżą", "KosztCałkowityCzęści", "WykonanaPraca", "WykonawcaPracy" };

        readonly private string[] company = new string[2];
        readonly private string[] client = new string[4];
        readonly private string[] car = new string[4];
        readonly private string[] history = new string[9];
        readonly private string[] repair = new string[4];
        readonly private string[] orderManagement = new string[12];

        readonly private string directory = "pdf\\";
        public void Create(string vin)
            {
            VIN = vin;
            string path = directory + vin;
            Read(); //read Data
            WritePDF();
            MessageBox.Show("PDF generated successfully!");
            MessageBox.Show("" + System.IO.File.Exists(path + "\\PDF.pdf"));
            /*            if (System.IO.File.Exists(directory + VIN + "\\PDF.pdf"))
                        {
                            Process.Start($"{directory + VIN}\\PDF.pdf");
                        }*/

            }
        private void Read()
            {
            string[][] columnArrays = { clientColumn, carColumn, historyColumn, repairColumn, orderManagementColumn };
            string[][] dataArrays = { client, car, history, repair, orderManagement };

            using SQLiteConnection conn = new(connectionString);
            conn.Open();
            using SQLiteCommand readComapny = new("SELECT NazwaFirmy, AdresFirmy FROM  DaneFirmy", conn);
            using SQLiteDataReader reader = readComapny.ExecuteReader();

            while(reader.Read())
                {
                company[0] = $"{reader[companyColumn[0]]}";
                company[1] = $"{reader[companyColumn[1]]}";
                }

            for(int i = 0;i < sqlcommand.Length;i++)
                {
                using SQLiteCommand cmd = new(sqlcommand[i] + $" WHERE VIN LIKE '%{VIN}'", conn);
                using SQLiteDataReader read = cmd.ExecuteReader();
                while(read.Read())
                    {
                    foreach(string column in columnArrays[i])
                        {
                        dataArrays[i][Array.IndexOf(columnArrays[i], column)] = $"{read[column]}";
                        }
                    }
                }
            }
        private void WritePDF()
            {
            string[] clientWrite = { "Imię", "Nazwisko", "Nr. kontaktowy", "Adres" };
            string[] carWrite = { "Marka", "Model", "Engine", "Rok produkcji" };
            string[] orderManagementWrite = { "Przyjęty", "Oddany", "Data płatności", "Sposób płatności", "Koszt szacunkowy", "Koszt końcowy", "Cena na części wraz z marżą" };
            #region generetePDF
            Document document = new();
            Section section = document.AddSection();
            #endregion
            #region title
            // Додавання тексту "Назва фірми"
            Paragraph companyName = section.AddParagraph(company[0]);
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

            for(byte x = 0;x < clientWrite.Length;x++)
                {
                clientInfo.AddLineBreak();
                clientInfo.AddText($"{clientWrite[x]}: {client[x]}");
                }
            #endregion
            #region car
            // Дані автомобіля
            Paragraph carInfo = infoRow.Cells[1].AddParagraph();
            carInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            carInfo.AddFormattedText("Dane samochodu:", TextFormat.Bold);
            for(byte x = 0;x < carWrite.Length;x++)
                {
                carInfo.AddLineBreak();
                carInfo.AddText($"{carWrite[x]}: {car[x]}");
                }
            carInfo.AddLineBreak();
            carInfo.AddText($"Numer nadwozia: {VIN}");
            #endregion
            #endregion

            #region table history
            // Додавання простору
            section.AddParagraph();

            // Додавання заголовку "Історія машини"
            Paragraph carHistoryTitle = section.AddParagraph("Historia samochodu u " + company[0]);
            carHistoryTitle.Format.Font.Name = "Courier New"; // Задати назву шрифта
            carHistoryTitle.Format.Font.Size = 14;
            #region create a table of history
            // Додавання таблиці "Історія машини"
            Table historyTable = section.AddTable();
            historyTable.Format.Font.Name = "Courier New"; // Задати назву шрифта
            historyTable.Borders.Width = 0.75;
            historyTable.Format.Alignment = ParagraphAlignment.Center;

            // Додаємо колонки до таблиці
            for(byte i = 0;i < 6;i++)
                {
                Column column = historyTable.AddColumn();
                column.Width = 80; // Зменшуємо ширину колонок
                if(i == 5)
                    column.Width = 120;
                }

            Row headerRow = historyTable.AddRow();
            headerRow.Format.Font.Name = "Courier New"; // Задати назву шрифта
            headerRow.HeadingFormat = true;
            string[] historyWriteTable = { "Data przyjęcia", "Nr Rejestracji", "Przebieg", "Zlecenie", "Diagnostyka", "Naprawa" };

            for(byte x = 0;x < historyWriteTable.Length;x++)
                headerRow.Cells[x].AddParagraph(historyWriteTable[x]);

            #endregion
            #region add data to table
            Row dataRow = historyTable.AddRow();
            dataRow.Format.Font.Name = "Courier New"; // Задати назву шрифта
            dataRow.Format.Font.Size = 10;
            dataRow.Cells[0].AddParagraph(history[0]);
            dataRow.Cells[1].AddParagraph(history[1]);
            dataRow.Cells[2].AddParagraph(history[2]);
            dataRow.Cells[3].AddParagraph(history[6]);
            dataRow.Cells[4].AddParagraph(history[7]);
            dataRow.Cells[5].AddParagraph(history[8]);
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

            for(byte i = 0;i < 4;i++)
                {
                Column columnRepair = RepairTable.AddColumn();
                columnRepair.Width = 200; // Зменшуємо ширину колонок
                if(i > 1)
                    columnRepair.Width = 60;
                }

            Row rowRepair = RepairTable.AddRow();

            rowRepair.HeadingFormat = true;
            rowRepair.Format.Font.Name = "Courier New"; // Задати назву шрифта

            string[] RepairWriteTable = { "Opis", "Numer części", "Cena", "Ilość" };
            for(byte x = 0;x < RepairWriteTable.Length;x++)
                rowRepair.Cells[x].AddParagraph(RepairWriteTable[x]);

            #endregion
            #region add repair data to table
            // Перевіряємо, чи не вийшли за межі списку repairData
            int rowCount = (int)Math.Ceiling((double)repair.Length / 4);
            for(byte row = 0;row < rowCount;row++)
                {
                Row dataRowRepair = RepairTable.AddRow();
                dataRowRepair.Format.Font.Name = "Courier New"; // Задати назву шрифта
                dataRowRepair.Format.Font.Size = 10;
                for(byte columnIndex = 0;columnIndex < 4;columnIndex++)
                    {
                    int dataIndex = row * 4 + columnIndex; // Індекс поточного елемента в масиві repair
                                                           // Перевіряємо, чи не вийшли за межі масиву repair
                    if(dataIndex < repair.Length)
                        {
                        dataRowRepair.Cells[columnIndex].AddParagraph(repair[dataIndex]);
                        }
                    }
                }
            Paragraph sumPriceRepair = section.AddParagraph($"Łączna cena: {orderManagement[7]}");
            sumPriceRepair.AddLineBreak();
            sumPriceRepair.Format.Font.Name = "Courier New"; // Задати назву шрифта
            sumPriceRepair.Format.Font.Size = 10;



            #endregion
            #endregion
            #region OrderManagement
            string leftDocument = (history[4] == "1") ? "Klient zostawił dokumenty" : "Klient nie zostawił dokumentów";
            string leftKey = (history[5] == "1") ? "Klient zostawił klucze samochodowe" : "Klient nie zostawił kluczyków samochodowych"; ;
            string TestDrive = (history[6] == "1") ? "Klient wyraża zgodę na jazdę próbną" : "Klient nie wyrażił zgody na jazdę próbną"; ;
            section.AddParagraph();
            Paragraph OrderManagementTitle = section.AddParagraph("Zlecenie");
            OrderManagementTitle.Format.Font.Name = "Courier New"; // Задати назву шрифта
            OrderManagementTitle.Format.Font.Size = 14;

            Paragraph orderManagementInfo = section.AddParagraph();
            orderManagementInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            orderManagementInfo.Format.Font.Size = 10;

            for(byte x = 0;x < orderManagementWrite.Length;x++)
                {
                orderManagementInfo.AddLineBreak();
                orderManagementInfo.AddText($"{orderManagementWrite[x]}: {orderManagement[x]}");
                }

            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"Zostawione Dokumenty od samochodu: {leftDocument}");
            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"Zostawione kluczyki od samochodu: {leftKey}");
            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"TestDrive: {TestDrive}");
            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"Kto wykonał robotę: {orderManagement[9]}");
            #endregion
            #region signature
            // Створюємо прямокутник
            // Create a TextFrame for the page header
            section.AddParagraph();
            Table table0 = section.AddTable();
            table0.Borders.Width = 0;

            Column column0 = table0.AddColumn(Unit.FromCentimeter(10));
            Column column1 = table0.AddColumn(Unit.FromCentimeter(10));


            Row row0 = table0.AddRow();

            row0.Height = 100;
            DrawReactangle(section, row0, 0, "Podpis Klienta");//Прямокутник по лівій стороні
            DrawReactangle(section, row0, 1, "Pieczątka Firmy");//Прямокутник по правій стороні
            #endregion
            #region save pdf
            // Збереження документу

            PdfDocumentRenderer renderer = new()
                {
                Document = document
                };
            renderer.RenderDocument();
            if(!Directory.Exists(directory + VIN)) // string path = directory + vin;           rivate string directory = "pdf\\";
                {
                Directory.CreateDirectory(directory + VIN);
                }
            renderer.PdfDocument.Save($"{directory + VIN}\\PDF.pdf");
            #endregion
            #region clear Data
            #endregion
            }
        private void DrawReactangle(Section section, Row row, byte num, string text)
            {
            TextFrame footerFrame1 = row.Cells[num].AddTextFrame();

            Paragraph tableData1 = row.Cells[num].AddParagraph();
            tableData1.Format.Font.Name = "Courier New"; // Задати назву шрифта
            tableData1.AddFormattedText(text, TextFormat.Bold);


            footerFrame1.Width = 100;
            footerFrame1.Height = 50; // Висота прямокутника
            footerFrame1.LineFormat.Color = MigraDoc.DocumentObjectModel.Colors.Black; // Колір межі
            footerFrame1.LineFormat.Width = 1; // Ширина межі
            footerFrame1.Left = 0; // Позиція по лівому краю
            footerFrame1.Top = section.PageSetup.PageHeight; // Позиція по верхньому краю
            }
        }
    }