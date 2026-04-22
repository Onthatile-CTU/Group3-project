namespace FastFoodSystem
{
    partial class FastFoodSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            select_order = new Label();
            pizza = new CheckBox();
            drink = new CheckBox();
            burger = new CheckBox();
            chips = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            total = new Label();
            total_input = new TextBox();
            pay_cash = new RadioButton();
            pay_card = new RadioButton();
            calculate_btn = new Button();
            clear_btn = new Button();
            exit_btn = new Button();
            SuspendLayout();
            // 
            // select_order
            // 
            select_order.AutoSize = true;
            select_order.Font = new Font("ROG Fonts", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            select_order.Location = new Point(12, 34);
            select_order.Name = "select_order";
            select_order.Size = new Size(626, 52);
            select_order.TabIndex = 0;
            select_order.Text = "Select Your Order";
            // 
            // pizza
            // 
            pizza.AutoSize = true;
            pizza.Location = new Point(60, 114);
            pizza.Name = "pizza";
            pizza.Size = new Size(99, 36);
            pizza.TabIndex = 1;
            pizza.Text = "Pizza";
            pizza.UseVisualStyleBackColor = true;
            // 
            // drink
            // 
            drink.AutoSize = true;
            drink.Location = new Point(60, 188);
            drink.Name = "drink";
            drink.Size = new Size(103, 36);
            drink.TabIndex = 2;
            drink.Text = "Drink";
            drink.UseVisualStyleBackColor = true;
            // 
            // burger
            // 
            burger.AutoSize = true;
            burger.Location = new Point(60, 262);
            burger.Name = "burger";
            burger.Size = new Size(117, 36);
            burger.TabIndex = 3;
            burger.Text = "Burger";
            burger.UseVisualStyleBackColor = true;
            // 
            // chips
            // 
            chips.AutoSize = true;
            chips.Location = new Point(60, 332);
            chips.Name = "chips";
            chips.Size = new Size(105, 36);
            chips.TabIndex = 4;
            chips.Text = "Chips";
            chips.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 118);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 5;
            label1.Text = "R 75.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 189);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 6;
            label2.Text = "R 18.50";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 263);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 7;
            label3.Text = "R 45.30";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 333);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 8;
            label4.Text = "R 35.70";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Location = new Point(60, 462);
            total.Name = "total";
            total.Size = new Size(85, 32);
            total.TabIndex = 9;
            total.Text = "TOTAL:";
            total.TextAlign = ContentAlignment.TopCenter;
            // 
            // total_input
            // 
            total_input.BackColor = SystemColors.ScrollBar;
            total_input.Location = new Point(169, 459);
            total_input.Name = "total_input";
            total_input.Size = new Size(315, 39);
            total_input.TabIndex = 11;
            // 
            // pay_cash
            // 
            pay_cash.AutoSize = true;
            pay_cash.Location = new Point(663, 118);
            pay_cash.Name = "pay_cash";
            pay_cash.Size = new Size(96, 36);
            pay_cash.TabIndex = 12;
            pay_cash.TabStop = true;
            pay_cash.Text = "Cash";
            pay_cash.TextAlign = ContentAlignment.MiddleCenter;
            pay_cash.UseVisualStyleBackColor = true;
            // 
            // pay_card
            // 
            pay_card.AutoSize = true;
            pay_card.Location = new Point(663, 189);
            pay_card.Name = "pay_card";
            pay_card.Size = new Size(195, 36);
            pay_card.TabIndex = 13;
            pay_card.TabStop = true;
            pay_card.Text = "Card @ 15.5%";
            pay_card.TextAlign = ContentAlignment.MiddleCenter;
            pay_card.UseVisualStyleBackColor = true;
            // 
            // calculate_btn
            // 
            calculate_btn.BackColor = Color.Lime;
            calculate_btn.Location = new Point(60, 554);
            calculate_btn.Name = "calculate_btn";
            calculate_btn.Size = new Size(221, 75);
            calculate_btn.TabIndex = 14;
            calculate_btn.Text = "CALCULATE";
            calculate_btn.UseVisualStyleBackColor = false;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.Yellow;
            clear_btn.Location = new Point(348, 554);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(171, 75);
            clear_btn.TabIndex = 15;
            clear_btn.Text = "CLEAR";
            clear_btn.UseVisualStyleBackColor = false;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.Orchid;
            exit_btn.Location = new Point(571, 554);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(165, 75);
            exit_btn.TabIndex = 16;
            exit_btn.Text = "EXIT";
            exit_btn.UseVisualStyleBackColor = false;
            // 
            // FastFoodSystem
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 695);
            Controls.Add(exit_btn);
            Controls.Add(clear_btn);
            Controls.Add(calculate_btn);
            Controls.Add(pay_card);
            Controls.Add(pay_cash);
            Controls.Add(total_input);
            Controls.Add(total);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chips);
            Controls.Add(burger);
            Controls.Add(drink);
            Controls.Add(pizza);
            Controls.Add(select_order);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FastFoodSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CTU Fast Food Order System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label select_order;
        private CheckBox pizza;
        private CheckBox drink;
        private CheckBox burger;
        private CheckBox chips;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label total;
        private TextBox total_input;
        private RadioButton pay_cash;
        private RadioButton pay_card;
        private Button calculate_btn;
        private Button clear_btn;
        private Button exit_btn;
    }
}
