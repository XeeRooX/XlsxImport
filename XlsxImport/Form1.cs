using XlsxImport.Dtos;
using XlsxImport.Models;
using XlsxImport.Services;

namespace XlsxImport
{
    public partial class Form1 : Form
    {
        private readonly IStoreInfoService _storeInfoService;
        private static int dg1Page = 1;
        private static int dg2Page = 2;
        private readonly List<StoreInfoDto> _data = new();
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            ApplicationDbContext dbContext = new ApplicationDbContext();
            _storeInfoService = new StoreInfoService(dbContext);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filePath = openFileDialog1.FileName;

            var ei = new ExcelImporter();

            _data.Clear();
            _data.AddRange(ei.Load(filePath));

            dg1Page = 1;

            ShowDataInTable(dataGridView1, _data);
            AddDataToDb(_data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dg2Page = 1;
            var data = _storeInfoService.GetByPage(0, 10);
            ShowDataInDbTable(dataGridView2, data, true);
        }

        private void ShowDataInDbTable(DataGridView dg, List<StoreInfo> data, bool clear = false)
        {
            if(clear)
                dg.Rows.Clear();

            for (int i = 0; i < data.Count; i++)
            {
                int j = dg.Rows.Add();
                dg.Rows[j].Cells[0].Value = data.ElementAt(i).Store.ToString();
                dg.Rows[j].Cells[1].Value = data.ElementAt(i).DocNumber.ToString();
                dg.Rows[j].Cells[2].Value = data.ElementAt(i).DocDate.ToString();
            }
        }

        private void AddDataToDb(List<StoreInfoDto> data)
        {
            List<StoreInfo> si = new List<StoreInfo>();
            foreach (var item in data)
            {
                si.Add(new StoreInfo() { DocDate = item.DocDate, DocNumber = item.DocNumber, Store = item.Store });
            }
            _storeInfoService.AddRange(si);
        }

        private void ShowDataInTable(DataGridView dg, List<StoreInfoDto> data)
        {
            dg.Rows.Clear();
            var count = data.Count < 10 ? data.Count : 10;

            for (int i = 0; i < count; i++)
            {
                dg.Rows.Add();
                dg.Rows[i].Cells[0].Value = data.ElementAt(i).Store.ToString();
                dg.Rows[i].Cells[1].Value = data.ElementAt(i).DocNumber.ToString();
                dg.Rows[i].Cells[2].Value = data.ElementAt(i).DocDate.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var data = _data.Skip(10 * dg1Page).Take(10);

            if (data.Count() >= 0)
                dg1Page++;

            for (int i = 0; i < data.Count(); i++)
            {
                int j = dataGridView1.Rows.Add();
                dataGridView1.Rows[j].Cells[0].Value = data.ElementAt(i).Store.ToString();
                dataGridView1.Rows[j].Cells[1].Value = data.ElementAt(i).DocNumber.ToString();
                dataGridView1.Rows[j].Cells[2].Value = data.ElementAt(i).DocDate.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var data = _storeInfoService.GetByPage(dg2Page, 10);
            ShowDataInDbTable(dataGridView2, data);
        }
    }
}
