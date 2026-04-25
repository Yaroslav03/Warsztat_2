using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warsztat_2.UserControls.BarMenu.Archive {
    public partial class Form_ViewDataArchive :Form {
        public Form_ViewDataArchive()
            {
            InitializeComponent();
            }
        public async Task ReadData(Guid uniqueKey)
            {
            var searchKey = new Dictionary<string, object>
                {
                    {"UniqueKey", uniqueKey }
                };
            await CompleteClientData(uniqueKey);
            await CompleteCarData(uniqueKey);
            await CompleteHistoryData(uniqueKey);
            await CompleteManagementData(uniqueKey);

            string _connectionStringArchive = "Data Source=Archive.db;Version=3;New=False;Compress=True;";
            await SqlCmd.LoadData($"SELECT Typ, Nazwa, Opis, NumerCzęści, Cena, Ilość, ZarobekCzęści, SumaZarobku, Suma, Stan FROM NaprawaSamochodu WHERE UniqueKey=@UniqueKey", ViewRepair, "Repair", "Load table Repair from DB", searchKey, _connectionStringArchive);
            await SqlCmd.LoadData($"SELECT  ServiceName, Price FROM HistoriaUsług WHERE UniqueKey=@UniqueKey", ServiceHistoryView, "Service", "Load table Service from DB", searchKey, _connectionStringArchive);
            }
        private async Task CompleteClientData(Guid uniqueKey)
            {
            var clientData = await SqlCmd.LoadDataAsync("Archive", "Klienty", null, "UniqueKey", uniqueKey);
            NameTextBox.Text = clientData["Imię"].ToString();
            SurNameTextBox.Text = clientData["Nazwisko"].ToString();
            TelephoneNumberTextBox.Text = clientData["NrTelefonu"].ToString();
            NIPTextBox.Text = clientData["NIP"].ToString();
            NameCompanyTextBox.Text = clientData["NazwaFirmyKlienta"].ToString();
            AdressCompanyTextBox.Text = clientData["AdresFirmy"].ToString();
            }
        private async Task CompleteCarData(Guid uniqueKey)
            {
            var carData = await SqlCmd.LoadDataAsync("Archive", "Samochód", null, "UniqueKey", uniqueKey);
            BrandTextBox.Text = carData["Marka"].ToString();
            ModelTextBox.Text = carData["Model"].ToString();
            VINTextBox.Text = carData["VIN"].ToString();
            EngineTextBox.Text = carData["Silnik"].ToString();
            CodeEngineTextBox.Text = carData["KodSilnika"].ToString();
            YearOfProductionNUD.Value = Convert.ToInt32(carData["RokProdukcji"]);
            }
        private async Task CompleteHistoryData(Guid uniqueKey)
            {
            var historyRepairData = await SqlCmd.LoadDataAsync("Archive", "HistoriaNapraw", null, "UniqueKey", uniqueKey);
            OrderTextBox.Text = historyRepairData["Zlecenie"].ToString();
            DiagnosticTextBox.Text = historyRepairData["Diagnostyka"].ToString();
            RepairTextBox.Text = historyRepairData["Naprawa"].ToString();
            RegistrationPlateTextBox.Text = historyRepairData["NrRejestracji"].ToString();
            MileageTextBox.Text = historyRepairData["Przebieg"].ToString();
            DateOfAcceptance.Value = Convert.ToDateTime(historyRepairData["DataPrzyjęcia"]).Date;

            LeftDocumentsCheck.Checked = historyRepairData["DokumentySamochodu"]?.ToString() == "1";
            LeftKeyChceck.Checked = historyRepairData["KluczykiSamochodu"]?.ToString() == "1";
            TestDriveChceck.Checked = historyRepairData["TestDrive"]?.ToString() == "1";

            OrderAddoptedTimePicker.Value = Convert.ToDateTime(historyRepairData["DataPrzyjęcia"]).Date;
            }
        private async Task CompleteManagementData(Guid uniqueKey)
            {
            var managementData = await SqlCmd.LoadDataAsync("Archive", "ZarządzanieZleceniem", null, "UniqueKey", uniqueKey);

            dateTimePickerDateOfClosed.Value = Convert.ToDateTime(managementData["DataZamknięciaZlecenia"]).Date;
            DateOfPay.Value = Convert.ToDateTime(managementData["DataPłatności"]).Date;
            labelPricePartBrutto.Text = Convert.ToDecimal(managementData["KosztCzęściZMarżą"]).ToString() + " zł";
            labelPriceDemontageMontage.Text = Convert.ToDecimal(managementData["KosztPracyRęcznej"]).ToString() + " zł";
            labelPriceServices.Text = Convert.ToDecimal(managementData["KosztUsługi"]).ToString() + " zł";
            labelTotalCost.Text = Convert.ToDecimal(managementData["KosztKońcowy"]).ToString() + " zł";

            if(managementData["MetodaPłatności"].ToString() == "gotówką")
                {
                radioButtonCash.Checked = true;
                }
            else if(managementData["MetodaPłatności"].ToString() == "kartą")
                {
                radioButtonCard.Checked = true;
                }
            }
        }
    }
