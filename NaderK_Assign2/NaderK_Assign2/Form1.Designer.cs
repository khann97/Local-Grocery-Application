
namespace NaderK_Assign2
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
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.loadingData = new System.Windows.Forms.GroupBox();
            this.loadGroceryData = new System.Windows.Forms.Button();
            this.updateData = new System.Windows.Forms.GroupBox();
            this.deleteGroceryItem = new System.Windows.Forms.Button();
            this.updateRestockedQuantity = new System.Windows.Forms.Button();
            this.updateSoldQuantity = new System.Windows.Forms.Button();
            this.savingData = new System.Windows.Forms.GroupBox();
            this.saveGroceryData = new System.Windows.Forms.Button();
            this.saveSalesReport = new System.Windows.Forms.Button();
            this.saveRestockReport = new System.Windows.Forms.Button();
            this.quantitySoldLabel = new System.Windows.Forms.Label();
            this.quantityRestockedLabel = new System.Windows.Forms.Label();
            this.quantitySoldTextBox = new System.Windows.Forms.TextBox();
            this.quantityRestockedTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.loadingData.SuspendLayout();
            this.updateData.SuspendLayout();
            this.savingData.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 15;
            this.outputListBox.Location = new System.Drawing.Point(40, 40);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(1100, 214);
            this.outputListBox.TabIndex = 0;
            this.outputListBox.SelectedIndexChanged += new System.EventHandler(this.outputListBox_SelectedIndexChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(380, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(415, 36);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Local Grocery Application";
            // 
            // loadingData
            // 
            this.loadingData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadingData.Controls.Add(this.loadGroceryData);
            this.loadingData.Location = new System.Drawing.Point(55, 270);
            this.loadingData.Name = "loadingData";
            this.loadingData.Size = new System.Drawing.Size(230, 150);
            this.loadingData.TabIndex = 2;
            this.loadingData.TabStop = false;
            this.loadingData.Text = "Loading Data";
            // 
            // loadGroceryData
            // 
            this.loadGroceryData.Location = new System.Drawing.Point(41, 41);
            this.loadGroceryData.Name = "loadGroceryData";
            this.loadGroceryData.Size = new System.Drawing.Size(150, 40);
            this.loadGroceryData.TabIndex = 0;
            this.loadGroceryData.Text = "Load Grocery Data";
            this.loadGroceryData.UseVisualStyleBackColor = true;
            this.loadGroceryData.Click += new System.EventHandler(this.loadGroceryData_Click);
            // 
            // updateData
            // 
            this.updateData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateData.Controls.Add(this.quantityRestockedTextBox);
            this.updateData.Controls.Add(this.quantitySoldTextBox);
            this.updateData.Controls.Add(this.quantityRestockedLabel);
            this.updateData.Controls.Add(this.quantitySoldLabel);
            this.updateData.Controls.Add(this.deleteGroceryItem);
            this.updateData.Controls.Add(this.updateRestockedQuantity);
            this.updateData.Controls.Add(this.updateSoldQuantity);
            this.updateData.Location = new System.Drawing.Point(301, 270);
            this.updateData.Name = "updateData";
            this.updateData.Size = new System.Drawing.Size(558, 217);
            this.updateData.TabIndex = 3;
            this.updateData.TabStop = false;
            this.updateData.Text = "Update Data";
            // 
            // deleteGroceryItem
            // 
            this.deleteGroceryItem.Location = new System.Drawing.Point(171, 160);
            this.deleteGroceryItem.Name = "deleteGroceryItem";
            this.deleteGroceryItem.Size = new System.Drawing.Size(250, 40);
            this.deleteGroceryItem.TabIndex = 2;
            this.deleteGroceryItem.Text = "Delete Selected Grocery Item";
            this.deleteGroceryItem.UseVisualStyleBackColor = true;
            this.deleteGroceryItem.Click += new System.EventHandler(this.deleteGroceryItem_Click);
            // 
            // updateRestockedQuantity
            // 
            this.updateRestockedQuantity.Location = new System.Drawing.Point(374, 90);
            this.updateRestockedQuantity.Name = "updateRestockedQuantity";
            this.updateRestockedQuantity.Size = new System.Drawing.Size(165, 50);
            this.updateRestockedQuantity.TabIndex = 1;
            this.updateRestockedQuantity.Text = "Update Restocked Qty For Selected Item";
            this.updateRestockedQuantity.UseVisualStyleBackColor = true;
            this.updateRestockedQuantity.Click += new System.EventHandler(this.updateRestockedQuantity_Click);
            // 
            // updateSoldQuantity
            // 
            this.updateSoldQuantity.Location = new System.Drawing.Point(30, 90);
            this.updateSoldQuantity.Name = "updateSoldQuantity";
            this.updateSoldQuantity.Size = new System.Drawing.Size(150, 50);
            this.updateSoldQuantity.TabIndex = 0;
            this.updateSoldQuantity.Text = "Update Sold Qty For Selected Item";
            this.updateSoldQuantity.UseVisualStyleBackColor = true;
            this.updateSoldQuantity.Click += new System.EventHandler(this.updateSoldQuantity_Click);
            // 
            // savingData
            // 
            this.savingData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.savingData.Controls.Add(this.saveRestockReport);
            this.savingData.Controls.Add(this.saveSalesReport);
            this.savingData.Controls.Add(this.saveGroceryData);
            this.savingData.Location = new System.Drawing.Point(875, 270);
            this.savingData.Name = "savingData";
            this.savingData.Size = new System.Drawing.Size(250, 250);
            this.savingData.TabIndex = 4;
            this.savingData.TabStop = false;
            this.savingData.Text = "Saving Data";
            // 
            // saveGroceryData
            // 
            this.saveGroceryData.Location = new System.Drawing.Point(41, 41);
            this.saveGroceryData.Name = "saveGroceryData";
            this.saveGroceryData.Size = new System.Drawing.Size(150, 40);
            this.saveGroceryData.TabIndex = 0;
            this.saveGroceryData.Text = "Save Grocery Data";
            this.saveGroceryData.UseVisualStyleBackColor = true;
            this.saveGroceryData.Click += new System.EventHandler(this.saveGroceryData_Click);
            // 
            // saveSalesReport
            // 
            this.saveSalesReport.Location = new System.Drawing.Point(41, 106);
            this.saveSalesReport.Name = "saveSalesReport";
            this.saveSalesReport.Size = new System.Drawing.Size(150, 40);
            this.saveSalesReport.TabIndex = 1;
            this.saveSalesReport.Text = "Save Sales Report";
            this.saveSalesReport.UseVisualStyleBackColor = true;
            this.saveSalesReport.Click += new System.EventHandler(this.saveSalesReport_Click);
            // 
            // saveRestockReport
            // 
            this.saveRestockReport.Location = new System.Drawing.Point(13, 172);
            this.saveRestockReport.Name = "saveRestockReport";
            this.saveRestockReport.Size = new System.Drawing.Size(221, 40);
            this.saveRestockReport.TabIndex = 2;
            this.saveRestockReport.Text = "Save Restock Needs Report";
            this.saveRestockReport.UseVisualStyleBackColor = true;
            this.saveRestockReport.Click += new System.EventHandler(this.saveRestockReport_Click);
            // 
            // quantitySoldLabel
            // 
            this.quantitySoldLabel.AutoSize = true;
            this.quantitySoldLabel.Location = new System.Drawing.Point(27, 37);
            this.quantitySoldLabel.Name = "quantitySoldLabel";
            this.quantitySoldLabel.Size = new System.Drawing.Size(97, 17);
            this.quantitySoldLabel.TabIndex = 3;
            this.quantitySoldLabel.Text = "Quantity Sold:";
            // 
            // quantityRestockedLabel
            // 
            this.quantityRestockedLabel.AutoSize = true;
            this.quantityRestockedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityRestockedLabel.Location = new System.Drawing.Point(297, 37);
            this.quantityRestockedLabel.Name = "quantityRestockedLabel";
            this.quantityRestockedLabel.Size = new System.Drawing.Size(136, 17);
            this.quantityRestockedLabel.TabIndex = 4;
            this.quantityRestockedLabel.Text = "Quantity Restocked:";
            // 
            // quantitySoldTextBox
            // 
            this.quantitySoldTextBox.Location = new System.Drawing.Point(130, 35);
            this.quantitySoldTextBox.Name = "quantitySoldTextBox";
            this.quantitySoldTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantitySoldTextBox.TabIndex = 5;
            // 
            // quantityRestockedTextBox
            // 
            this.quantityRestockedTextBox.Location = new System.Drawing.Point(439, 35);
            this.quantityRestockedTextBox.Name = "quantityRestockedTextBox";
            this.quantityRestockedTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantityRestockedTextBox.TabIndex = 6;
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.LightGray;
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusLabel.Location = new System.Drawing.Point(335, 500);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(509, 42);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Operation Status Update Displayed Here";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.savingData);
            this.Controls.Add(this.updateData);
            this.Controls.Add(this.loadingData);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.outputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.loadingData.ResumeLayout(false);
            this.updateData.ResumeLayout(false);
            this.updateData.PerformLayout();
            this.savingData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox loadingData;
        private System.Windows.Forms.GroupBox updateData;
        private System.Windows.Forms.GroupBox savingData;
        private System.Windows.Forms.Button loadGroceryData;
        private System.Windows.Forms.Button deleteGroceryItem;
        private System.Windows.Forms.Button updateRestockedQuantity;
        private System.Windows.Forms.Button updateSoldQuantity;
        private System.Windows.Forms.TextBox quantityRestockedTextBox;
        private System.Windows.Forms.TextBox quantitySoldTextBox;
        private System.Windows.Forms.Label quantityRestockedLabel;
        private System.Windows.Forms.Label quantitySoldLabel;
        private System.Windows.Forms.Button saveRestockReport;
        private System.Windows.Forms.Button saveSalesReport;
        private System.Windows.Forms.Button saveGroceryData;
        private System.Windows.Forms.Label statusLabel;
    }
}

