namespace Dem
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableEvent = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.lableTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnEventInfo = new System.Windows.Forms.Button();
            this.btnAuth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableEvent)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableEvent
            // 
            this.tableEvent.AllowUserToAddRows = false;
            this.tableEvent.AllowUserToDeleteRows = false;
            this.tableEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableEvent.BackgroundColor = System.Drawing.Color.White;
            this.tableEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableEvent.GridColor = System.Drawing.Color.White;
            this.tableEvent.Location = new System.Drawing.Point(12, 58);
            this.tableEvent.MultiSelect = false;
            this.tableEvent.Name = "tableEvent";
            this.tableEvent.ReadOnly = true;
            this.tableEvent.RowHeadersVisible = false;
            this.tableEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableEvent.Size = new System.Drawing.Size(776, 351);
            this.tableEvent.TabIndex = 0;
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
            // lableTitle
            // 
            this.lableTitle.AutoSize = true;
            this.lableTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableTitle.Location = new System.Drawing.Point(332, 9);
            this.lableTitle.Name = "lableTitle";
            this.lableTitle.Size = new System.Drawing.Size(136, 26);
            this.lableTitle.TabIndex = 1;
            this.lableTitle.Text = "Главное окно";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.btnAuth);
            this.panelHeader.Controls.Add(this.lableTitle);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 44);
            this.panelHeader.TabIndex = 1;
            // 
            // btnEventInfo
            // 
            this.btnEventInfo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEventInfo.Location = new System.Drawing.Point(688, 415);
            this.btnEventInfo.Name = "btnEventInfo";
            this.btnEventInfo.Size = new System.Drawing.Size(100, 23);
            this.btnEventInfo.TabIndex = 2;
            this.btnEventInfo.Text = "Подробнее";
            this.btnEventInfo.UseVisualStyleBackColor = true;
            this.btnEventInfo.Click += new System.EventHandler(this.btnEventInfo_Click);
            // 
            // btnAuth
            // 
            this.btnAuth.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuth.Location = new System.Drawing.Point(607, 12);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(100, 23);
            this.btnAuth.TabIndex = 3;
            this.btnAuth.Text = "Авторизация";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEventInfo);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.tableEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableEvent)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableEvent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lableTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnEventInfo;
        private System.Windows.Forms.Button btnAuth;
    }
}

