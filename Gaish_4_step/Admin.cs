using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;

namespace Gaish_4_step
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Admin : Form
    {
        DataBase database = new DataBase();

        int selectRow;

        public Admin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("OrderID", "ID"); //0
            dataGridView1.Columns.Add("ProductName", "Наименования товара"); //1
            dataGridView1.Columns.Add("ShipType", "Тип лодки"); //2
            dataGridView1.Columns.Add("RowerCapacity", "Количество мест для гребцов"); //3
            dataGridView1.Columns.Add("WoodTypes", "Сорта деревьев"); //4
            dataGridView1.Columns.Add("Color", "Цвет"); //5
            dataGridView1.Columns.Add("MastHas", "Налаичие мачты"); //6
            dataGridView1.Columns.Add("BasePrice", "Базовая цена"); //7
            dataGridView1.Columns.Add("OrderProcess", "Процесс заказа товаров"); //8
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ClearFields()
        {
            textBoxID.Text = "";
            textBoxProfuctName.Text = "";
            textBoxShipType.Text = "";
            textBoxRowerCapacity.Text = ""; 
            textBoxWoodTypes.Text = "";
            textBoxColor.Text = "";
            textBoxMastHas.Text = "";
            textBoxBasePrice.Text = "";
            textBoxProcess.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetInt32(7), record.GetString(8), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from ship_orders";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.GetConnection().Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            database.GetConnection().Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectRow];

                textBoxID.Text = row.Cells[0].Value.ToString(); //0
                textBoxProfuctName.Text = row.Cells[1].Value.ToString(); //1 
                textBoxShipType.Text = row.Cells[2].Value.ToString(); //2 
                textBoxRowerCapacity.Text = row.Cells[3].Value.ToString(); //3 
                textBoxWoodTypes.Text = row.Cells[4].Value.ToString(); //4
                textBoxColor.Text = row.Cells[5].Value.ToString(); //5 
                textBoxMastHas.Text = row.Cells[6].Value.ToString(); //6
                textBoxBasePrice.Text = row.Cells[7].Value.ToString(); //7
                textBoxProcess.Text = row.Cells[8].Value.ToString(); //8
            }
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            AddInfoIntoDB addInfofrm = new AddInfoIntoDB();
            addInfofrm.Show();
            //this.Hide();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from ship_orders where concat (OrderID, ProductName, ShipType, RowerCapacity, WoodTypes, Color, MastHas, BasePrice, OrderProcess) like '%" + textBoxSearch.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.GetConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }
        
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;
        }

        private void UpdateDelete()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[9].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from ship_orders where OrderID = {id}";

                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var OrderID = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var ProductName = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var ShipType = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var RowerCapacity = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var WoodTypes = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var Color = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var MastHas = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var BasePrice = dataGridView1.Rows[index].Cells[7].Value.ToString();
                    var OrderProcess = dataGridView1.Rows[index].Cells[8].Value.ToString();

                    if (!int.TryParse(BasePrice, out int basePriceValue))
                    {
                        MessageBox.Show("Ошибка: Цена должна быть числом.");
                        continue;
                    }

                    var changeQuery = "update ship_orders set " +
                                      "ProductName = @ProductName, " +
                                      "ShipType = @ShipType, " +
                                      "RowerCapacity = @RowerCapacity, " +
                                      "WoodTypes = @WoodTypes, " +
                                      "Color = @Color, " +
                                      "MastHas = @MastHas, " +
                                      "BasePrice = @BasePrice, " +
                                      "OrderProcess = @OrderProcess " +
                                      "where OrderID = @OrderID";

                    var command = new SqlCommand(changeQuery, database.GetConnection());
                    command.Parameters.AddWithValue("@ProductName", ProductName);
                    command.Parameters.AddWithValue("@ShipType", ShipType);
                    command.Parameters.AddWithValue("@RowerCapacity", RowerCapacity);
                    command.Parameters.AddWithValue("@WoodTypes", WoodTypes);
                    command.Parameters.AddWithValue("@Color", Color);
                    command.Parameters.AddWithValue("@MastHas", MastHas);
                    command.Parameters.AddWithValue("@BasePrice", basePriceValue);
                    command.Parameters.AddWithValue("@OrderProcess", OrderProcess);
                    command.Parameters.AddWithValue("@OrderID", OrderID);

                    command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdateDelete();

            if(textBoxProcess.Text == "Лодка готова")
            {
                string fileName = "Отчет_о_лодке.docx";
                GenerateWordDocument(fileName);

                string fromMail = "nodiode05@gmail.com";
                string fromPassword = "zfjdwmvcckxwufoz";

                Random random = new Random();
                int randomNumber = random.Next(1000, 10000);

                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = "Договор №" + randomNumber;
                message.To.Add(new MailAddress("nodioxide@gmail.com"));
                message.Body = $"Отчет и договор по лодке в приложении.";
                message.IsBodyHtml = true;
                
                Attachment attachment = new Attachment(fileName);
                message.Attachments.Add(attachment);

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true,
                };

                smtpClient.Send(message);
            }
        }

        private void GenerateWordDocument(string fileName)
        {
            /*using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(fileName, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                Paragraph paragraph = body.AppendChild(new Paragraph());
                paragraph.AppendChild(new Run(new Text($"ОТЧЁТ")));
                paragraph.Append(new Break());
                paragraph.AppendChild(new Run(new Text($"Лодка готова!")));
                paragraph.Append(new Break());
                paragraph.AppendChild(new Run(new Text($"Наименование товара: {textBoxProfuctName.Text}")));
                paragraph.Append(new Break());
                paragraph.AppendChild(new Run(new Text($"Цвет: {textBoxColor.Text}")));
                paragraph.Append(new Break());
                paragraph.AppendChild(new Run(new Text($"Тип лодки: {textBoxShipType.Text}")));
                paragraph.Append(new Break());
                paragraph.AppendChild(new Run(new Text($"Количество гребцов: {textBoxRowerCapacity.Text}")));
                paragraph.Append(new Break());
                paragraph.AppendChild(new Run(new Text($"Сорт дерева: {textBoxWoodTypes.Text}")));
                paragraph.Append(new Break());
                paragraph.AppendChild(new Run(new Text($"Наличие мачты: {textBoxMastHas.Text}")));
                paragraph.Append(new Break());
                paragraph.AppendChild(new Run(new Text($"К оплате: {textBoxBasePrice.Text} рублей")));

                mainPart.Document.Save();
            }*/

            string reportContent = $"Договор №{new Random().Next(1000, 10000)}\n\n" +
                                   "ОТЧЕТ\n" +
                                   "Лодка готова!\n\n" +
                                   $"Наименование товара: {textBoxProfuctName.Text}\n" +
                                   $"Цвет: {textBoxColor.Text}\n" +
                                   $"Тип лодки: {textBoxShipType.Text}\n" +
                                   $"Количество гребцов: {textBoxRowerCapacity.Text}\n" +
                                   $"Сорт дерева: {textBoxWoodTypes.Text}\n" +
                                   $"Наличие мачты: {textBoxMastHas.Text}\n\n" +
                                   $"К оплате: {textBoxBasePrice.Text} рублей\n\n" +
                                   "ДОГОВОР\n" +
                                   $"Настоящим подтверждается, что покупатель приобрел лодку по вышеуказанным характеристикам и цене.\n" +
                                   "Данный договор является официальным подтверждением сделки.\n\n" +
                                   "Дата: " + DateTime.Now.ToString("dd.MM.yyyy");

            File.WriteAllText(fileName, reportContent, Encoding.UTF8);
        }


        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var OrderID = textBoxID.Text;
            var ProductName = textBoxProfuctName.Text;
            var ShipType = textBoxShipType.Text;
            var RowerCapacity = textBoxRowerCapacity.Text;
            var WoodTypes = textBoxWoodTypes.Text;
            var Color = textBoxColor.Text;
            var MastHas = textBoxMastHas.Text;
            var OrderProcess = textBoxProcess.Text;
            int BasePrice;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBoxBasePrice.Text, out BasePrice))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(OrderID, ProductName, ShipType, RowerCapacity, WoodTypes, Color, MastHas, BasePrice, OrderProcess);
                    dataGridView1.Rows[selectedRowIndex].Cells[9].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!");
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void pictureBoxEraser_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void DataHolder_PaymentButtonClicked(object sender, EventArgs e)
        {

        }

        private void PaymentForm_PaymentButtonClicked(object sender, EventArgs e)
        {

        }

        private void ShowPaymentForm()
        {

        }

        private void Admin_Activated(object sender, EventArgs e)
        {

        }

        private void labelEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
