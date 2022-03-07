
namespace WindowsFormsApp1
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
            this.btnDataGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnJoinData = new System.Windows.Forms.Button();
            this.btnSakliProsedur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDataGetir
            // 
            this.btnDataGetir.Location = new System.Drawing.Point(12, 25);
            this.btnDataGetir.Name = "btnDataGetir";
            this.btnDataGetir.Size = new System.Drawing.Size(135, 35);
            this.btnDataGetir.TabIndex = 0;
            this.btnDataGetir.Text = "EF Data Getir";
            this.btnDataGetir.UseVisualStyleBackColor = true;
            this.btnDataGetir.Click += new System.EventHandler(this.btnDataGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1034, 276);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnJoinData
            // 
            this.btnJoinData.Location = new System.Drawing.Point(191, 24);
            this.btnJoinData.Name = "btnJoinData";
            this.btnJoinData.Size = new System.Drawing.Size(165, 36);
            this.btnJoinData.TabIndex = 2;
            this.btnJoinData.Text = "Join ile Data";
            this.btnJoinData.UseVisualStyleBackColor = true;
            this.btnJoinData.Click += new System.EventHandler(this.btnJoinData_Click);
            // 
            // btnSakliProsedur
            // 
            this.btnSakliProsedur.Location = new System.Drawing.Point(391, 25);
            this.btnSakliProsedur.Name = "btnSakliProsedur";
            this.btnSakliProsedur.Size = new System.Drawing.Size(136, 35);
            this.btnSakliProsedur.TabIndex = 3;
            this.btnSakliProsedur.Text = "Saklı Prosedür";
            this.btnSakliProsedur.UseVisualStyleBackColor = true;
            this.btnSakliProsedur.Click += new System.EventHandler(this.btnSakliProsedur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 481);
            this.Controls.Add(this.btnSakliProsedur);
            this.Controls.Add(this.btnJoinData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDataGetir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDataGetir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnJoinData;
        private System.Windows.Forms.Button btnSakliProsedur;
    }
}

