namespace MobileStockCapture
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOutput = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCode = new TextBox();
            txtMake = new TextBox();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(120, 67);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 20);
            lblOutput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 119);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 1;
            label1.Text = "Mobile Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 181);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "Make:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 244);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 3;
            label3.Text = "Quantity:";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(324, 116);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(125, 27);
            txtCode.TabIndex = 4;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(324, 178);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(125, 27);
            txtMake.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(324, 241);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.Location = new Point(120, 305);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(237, 305);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Gray;
            btnFind.Location = new Point(355, 305);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 9;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(txtMake);
            Controls.Add(txtCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCode;
        private TextBox txtMake;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
    }
}
