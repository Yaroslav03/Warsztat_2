using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;

namespace Warsztat_2 {
    internal class GeneretePDF {

        readonly private string directory = "pdf\\";
        Guid uniqueKey;
        public void InvoicePDF(Guid key)
            {
            uniqueKey = key;
            CreateInvoicePDF();
            }
        public void OrderPDF(Guid key)
            {
            uniqueKey = key;
            CreateOrderPDF();
            }
        public void GeneratePDFSecondType(Guid key)
            {
            uniqueKey = key;
            ClientAgreeToPayIfRefused();
            }
        private async void ClientAgreeToPayIfRefused()
            {
            #region ReadData
            var companyData = await SqlCmd.LoadDataAsync("WarsztatDB", "DaneFirmy");
            var clientData = await SqlCmd.LoadDataAsync("WarsztatDB", "Klienty", null, "UniqueKey", uniqueKey);
            var carData = await SqlCmd.LoadDataAsync("WarsztatDB", "Samochód", null, "UniqueKey", uniqueKey);
            var HistoryData = await SqlCmd.LoadDataAsync("WarsztatDB", "HistoriaNapraw", null, "UniqueKey", uniqueKey);
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
            #region TitleDocuments
            Paragraph SecondTitle = section.AddParagraph($"UMOWA NA ŚWIADCZENIE USŁUG DIAGNOSTYKI \n Miejscowość {companyData["AdresFirmy"]}, dnia {DateTime.Now.ToString("D")}");
            SecondTitle.Format.Font.Name = "Courier New"; // Задати назву шрифта
            SecondTitle.Format.Font.Size = 10;
            SecondTitle.Format.Alignment = ParagraphAlignment.Center;

            #endregion
            #region Section Client && Przedsiebiorca
            #region set two data but in diferent sides
            Table clientEntrepreneurTable = section.AddTable();
            clientEntrepreneurTable.Borders.Width = 0; // Зменшуємо товщину рамки

            // Додаємо дві колонки
            Column clientColumn = clientEntrepreneurTable.AddColumn(Unit.FromCentimeter(10)); // Встановлюємо ширину у 7.5 сантиметра
            Column EntrepreneurColumn = clientEntrepreneurTable.AddColumn(Unit.FromCentimeter(10)); // Встановлюємо ширину у 7.5 сантиметра

            // Додаємо один рядок
            Row infoRow = clientEntrepreneurTable.AddRow();
            infoRow.Height = 50; // Встановлюємо висоту рядка (можна змінити за потребою)
            #endregion
            #region client
            // Дані клієнта
            Paragraph clientInfo = infoRow.Cells[0].AddParagraph();
            clientInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            clientInfo.AddFormattedText("Klient:", TextFormat.Bold);

            clientInfo.AddLineBreak();
            clientInfo.AddText($"{clientData["Imię"]} {clientData["Nazwisko"]},\n zwanny dalej zamawiającym.");

            #endregion
            #region car
            // Дані автомобіля
            Paragraph entrepreneurInfo = infoRow.Cells[1].AddParagraph();
            entrepreneurInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            entrepreneurInfo.AddFormattedText("Wykonawca usługi", TextFormat.Bold);

            entrepreneurInfo.AddLineBreak();
            entrepreneurInfo.AddText($"{companyData["NazwaFirmy"]},\n zwany dalej wykonawcą.");

            #endregion
            #endregion
            #region Treść
            Paragraph textData = section.AddParagraph();
            textData.Format.Font.Name = "Courier New"; // Задати назву шрифта
            textData.AddLineBreak();
            textData.AddText($"1. Przedmiot umowy\r\n" +
                $"1.1. Wykonawca zobowiązuje się do przeprowadzenia diagnostyki systemów elektrycznych i elektronicznych pojazdu marki {carData["Marka"]}, numer VIN {carData["VIN"]}, numer rejestracji {HistoryData["NrRejestracji"]}, w celu wykrycia usterek a Zamawiający zobowiązuje się do zapłaty za wykonane usługi.\r\n\r\n2. Warunki świadczenia usług\r\n" +
                $"2.1. Diagnostyka jest usługą płatną i podlega opłacie niezależnie od stopnia skomplikowania lub „prostoty” wykrytej usterki.\r\n" +
                $"2.2. Koszt diagnostyki wynosi ____ zł.\r\n" +
                $"2.3. Płatność następuje po zakończeniu diagnostyki.\r\n\r\n" +
                $"3. Obowiązki Stron\r\n" +
                $"3.1. Wykonawca zobowiązuje się:\r\n\r\nPrzeprowadzić diagnostykę zgodnie z profesjonalnymi standardami;\r\n\r\nPoinformować Zamawiającego o wynikach przeprowadzonych prac.\r\n\r\n\r\n" +
                $"3.2. Zamawiający zobowiązuje się:\r\n\r\nUdostępnić pojazd do przeprowadzenia diagnostyki;\r\n\r\nDokonać płatności za usługi Wykonawcy zgodnie z warunkami niniejszej umowy.\r\n\r\n\r\n" +
                $"4. Dodatkowe warunki\r\n" +
                $"4.1. Wykonawca nie ponosi odpowiedzialności za nowe usterki, które pojawiły się po przeprowadzeniu diagnostyki, jeśli nie są one związane z wykonanymi usługami.\r\n" +
                $"4.2. Zamawiający potwierdza, że rozumie złożoność procesu diagnostyki i akceptuje koszt usługi.\r\n\r\n" +
                $"5. Podpisy Stron\r\nPodpisując niniejszą umowę, Zamawiający potwierdza zgodę na wykonanie usług oraz zobowiązuje się do ich opłacenia.");

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
            renderer.PdfDocument.Save($"{directory + carData["VIN"].ToString()}\\PDF_Umowa_Po_Obu_Stron_Zgody{DateTime.Now.ToString("d_M__yyyy")}.pdf");
            ;

            string path = Path.Combine($"{directory + carData["VIN"].ToString()}\\PDF_Umowa_Po_Obu_Stron_Zgody{DateTime.Now.ToString("d_M__yyyy")}.pdf");

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
        private async void CreateOrderPDF()
            {

            #region ReadData
            var companyData = await SqlCmd.LoadDataAsync("WarsztatDB", "DaneFirmy");
            var clientData = await SqlCmd.LoadDataAsync("Archive", "Klienty", null, "UniqueKey", uniqueKey);
            var carData = await SqlCmd.LoadDataAsync("Archive", "Samochód", null, "UniqueKey", uniqueKey);
            var repairCarData = await SqlCmd.LoadListAsync("Archive", "NaprawaSamochodu", "Opis, NumerCzęści, Cena, Ilość", "UniqueKey", uniqueKey);
            var serviceData = await SqlCmd.LoadListAsync("Archive", "HistoriaUsług", "ServiceName, Price", "UniqueKey", uniqueKey);
            var historyRepairData = await SqlCmd.LoadDataAsync("Archive", "HistoriaNapraw", null, "UniqueKey", uniqueKey);
            var managementData = await SqlCmd.LoadDataAsync("Archive", "ZarządzanieZleceniem", null, "UniqueKey", uniqueKey);


            #endregion
            #region generetePDF
            Document document = new();
            Section section = document.AddSection();

            var ps = section.PageSetup;                // а не document.DefaultPageSetup
            ps.PageFormat = PageFormat.A4;
            ps.TopMargin = Unit.FromCentimeter(1.0);
            ps.BottomMargin = Unit.FromCentimeter(0.5);
            ps.LeftMargin = Unit.FromCentimeter(1.7);
            ps.RightMargin = Unit.FromCentimeter(1.7);
            ps.HeaderDistance = Unit.FromCentimeter(0.0);  // якщо хедера нема
            ps.FooterDistance = Unit.FromCentimeter(0.7);

            //Section section = document.AddSection();
            #endregion
            #region title Company
            // Додавання тексту "Назва фірми"
            Paragraph companyName = section.AddParagraph($"{companyData["NazwaFirmy"]}");
            companyName.Format.Font.Size = 22;
            companyName.Format.Font.Name = "Courier New"; // Задати назву шрифта
            companyName.Format.Alignment = ParagraphAlignment.Center;
            #endregion

            #region Section Company && Client
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
            #region company
            // Дані фірми
            Paragraph companyInfo = infoRow.Cells[0].AddParagraph();
            companyInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            companyInfo.Format.Font.Size = 11;
            companyInfo.AddFormattedText("Sprzedawca:", TextFormat.Bold);

            companyInfo.AddLineBreak();
            companyInfo.AddText($"Nazwa firmy: {companyData["NazwaFirmy"]}");

            companyInfo.AddLineBreak();
            companyInfo.AddText($"Adres Firmy: {companyData["AdresFirmy"]}");

            companyInfo.AddLineBreak();
            companyInfo.AddText($"NIP: {companyData["NIP"]}");

            companyInfo.AddLineBreak();
            companyInfo.AddText($"BDO: {companyData["BDO"]}");

            companyInfo.AddLineBreak();
            companyInfo.AddText($"Nr. telefonu: {companyData["NrTelefonu"]}");

            companyInfo.AddLineBreak();
            companyInfo.AddText($"E-mail: aleksauto@i.ua");

            companyInfo.AddLineBreak();
            companyInfo.AddText($"Konto Bankowe: {companyData["KontoBankowe"]}");

            #endregion
            #region Client
            Paragraph clientInfo = infoRow.Cells[1].AddParagraph();
            clientInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            clientInfo.Format.Font.Size = 11;
            clientInfo.AddFormattedText("Nabywca:", TextFormat.Bold);

            //clientInfo.AddLineBreak();
            //clientInfo.AddText($"Nazwa firmy: {companyData["NazwaFirmy"]}");

            clientInfo.AddLineBreak();
            clientInfo.AddText($"Adres Firmy: {clientData["AdresFirmy"]}");

            clientInfo.AddLineBreak();
            clientInfo.AddText($"NIP: {clientData["NIP"]}");

            clientInfo.AddLineBreak();
            clientInfo.AddText($"Nr. telefonu: {clientData["NrTelefonu"]}");

            #endregion
            #endregion

            #region data history
            // Додавання простору
            section.AddParagraph();

            // Додавання заголовку "Історія машини"
            Paragraph carHistoryTitle = section.AddParagraph();
            carHistoryTitle.AddFormattedText("Historia samochodu", TextFormat.Bold);
            carHistoryTitle.Format.Font.Name = "Courier New"; // Задати назву шрифта
            carHistoryTitle.Format.Font.Size = 14;

            AddBulletBlock(section, "Zlecenie:",
                           Convert.ToString(historyRepairData["Zlecenie"]) ?? string.Empty,
                           Colors.Black);

            AddBulletBlock(section, "Diagnostyka:",
                           Convert.ToString(historyRepairData["Diagnostyka"]) ?? string.Empty,
                           Colors.Red);

            AddBulletBlock(section, "Naprawa samochodu:",
                           Convert.ToString(historyRepairData["Naprawa"]) ?? string.Empty,
                           Colors.DarkGreen);

            #endregion                                 // Додавання лінії для підпису клієнта
            #region table of repair
            // Додавання простору

            section.AddParagraph();
            Paragraph RepairTitle = section.AddParagraph();
            RepairTitle.AddFormattedText("Zamówione części", TextFormat.Bold);
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
            rowRepair.Shading.Color = Colors.LightGray;
            rowRepair.Format.Font.Bold = true;

            string[] RepairWriteTable = { "Opis", "Numer części", "Cena", "Ilość" };
            for(byte x = 0;x < RepairWriteTable.Length;x++)
                {
                rowRepair.Cells[x].AddParagraph(RepairWriteTable[x]);
                }
            #endregion
            #region add repair data to table
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
            Paragraph sumPriceRepair = section.AddParagraph($"Łączna cena: {managementData["KosztCzęści"]} zł");
            sumPriceRepair.Format.Font.Name = "Courier New"; // Задати назву шрифта
            sumPriceRepair.Format.Font.Size = 10;
            sumPriceRepair.Format.Alignment = ParagraphAlignment.Right;

            #endregion
            #endregion
            #region table of services
            section.AddParagraph();
            Paragraph ServiceTitle = section.AddParagraph();
            ServiceTitle.AddFormattedText("Usługi", TextFormat.Bold);
            ServiceTitle.Format.Font.Name = "Courier New"; // Задати назву шрифта
            ServiceTitle.Format.Font.Size = 14;

            #region create a table of service
            // Додавання таблиці "Історія машини"
            Table ServiceTable = section.AddTable();
            ServiceTable.Borders.Width = 0.75;
            ServiceTable.Format.Alignment = ParagraphAlignment.Center;

            // Додаємо колонки до таблиці

            for(byte i = 0;i < 2;i++)
                {
                Column columnService = ServiceTable.AddColumn();
                columnService.Width = 260; // Зменшуємо ширину колонок
                if(i > 1)
                    columnService.Width = 10;
                }

            Row rowService = ServiceTable.AddRow();

            rowService.HeadingFormat = true;
            rowService.Format.Font.Name = "Courier New"; // Задати назву шрифта
            rowService.Shading.Color = Colors.LightGray;
            rowService.Format.Font.Bold = true;

            string[] ServiceWriteTable = { "Nazwa usługi", "Cena" };
            for(byte x = 0;x < ServiceWriteTable.Length;x++)
                {
                rowService.Cells[x].AddParagraph(ServiceWriteTable[x]);
                }
            #endregion
            #region add data of service to table
            foreach(var serviceItem in serviceData)
                {
                Row dataRowService = ServiceTable.AddRow();
                dataRowService.Format.Font.Name = "Courier New"; // Задати назву шрифта
                dataRowService.Format.Font.Size = 10;

                dataRowService.Cells[0].AddParagraph(serviceItem.ContainsKey("ServiceName") ? serviceItem["ServiceName"].ToString() : "");
                dataRowService.Cells[1].AddParagraph(serviceItem.ContainsKey("Price") ? serviceItem["Price"].ToString() : "");

                }
            Paragraph sumPriceService = section.AddParagraph($"Łączna cena: {managementData["KosztUsługi"]} zł");
            sumPriceService.Format.Font.Name = "Courier New"; // Задати назву шрифта
            sumPriceService.Format.Font.Size = 10;
            sumPriceService.Format.Alignment = ParagraphAlignment.Right;

            #endregion
            #endregion
            #region car
            Paragraph carInfo = section.AddParagraph();
            carInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            carInfo.Format.Font.Size = 11;
            carInfo.AddFormattedText("Dotyczy samochodu:", TextFormat.Bold);
            carInfo.AddLineBreak();
            carInfo.AddText($"{carData["Marka"]} {carData["Model"]}, {carData["RokProdukcji"]} roku produkcji z silnikiem {carData["Silnik"]}, z przebiegiem {historyRepairData["Przebieg"]}km. o numerze VIN: {carData["VIN"]}");

            #endregion
            #region OrderManagement
            string leftDocument = (historyRepairData["DokumentySamochodu"].ToString() == "1") ? "Klient zostawił dokumenty" : "Klient nie zostawił dokumentów";
            string leftKey = (historyRepairData["KluczykiSamochodu"].ToString() == "1") ? "Klient zostawił klucze samochodowe" : "Klient nie zostawił kluczyków samochodowych"; ;
            string TestDrive = (historyRepairData["TestDrive"].ToString() == "1") ? "Klient wyraża zgodę na jazdę próbną" : "Klient nie wyrażił zgody na jazdę próbną"; ;
            managementData.Add("leftDocument", leftDocument);
            managementData.Add("leftKey", leftKey);
            managementData.Add("TestDrive", TestDrive);
            section.AddParagraph();
            Paragraph OrderManagementTitle = section.AddParagraph("Pozostałe informacje");
            OrderManagementTitle.Format.Font.Name = "Courier New"; // Задати назву шрифта
            OrderManagementTitle.Format.Font.Size = 14;

            Paragraph orderManagementInfo = section.AddParagraph();
            orderManagementInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            orderManagementInfo.Format.Font.Size = 10;

            var dataFields = new List<(string Label, string Key)>
                        {
                            //("Data oczekiwania odbioru", "DataOczekiwaniaOdbioru"),
                            ("Dokumenty", "leftDocument"),
                            ("Klucze samochodowe", "leftKey"),
                            ("TestDrive", "TestDrive"),
                            ("Data Płatności", "DataPłatności"),
                            ("Sposób płatności", "MetodaPłatności")
                        };

            var priceFields = new List<(string Label, string Key)>
                        {
                            ("Cena części brutto", "KosztCzęściZMarżą"),
                            ("Koszt demontaż/montaż - usługa serwisowa", "KosztPracyRęcznej"),
                            ("koszt końcowy", "KosztKońcowy"),
                        };
            orderManagementInfo.AddLineBreak();
            orderManagementInfo.AddText($"Przyjęty: {historyRepairData["DataPrzyjęcia"]}");

            foreach(var (label, key) in dataFields)
                {
                orderManagementInfo.AddLineBreak();
                orderManagementInfo.AddText($"{label}: {managementData[key]}");
                }
            foreach(var (label, key) in priceFields)
                {
                orderManagementInfo.AddLineBreak();
                orderManagementInfo.AddText($"{label}: {managementData[key]} zł");
                }
            #endregion
            #region FreeFromVat
            section.AddParagraph();
            Paragraph FreeVat = section.AddParagraph();
            FreeVat.AddFormattedText("SPRZEDAWCA ZWOLNIONY PODMIOTOWO Z PODATKU OD TOWARÓW I USŁUG", TextFormat.Bold);
            FreeVat.Format.Font.Name = "Courier New"; // Задати назву шрифта
            FreeVat.Format.Font.Size = 10;
            FreeVat.AddLineBreak();
            FreeVat.AddText("dostawa towarów lub świadczenie usług zwolnione na podstawie art. 113 ust. 1 (albo ust. 9) ustawy\r\nz dnia 11 marca 2004r. o podatku od towarów i usług (Dz.U. z 2011r. Nr 177, poz.1054, z późn. zm.)");
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
            renderer.PdfDocument.Save($"{directory + carData["VIN"].ToString()}\\Zlecenie_{historyRepairData["DataPrzyjęcia"]}.pdf");

            //Process.Start($"{directory + carData["VIN"].ToString()}\\PDF_{historyRepairData["DataPrzyjęcia"]}.pdf");

            string path = Path.Combine($"{directory + carData["VIN"].ToString()}\\Zlecenie_{historyRepairData["DataPrzyjęcia"]}.pdf");

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
        private async void CreateInvoicePDF()
            {

            #region ReadData
            var companyData = await SqlCmd.LoadDataAsync("WarsztatDB", "DaneFirmy");
            var clientData = await SqlCmd.LoadDataAsync("Archive", "Klienty", null, "UniqueKey", uniqueKey);
            var carData = await SqlCmd.LoadDataAsync("Archive", "Samochód", null, "UniqueKey", uniqueKey);
            var repairCarData = await SqlCmd.LoadListAsync("Archive", "NaprawaSamochodu", "Opis, NumerCzęści, Cena, Ilość, Suma", "UniqueKey", uniqueKey);
            var serviceData = await SqlCmd.LoadListAsync("Archive", "HistoriaUsług", "ServiceName, Price", "UniqueKey", uniqueKey);
            var historyRepairData = await SqlCmd.LoadDataAsync("Archive", "HistoriaNapraw", null, "UniqueKey", uniqueKey);
            var managementData = await SqlCmd.LoadDataAsync("Archive", "ZarządzanieZleceniem", null, "UniqueKey", uniqueKey);


            #endregion
            #region generetePDF
            Document document = new();
            Section section = document.AddSection();

            var ps = section.PageSetup;                // а не document.DefaultPageSetup
            ps.PageFormat = PageFormat.A4;
            ps.TopMargin = Unit.FromCentimeter(1.0);
            ps.BottomMargin = Unit.FromCentimeter(0.5);
            ps.LeftMargin = Unit.FromCentimeter(1.7);
            ps.RightMargin = Unit.FromCentimeter(1.7);
            ps.HeaderDistance = Unit.FromCentimeter(0.0);  // якщо хедера нема
            ps.FooterDistance = Unit.FromCentimeter(0.7);

            //Section section = document.AddSection();
            #endregion
            #region title Company
            // Додавання тексту "Назва фірми"
            Paragraph companyName = section.AddParagraph($"{companyData["NazwaFirmy"]}");
            companyName.Format.Font.Size = 22;
            companyName.Format.Font.Name = "Courier New"; // Задати назву шрифта
            companyName.Format.Alignment = ParagraphAlignment.Center;
            #endregion
            #region Date
            var shortDate = FormatDateForPDF(managementData["DataPłatności"].ToString());
            var p = section.AddParagraph();
            p.Format.Font.Name = "Courier New";
            p.Format.Font.Size = 8;

            // таб-стоп праворуч (підженти під свою ширину сторінки)
            //p.Format.TabStops.AddTabStop(Unit.FromCentimeter(18), MigraDoc.DocumentObjectModel.TabAlignment.Right);

            p.AddText("Data wystawienia:");
            //p.AddTab();
            p.AddText($"{DateTime.Today:dd.MM.yyyy}");
            p.AddLineBreak();

            p.AddText("Data zakończenia dostawy/usług:");
            //p.AddTab();
            p.AddText($"{shortDate}");
            section.AddParagraph();
            #endregion
            #region Section Company && Client
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
            #region company
            // Дані фірми
            Paragraph companyInfo = infoRow.Cells[0].AddParagraph();
            companyInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            companyInfo.Format.Font.Size = 11;
            companyInfo.AddFormattedText("Sprzedawca:", TextFormat.Bold);

            companyInfo.AddLineBreak();
            companyInfo.AddText($"Nazwa firmy: {companyData["NazwaFirmy"]}");

            companyInfo.AddLineBreak();
            companyInfo.AddText($"Adres Firmy: {companyData["AdresFirmy"]}");

            companyInfo.AddLineBreak();
            companyInfo.AddText($"NIP: {companyData["NIP"]}");

            companyInfo.AddLineBreak();
            companyInfo.AddText($"BDO: {companyData["BDO"]}");

            companyInfo.AddLineBreak();
            companyInfo.AddText($"Nr. telefonu: {companyData["NrTelefonu"]}");

            companyInfo.AddLineBreak();
            companyInfo.AddText($"E-mail: {companyData["Email"]}");

            companyInfo.AddLineBreak();
            companyInfo.AddText($"Konto Bankowe: {companyData["KontoBankowe"]}");

            #endregion
            #region Client
            Paragraph clientInfo = infoRow.Cells[1].AddParagraph();
            clientInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            clientInfo.Format.Font.Size = 11;
            clientInfo.AddFormattedText("Nabywca:", TextFormat.Bold);

            clientInfo.AddLineBreak();
            clientInfo.AddText($"Nazwa firmy: {clientData["NazwaFirmyKlienta"]}");

            clientInfo.AddLineBreak();
            clientInfo.AddText($"Adres Firmy: {clientData["AdresFirmy"]}");

            clientInfo.AddLineBreak();
            clientInfo.AddText($"NIP: {clientData["NIP"]}");

            clientInfo.AddLineBreak();
            clientInfo.AddText($"Nr. telefonu: {clientData["NrTelefonu"]}");

            #endregion
            #endregion

            #region table of repair

            #region create a table of repair
            section.AddParagraph();
            // Додавання таблиці "Історія машини"
            Table RepairTable = section.AddTable();
            RepairTable.Borders.Width = 0.75;
            RepairTable.Format.Alignment = ParagraphAlignment.Center;

            // Додаємо колонки до таблиці
            int[] widths = {40, 300, 60, 100};
            for(byte i = 0;i < 4;i++)
                {
                Column columnRepair = RepairTable.AddColumn();
                columnRepair.Width = 250;
                columnRepair.Width = widths[i];
                }

            Row rowRepair = RepairTable.AddRow();

            rowRepair.HeadingFormat = true;
            rowRepair.Format.Font.Name = "Courier New"; // Задати назву шрифта
            rowRepair.Shading.Color = Colors.LightGray;
            rowRepair.Format.Font.Bold = true;

            string[] RepairWriteTable = {"L.P.", "Nazwa towarów i usług", "Ilość" , "Wartość towarów/usług", };
            for(byte x = 0;x < RepairWriteTable.Length;x++)
                {
                rowRepair.Cells[x].AddParagraph(RepairWriteTable[x]);
                }
            #endregion
            #region add repair data to table
            byte quantityItems = 1;
            decimal sumPrice = 0;
            foreach(var repairItem in repairCarData)
                {
                Row dataRowRepair = RepairTable.AddRow();
                dataRowRepair.Format.Font.Name = "Courier New"; // Задати назву шрифта
                dataRowRepair.Format.Font.Size = 9;

                dataRowRepair.Cells[0].AddParagraph($"{quantityItems++}");
                dataRowRepair.Cells[1].AddParagraph(repairItem["Opis"].ToString() + $" ({repairItem["NumerCzęści"]})");
                dataRowRepair.Cells[2].AddParagraph(repairItem.ContainsKey("Ilość") ? repairItem["Ilość"].ToString() + " szt." : "");
                dataRowRepair.Cells[3].AddParagraph(repairItem.ContainsKey("Suma") ? repairItem["Suma"].ToString() + " zł" : "");
                sumPrice += Convert.ToDecimal(repairItem["Suma"].ToString());
                }
            foreach(var serviceItem in serviceData)
                {
                Row dataRowService = RepairTable.AddRow();
                dataRowService.Format.Font.Name = "Courier New"; // Задати назву шрифта
                dataRowService.Format.Font.Size = 9;

                dataRowService.Cells[0].AddParagraph($"{quantityItems++}");
                dataRowService.Cells[1].AddParagraph(serviceItem["ServiceName"].ToString());
                dataRowService.Cells[2].AddParagraph("1 szt.");
                dataRowService.Cells[3].AddParagraph(serviceItem["Price"].ToString() + " zł");

                sumPrice += Convert.ToDecimal(serviceItem["Price"].ToString());
                }
            
            
            Paragraph sumPriceRepair = section.AddParagraph($"Łączna cena: {sumPrice} zł");
            sumPriceRepair.Format.Font.Name = "Courier New"; // Задати назву шрифта
            sumPriceRepair.Format.Font.Size = 10;
            sumPriceRepair.Format.Alignment = ParagraphAlignment.Right;

            #endregion
            #endregion
            #region other data
            section.AddParagraph();
            Paragraph otherDataTitle = section.AddParagraph();
            otherDataTitle.AddFormattedText("Płatność", TextFormat.Bold);
            otherDataTitle.Format.Font.Name = "Courier New"; // Задати назву шрифта
            otherDataTitle.Format.Font.Size = 11;

            Paragraph otherData = section.AddParagraph();
            otherData.Format.Font.Name = "Courier New"; // Задати назву шрифта
            otherData.Format.Font.Size = 10;
            string paymentType;

                paymentType = managementData["MetodaPłatności"].ToString();
                // Replace this block in CreateInvoicePDF:
                if(managementData["MetodaPłatności"].ToString() == "kartą")
                    {
                    paymentType = "przelew";
                    }
                else
                    {
                    paymentType = managementData["MetodaPłatności"]?.ToString() ?? string.Empty;
                    }
                otherData.AddText($"Sposób płatności: {paymentType}");

            otherData.AddLineBreak();
            otherData.AddText($"Termin płatności: {managementData["DataPłatności"]}");
            //otherData.AddLineBreak();
            //otherData.AddText($"Kwota słownie: {NumberToWords.Convert(sumPrice)} złotych");

            #endregion
            #region car
            section.AddParagraph();
            Paragraph carInfo = section.AddParagraph();
            carInfo.Format.Font.Name = "Courier New"; // Задати назву шрифта
            carInfo.Format.Font.Size = 11;
            carInfo.AddFormattedText("Dotyczy samochodu:", TextFormat.Bold);
            carInfo.AddLineBreak();
            carInfo.AddText($"{carData["Marka"]} {carData["Model"]}, {carData["RokProdukcji"]} roku produkcji z silnikiem {carData["Silnik"]}, z przebiegiem {historyRepairData["Przebieg"]}km. o numerze VIN: {carData["VIN"]}");
            #endregion
            #region FreeFromVat
            section.AddParagraph();
            Paragraph FreeVat = section.AddParagraph();
            FreeVat.AddFormattedText("SPRZEDAWCA ZWOLNIONY PODMIOTOWO Z PODATKU OD TOWARÓW I USŁUG", TextFormat.Bold);
            FreeVat.Format.Font.Name = "Courier New"; // Задати назву шрифта
            FreeVat.Format.Font.Size = 10;
            FreeVat.AddLineBreak();
            FreeVat.AddText("dostawa towarów lub świadczenie usług zwolnione na podstawie art. 113 ust. 1 (albo ust. 9) ustawy z dnia 11 marca 2004r. o podatku od towarów i usług (Dz.U. z 2011r. Nr 177, poz.1054, z późn. zm.)");
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
            DrawReactangle(section, row0, 0, "Nabywca");//Прямокутник по лівій стороні
            DrawReactangle(section, row0, 1, "Sprzedawca");//Прямокутник по правій стороні
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
            renderer.PdfDocument.Save($"{directory + carData["VIN"].ToString()}\\Faktura_{historyRepairData["DataPrzyjęcia"]}.pdf");

            //Process.Start($"{directory + carData["VIN"].ToString()}\\PDF_{historyRepairData["DataPrzyjęcia"]}.pdf");

            string path = Path.Combine($"{directory + carData["VIN"].ToString()}\\Faktura_{historyRepairData["DataPrzyjęcia"]}.pdf");

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
        static void AddBulletBlock(Section section, string title, string rawText, MigraDoc.DocumentObjectModel.Color color)
            {
            // Заголовок
            Paragraph t = section.AddParagraph(title);
            t.Format.Font.Name = "Courier New";
            t.Format.Font.Size = 11;
            t.Format.Font.Bold = true;
            t.Format.SpaceBefore = Unit.FromPoint(8);
            t.Format.SpaceAfter = Unit.FromPoint(8);
            t.Format.KeepWithNext = true;
            t.Format.OutlineLevel = OutlineLevel.Level3;
            if(string.IsNullOrWhiteSpace(rawText)) return;

            // Розбити незалежно від формату переносу рядка
            var lines = rawText.Split(new[] { "\r\n", "\n", "\r" },
                                      StringSplitOptions.RemoveEmptyEntries);

            foreach(var lineRaw in lines)
                {
                // прибрати власні «*», «•», «-» і зайві пробіли з БД
                var line = lineRaw.Trim().TrimStart('*', '•', '-').Trim();

                var li = section.AddParagraph();
                li.Format.ListInfo.ListType = ListType.BulletList1;

                // компактні відступи біля кульки:
                li.Format.LeftIndent = Unit.FromCentimeter(0);
                li.Format.FirstLineIndent = Unit.FromCentimeter(0);
                li.Format.ListInfo.NumberPosition = Unit.FromCentimeter(0.0); // позиція маркера
                li.Format.ListInfo.NumberPosition = Unit.FromCentimeter(0.5); // де починається текст

                // Шрифт пунктів
                li.Format.Font.Name = "Courier New";
                li.Format.Font.Size = 10;

                var ft = li.AddFormattedText(line, TextFormat.Italic);
                ft.Font.Name = "Courier New";
                ft.Font.Color = color;    // колір задаємо ззовні
                }
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
        private static string FormatDateForPDF(string date)
            {
            return DateTime.TryParse(date, out DateTime parsedDate) ? parsedDate.ToString("dd.MM.yyyy") : date;
            }
        }
    }