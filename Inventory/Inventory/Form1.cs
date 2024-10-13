using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        BindingSource showProductList;
        private int _Quantity;
        private double _SellPrice;
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;

        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = new string[] {
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other"
            };

            foreach (string items in ListOfProductCategory)
            {
                cbCategory.Items.Add(items);

            }
        }

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                throw new StringFormatException("");
            }

            return name;
        }
        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
            {
                throw new NumberFormatException("");
            }

            return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
            {
                throw new CurrencyFormatException("");
            }
            return Convert.ToDouble(price);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (StringFormatException err)
            {
                MessageBox.Show(err.Message);
            }
            catch (CurrencyFormatException err1)
            {
                MessageBox.Show(err1.Message);
            }
            catch (NumberFormatException err2)
            {
                MessageBox.Show(err2.Message);
            }
        }
    }
}
