namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Save = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Index = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.Label();
            this.Costumer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(686, 27);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(99, 33);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Add_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(686, 66);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(99, 33);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(527, 27);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(99, 33);
            this.Confirm.TabIndex = 2;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(686, 105);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(99, 33);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("宋体", 13F);
            this.Search.Location = new System.Drawing.Point(78, 27);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(392, 32);
            this.Search.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 13F);
            this.textBox1.Location = new System.Drawing.Point(139, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 32);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 13F);
            this.textBox2.Location = new System.Drawing.Point(139, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(392, 32);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 13F);
            this.textBox3.Location = new System.Drawing.Point(139, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(392, 32);
            this.textBox3.TabIndex = 7;
            // 
            // Index
            // 
            this.Index.AutoSize = true;
            this.Index.Font = new System.Drawing.Font("宋体", 13F);
            this.Index.Location = new System.Drawing.Point(24, 123);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(76, 22);
            this.Index.TabIndex = 8;
            this.Index.Text = "Index:";
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Font = new System.Drawing.Font("宋体", 13F);
            this.Item.Location = new System.Drawing.Point(24, 171);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(65, 22);
            this.Item.TabIndex = 9;
            this.Item.Text = "Item:";
            // 
            // Costumer
            // 
            this.Costumer.AutoSize = true;
            this.Costumer.Font = new System.Drawing.Font("宋体", 13F);
            this.Costumer.Location = new System.Drawing.Point(24, 228);
            this.Costumer.Name = "Costumer";
            this.Costumer.Size = new System.Drawing.Size(109, 22);
            this.Costumer.TabIndex = 10;
            this.Costumer.Text = "Costumer:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Costumer);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Index;
        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.Label Costumer;
    }
}

