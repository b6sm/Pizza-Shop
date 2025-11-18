namespace PizzaProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lpPizza = new System.Windows.Forms.Label();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.rbTackOut = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.cbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.cbExtraChees = new System.Windows.Forms.CheckBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbOnions = new System.Windows.Forms.CheckBox();
            this.cbTomatoes = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lbChoosenTotalPrice = new System.Windows.Forms.Label();
            this.lbChoosenCrustType = new System.Windows.Forms.Label();
            this.lbChoosenWhereToEat = new System.Windows.Forms.Label();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbTopingsChosed = new System.Windows.Forms.Label();
            this.lbChoosenSize = new System.Windows.Forms.Label();
            this.lbTopings = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.btmOrderPizza = new System.Windows.Forms.Button();
            this.btmResetForm = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lpPizza
            // 
            this.lpPizza.AutoSize = true;
            this.lpPizza.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpPizza.ForeColor = System.Drawing.Color.Red;
            this.lpPizza.Location = new System.Drawing.Point(250, -2);
            this.lpPizza.Name = "lpPizza";
            this.lpPizza.Size = new System.Drawing.Size(314, 53);
            this.lpPizza.TabIndex = 0;
            this.lpPizza.Text = "Make Your Pizza";
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Location = new System.Drawing.Point(13, 19);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(74, 17);
            this.rbThinCrust.TabIndex = 4;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.Location = new System.Drawing.Point(13, 54);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(79, 17);
            this.rbThinkCrust.TabIndex = 5;
            this.rbThinkCrust.Tag = "10";
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Location = new System.Drawing.Point(22, 29);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(54, 17);
            this.rbEatIn.TabIndex = 6;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // rbTackOut
            // 
            this.rbTackOut.AutoSize = true;
            this.rbTackOut.Location = new System.Drawing.Point(99, 29);
            this.rbTackOut.Name = "rbTackOut";
            this.rbTackOut.Size = new System.Drawing.Size(69, 17);
            this.rbTackOut.TabIndex = 7;
            this.rbTackOut.Text = "Take Out";
            this.rbTackOut.UseVisualStyleBackColor = true;
            this.rbTackOut.CheckedChanged += new System.EventHandler(this.rbTackOut_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarg);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(25, 54);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(144, 126);
            this.gbSize.TabIndex = 8;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Location = new System.Drawing.Point(42, 87);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(46, 17);
            this.rbLarg.TabIndex = 6;
            this.rbLarg.Tag = "40";
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Checked = true;
            this.rbMeduim.Location = new System.Drawing.Point(42, 54);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(61, 17);
            this.rbMeduim.TabIndex = 5;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "30";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(42, 19);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(49, 17);
            this.rbSmall.TabIndex = 4;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThinkCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Location = new System.Drawing.Point(29, 195);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(139, 91);
            this.gbCrustType.TabIndex = 9;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Controls.Add(this.rbTackOut);
            this.gbWhereToEat.Location = new System.Drawing.Point(259, 186);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(223, 57);
            this.gbWhereToEat.TabIndex = 10;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.cbGreenPeppers);
            this.gbToppings.Controls.Add(this.cbExtraChees);
            this.gbToppings.Controls.Add(this.cbOlives);
            this.gbToppings.Controls.Add(this.cbOnions);
            this.gbToppings.Controls.Add(this.cbTomatoes);
            this.gbToppings.Controls.Add(this.cbMushrooms);
            this.gbToppings.Location = new System.Drawing.Point(261, 54);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(229, 94);
            this.gbToppings.TabIndex = 11;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // cbGreenPeppers
            // 
            this.cbGreenPeppers.AutoSize = true;
            this.cbGreenPeppers.Location = new System.Drawing.Point(131, 66);
            this.cbGreenPeppers.Name = "cbGreenPeppers";
            this.cbGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.cbGreenPeppers.TabIndex = 17;
            this.cbGreenPeppers.Tag = "5";
            this.cbGreenPeppers.Text = "Green Peppers";
            this.cbGreenPeppers.UseVisualStyleBackColor = true;
            this.cbGreenPeppers.CheckedChanged += new System.EventHandler(this.cbGreenPeppers_CheckedChanged);
            // 
            // cbExtraChees
            // 
            this.cbExtraChees.AutoSize = true;
            this.cbExtraChees.Location = new System.Drawing.Point(20, 20);
            this.cbExtraChees.Name = "cbExtraChees";
            this.cbExtraChees.Size = new System.Drawing.Size(85, 17);
            this.cbExtraChees.TabIndex = 12;
            this.cbExtraChees.Tag = "5";
            this.cbExtraChees.Text = "Extra Chees";
            this.cbExtraChees.UseVisualStyleBackColor = true;
            this.cbExtraChees.CheckedChanged += new System.EventHandler(this.cbExtraChees_CheckedChanged);
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.Location = new System.Drawing.Point(131, 43);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(55, 17);
            this.cbOlives.TabIndex = 16;
            this.cbOlives.Tag = "5";
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = true;
            this.cbOlives.CheckedChanged += new System.EventHandler(this.cbOlives_CheckedChanged);
            // 
            // cbOnions
            // 
            this.cbOnions.AutoSize = true;
            this.cbOnions.Location = new System.Drawing.Point(132, 19);
            this.cbOnions.Name = "cbOnions";
            this.cbOnions.Size = new System.Drawing.Size(54, 17);
            this.cbOnions.TabIndex = 15;
            this.cbOnions.Tag = "5";
            this.cbOnions.Text = "Onion";
            this.cbOnions.UseVisualStyleBackColor = true;
            this.cbOnions.CheckedChanged += new System.EventHandler(this.cbOnions_CheckedChanged);
            // 
            // cbTomatoes
            // 
            this.cbTomatoes.AutoSize = true;
            this.cbTomatoes.Location = new System.Drawing.Point(20, 66);
            this.cbTomatoes.Name = "cbTomatoes";
            this.cbTomatoes.Size = new System.Drawing.Size(73, 17);
            this.cbTomatoes.TabIndex = 14;
            this.cbTomatoes.Tag = "5";
            this.cbTomatoes.Text = "Tomatoes";
            this.cbTomatoes.UseVisualStyleBackColor = true;
            this.cbTomatoes.CheckedChanged += new System.EventHandler(this.cbTomatoes_CheckedChanged);
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.Location = new System.Drawing.Point(20, 43);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(80, 17);
            this.cbMushrooms.TabIndex = 13;
            this.cbMushrooms.Tag = "5";
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            this.cbMushrooms.CheckedChanged += new System.EventHandler(this.cbMushrooms_CheckedChanged);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.lbChoosenTotalPrice);
            this.gbOrderSummary.Controls.Add(this.lbChoosenCrustType);
            this.gbOrderSummary.Controls.Add(this.lbChoosenWhereToEat);
            this.gbOrderSummary.Controls.Add(this.lbWhereToEat);
            this.gbOrderSummary.Controls.Add(this.lbTotalPrice);
            this.gbOrderSummary.Controls.Add(this.lbCrustType);
            this.gbOrderSummary.Controls.Add(this.lbTopingsChosed);
            this.gbOrderSummary.Controls.Add(this.lbChoosenSize);
            this.gbOrderSummary.Controls.Add(this.lbTopings);
            this.gbOrderSummary.Controls.Add(this.lbSize);
            this.gbOrderSummary.Location = new System.Drawing.Point(557, 54);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(180, 232);
            this.gbOrderSummary.TabIndex = 12;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lbChoosenTotalPrice
            // 
            this.lbChoosenTotalPrice.AutoSize = true;
            this.lbChoosenTotalPrice.Font = new System.Drawing.Font("Bank Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChoosenTotalPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbChoosenTotalPrice.Location = new System.Drawing.Point(82, 183);
            this.lbChoosenTotalPrice.Name = "lbChoosenTotalPrice";
            this.lbChoosenTotalPrice.Size = new System.Drawing.Size(57, 29);
            this.lbChoosenTotalPrice.TabIndex = 9;
            this.lbChoosenTotalPrice.Tag = "30";
            this.lbChoosenTotalPrice.Text = "$0";
            // 
            // lbChoosenCrustType
            // 
            this.lbChoosenCrustType.AutoSize = true;
            this.lbChoosenCrustType.Location = new System.Drawing.Point(103, 89);
            this.lbChoosenCrustType.Name = "lbChoosenCrustType";
            this.lbChoosenCrustType.Size = new System.Drawing.Size(56, 13);
            this.lbChoosenCrustType.TabIndex = 8;
            this.lbChoosenCrustType.Text = "Thin Crust";
            // 
            // lbChoosenWhereToEat
            // 
            this.lbChoosenWhereToEat.AutoSize = true;
            this.lbChoosenWhereToEat.Location = new System.Drawing.Point(103, 126);
            this.lbChoosenWhereToEat.Name = "lbChoosenWhereToEat";
            this.lbChoosenWhereToEat.Size = new System.Drawing.Size(36, 13);
            this.lbChoosenWhereToEat.TabIndex = 7;
            this.lbChoosenWhereToEat.Text = "Eat In";
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEat.Location = new System.Drawing.Point(22, 113);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(85, 13);
            this.lbWhereToEat.TabIndex = 6;
            this.lbWhereToEat.Text = "Where To Eat:";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(21, 165);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(64, 13);
            this.lbTotalPrice.TabIndex = 5;
            this.lbTotalPrice.Text = "TotalPrice";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.Location = new System.Drawing.Point(21, 89);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(71, 13);
            this.lbCrustType.TabIndex = 4;
            this.lbCrustType.Text = "Crust Type:";
            // 
            // lbTopingsChosed
            // 
            this.lbTopingsChosed.AutoSize = true;
            this.lbTopingsChosed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopingsChosed.Location = new System.Drawing.Point(21, 43);
            this.lbTopingsChosed.Name = "lbTopingsChosed";
            this.lbTopingsChosed.Size = new System.Drawing.Size(61, 13);
            this.lbTopingsChosed.TabIndex = 3;
            this.lbTopingsChosed.Text = "Toppings:";
            // 
            // lbChoosenSize
            // 
            this.lbChoosenSize.AutoSize = true;
            this.lbChoosenSize.Location = new System.Drawing.Point(61, 21);
            this.lbChoosenSize.Name = "lbChoosenSize";
            this.lbChoosenSize.Size = new System.Drawing.Size(43, 13);
            this.lbChoosenSize.TabIndex = 2;
            this.lbChoosenSize.Text = "Meduim";
            // 
            // lbTopings
            // 
            this.lbTopings.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopings.Location = new System.Drawing.Point(35, 56);
            this.lbTopings.Name = "lbTopings";
            this.lbTopings.Size = new System.Drawing.Size(139, 33);
            this.lbTopings.TabIndex = 0;
            this.lbTopings.Text = "No Toppings";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(21, 20);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(33, 13);
            this.lbSize.TabIndex = 1;
            this.lbSize.Text = "Size:";
            // 
            // btmOrderPizza
            // 
            this.btmOrderPizza.Location = new System.Drawing.Point(261, 255);
            this.btmOrderPizza.Name = "btmOrderPizza";
            this.btmOrderPizza.Size = new System.Drawing.Size(97, 31);
            this.btmOrderPizza.TabIndex = 0;
            this.btmOrderPizza.Text = "Order Pizza";
            this.btmOrderPizza.UseVisualStyleBackColor = true;
            this.btmOrderPizza.Click += new System.EventHandler(this.btmOrderPizza_Click);
            // 
            // btmResetForm
            // 
            this.btmResetForm.Location = new System.Drawing.Point(385, 255);
            this.btmResetForm.Name = "btmResetForm";
            this.btmResetForm.Size = new System.Drawing.Size(97, 31);
            this.btmResetForm.TabIndex = 14;
            this.btmResetForm.Text = "Reset Form";
            this.btmResetForm.UseVisualStyleBackColor = true;
            this.btmResetForm.Click += new System.EventHandler(this.btmResetForm_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Gray;
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDown1.Location = new System.Drawing.Point(42, 28);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(117, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(781, 313);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btmResetForm);
            this.Controls.Add(this.btmOrderPizza);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lpPizza);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lpPizza;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.RadioButton rbTackOut;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox cbGreenPeppers;
        private System.Windows.Forms.CheckBox cbExtraChees;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox cbOnions;
        private System.Windows.Forms.CheckBox cbTomatoes;
        private System.Windows.Forms.CheckBox cbMushrooms;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label lbTopings;
        private System.Windows.Forms.Label lbChoosenTotalPrice;
        private System.Windows.Forms.Label lbChoosenCrustType;
        private System.Windows.Forms.Label lbChoosenWhereToEat;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbTopingsChosed;
        private System.Windows.Forms.Label lbChoosenSize;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Button btmOrderPizza;
        private System.Windows.Forms.Button btmResetForm;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

