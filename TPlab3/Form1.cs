using ConverterLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        ConverterLibrary.IConverter converter;
        public static bool isGetPersenPressed = false;
        public List<CurrencyIhave> CurrenciesIhave { get; set; }
        public List<CurrencyIwant> CurrenciesIwant { get; set; }
        public static string connectionString = (@"Data Source=DESKTOP-1IVG2LS\SQLEXPRESS;Initial Catalog=MainBase;Integrated Security=True");
        public class CurrencyIhave
        {
            public string Name { get; set; }
        }
        public class CurrencyIwant
        {
            public string CurrencyIhave { get; set; }
            public string Name { get; set; }
        }
        public Form1(ConverterLibrary.IConverter conv)
        {
            InitializeComponent();
            converter = conv;
            CurrenciesIhave = new List<CurrencyIhave>() {
                new CurrencyIhave { Name = "Рубль" },
                new CurrencyIhave { Name = "Йена" },

            };
            CurrenciesIwant = new List<CurrencyIwant>() {

                new CurrencyIwant { Name = "Рубль", CurrencyIhave = "Йена" },
                new CurrencyIwant { Name = "Йена", CurrencyIhave = "Рубль" },
            };

            cbIhave.DataSource = CurrenciesIhave;
            cbIhave.DisplayMember = "Name";
        }

        [FaultContract(typeof(FormatException))]

        

        double parser()
        {
            bool IsDigitsOnly(string str)
            {
                foreach (char c in str)
                {
                    if ((c < '0')  || (c > '9') )
                        return false;
                  
                    
                }

                return true;
            }

            if (IsDigitsOnly(tbIhave.Text) == true)
            {
                double p = double.Parse(tbIhave.Text);
                return p;
            }
            else
            {
                FormatException exception = new FormatException("Введен неверный формат");
                throw new FaultException<FormatException>(exception, exception.Message);
            }
        }

        [FaultContract(typeof(ArgumentNullException))]
        private void btCount_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbLastName.Text != "" && tbName.Text != "" && tbOtch.Text != "")
                {
                    if (cbIhave.Text == "Рубль")
                    {
                        if (cbIwant.Text == "Йена")
                        {

                            double res = converter.RtoI(parser());
                            int resI = (int)res / 10 * 10;
                            double resD = Math.Round((res - resI) + resI % 10 * 1.65, 0);
                            tbIwant.Text = resI.ToString();
                            tbOst.Text = resD.ToString();
                        }

                    }
                    else if (cbIhave.Text == "Йена")
                    {
                        if (cbIwant.Text == "Рубль")
                        {
                            double res =  converter.ItoR(parser());
                            res = Math.Round(res, 0);
                            tbIwant.Text =  res.ToString();
                        }

                    }

                    saveToBD();
                }
                else if (tbLastName.Text == "" || tbName.Text == "" || tbOtch.Text == "" || tbIhave.Text == "")
                {
                    ArgumentNullException exception = new ArgumentNullException("Заполнены не все поля.");
                    throw new FaultException<ArgumentNullException>(exception, exception.Message);
                }

            }
            catch (FaultException<ArgumentException> ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FaultException<FormatException> ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FaultException<ArgumentNullException> ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (EndpointNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "EndpointNotFoundException");
            }

        }

        private void cbIhave_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIwant.DataSource = CurrenciesIwant.Where(x => x.CurrencyIhave == (cbIhave.SelectedValue as CurrencyIhave).Name).ToList();
            cbIwant.DisplayMember = "Name";
        }
        Person FormGetPerson()
        {
            Person person = new Person();
            person = converter.GetPerson();
            person.LastName = tbLastName.Text;
            person.Name = tbName.Text;
            person.Otch = tbOtch.Text;

            return person;
        }

        private void saveToBD()
        {
            ConverterLibrary.Person person = FormGetPerson();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "insert into wcf (lastname,name) values (@lastname,@name)";


            command.Parameters.AddWithValue("@lastname", person.LastName);
            command.Parameters.AddWithValue("@name", person.Name);

            command.ExecuteNonQuery();
            converter.Save();
            conn.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbIwant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbFam_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIhave_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOtch_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIhave_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
