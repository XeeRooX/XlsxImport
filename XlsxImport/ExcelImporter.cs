using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XlsxImport.Dtos;
using ExcelDataReader;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using System.Data;


namespace XlsxImport
{
    internal class ExcelImporter
    {
        private readonly List<StoreInfoDto> data = new();

        public List<StoreInfoDto> Load(string path)
        {
            try
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                using var stream = new FileStream(path, FileMode.Open, FileAccess.Read);

                var reader = ExcelReaderFactory.CreateReader(stream);
                var conf = new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true
                    }
                };

                var dataSet = reader.AsDataSet(conf);
                var dt = dataSet.Tables[0];
                ValidateInput(dt);

                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    data.Add(new StoreInfoDto()
                    {
                        Store = Convert.ToInt32(dt.Rows[i][0].ToString()),
                        DocNumber = dt.Rows[i][1].ToString()!,
                        DocDate = DateTime.ParseExact(dt.Rows[i][2].ToString()!, "yyyy-MM-dd HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture)
                    });
                }

            }
            catch (Exception e)
            {
                MessageBox.Show($"Произошла непредвиденная ошибка.\n{e.Message}");
            }

            return data;
        }

        private void ValidateInput(DataTable dt)
        {
            var header1 = dt.Rows[0][0].ToString();
            var header2 = dt.Rows[0][1].ToString();
            var header3 = dt.Rows[0][2].ToString();

            if (header1 != "store" || header2 != "docNumber" || header3 != "docDate")
            {
                throw new Exception("Загружаемый файл не соответсвует требованиям");
            }
        }
    }
}