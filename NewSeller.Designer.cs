
namespace WindowsFormsApp1
{
    partial class NewSeller
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.TextBox();
            this.aname = new System.Windows.Forms.TextBox();
            this.esname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 121);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Berry Go Market";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SellerName,
            this.SellerLastName,
            this.EmailId,
            this.SellerId});
            this.dataGridView1.Location = new System.Drawing.Point(535, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(673, 358);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SellerName
            // 
            this.SellerName.HeaderText = "SellerName";
            this.SellerName.MinimumWidth = 8;
            this.SellerName.Name = "SellerName";
            this.SellerName.Width = 150;
            // 
            // SellerLastName
            // 
            this.SellerLastName.HeaderText = "SellerLastName";
            this.SellerLastName.MinimumWidth = 8;
            this.SellerLastName.Name = "SellerLastName";
            this.SellerLastName.Width = 150;
            // 
            // EmailId
            // 
            this.EmailId.HeaderText = "EmailId";
            this.EmailId.MinimumWidth = 8;
            this.EmailId.Name = "EmailId";
            this.EmailId.Width = 150;
            // 
            // SellerId
            // 
            this.SellerId.HeaderText = "SellerId";
            this.SellerId.MinimumWidth = 8;
            this.SellerId.Name = "SellerId";
            this.SellerId.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "SellerName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "SellerLastName";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(190, 142);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(325, 26);
            this.sname.TabIndex = 8;
            // 
            // aname
            // 
            this.aname.Location = new System.Drawing.Point(190, 211);
            this.aname.Name = "aname";
            this.aname.Size = new System.Drawing.Size(325, 26);
            this.aname.TabIndex = 9;
            // 
            // esname
            // 
            this.esname.Location = new System.Drawing.Point(190, 283);
            this.esname.Name = "esname";
            this.esname.Size = new System.Drawing.Size(325, 26);
            this.esname.TabIndex = 10;
            this.esname.TextChanged += new System.EventHandler(this.esname_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(204, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 55);
            this.button1.TabIndex = 12;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(190, 352);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(325, 26);
            this.tname.TabIndex = 13;
            this.tname.TextChanged += new System.EventHandler(this.tname_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "SellerId";
            // 
            // NewSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 503);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.esname);
            this.Controls.Add(this.aname);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "NewSeller";
            this.Text = "NewSeller";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.TextBox aname;
        private System.Windows.Forms.TextBox esname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerId;
    }
}