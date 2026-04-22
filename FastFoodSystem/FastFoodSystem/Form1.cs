namespace FastFoodSystem
{
    public partial class FastFoodSystem : Form
    {
        // Store each menu item's price mapped to its checkbox
        private Dictionary<CheckBox, double> itemPrices;
        
        public FastFoodSystem()
        {
            InitializeComponent();
            // Assign prices to each menu item checkbox when the form loads
            itemPrices = new Dictionary<CheckBox, double>
            {
                { pizza,  75.00 },
                { drink,  18.50 },
                { burger, 45.30 },
                { chips,  35.70 }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         private void calculate_btn_Click(object sender, EventArgs e)
         {
             // Ensure the user has selected a payment method before proceeding
             if (!pay_cash.Checked && !pay_card.Checked)
             {
                 MessageBox.Show("Please pick a payment method");
                 return;
             }

             // Sum prices of only the checked menu items using the dictionary
             double total = itemPrices
                 .Where(kvp => kvp.Key.Checked)
                 .Sum(kvp => kvp.Value);

             // Apply a 15.5% surcharge if the user is paying by card
             if (pay_card.Checked) total *= 1.155;

             // Display the final total formatted to 2 decimal places
             total_input.Text = "Total: R" + total.ToString("0.00");
         }
    }
}
