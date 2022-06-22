namespace Dem
{
    partial class MyActions
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lableTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelGreetings = new System.Windows.Forms.Label();
            this.tableMyActivity = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMyActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.lableTitle);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 44);
            this.panelHeader.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(629, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lableTitle
            // 
            this.lableTitle.AutoSize = true;
            this.lableTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableTitle.Location = new System.Drawing.Point(315, 9);
            this.lableTitle.Name = "lableTitle";
            this.lableTitle.Size = new System.Drawing.Size(156, 26);
            this.lableTitle.TabIndex = 1;
            this.lableTitle.Text = "Моя активность";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(713, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelGreetings
            // 
            this.labelGreetings.AutoSize = true;
            this.labelGreetings.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGreetings.Location = new System.Drawing.Point(261, 73);
            this.labelGreetings.Name = "labelGreetings";
            this.labelGreetings.Size = new System.Drawing.Size(110, 23);
            this.labelGreetings.TabIndex = 11;
            this.labelGreetings.Text = "Добрый день";
            // 
            // tableMyActivity
            // 
            this.tableMyActivity.AllowUserToAddRows = false;
            this.tableMyActivity.AllowUserToDeleteRows = false;
            this.tableMyActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableMyActivity.BackgroundColor = System.Drawing.Color.White;
            this.tableMyActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMyActivity.GridColor = System.Drawing.Color.White;
            this.tableMyActivity.Location = new System.Drawing.Point(336, 124);
            this.tableMyActivity.MultiSelect = false;
            this.tableMyActivity.Name = "tableMyActivity";
            this.tableMyActivity.ReadOnly = true;
            this.tableMyActivity.RowHeadersVisible = false;
            this.tableMyActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableMyActivity.Size = new System.Drawing.Size(452, 314);
            this.tableMyActivity.TabIndex = 13;
            // 
            // MyActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableMyActivity);
            this.Controls.Add(this.labelGreetings);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyActions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyActions";
            this.Load += new System.EventHandler(this.MyActions_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMyActivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lableTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelGreetings;
        private System.Windows.Forms.DataGridView tableMyActivity;
    }
}