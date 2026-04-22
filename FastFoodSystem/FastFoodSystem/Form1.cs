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
            // Uncheck all food items
            pizza.Checked = false;
            drink.Checked = false;
            burger.Checked = false;
            chips.Checked = false;

            // Reset payment method
            pay_cash.Checked = false;
            pay_card.Checked = false;

            // Clear total textbox
            total_input.Clear();
        }

        //validation if food item or payment method not selected
        private void calculate_btn_Click(object sender, EventArgs e)
        {
            //unselected foor item warning/validation
            if (!pizza.Checked && !drink.Checked &&
        !       burger.Checked && !chips.Checked)
            {
                MessageBox.Show("Please select at least one food item.");
                return;
            }
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
            total_input.Text = "R " + total.ToString("0.00");
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();

        }
    }
}
