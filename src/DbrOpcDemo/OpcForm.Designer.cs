namespace DbrOpcDemo
{
    partial class OpcForm
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
            this.BtnRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbNodeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNodeReadValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbParamFir = new System.Windows.Forms.TextBox();
            this.TbParamSecond = new System.Windows.Forms.TextBox();
            this.BtnChangeValue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TbCallValueResult = new System.Windows.Forms.TextBox();
            this.BtnOperation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TbMethodId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(352, 83);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(59, 23);
            this.BtnRead.TabIndex = 0;
            this.BtnRead.Text = "Read";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnOpcRead_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "node id:";
            // 
            // TbNodeId
            // 
            this.TbNodeId.Location = new System.Drawing.Point(121, 41);
            this.TbNodeId.Name = "TbNodeId";
            this.TbNodeId.Size = new System.Drawing.Size(290, 20);
            this.TbNodeId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "node value:";
            // 
            // TbNodeReadValue
            // 
            this.TbNodeReadValue.Location = new System.Drawing.Point(121, 85);
            this.TbNodeReadValue.Name = "TbNodeReadValue";
            this.TbNodeReadValue.Size = new System.Drawing.Size(225, 20);
            this.TbNodeReadValue.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Param1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Param2:";
            // 
            // TbParamFir
            // 
            this.TbParamFir.Location = new System.Drawing.Point(121, 161);
            this.TbParamFir.Name = "TbParamFir";
            this.TbParamFir.Size = new System.Drawing.Size(290, 20);
            this.TbParamFir.TabIndex = 7;
            // 
            // TbParamSecond
            // 
            this.TbParamSecond.Location = new System.Drawing.Point(121, 204);
            this.TbParamSecond.Name = "TbParamSecond";
            this.TbParamSecond.Size = new System.Drawing.Size(290, 20);
            this.TbParamSecond.TabIndex = 8;
            // 
            // BtnChangeValue
            // 
            this.BtnChangeValue.Location = new System.Drawing.Point(121, 289);
            this.BtnChangeValue.Name = "BtnChangeValue";
            this.BtnChangeValue.Size = new System.Drawing.Size(114, 32);
            this.BtnChangeValue.TabIndex = 9;
            this.BtnChangeValue.Text = "Change Value";
            this.BtnChangeValue.UseVisualStyleBackColor = true;
            this.BtnChangeValue.Click += new System.EventHandler(this.BtnChangeValue_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "call result :";
            // 
            // TbCallValueResult
            // 
            this.TbCallValueResult.Location = new System.Drawing.Point(121, 250);
            this.TbCallValueResult.Name = "TbCallValueResult";
            this.TbCallValueResult.Size = new System.Drawing.Size(290, 20);
            this.TbCallValueResult.TabIndex = 11;
            // 
            // BtnOperation
            // 
            this.BtnOperation.Location = new System.Drawing.Point(250, 289);
            this.BtnOperation.Name = "BtnOperation";
            this.BtnOperation.Size = new System.Drawing.Size(114, 32);
            this.BtnOperation.TabIndex = 14;
            this.BtnOperation.Text = "Operation";
            this.BtnOperation.UseVisualStyleBackColor = true;
            this.BtnOperation.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "method id:";
            // 
            // TbMethodId
            // 
            this.TbMethodId.Location = new System.Drawing.Point(121, 130);
            this.TbMethodId.Name = "TbMethodId";
            this.TbMethodId.Size = new System.Drawing.Size(290, 20);
            this.TbMethodId.TabIndex = 16;
            // 
            // OpcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 383);
            this.Controls.Add(this.TbMethodId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnOperation);
            this.Controls.Add(this.TbCallValueResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnChangeValue);
            this.Controls.Add(this.TbParamSecond);
            this.Controls.Add(this.TbParamFir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbNodeReadValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbNodeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRead);
            this.Name = "OpcForm";
            this.Text = "OpcForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbNodeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNodeReadValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbParamFir;
        private System.Windows.Forms.TextBox TbParamSecond;
        private System.Windows.Forms.Button BtnChangeValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbCallValueResult;
        private System.Windows.Forms.Button BtnOperation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbMethodId;
    }
}