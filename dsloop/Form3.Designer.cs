namespace dsloop
{
    partial class frmag
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
            this.lbllitro = new System.Windows.Forms.Label();
            this.lblcomb = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtlitro = new System.Windows.Forms.TextBox();
            this.txtcomb = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllitro
            // 
            this.lbllitro.AutoSize = true;
            this.lbllitro.Location = new System.Drawing.Point(36, 52);
            this.lbllitro.Name = "lbllitro";
            this.lbllitro.Size = new System.Drawing.Size(127, 16);
            this.lbllitro.TabIndex = 0;
            this.lbllitro.Text = "Digite quantos litros:";
            // 
            // lblcomb
            // 
            this.lblcomb.AutoSize = true;
            this.lblcomb.Location = new System.Drawing.Point(39, 101);
            this.lblcomb.Name = "lblcomb";
            this.lblcomb.Size = new System.Drawing.Size(238, 16);
            this.lblcomb.TabIndex = 1;
            this.lblcomb.Text = "Digite A para alcoól e G para gasolina:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(39, 151);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(72, 16);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "Resultado:";
            // 
            // txtlitro
            // 
            this.txtlitro.Location = new System.Drawing.Point(315, 46);
            this.txtlitro.Name = "txtlitro";
            this.txtlitro.Size = new System.Drawing.Size(100, 22);
            this.txtlitro.TabIndex = 3;
            // 
            // txtcomb
            // 
            this.txtcomb.Location = new System.Drawing.Point(315, 101);
            this.txtcomb.Name = "txtcomb";
            this.txtcomb.Size = new System.Drawing.Size(100, 22);
            this.txtcomb.TabIndex = 4;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(315, 148);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(100, 22);
            this.txtresult.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(39, 238);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(229, 238);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(423, 237);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtcomb);
            this.Controls.Add(this.txtlitro);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblcomb);
            this.Controls.Add(this.lbllitro);
            this.Name = "frmag";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllitro;
        private System.Windows.Forms.Label lblcomb;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtlitro;
        private System.Windows.Forms.TextBox txtcomb;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}