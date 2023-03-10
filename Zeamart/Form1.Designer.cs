
namespace Zeamart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv_zeamart = new System.Windows.Forms.DataGridView();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.tb_amnt = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zeamart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_zeamart
            // 
            this.dgv_zeamart.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgv_zeamart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_zeamart.Location = new System.Drawing.Point(12, 395);
            this.dgv_zeamart.Name = "dgv_zeamart";
            this.dgv_zeamart.RowHeadersWidth = 62;
            this.dgv_zeamart.RowTemplate.Height = 28;
            this.dgv_zeamart.Size = new System.Drawing.Size(1079, 312);
            this.dgv_zeamart.TabIndex = 0;
            this.dgv_zeamart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_zeamart_CellClick);
            this.dgv_zeamart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tb_item
            // 
            this.tb_item.Location = new System.Drawing.Point(202, 123);
            this.tb_item.Name = "tb_item";
            this.tb_item.Size = new System.Drawing.Size(686, 26);
            this.tb_item.TabIndex = 1;
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(202, 166);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(686, 86);
            this.tb_desc.TabIndex = 2;
            // 
            // tb_amnt
            // 
            this.tb_amnt.Location = new System.Drawing.Point(202, 269);
            this.tb_amnt.Name = "tb_amnt";
            this.tb_amnt.Size = new System.Drawing.Size(686, 26);
            this.tb_amnt.TabIndex = 3;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(202, 314);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(686, 26);
            this.tb_price.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descriptions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price";
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(927, 339);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(80, 40);
            this.btn_new.TabIndex = 13;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1013, 339);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 40);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.tb_item);
            this.panel1.Controls.Add(this.tb_desc);
            this.panel1.Controls.Add(this.tb_amnt);
            this.panel1.Controls.Add(this.tb_price);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 367);
            this.panel1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 60);
            this.label5.TabIndex = 19;
            this.label5.Text = "Zeamart";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(202, 81);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(686, 26);
            this.tb_id.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1103, 759);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.dgv_zeamart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zeamart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_zeamart;
        private System.Windows.Forms.TextBox tb_item;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.TextBox tb_amnt;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

