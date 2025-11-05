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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.rdbMeduim = new System.Windows.Forms.RadioButton();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rdbThickCrust = new System.Windows.Forms.RadioButton();
            this.rdbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.ckMashrooms = new System.Windows.Forms.CheckBox();
            this.ckTomatos = new System.Windows.Forms.CheckBox();
            this.ckGreenPeppers = new System.Windows.Forms.CheckBox();
            this.ckOlives = new System.Windows.Forms.CheckBox();
            this.ckOnion = new System.Windows.Forms.CheckBox();
            this.ckExtraChees = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbEatOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.bOrderPizza = new System.Windows.Forms.Button();
            this.bRestForm = new System.Windows.Forms.Button();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CrustType = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.Toppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lbToppingsContent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbOrderSummary = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(302, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Location = new System.Drawing.Point(30, 34);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(71, 24);
            this.rdbSmall.TabIndex = 2;
            this.rdbSmall.TabStop = true;
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = true;
            // 
            // rdbMeduim
            // 
            this.rdbMeduim.AutoSize = true;
            this.rdbMeduim.Location = new System.Drawing.Point(30, 64);
            this.rdbMeduim.Name = "rdbMeduim";
            this.rdbMeduim.Size = new System.Drawing.Size(89, 24);
            this.rdbMeduim.TabIndex = 3;
            this.rdbMeduim.TabStop = true;
            this.rdbMeduim.Text = "Meduim";
            this.rdbMeduim.UseVisualStyleBackColor = true;
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.Location = new System.Drawing.Point(30, 94);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(73, 24);
            this.rdbLarge.TabIndex = 4;
            this.rdbLarge.TabStop = true;
            this.rdbLarge.Text = "Large";
            this.rdbLarge.UseVisualStyleBackColor = true;
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rdbLarge);
            this.gbSize.Controls.Add(this.rdbMeduim);
            this.gbSize.Controls.Add(this.rdbSmall);
            this.gbSize.Location = new System.Drawing.Point(44, 111);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(147, 150);
            this.gbSize.TabIndex = 5;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rdbThickCrust);
            this.gbCrust.Controls.Add(this.rdbThinCrust);
            this.gbCrust.Location = new System.Drawing.Point(44, 291);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(152, 131);
            this.gbCrust.TabIndex = 6;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            // 
            // rdbThickCrust
            // 
            this.rdbThickCrust.AutoSize = true;
            this.rdbThickCrust.Location = new System.Drawing.Point(19, 68);
            this.rdbThickCrust.Name = "rdbThickCrust";
            this.rdbThickCrust.Size = new System.Drawing.Size(117, 24);
            this.rdbThickCrust.TabIndex = 5;
            this.rdbThickCrust.TabStop = true;
            this.rdbThickCrust.Text = "Thick Crust";
            this.rdbThickCrust.UseVisualStyleBackColor = true;
            // 
            // rdbThinCrust
            // 
            this.rdbThinCrust.AutoSize = true;
            this.rdbThinCrust.Location = new System.Drawing.Point(19, 38);
            this.rdbThinCrust.Name = "rdbThinCrust";
            this.rdbThinCrust.Size = new System.Drawing.Size(109, 24);
            this.rdbThinCrust.TabIndex = 4;
            this.rdbThinCrust.TabStop = true;
            this.rdbThinCrust.Text = "Thin Crust";
            this.rdbThinCrust.UseVisualStyleBackColor = true;
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.ckMashrooms);
            this.gbToppings.Controls.Add(this.ckTomatos);
            this.gbToppings.Controls.Add(this.ckGreenPeppers);
            this.gbToppings.Controls.Add(this.ckOlives);
            this.gbToppings.Controls.Add(this.ckOnion);
            this.gbToppings.Controls.Add(this.ckExtraChees);
            this.gbToppings.Location = new System.Drawing.Point(332, 119);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(319, 141);
            this.gbToppings.TabIndex = 7;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // ckMashrooms
            // 
            this.ckMashrooms.AutoSize = true;
            this.ckMashrooms.Location = new System.Drawing.Point(162, 99);
            this.ckMashrooms.Name = "ckMashrooms";
            this.ckMashrooms.Size = new System.Drawing.Size(120, 24);
            this.ckMashrooms.TabIndex = 5;
            this.ckMashrooms.Text = "Mashrooms";
            this.ckMashrooms.UseVisualStyleBackColor = true;
            // 
            // ckTomatos
            // 
            this.ckTomatos.AutoSize = true;
            this.ckTomatos.Location = new System.Drawing.Point(26, 99);
            this.ckTomatos.Name = "ckTomatos";
            this.ckTomatos.Size = new System.Drawing.Size(97, 24);
            this.ckTomatos.TabIndex = 4;
            this.ckTomatos.Text = "Tomatos";
            this.ckTomatos.UseVisualStyleBackColor = true;
            // 
            // ckGreenPeppers
            // 
            this.ckGreenPeppers.AutoSize = true;
            this.ckGreenPeppers.Location = new System.Drawing.Point(162, 69);
            this.ckGreenPeppers.Name = "ckGreenPeppers";
            this.ckGreenPeppers.Size = new System.Drawing.Size(149, 24);
            this.ckGreenPeppers.TabIndex = 3;
            this.ckGreenPeppers.Text = "Green Peppers";
            this.ckGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // ckOlives
            // 
            this.ckOlives.AutoSize = true;
            this.ckOlives.Location = new System.Drawing.Point(162, 39);
            this.ckOlives.Name = "ckOlives";
            this.ckOlives.Size = new System.Drawing.Size(76, 24);
            this.ckOlives.TabIndex = 2;
            this.ckOlives.Text = "Olives";
            this.ckOlives.UseVisualStyleBackColor = true;
            // 
            // ckOnion
            // 
            this.ckOnion.AutoSize = true;
            this.ckOnion.Location = new System.Drawing.Point(26, 69);
            this.ckOnion.Name = "ckOnion";
            this.ckOnion.Size = new System.Drawing.Size(75, 24);
            this.ckOnion.TabIndex = 1;
            this.ckOnion.Text = "Onion";
            this.ckOnion.UseVisualStyleBackColor = true;
            // 
            // ckExtraChees
            // 
            this.ckExtraChees.AutoSize = true;
            this.ckExtraChees.Location = new System.Drawing.Point(26, 39);
            this.ckExtraChees.Name = "ckExtraChees";
            this.ckExtraChees.Size = new System.Drawing.Size(126, 24);
            this.ckExtraChees.TabIndex = 0;
            this.ckExtraChees.Text = "Extra Chees";
            this.ckExtraChees.UseVisualStyleBackColor = true;
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbEatOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(332, 280);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(319, 93);
            this.gbWhereToEat.TabIndex = 8;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where to Eat";
            // 
            // rbEatOut
            // 
            this.rbEatOut.AutoSize = true;
            this.rbEatOut.Location = new System.Drawing.Point(176, 47);
            this.rbEatOut.Name = "rbEatOut";
            this.rbEatOut.Size = new System.Drawing.Size(89, 24);
            this.rbEatOut.TabIndex = 1;
            this.rbEatOut.TabStop = true;
            this.rbEatOut.Text = "Eat Out";
            this.rbEatOut.UseVisualStyleBackColor = true;
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(26, 47);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(76, 24);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            // 
            // bOrderPizza
            // 
            this.bOrderPizza.Location = new System.Drawing.Point(305, 423);
            this.bOrderPizza.Name = "bOrderPizza";
            this.bOrderPizza.Size = new System.Drawing.Size(140, 52);
            this.bOrderPizza.TabIndex = 9;
            this.bOrderPizza.Text = "Order Pizza";
            this.bOrderPizza.UseVisualStyleBackColor = true;
            // 
            // bRestForm
            // 
            this.bRestForm.Location = new System.Drawing.Point(539, 423);
            this.bRestForm.Name = "bRestForm";
            this.bRestForm.Size = new System.Drawing.Size(140, 52);
            this.bRestForm.TabIndex = 10;
            this.bRestForm.Text = "Rest form";
            this.bRestForm.UseVisualStyleBackColor = true;
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Controls.Add(this.lblWhereToEat);
            this.gbOrderSummary.Controls.Add(this.label3);
            this.gbOrderSummary.Controls.Add(this.CrustType);
            this.gbOrderSummary.Controls.Add(this.lblCrustType);
            this.gbOrderSummary.Controls.Add(this.Toppings);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.Controls.Add(this.lbToppingsContent);
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.Controls.Add(this.lbOrderSummary);
            this.gbOrderSummary.Controls.Add(this.Size);
            this.gbOrderSummary.Controls.Add(this.label);
            this.gbOrderSummary.Location = new System.Drawing.Point(702, 119);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(236, 375);
            this.gbOrderSummary.TabIndex = 11;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Script MT Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(75, 290);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(51, 38);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "$0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Price :";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Location = new System.Drawing.Point(126, 212);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(58, 20);
            this.lblWhereToEat.TabIndex = 10;
            this.lblWhereToEat.Text = "Eat In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Where to Eat :";
            // 
            // CrustType
            // 
            this.CrustType.AutoSize = true;
            this.CrustType.Location = new System.Drawing.Point(120, 172);
            this.CrustType.Name = "CrustType";
            this.CrustType.Size = new System.Drawing.Size(91, 20);
            this.CrustType.TabIndex = 8;
            this.CrustType.Text = "Thin Crust";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Location = new System.Drawing.Point(6, 172);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(110, 20);
            this.lblCrustType.TabIndex = 7;
            this.lblCrustType.Text = " Crust Type :";
            // 
            // Toppings
            // 
            this.Toppings.AutoSize = true;
            this.Toppings.Location = new System.Drawing.Point(24, 121);
            this.Toppings.Name = "Toppings";
            this.Toppings.Size = new System.Drawing.Size(109, 20);
            this.Toppings.TabIndex = 6;
            this.Toppings.Text = "No Toppings";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(84, 49);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(44, 20);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size";
            // 
            // lbToppingsContent
            // 
            this.lbToppingsContent.AutoSize = true;
            this.lbToppingsContent.Location = new System.Drawing.Point(18, 140);
            this.lbToppingsContent.Name = "lbToppingsContent";
            this.lbToppingsContent.Size = new System.Drawing.Size(0, 20);
            this.lbToppingsContent.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // lbOrderSummary
            // 
            this.lbOrderSummary.AutoSize = true;
            this.lbOrderSummary.Location = new System.Drawing.Point(18, 86);
            this.lbOrderSummary.Name = "lbOrderSummary";
            this.lbOrderSummary.Size = new System.Drawing.Size(92, 20);
            this.lbOrderSummary.TabIndex = 2;
            this.lbOrderSummary.Text = "Toppings :";
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(78, 49);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(0, 20);
            this.Size.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(18, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(54, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Size :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 506);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.bRestForm);
            this.Controls.Add(this.bOrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.RadioButton rdbMeduim;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rdbThickCrust;
        private System.Windows.Forms.RadioButton rdbThinCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox ckMashrooms;
        private System.Windows.Forms.CheckBox ckTomatos;
        private System.Windows.Forms.CheckBox ckGreenPeppers;
        private System.Windows.Forms.CheckBox ckOlives;
        private System.Windows.Forms.CheckBox ckOnion;
        private System.Windows.Forms.CheckBox ckExtraChees;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbEatOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button bOrderPizza;
        private System.Windows.Forms.Button bRestForm;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbOrderSummary;
        private System.Windows.Forms.Label lbToppingsContent;
        private System.Windows.Forms.Label CrustType;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label Toppings;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label label3;
    }
}

