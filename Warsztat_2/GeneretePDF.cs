using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System.ComponentModel;
using System.Diagnostics;

namespace Warsztat_2 {
    internal class GeneretePDF {

        readonly private string directory = "pdf\\";
        Guid uniqueKey;
        public void Create(Guid key)
            {
            uniqueKey = key;
            CreatePDF();
            }

        private async void CreatePDF()
            {

            #region ReadData
            var companyData = await SqlCmd.LoadDataAsync("WarsztatDB", "DaneFirmy");
            var clientData = await SqlCmd.LoadDataAsync("WarsztatDB", "Klienty", null, "UniqueKey", uniqueKey);
            var carData = await SqlCmd.LoadDataAsync("WarsztatDB", "Samochód", null, "UniqueKey", uniqueKey);
            var repairCarData = await SqlCmd.LoadListAsync("NaprawaSamochodu", "Opis, NumerCzęści, Cena, Ilość", "UniqueKey", uniqueKey);
            var historyRepairData = await SqlCmd.LoadDataAsync("WarsztatDB", "HistoriaNapraw", null, "UniqueKey", uniqueKey);
            var managementData = await SqlCmd.LoadDataAsync("WarsztatDB", "ZarządzanieZleceniem", null, "UniqueKey", uniqueKey);

            #endregion
            #region generetePDF
            Document document = new();
            Section section = document.AddSection();
            #endregion
            #region title
            // Додавання тексту "Назва фірми"
            Paragraph companyName = section.AddParagraph($"{companyData["NazwaFirmy"]}");
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
            clientInfo.AddText($"Imię: {clientData["Imię"]}");

            clientInfo.AddLineBreak();
            clientInfo.AddText($"Nazwisko: {clientData["Nazwisko"]}");

            clientInfo.AddLineBreak();
            clientInfo.AddText($"Nr. Telefonu: {clientData["NrTelefonu"]}");

            clientInfo.AddLineBreak();
            clientInfo.AddText($"Adres: {clientData["AdresFirmy"]}");


            #endregion
            #region car
            // Дані автомобіля
            Paragraph carInfo = infoRow.Cells[1].AddParagraph();
            carInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            carInfo.AddFormattedText("Dane samochodu:", TextFormat.Bold);

            string[] CarTable = { "Marka", "Model", "Silnik", "RokProdukcji", "VIN" };
            string[] CarData = { "Marka", "Model", "Silnik", "Rok produkcji", "Numer nadwozia" };
            for(byte x = 0;x < CarTable.Length;x++)
                {
                carInfo.AddLineBreak();
                carInfo.AddText($"{CarData[x]}: {carData[CarTable[x]]}");
                }
            #endregion
            #endregion

            #region table history
            // Додавання простору
            section.AddParagraph();

            // Додавання заголовку "Історія машини"
            Paragraph carHistoryTitle = section.AddParagraph("Historia samochodu u " + $"{companyData["NazwaFirmy"]}");
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
            string[] historyWriteTable = { "Data przyjęcia", "Numer Rejestracji", "Przebieg", "Zlecenie", "Diagnostyka", "Naprawa" };

            for(byte x = 0;x < historyWriteTable.Length;x++)
                headerRow.Cells[x].AddParagraph(historyWriteTable[x]);

            #endregion
            #region add data to table
            Row dataRow = historyTable.AddRow();
            dataRow.Format.Font.Name = "Courier New"; // Задати назву шрифта
            dataRow.Format.Font.Size = 10;
            string[] historyRepairTable = { "DataPrzyjęcia", "NrRejestracji", "Przebieg", "Zlecenie", "Diagnostyka", "Naprawa" };
            for(byte x = 0;x <= 5;x++)
                dataRow.Cells[x].AddParagraph($"{historyRepairData[historyRepairTable[x]]}");

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
            /*            foreach(var data in repairCarData)
                            {
                            Row dataRowRepair = RepairTable.AddRow();
                            dataRowRepair.Format.Font.Name = "Courier New"; // Задати назву шрифта
                            dataRowRepair.Format.Font.Size = 10;
                            }*/
            foreach(var repairItem in repairCarData)
                {
                Row dataRowRepair = RepairTable.AddRow();
                dataRowRepair.Format.Font.Name = "Courier New"; // Задати назву шрифта
                dataRowRepair.Format.Font.Size = 10;

                dataRowRepair.Cells[0].AddParagraph(repairItem.ContainsKey("Opis") ? repairItem["Opis"].ToString() : "");
                dataRowRepair.Cells[1].AddParagraph(repairItem.ContainsKey("NumerCzęści") ? repairItem["NumerCzęści"].ToString() : "");
                dataRowRepair.Cells[2].AddParagraph(repairItem.ContainsKey("Cena") ? repairItem["Cena"].ToString() : "");
                dataRowRepair.Cells[3].AddParagraph(repairItem.ContainsKey("Ilość") ? repairItem["Ilość"].ToString() : "");
                }
            Paragraph sumPriceRepair = section.AddParagraph($"Łączna cena: {managementData["KosztCzęści"]}");
            sumPriceRepair.AddLineBreak();
            sumPriceRepair.Format.Font.Name = "Courier New"; // Задати назву шрифта
            sumPriceRepair.Format.Font.Size = 10;

            #endregion
            #endregion
            #region OrderManagement
            string leftDocument = (historyRepairData["DokumentySamochodu"].ToString() == "1") ? "Klient zostawił dokumenty" : "Klient nie zostawił dokumentów";
            string leftKey = (historyRepairData["KluczykiSamochodu"].ToString() == "1") ? "Klient zostawił klucze samochodowe" : "Klient nie zostawił kluczyków samochodowych"; ;
            string TestDrive = (historyRepairData["TestDrive"].ToString() == "1") ? "Klient wyraża zgodę na jazdę próbną" : "Klient nie wyrażił zgody na jazdę próbną"; ;
            managementData.Add("leftDocument", leftDocument);
            managementData.Add("leftKey", leftKey);
            managementData.Add("TestDrive", TestDrive);
            section.AddParagraph();
            Paragraph OrderManagementTitle = section.AddParagraph("Zlecenie");
            OrderManagementTitle.Format.Font.Name = "Courier New"; // Задати назву шрифта
            OrderManagementTitle.Format.Font.Size = 14;

            Paragraph orderManagementInfo = section.AddParagraph();
            orderManagementInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            orderManagementInfo.Format.Font.Size = 10;

            string[] data0 = { "Data oczekiwania odbioru", "Data Płatności", "Sposób płatności", "cena na części wraz z marżą", "Koszt pracy ręcznej", "koszt końcowy", "Zostawione Dokumenty od samochodu", "Zostawione kluczyki od samochodu", "TestDrive", "Kto wykonał robotę" };
            string[] data1 = { "DataOczekiwaniaOdbioru", "DataPłatności", "MetodaPłatności",  "KosztCzęściZMarżą", "KosztPracyRęcznej", "KosztKońcowy", "leftDocument", "leftKey", "TestDrive", "WykonawcaPracy" };

            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"Przyjęty: {historyRepairData["DataPrzyjęcia"]}");
            for(byte x = 0;x < data0.Length;x++)
                {
                orderManagementInfo.AddLineBreak();
                orderManagementInfo.AddText($"{data0[x]}: {managementData[data1[x]]}");
                }
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
            if(!Directory.Exists(directory + carData["VIN"].ToString())) // string path = directory + vin;           rivate string directory = "pdf\\";
                {
                Directory.CreateDirectory(directory + carData["VIN"].ToString());
                }
            renderer.PdfDocument.Save($"{directory + carData["VIN"].ToString()}\\PDF_{historyRepairData["DataPrzyjęcia"]}.pdf");

