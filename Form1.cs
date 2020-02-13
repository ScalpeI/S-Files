using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;

namespace S_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Екземпляр приложения Excel
        Excel.Application xlApp;
        //Лист
        Excel.Worksheet xlSheet;
        //Выделеная область
        Excel.Range xlSheetRange;
        public string query = "";

        public string[,] Enp;
        public int Cou = 0;
        public string przcod;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "XML |*.xml";
            oFD.Multiselect = true;
            int r1 = 0;
            int r2 = 0;
            int r3 = 0;
            int r4 = 0;
            int r5 = 0;
            int r6 = 0;
            int r7 = 0;
            int sum = 0;

            DialogResult dr = oFD.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Enp = new string[oFD.FileNames.Count(), 7];
                Cou = oFD.FileNames.Count();
                for (int i=0;i<oFD.FileNames.Count() ; i++) {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(oFD.FileNames[i]);
                    przcod = doc.DocumentElement.Attributes[3].InnerText;
                    r1 = 0;
                    r2 = 0;
                    r3 = 0;
                    r4 = 0;
                    r5 = 0;
                    r6 = 0;
                    r7 = 0;
                    sum = 0;
                    foreach (XmlNode node in doc.DocumentElement)
                    {
                        if (node.Attributes[1].InnerText == "1")
                        {
                            r1++;
                            Enp[i, 0] += node.Attributes["ENP"].InnerText + ";";
                        }
                        if (node.Attributes[1].InnerText == "2")
                        {
                            r2++;
                            Enp[i, 1] += node.Attributes["ENP"].InnerText + ";";
                        }
                        if (node.Attributes[1].InnerText == "3")
                        {
                            r3++;
                            Enp[i, 2] += node.Attributes["ENP"].InnerText + ";";
                        }
                        if (node.Attributes[1].InnerText == "4")
                        {
                            r4++;
                            Enp[i, 3] += node.Attributes["ENP"].InnerText + ";";
                        }
                        if (node.Attributes[1].InnerText == "5")
                        {
                            r5++;
                            Enp[i, 4] += node.Attributes["ENP"].InnerText + ";";
                        }
                        if (node.Attributes[1].InnerText == "6")
                        {
                            r6++;
                            Enp[i, 5] += node.Attributes["ENP"].InnerText + ";";
                        }
                        if (node.Attributes[1].InnerText == "7")
                        {
                            r7++;
                            Enp[i, 6] += node.Attributes["ENP"].InnerText + ";";
                        }
                        sum = r1 + r2 + r3 + r4 + r5 + r6 + r7;
                    }
                    dataGridView1.Rows.Add(przcod, r1.ToString(), r2.ToString(), r3.ToString(), r4.ToString(), r5.ToString(), r6.ToString(), r7.ToString(),sum.ToString());
                }
                r1 = 0;
                r2 = 0;
                r3 = 0;
                r4 = 0;
                r5 = 0;
                r6 = 0;
                r7 = 0;
                sum = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int incom;
                    int.TryParse((row.Cells[1].Value ?? "0").ToString().Replace(".", ","), out incom);
                    r1 += incom;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int incom;
                    int.TryParse((row.Cells[2].Value ?? "0").ToString().Replace(".", ","), out incom);
                    r2 += incom;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int incom;
                    int.TryParse((row.Cells[3].Value ?? "0").ToString().Replace(".", ","), out incom);
                    r3 += incom;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int incom;
                    int.TryParse((row.Cells[4].Value ?? "0").ToString().Replace(".", ","), out incom);
                    r4 += incom;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int incom;
                    int.TryParse((row.Cells[5].Value ?? "0").ToString().Replace(".", ","), out incom);
                    r5 += incom;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int incom;
                    int.TryParse((row.Cells[6].Value ?? "0").ToString().Replace(".", ","), out incom);
                    r6 += incom;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int incom;
                    int.TryParse((row.Cells[7].Value ?? "0").ToString().Replace(".", ","), out incom);
                    r7 += incom;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int incom;
                    int.TryParse((row.Cells[8].Value ?? "0").ToString().Replace(".", ","), out incom);
                    sum += incom;
                }
                dataGridView1.Rows.Add("ИТОГ", r1.ToString(), r2.ToString(), r3.ToString(), r4.ToString(), r5.ToString(), r6.ToString(), r7.ToString(), sum.ToString());

            }
            oFD.Dispose();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataTable GetData()
        {
            //строка соединения
            string connString = @"Network Library=DBMSSOCN;Data Source=192.168.1.101;Initial Catalog=Oms_Buryatiya;User ID=sa;Password=Kmsadmin_403;Persist Security Info=True;";

            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                SqlCommand comm = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }
        void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                GC.Collect();
            }
        }

        private void Create_Click(int col, int row)
        {
            xlApp = new Excel.Application();

            try
            {
                //добавляем книгу
                xlApp.Workbooks.Add(Type.Missing);
                
                //делаем временно неактивным документ
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;

                //выбираем лист на котором будем работать (Лист 1)
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                //Название листа
                xlSheet.Name = "ПРЗ " + dataGridView1.Rows[row].Cells[0].Value.ToString() + " - " + dataGridView1.Columns[col].HeaderCell.Value.ToString() + " - " + dataGridView1.Rows[row].Cells[col].Value.ToString();//"Данные";
                
                //Выгрузка данных
                DataTable dt = GetData();
                

                int collInd = 0;
                int rowInd = 0;
                string data = "";

                //называем колонки
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[1, i + 1] = data;

                    //выделяем первую строку
                    xlSheetRange = xlSheet.get_Range("A1:Z1", Type.Missing);

                    //делаем полужирный текст и перенос слов
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                //заполняем строки
                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells.NumberFormat = "@";
                        xlSheet.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }
                

                //выбираем всю область данных
                xlSheetRange = xlSheet.UsedRange;

                //выравниваем строки и колонки по их содержимому
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Показываем ексель
                xlApp.Visible = true;

                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;

                //Отсоединяемся от Excel
                releaseObject(xlSheetRange);
                releaseObject(xlSheet);
                releaseObject(xlApp);
            }
        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex > 0 && e.ColumnIndex < 8 && e.RowIndex >= 0 && e.RowIndex < Cou)
                if (Enp[e.RowIndex, e.ColumnIndex - 1] != "" && Enp[e.RowIndex, e.ColumnIndex - 1] != null) 
                {
                    try
                    {
                        string s = "";
                        int i = 1;
                        String[] words = Enp[e.RowIndex, e.ColumnIndex - 1].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string word in words)
                        {
                            if (i == words.Count())
                            {
                                s += "ENP='" + word + "'";
                            }
                            else
                            {
                                i++;
                                s += "ENP='" + word + "' or ";
                            }
                        }
                        query = @"SELECT a.[IDPRZ],[ENP],[Surname],[Name1],[Name2],[Sex],CONVERT(DATE,[Birthday]) AS Birthday,[Phone],[Addr]	  
                                    FROM [Oms_Buryatiya].[dbo].[Pers] a left join [Oms_Buryatiya].[dbo].[Address] on (IDAddressOwner=IDPers and IDAddressType='35021') 
                                    WHERE " + s + " ORDER BY [Surname],[Name1],[Name2],[Sex],[Birthday]";
                        toolTip1.Show("Запрос к БД", this.label1, 500);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        Create_Click(e.ColumnIndex, e.RowIndex);
                    }
                }
            
        }

        Bitmap bmp;

        private void Button1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog dPP = new PrintPreviewDialog();
            int height = dataGridView1.Height;
            int height1 = (dataGridView1.RowCount + 1) * dataGridView1.RowTemplate.Height+2;
            dataGridView1.Dock = DockStyle.None;
            dataGridView1.Height = height1;
            //MessageBox.Show(height1 + " " + height);
            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            dataGridView1.Dock = DockStyle.Fill;
            PrintDocument dP = new PrintDocument();
            dP.PrintPage += dP_PrintPage;
            dPP.Document = dP;
            //bmp.Save("dpp.jpg",System.Drawing.Imaging.ImageFormat.Jpeg);
            dPP.ShowDialog();

        }

        private void dP_PrintPage (object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
