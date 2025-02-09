namespace Hardware_Management
{
    partial class Billing
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.lblItem = new System.Windows.Forms.Label();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.lblCategories = new System.Windows.Forms.Label();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.pnlBilling = new System.Windows.Forms.Panel();
            this.lblBilling = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddToBill = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rdCash = new System.Windows.Forms.RadioButton();
            this.rdCard = new System.Windows.Forms.RadioButton();
            this.rdMobile = new System.Windows.Forms.RadioButton();
            this.gbItemsList = new System.Windows.Forms.GroupBox();
            this.gbClientBill = new System.Windows.Forms.GroupBox();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.pnlBilling.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlLogout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufacturer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(418, 133);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(240, 22);
            this.txtManufacturer.TabIndex = 4;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(418, 41);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(240, 22);
            this.txtItem.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(418, 103);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(240, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(418, 73);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(240, 22);
            this.txtCategory.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.pnlItem);
            this.flowLayoutPanel1.Controls.Add(this.pnlCategories);
            this.flowLayoutPanel1.Controls.Add(this.pnlCustomer);
            this.flowLayoutPanel1.Controls.Add(this.pnlBilling);
            this.flowLayoutPanel1.Controls.Add(this.pnlDashboard);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.pnlLogout);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-4, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(282, 552);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 75);
            this.panel6.TabIndex = 3;
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.lblItem);
            this.pnlItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlItem.Location = new System.Drawing.Point(3, 84);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(279, 59);
            this.pnlItem.TabIndex = 1;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblItem.Location = new System.Drawing.Point(23, 18);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(64, 25);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Items";
            // 
            // pnlCategories
            // 
            this.pnlCategories.Controls.Add(this.lblCategories);
            this.pnlCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCategories.Location = new System.Drawing.Point(3, 149);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(279, 59);
            this.pnlCategories.TabIndex = 1;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCategories.Location = new System.Drawing.Point(23, 18);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(117, 25);
            this.lblCategories.TabIndex = 1;
            this.lblCategories.Text = "Categories";
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.lblCustomer);
            this.pnlCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCustomer.Location = new System.Drawing.Point(3, 214);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(279, 59);
            this.pnlCustomer.TabIndex = 0;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCustomer.Location = new System.Drawing.Point(23, 18);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(105, 25);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer";
            // 
            // pnlBilling
            // 
            this.pnlBilling.Controls.Add(this.lblBilling);
            this.pnlBilling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBilling.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pnlBilling.Location = new System.Drawing.Point(3, 279);
            this.pnlBilling.Name = "pnlBilling";
            this.pnlBilling.Size = new System.Drawing.Size(279, 59);
            this.pnlBilling.TabIndex = 1;
            // 
            // lblBilling
            // 
            this.lblBilling.AutoSize = true;
            this.lblBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilling.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBilling.Location = new System.Drawing.Point(23, 18);
            this.lblBilling.Name = "lblBilling";
            this.lblBilling.Size = new System.Drawing.Size(70, 25);
            this.lblBilling.TabIndex = 3;
            this.lblBilling.Text = "Billing";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDashboard.Location = new System.Drawing.Point(3, 344);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(279, 59);
            this.pnlDashboard.TabIndex = 2;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDashboard.Location = new System.Drawing.Point(23, 19);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(117, 25);
            this.lblDashboard.TabIndex = 4;
            this.lblDashboard.Text = "Dashboard";
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(3, 409);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(279, 59);
            this.panel7.TabIndex = 4;
            // 
            // pnlLogout
            // 
            this.pnlLogout.Controls.Add(this.lblLogout);
            this.pnlLogout.Location = new System.Drawing.Point(3, 474);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(279, 49);
            this.pnlLogout.TabIndex = 5;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Red;
            this.lblLogout.Location = new System.Drawing.Point(181, 14);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(78, 25);
            this.lblLogout.TabIndex = 5;
            this.lblLogout.Text = "Logout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Billing";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(279, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 29);
            this.panel1.TabIndex = 10;
            // 
            // btnAddToBill
            // 
            this.btnAddToBill.BackColor = System.Drawing.Color.Orange;
            this.btnAddToBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToBill.Location = new System.Drawing.Point(366, 181);
            this.btnAddToBill.Name = "btnAddToBill";
            this.btnAddToBill.Size = new System.Drawing.Size(152, 28);
            this.btnAddToBill.TabIndex = 14;
            this.btnAddToBill.Text = "Add to Bill";
            this.btnAddToBill.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(366, 215);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 28);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Reset";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(703, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Payment Mode";
            // 
            // rdCash
            // 
            this.rdCash.AutoSize = true;
            this.rdCash.Location = new System.Drawing.Point(754, 73);
            this.rdCash.Name = "rdCash";
            this.rdCash.Size = new System.Drawing.Size(59, 20);
            this.rdCash.TabIndex = 18;
            this.rdCash.TabStop = true;
            this.rdCash.Text = "Cash";
            this.rdCash.UseVisualStyleBackColor = true;
            // 
            // rdCard
            // 
            this.rdCard.AutoSize = true;
            this.rdCard.Location = new System.Drawing.Point(754, 99);
            this.rdCard.Name = "rdCard";
            this.rdCard.Size = new System.Drawing.Size(57, 20);
            this.rdCard.TabIndex = 19;
            this.rdCard.TabStop = true;
            this.rdCard.Text = "Card";
            this.rdCard.UseVisualStyleBackColor = true;
            // 
            // rdMobile
            // 
            this.rdMobile.AutoSize = true;
            this.rdMobile.Location = new System.Drawing.Point(754, 125);
            this.rdMobile.Name = "rdMobile";
            this.rdMobile.Size = new System.Drawing.Size(69, 20);
            this.rdMobile.TabIndex = 20;
            this.rdMobile.TabStop = true;
            this.rdMobile.Text = "Mobile";
            this.rdMobile.UseVisualStyleBackColor = true;
            // 
            // gbItemsList
            // 
            this.gbItemsList.Location = new System.Drawing.Point(315, 249);
            this.gbItemsList.Name = "gbItemsList";
            this.gbItemsList.Size = new System.Drawing.Size(273, 275);
            this.gbItemsList.TabIndex = 21;
            this.gbItemsList.TabStop = false;
            this.gbItemsList.Text = "Item List";
            // 
            // gbClientBill
            // 
            this.gbClientBill.Location = new System.Drawing.Point(594, 168);
            this.gbClientBill.Name = "gbClientBill";
            this.gbClientBill.Size = new System.Drawing.Size(273, 322);
            this.gbClientBill.TabIndex = 22;
            this.gbClientBill.TabStop = false;
            this.gbClientBill.Text = "Client Bill";
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.Location = new System.Drawing.Point(718, 496);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPrintBill.Size = new System.Drawing.Size(152, 28);
            this.btnPrintBill.TabIndex = 23;
            this.btnPrintBill.Text = "Print Bill";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.gbClientBill);
            this.Controls.Add(this.gbItemsList);
            this.Controls.Add(this.rdMobile);
            this.Controls.Add(this.rdCard);
            this.Controls.Add(this.rdCash);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddToBill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Billing";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlItem.ResumeLayout(false);
            this.pnlItem.PerformLayout();
            this.pnlCategories.ResumeLayout(false);
            this.pnlCategories.PerformLayout();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.pnlBilling.ResumeLayout(false);
            this.pnlBilling.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlLogout.ResumeLayout(false);
            this.pnlLogout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Panel pnlBilling;
        private System.Windows.Forms.Label lblBilling;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddToBill;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdCash;
        private System.Windows.Forms.RadioButton rdCard;
        private System.Windows.Forms.RadioButton rdMobile;
        private System.Windows.Forms.GroupBox gbItemsList;
        private System.Windows.Forms.GroupBox gbClientBill;
        private System.Windows.Forms.Button btnPrintBill;
    }
}