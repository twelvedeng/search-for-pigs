namespace 要了卿命的猪
{
    partial class Doityourself
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doityourself));
            this.Labelwidth = new System.Windows.Forms.Label();
            this.NumericUpDowwidth = new System.Windows.Forms.NumericUpDown();
            this.Labelheight = new System.Windows.Forms.Label();
            this.Labelnum = new System.Windows.Forms.Label();
            this.NumericUpDownheight = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownnum = new System.Windows.Forms.NumericUpDown();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDowwidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownheight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownnum)).BeginInit();
            this.SuspendLayout();
            // 
            // Labelwidth
            // 
            this.Labelwidth.AutoSize = true;
            this.Labelwidth.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Labelwidth.Location = new System.Drawing.Point(27, 29);
            this.Labelwidth.Name = "Labelwidth";
            this.Labelwidth.Size = new System.Drawing.Size(37, 20);
            this.Labelwidth.TabIndex = 0;
            this.Labelwidth.Text = "宽度";
            // 
            // NumericUpDowwidth
            // 
            this.NumericUpDowwidth.Location = new System.Drawing.Point(105, 28);
            this.NumericUpDowwidth.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NumericUpDowwidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDowwidth.Name = "NumericUpDowwidth";
            this.NumericUpDowwidth.Size = new System.Drawing.Size(120, 21);
            this.NumericUpDowwidth.TabIndex = 1;
            this.NumericUpDowwidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDowwidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Labelheight
            // 
            this.Labelheight.AutoSize = true;
            this.Labelheight.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Labelheight.Location = new System.Drawing.Point(27, 68);
            this.Labelheight.Name = "Labelheight";
            this.Labelheight.Size = new System.Drawing.Size(37, 20);
            this.Labelheight.TabIndex = 2;
            this.Labelheight.Text = "高度";
            // 
            // Labelnum
            // 
            this.Labelnum.AutoSize = true;
            this.Labelnum.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Labelnum.Location = new System.Drawing.Point(12, 112);
            this.Labelnum.Name = "Labelnum";
            this.Labelnum.Size = new System.Drawing.Size(65, 20);
            this.Labelnum.TabIndex = 3;
            this.Labelnum.Text = "猪的个数";
            // 
            // NumericUpDownheight
            // 
            this.NumericUpDownheight.Location = new System.Drawing.Point(105, 67);
            this.NumericUpDownheight.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NumericUpDownheight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownheight.Name = "NumericUpDownheight";
            this.NumericUpDownheight.Size = new System.Drawing.Size(120, 21);
            this.NumericUpDownheight.TabIndex = 4;
            this.NumericUpDownheight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDownheight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericUpDownnum
            // 
            this.NumericUpDownnum.Location = new System.Drawing.Point(105, 111);
            this.NumericUpDownnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownnum.Name = "NumericUpDownnum";
            this.NumericUpDownnum.Size = new System.Drawing.Size(120, 21);
            this.NumericUpDownnum.TabIndex = 5;
            this.NumericUpDownnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDownnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(31, 159);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "确定";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(162, 159);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 7;
            this.Button2.Text = "取消";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Doityourself
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(259, 202);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.NumericUpDownnum);
            this.Controls.Add(this.NumericUpDownheight);
            this.Controls.Add(this.Labelnum);
            this.Controls.Add(this.Labelheight);
            this.Controls.Add(this.NumericUpDowwidth);
            this.Controls.Add(this.Labelwidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Doityourself";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doityourself";
            this.Load += new System.EventHandler(this.Doityourself_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDowwidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownheight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Labelwidth;
        private System.Windows.Forms.NumericUpDown NumericUpDowwidth;
        private System.Windows.Forms.Label Labelheight;
        private System.Windows.Forms.Label Labelnum;
        private System.Windows.Forms.NumericUpDown NumericUpDownheight;
        private System.Windows.Forms.NumericUpDown NumericUpDownnum;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
    }
}