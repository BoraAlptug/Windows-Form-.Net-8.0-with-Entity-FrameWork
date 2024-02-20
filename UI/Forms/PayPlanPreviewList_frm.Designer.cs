namespace OdemePlanı_7.UI.Forms
{
    partial class PayPlanPreviewList_frm
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
            payPlanPreviewDetailList_dgw = new DataGridView();
            payPlanPreviewList_lstbox = new ListBox();
            newPayPlanAdd_btn = new Button();
            payPlanDelete_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)payPlanPreviewDetailList_dgw).BeginInit();
            SuspendLayout();
            // 
            // payPlanPreviewDetailList_dgw
            // 
            payPlanPreviewDetailList_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            payPlanPreviewDetailList_dgw.Location = new Point(241, 12);
            payPlanPreviewDetailList_dgw.Name = "payPlanPreviewDetailList_dgw";
            payPlanPreviewDetailList_dgw.RowHeadersWidth = 51;
            payPlanPreviewDetailList_dgw.Size = new Size(213, 293);
            payPlanPreviewDetailList_dgw.TabIndex = 0;
            // 
            // payPlanPreviewList_lstbox
            // 
            payPlanPreviewList_lstbox.FormattingEnabled = true;
            payPlanPreviewList_lstbox.Location = new Point(12, 12);
            payPlanPreviewList_lstbox.Name = "payPlanPreviewList_lstbox";
            payPlanPreviewList_lstbox.Size = new Size(223, 284);
            payPlanPreviewList_lstbox.TabIndex = 1;
            payPlanPreviewList_lstbox.MouseDoubleClick += payPlanPreviewList_lstbox_MouseDoubleClick;
            // 
            // newPayPlanAdd_btn
            // 
            newPayPlanAdd_btn.Location = new Point(18, 322);
            newPayPlanAdd_btn.Name = "newPayPlanAdd_btn";
            newPayPlanAdd_btn.Size = new Size(148, 53);
            newPayPlanAdd_btn.TabIndex = 2;
            newPayPlanAdd_btn.Text = "Yeni Ödeme Planı Oluştur";
            newPayPlanAdd_btn.UseVisualStyleBackColor = true;
            newPayPlanAdd_btn.Click += newPayPlanAdd_btn_Click;
            // 
            // payPlanDelete_btn
            // 
            payPlanDelete_btn.Location = new Point(195, 322);
            payPlanDelete_btn.Name = "payPlanDelete_btn";
            payPlanDelete_btn.Size = new Size(148, 53);
            payPlanDelete_btn.TabIndex = 3;
            payPlanDelete_btn.Text = "Planı Sil";
            payPlanDelete_btn.UseVisualStyleBackColor = true;
            payPlanDelete_btn.Click += payPlanDelete_btn_Click;
            // 
            // PayPlanPreviewList_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 450);
            Controls.Add(payPlanDelete_btn);
            Controls.Add(newPayPlanAdd_btn);
            Controls.Add(payPlanPreviewList_lstbox);
            Controls.Add(payPlanPreviewDetailList_dgw);
            Name = "PayPlanPreviewList_frm";
            Text = "PayPlanPreviewList_frm";
            Load += PayPlanPreviewList_frm_Load;
            ((System.ComponentModel.ISupportInitialize)payPlanPreviewDetailList_dgw).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView payPlanPreviewDetailList_dgw;
        private ListBox payPlanPreviewList_lstbox;
        private Button newPayPlanAdd_btn;
        private Button payPlanDelete_btn;
    }
}