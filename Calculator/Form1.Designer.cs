
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbop1 = new System.Windows.Forms.Label();
            this.btPlus = new System.Windows.Forms.Button();
            this.Operant1 = new System.Windows.Forms.TextBox();
            this.Operant2 = new System.Windows.Forms.TextBox();
            this.lbop2 = new System.Windows.Forms.Label();
            this.btMinus = new System.Windows.Forms.Button();
            this.btMal = new System.Windows.Forms.Button();
            this.btGeteilt = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbop1
            // 
            this.lbop1.AutoSize = true;
            this.lbop1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbop1.Location = new System.Drawing.Point(47, 30);
            this.lbop1.Name = "lbop1";
            this.lbop1.Size = new System.Drawing.Size(90, 23);
            this.lbop1.TabIndex = 0;
            this.lbop1.Text = "Operant 1";
            // 
            // btPlus
            // 
            this.btPlus.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlus.Location = new System.Drawing.Point(32, 165);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(124, 45);
            this.btPlus.TabIndex = 2;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // Operant1
            // 
            this.Operant1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operant1.Location = new System.Drawing.Point(32, 88);
            this.Operant1.Name = "Operant1";
            this.Operant1.Size = new System.Drawing.Size(124, 43);
            this.Operant1.TabIndex = 4;
            // 
            // Operant2
            // 
            this.Operant2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operant2.Location = new System.Drawing.Point(162, 88);
            this.Operant2.Name = "Operant2";
            this.Operant2.Size = new System.Drawing.Size(124, 43);
            this.Operant2.TabIndex = 5;
            // 
            // lbop2
            // 
            this.lbop2.AutoSize = true;
            this.lbop2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbop2.Location = new System.Drawing.Point(178, 30);
            this.lbop2.Name = "lbop2";
            this.lbop2.Size = new System.Drawing.Size(90, 23);
            this.lbop2.TabIndex = 6;
            this.lbop2.Text = "Operant 2";
            // 
            // btMinus
            // 
            this.btMinus.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinus.Location = new System.Drawing.Point(162, 165);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(124, 45);
            this.btMinus.TabIndex = 7;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btMal
            // 
            this.btMal.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMal.Location = new System.Drawing.Point(32, 233);
            this.btMal.Name = "btMal";
            this.btMal.Size = new System.Drawing.Size(124, 45);
            this.btMal.TabIndex = 8;
            this.btMal.Text = "*";
            this.btMal.UseVisualStyleBackColor = true;
            this.btMal.Click += new System.EventHandler(this.btMal_Click);
            // 
            // btGeteilt
            // 
            this.btGeteilt.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGeteilt.Location = new System.Drawing.Point(162, 233);
            this.btGeteilt.Name = "btGeteilt";
            this.btGeteilt.Size = new System.Drawing.Size(124, 45);
            this.btGeteilt.TabIndex = 9;
            this.btGeteilt.Text = "/";
            this.btGeteilt.UseVisualStyleBackColor = true;
            this.btGeteilt.Click += new System.EventHandler(this.btGeteilt_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(248, 311);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 10;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 346);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btGeteilt);
            this.Controls.Add(this.btMal);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.lbop2);
            this.Controls.Add(this.Operant2);
            this.Controls.Add(this.Operant1);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.lbop1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator v0.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbop1;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.TextBox Operant1;
        private System.Windows.Forms.TextBox Operant2;
        private System.Windows.Forms.Label lbop2;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btMal;
        private System.Windows.Forms.Button btGeteilt;
        private System.Windows.Forms.Button btClose;
    }
}

