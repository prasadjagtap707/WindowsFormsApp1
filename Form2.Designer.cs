
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.courseID = new System.Windows.Forms.Label();
            this.CName = new System.Windows.Forms.Label();
            this.CFee = new System.Windows.Forms.Label();
            this.CDuration = new System.Windows.Forms.Label();
            this.txtCId = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCFee = new System.Windows.Forms.TextBox();
            this.txtCDuration = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Course";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(24, 314);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(143, 314);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Serach";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(271, 314);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(355, 81);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // courseID
            // 
            this.courseID.AutoSize = true;
            this.courseID.Location = new System.Drawing.Point(50, 64);
            this.courseID.Name = "courseID";
            this.courseID.Size = new System.Drawing.Size(49, 13);
            this.courseID.TabIndex = 5;
            this.courseID.Text = "Couse Id";
            // 
            // CName
            // 
            this.CName.AutoSize = true;
            this.CName.Location = new System.Drawing.Point(50, 120);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(71, 13);
            this.CName.TabIndex = 6;
            this.CName.Text = "Course Name";
            // 
            // CFee
            // 
            this.CFee.AutoSize = true;
            this.CFee.Location = new System.Drawing.Point(50, 181);
            this.CFee.Name = "CFee";
            this.CFee.Size = new System.Drawing.Size(30, 13);
            this.CFee.TabIndex = 7;
            this.CFee.Text = "Fees";
            // 
            // CDuration
            // 
            this.CDuration.AutoSize = true;
            this.CDuration.Location = new System.Drawing.Point(53, 236);
            this.CDuration.Name = "CDuration";
            this.CDuration.Size = new System.Drawing.Size(47, 13);
            this.CDuration.TabIndex = 8;
            this.CDuration.Text = "Duration";
            // 
            // txtCId
            // 
            this.txtCId.Location = new System.Drawing.Point(143, 61);
            this.txtCId.Name = "txtCId";
            this.txtCId.Size = new System.Drawing.Size(100, 20);
            this.txtCId.TabIndex = 9;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(143, 111);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(100, 20);
            this.txtCName.TabIndex = 10;
            // 
            // txtCFee
            // 
            this.txtCFee.Location = new System.Drawing.Point(143, 178);
            this.txtCFee.Name = "txtCFee";
            this.txtCFee.Size = new System.Drawing.Size(100, 20);
            this.txtCFee.TabIndex = 11;
            // 
            // txtCDuration
            // 
            this.txtCDuration.Location = new System.Drawing.Point(143, 233);
            this.txtCDuration.Name = "txtCDuration";
            this.txtCDuration.Size = new System.Drawing.Size(100, 20);
            this.txtCDuration.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(522, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(522, 211);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(228, 23);
            this.btnShowAll.TabIndex = 14;
            this.btnShowAll.Text = "Show All Course";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(355, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCDuration);
            this.Controls.Add(this.txtCFee);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtCId);
            this.Controls.Add(this.CDuration);
            this.Controls.Add(this.CFee);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.courseID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label courseID;
        private System.Windows.Forms.Label CName;
        private System.Windows.Forms.Label CFee;
        private System.Windows.Forms.Label CDuration;
        private System.Windows.Forms.TextBox txtCId;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCFee;
        private System.Windows.Forms.TextBox txtCDuration;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnDelete;
    }
}