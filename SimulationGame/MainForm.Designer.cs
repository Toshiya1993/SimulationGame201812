namespace SimulationGame
{
    partial class ShopManagement
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.listboxProducts = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnToProducts = new System.Windows.Forms.Button();
            this.btnFromProducts = new System.Windows.Forms.Button();
            this.listboxStockItems = new System.Windows.Forms.ListBox();
            this.listboxArrivalItems = new System.Windows.Forms.ListBox();
            this.btnToStock = new System.Windows.Forms.Button();
            this.btnFromStock = new System.Windows.Forms.Button();
            this.labelArrivalItems = new System.Windows.Forms.Label();
            this.labelStockItems = new System.Windows.Forms.Label();
            this.labelProducts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listboxProducts
            // 
            this.listboxProducts.FormattingEnabled = true;
            this.listboxProducts.ItemHeight = 12;
            this.listboxProducts.Location = new System.Drawing.Point(602, 26);
            this.listboxProducts.Name = "listboxProducts";
            this.listboxProducts.Size = new System.Drawing.Size(168, 268);
            this.listboxProducts.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 329);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(760, 220);
            this.textBox1.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(695, 300);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "商売開始";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnToProducts
            // 
            this.btnToProducts.Location = new System.Drawing.Point(501, 137);
            this.btnToProducts.Name = "btnToProducts";
            this.btnToProducts.Size = new System.Drawing.Size(75, 23);
            this.btnToProducts.TabIndex = 2;
            this.btnToProducts.Text = "→";
            this.btnToProducts.UseVisualStyleBackColor = true;
            // 
            // btnFromProducts
            // 
            this.btnFromProducts.Location = new System.Drawing.Point(501, 166);
            this.btnFromProducts.Name = "btnFromProducts";
            this.btnFromProducts.Size = new System.Drawing.Size(75, 23);
            this.btnFromProducts.TabIndex = 2;
            this.btnFromProducts.Text = "←";
            this.btnFromProducts.UseVisualStyleBackColor = true;
            // 
            // listboxStockItems
            // 
            this.listboxStockItems.FormattingEnabled = true;
            this.listboxStockItems.ItemHeight = 12;
            this.listboxStockItems.Location = new System.Drawing.Point(307, 26);
            this.listboxStockItems.Name = "listboxStockItems";
            this.listboxStockItems.Size = new System.Drawing.Size(168, 268);
            this.listboxStockItems.TabIndex = 0;
            // 
            // listboxArrivalItems
            // 
            this.listboxArrivalItems.FormattingEnabled = true;
            this.listboxArrivalItems.ItemHeight = 12;
            this.listboxArrivalItems.Location = new System.Drawing.Point(12, 26);
            this.listboxArrivalItems.Name = "listboxArrivalItems";
            this.listboxArrivalItems.Size = new System.Drawing.Size(168, 268);
            this.listboxArrivalItems.TabIndex = 0;
            // 
            // btnToStock
            // 
            this.btnToStock.Location = new System.Drawing.Point(206, 137);
            this.btnToStock.Name = "btnToStock";
            this.btnToStock.Size = new System.Drawing.Size(75, 23);
            this.btnToStock.TabIndex = 2;
            this.btnToStock.Text = "→";
            this.btnToStock.UseVisualStyleBackColor = true;
            // 
            // btnFromStock
            // 
            this.btnFromStock.Location = new System.Drawing.Point(206, 166);
            this.btnFromStock.Name = "btnFromStock";
            this.btnFromStock.Size = new System.Drawing.Size(75, 23);
            this.btnFromStock.TabIndex = 2;
            this.btnFromStock.Text = "←";
            this.btnFromStock.UseVisualStyleBackColor = true;
            // 
            // labelArrivalItems
            // 
            this.labelArrivalItems.AutoSize = true;
            this.labelArrivalItems.Location = new System.Drawing.Point(12, 9);
            this.labelArrivalItems.Name = "labelArrivalItems";
            this.labelArrivalItems.Size = new System.Drawing.Size(52, 12);
            this.labelArrivalItems.TabIndex = 3;
            this.labelArrivalItems.Text = "仕入れ品";
            // 
            // labelStockItems
            // 
            this.labelStockItems.AutoSize = true;
            this.labelStockItems.Location = new System.Drawing.Point(305, 9);
            this.labelStockItems.Name = "labelStockItems";
            this.labelStockItems.Size = new System.Drawing.Size(29, 12);
            this.labelStockItems.TabIndex = 3;
            this.labelStockItems.Text = "在庫";
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Location = new System.Drawing.Point(600, 9);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(29, 12);
            this.labelProducts.TabIndex = 3;
            this.labelProducts.Text = "商品";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "商売ログ";
            // 
            // ShopManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.labelStockItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelArrivalItems);
            this.Controls.Add(this.btnFromProducts);
            this.Controls.Add(this.btnFromStock);
            this.Controls.Add(this.btnToStock);
            this.Controls.Add(this.btnToProducts);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listboxArrivalItems);
            this.Controls.Add(this.listboxStockItems);
            this.Controls.Add(this.listboxProducts);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ShopManagement";
            this.Text = "店舗経営ゲーム";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxProducts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnToProducts;
        private System.Windows.Forms.Button btnFromProducts;
        private System.Windows.Forms.ListBox listboxStockItems;
        private System.Windows.Forms.ListBox listboxArrivalItems;
        private System.Windows.Forms.Button btnToStock;
        private System.Windows.Forms.Button btnFromStock;
        private System.Windows.Forms.Label labelArrivalItems;
        private System.Windows.Forms.Label labelStockItems;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label label1;
    }
}

