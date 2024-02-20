namespace OdemePlanı_7.UI.Forms
{
    partial class PayPlanAdd_frm
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
            payPlanAdd_dgw = new DataGridView();
            payPlanGroupName_txt = new TextBox();
            label1 = new Label();
            payPlanAdd_btn = new Button();
            payPlanListDeleteRow_btn = new Button();
            payPlanListAddRow_btn = new Button();
            payPlanClose_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)payPlanAdd_dgw).BeginInit();
            SuspendLayout();
            // 
            // payPlanAdd_dgw
            // 
            payPlanAdd_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            payPlanAdd_dgw.Location = new Point(186, 84);
            payPlanAdd_dgw.Name = "payPlanAdd_dgw";
            payPlanAdd_dgw.RowHeadersWidth = 51;
            payPlanAdd_dgw.Size = new Size(300, 260);
            payPlanAdd_dgw.TabIndex = 0;
            // 
            // payPlanGroupName_txt
            // 
            payPlanGroupName_txt.Location = new Point(35, 148);
            payPlanGroupName_txt.Name = "payPlanGroupName_txt";
            payPlanGroupName_txt.Size = new Size(125, 27);
            payPlanGroupName_txt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 114);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 2;
            label1.Text = "Grup Adı";
            // 
            // payPlanAdd_btn
            // 
            payPlanAdd_btn.Location = new Point(559, 315);
            payPlanAdd_btn.Name = "payPlanAdd_btn";
            payPlanAdd_btn.Size = new Size(94, 29);
            payPlanAdd_btn.TabIndex = 3;
            payPlanAdd_btn.Text = "Kaydet";
            payPlanAdd_btn.UseVisualStyleBackColor = true;
            payPlanAdd_btn.Click += payPlanAdd_btn_Click;
            // 
            // payPlanListDeleteRow_btn
            // 
            payPlanListDeleteRow_btn.Location = new Point(392, 364);
            payPlanListDeleteRow_btn.Name = "payPlanListDeleteRow_btn";
            payPlanListDeleteRow_btn.Size = new Size(94, 29);
            payPlanListDeleteRow_btn.TabIndex = 5;
            payPlanListDeleteRow_btn.Text = "Satır Sil";
            payPlanListDeleteRow_btn.UseVisualStyleBackColor = true;
            payPlanListDeleteRow_btn.Click += payPlanListDeleteRow_btn_Click;
            // 
            // payPlanListAddRow_btn
            // 
            payPlanListAddRow_btn.Location = new Point(190, 367);
            payPlanListAddRow_btn.Name = "payPlanListAddRow_btn";
            payPlanListAddRow_btn.Size = new Size(106, 30);
            payPlanListAddRow_btn.TabIndex = 6;
            payPlanListAddRow_btn.Text = "Satır Ekle";
            payPlanListAddRow_btn.UseVisualStyleBackColor = true;
            payPlanListAddRow_btn.Click += payPlanListAddRow_btn_Click;
            // 
            // payPlanClose_btn
            // 
            payPlanClose_btn.Location = new Point(547, 363);
            payPlanClose_btn.Name = "payPlanClose_btn";
            payPlanClose_btn.Size = new Size(106, 30);
            payPlanClose_btn.TabIndex = 7;
            payPlanClose_btn.Text = "Kapat";
            payPlanClose_btn.UseVisualStyleBackColor = true;
            payPlanClose_btn.Click += payPlanClose_btn_Click;
            // 
            // PayPlanAdd_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(payPlanClose_btn);
            Controls.Add(payPlanListAddRow_btn);
            Controls.Add(payPlanListDeleteRow_btn);
            Controls.Add(payPlanAdd_btn);
            Controls.Add(label1);
            Controls.Add(payPlanGroupName_txt);
            Controls.Add(payPlanAdd_dgw);
            Name = "PayPlanAdd_frm";
            Text = "PayPlanAdd_frm";
            Load += PayPlanAdd_frm_Load;
            ((System.ComponentModel.ISupportInitialize)payPlanAdd_dgw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView payPlanAdd_dgw;
        private TextBox payPlanGroupName_txt;
        private Label label1;
        private Button payPlanAdd_btn;
        private Button payPlanListDeleteRow_btn;
        private Button payPlanListAddRow_btn;
        private Button payPlanClose_btn;
    }
}