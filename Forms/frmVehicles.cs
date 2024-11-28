using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;
using ProjetoDesenvolvimentoAplicacoesMultplataforma.Forms;
using ProjetoDesenvolvimentoAplicacoesMultplataforma.Services;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class frmVehicles : Form
    {
        private readonly VehicleService service = new();

        public frmVehicles()
        {
            InitializeComponent();
            LoadLtvVehicles();
        }

        public void AdjustltvVehicleColumns(object? sender, EventArgs e)
        {
            int maxWidth = ltvVehicle.Width;
            chId.Width =               (int) Math.Round(0.08 * maxWidth);
            chModel.Width =            (int) Math.Round(0.20 * maxWidth);
            chLicensePlate.Width =     (int) Math.Round(0.20 * maxWidth);
            chColor.Width =            (int) Math.Round(0.12 * maxWidth);
            chDailyVehicleRate.Width = (int) Math.Round(0.20 * maxWidth);
            chRented.Width =           (int) Math.Round(0.20 * maxWidth);
        }

        private void LoadLtvVehicles(string search = "")
        {
            List<Vehicle> vehicles;
            if (string.IsNullOrEmpty(search))
            {
                vehicles = service.GetVehiclesByPlate(search);
            }
            else
            {
                vehicles = service.GetAllVehicles();
            }
            ltvVehicle.Items.Clear();
            foreach (Vehicle vehicle in vehicles)
            {
                ListViewItem item = new();
                item.Text = vehicle.Id.ToString();
                item.SubItems.Add(vehicle.Model);
                item.SubItems.Add(vehicle.LicensePlate);
                item.SubItems.Add(vehicle.DailyVehicleRate.ToString());
                item.SubItems.Add(vehicle.Color);
                if (vehicle.RentedBy == 0)
                {
                    item.SubItems.Add("Não alugado");
                }
                else
                {
                    item.SubItems.Add("Alugado");
                }

                ltvVehicle.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadLtvVehicles(txtSearch.Texts);
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            tmrSearch.Start();
        }

        private void tmrSearch_Tick(object sender, EventArgs e)
        {
            LoadLtvVehicles(txtSearch.Texts);
            tmrSearch.Stop();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmVehicle frm = new();
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ltvVehicle.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um veiculo primeiro", "Alerta");
                return;
            }
            int id = int.Parse(ltvVehicle.SelectedItems[0].Text);
            frmVehicle frm = new(id);
            frm.Show();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (ltvVehicle.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um veiculo primeiro", "Alerta");
                return;
            }
            int id = int.Parse(ltvVehicle.SelectedItems[0].Text);
            frmRented frm = new(id);
            frm.ShowDialog();
        }

        private void ltvVehicle_DoubleClick(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }
    }
}
