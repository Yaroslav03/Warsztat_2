using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warsztat_2.UserControls.BarMenu.UC_CreateData {
    public partial class Form_AddService :Form {
        public Form_AddService()
            {
            InitializeComponent();
            }

        private Dictionary<string, object> ServiceData()
            {
            return new Dictionary<string, object>
                {
                    {"ServiceName", ServiceTextBox.Text},
                    {"Price", PriceNumericUpDown.Value},
                };
            }
        private async void AddButton_Click(object sender, EventArgs e)
            {
            var serviceData = ServiceData();

            await SqlCmd.AddRecordAsync("WarsztatDB", "Usługi", serviceData);

            await SqlCmd.LoadData("SELECT Id, ServiceName, Price FROM Usługi", ServiceView, "Usługi", "Load table Usługi From DB");
            }

        private async void Form_AddService_Load(object sender, EventArgs e)
            {
            await SqlCmd.LoadData("SELECT Id, ServiceName, Price FROM Usługi", ServiceView, "Usługi", "Load table Usługi From DB");
            }
        }
    }
