namespace dsloop
{
    partial class frmloop
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
            this.btnwhile = new System.Windows.Forms.Button();
            this.btndo = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.lblnum = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(114, 221);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(101, 23);
            this.btnwhile.TabIndex = 6;
            this.btnwhile.Text = "calcular while";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btndo
            // 
            this.btndo.Location = new System.Drawing.Point(281, 221);
            this.btndo.Name = "btndo";
            this.btndo.Size = new System.Drawing.Size(96, 23);
            this.btndo.TabIndex = 7;
            this.btndo.Text = "calcular do";
            this.btndo.UseVisualStyleBackColor = true;
            this.btndo.Click += new System.EventHandler(this.btndo_Click);
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(433, 221);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(105, 23);
            this.btnfor.TabIndex = 8;
            this.btnfor.Text = "calcular for";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(111, 92);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(104, 16);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "Digite o número:";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(242, 89);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 22);
            this.txtnum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tabuada:";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(242, 138);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(187, 22);
            this.txtresult.TabIndex = 10;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(290, 314);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 11;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmloop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btndo);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblnum);
            this.Name = "frmloop";
            this.Text = "loop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btndo;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnvoltar;
    }
}