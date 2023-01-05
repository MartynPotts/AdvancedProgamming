
namespace AwayDayPlanner
{
    partial class ClientSearch
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
            this.txtCompanySearch = new System.Windows.Forms.TextBox();
            this.dgvClientsList = new System.Windows.Forms.DataGridView();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtClientSearch = new System.Windows.Forms.TextBox();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCompanySearch
            // 
            this.txtCompanySearch.Location = new System.Drawing.Point(154, 66);
            this.txtCompanySearch.Name = "txtCompanySearch";
            this.txtCompanySearch.Size = new System.Drawing.Size(159, 20);
            this.txtCompanySearch.TabIndex = 0;
            this.txtCompanySearch.TextChanged += new System.EventHandler(this.TxtCompanySearch_TextChanged);
            // 
            // dgvClientsList
            // 
            this.dgvClientsList.AllowUserToAddRows = false;
            this.dgvClientsList.AllowUserToDeleteRows = false;
            this.dgvClientsList.AllowUserToResizeColumns = false;
            this.dgvClientsList.AllowUserToResizeRows = false;
            this.dgvClientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsList.Location = new System.Drawing.Point(63, 147);
            this.dgvClientsList.Name = "dgvClientsList";
            this.dgvClientsList.ReadOnly = true;
            this.dgvClientsList.Size = new System.Drawing.Size(747, 257);
            this.dgvClientsList.TabIndex = 2;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(66, 34);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(64, 13);
            this.lblClientName.TabIndex = 3;
            this.lblClientName.Text = "Client Name";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(66, 69);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 4;
            this.lblCompanyName.Text = "Company Name";
            // 
            // txtClientSearch
            // 
            this.txtClientSearch.Location = new System.Drawing.Point(154, 31);
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.Size = new System.Drawing.Size(159, 20);
            this.txtClientSearch.TabIndex = 5;
            this.txtClientSearch.TextChanged += new System.EventHandler(this.TxtClientSearch_TextChanged);
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.Location = new System.Drawing.Point(579, 31);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(96, 48);
            this.btnAddNewClient.TabIndex = 6;
            this.btnAddNewClient.Text = "Add New Client";
            this.btnAddNewClient.UseVisualStyleBackColor = true;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // ClientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 533);
            this.Controls.Add(this.btnAddNewClient);
            this.Controls.Add(this.txtClientSearch);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.dgvClientsList);
            this.Controls.Add(this.txtCompanySearch);
            this.Name = "ClientSearch";
            this.Text = "Client Search Form";
            this.Load += new System.EventHandler(this.ClientSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompanySearch;
        private System.Windows.Forms.DataGridView dgvClientsList;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtClientSearch;
        private System.Windows.Forms.Button btnAddNewClient;
    }
}