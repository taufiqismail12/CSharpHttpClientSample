
namespace HttpClientSample
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.BtnGetData = new System.Windows.Forms.Button();
            this.DgPost = new System.Windows.Forms.DataGridView();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnGetAllData = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGetData
            // 
            this.BtnGetData.Location = new System.Drawing.Point(118, 5);
            this.BtnGetData.Name = "BtnGetData";
            this.BtnGetData.Size = new System.Drawing.Size(99, 26);
            this.BtnGetData.TabIndex = 0;
            this.BtnGetData.Text = "Get Data By ID";
            this.BtnGetData.UseVisualStyleBackColor = true;
            this.BtnGetData.Click += new System.EventHandler(this.BtnGetData_ClickAsync);
            // 
            // DgPost
            // 
            this.DgPost.AllowUserToAddRows = false;
            this.DgPost.AutoGenerateColumns = false;
            this.DgPost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.bodyDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.DgPost.DataSource = this.postBindingSource;
            this.DgPost.Location = new System.Drawing.Point(12, 69);
            this.DgPost.Name = "DgPost";
            this.DgPost.Size = new System.Drawing.Size(548, 280);
            this.DgPost.TabIndex = 1;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(12, 9);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 2;
            // 
            // BtnGetAllData
            // 
            this.BtnGetAllData.Location = new System.Drawing.Point(461, 9);
            this.BtnGetAllData.Name = "BtnGetAllData";
            this.BtnGetAllData.Size = new System.Drawing.Size(99, 26);
            this.BtnGetAllData.TabIndex = 3;
            this.BtnGetAllData.Text = "Get All Data";
            this.BtnGetAllData.UseVisualStyleBackColor = true;
            this.BtnGetAllData.Click += new System.EventHandler(this.BtnGetAllData_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            this.bodyDataGridViewTextBoxColumn.DataPropertyName = "body";
            this.bodyDataGridViewTextBoxColumn.HeaderText = "body";
            this.bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(HttpClientSample.DataModel.Post);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 361);
            this.Controls.Add(this.BtnGetAllData);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.DgPost);
            this.Controls.Add(this.BtnGetData);
            this.Name = "Main";
            this.Text = "Http Client Example";
            ((System.ComponentModel.ISupportInitialize)(this.DgPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGetData;
        private System.Windows.Forms.DataGridView DgPost;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button BtnGetAllData;
    }
}