            //Process.Start($"{directory + carData["VIN"].ToString()}\\PDF_{historyRepairData["DataPrzyjęcia"]}.pdf");

            string path = Path.Combine($"{directory + carData["VIN"].ToString()}\\PDF_{historyRepairData["DataPrzyjęcia"]}.pdf");

            try // Спосіб 1: відкрити PDF через асоційовану програму Windows (якщо встановлена)
                {
                Process.Start(new ProcessStartInfo
                    {
                    FileName = path,
                    UseShellExecute = true,
                    Verb = "open"
                    });
                }
            catch(Win32Exception ex)
                {
                // У більшості випадків це означає, що Windows не знає, чим відкрити PDF
                // Тому можна спробувати відкрити через браузер (Edge, Chrome, Opera).

                MessageBox.Show("Nie znaleziono domyślnej aplikacji do plików PDF. Spróbujemy otworzyć w przeglądarce...",
                    "Brak aplikacji PDF", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Спосіб 2: fallback на Microsoft Edge (якщо встановлений)
                // або інший браузер — вирішуйте, який хочете використовувати.
                try
                    {
                    Process.Start("msedge.exe", $"\"{path}\"");
                    }
                catch(Exception ex2)
                    {
                    MessageBox.Show($"Niestety nie udało się otworzyć w przeglądarce (Edge). Błąd: {ex2.Message}",
                        "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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