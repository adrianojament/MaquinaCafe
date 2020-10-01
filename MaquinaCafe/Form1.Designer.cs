namespace MaquinaCafe
{
    partial class Form1
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
            this.mskMoeda = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdCafecomLeite = new System.Windows.Forms.Button();
            this.cmdMocha = new System.Windows.Forms.Button();
            this.cmdCappuccino = new System.Windows.Forms.Button();
            this.cmdCafe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskMoeda
            // 
            this.mskMoeda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskMoeda.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskMoeda.Location = new System.Drawing.Point(17, 50);
            this.mskMoeda.Mask = "0.00";
            this.mskMoeda.Name = "mskMoeda";
            this.mskMoeda.Size = new System.Drawing.Size(142, 31);
            this.mskMoeda.TabIndex = 3;
            this.mskMoeda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskMoeda.ValidatingType = typeof(int);
            this.mskMoeda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskMoeda_KeyPress);
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.Location = new System.Drawing.Point(165, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.mskMoeda);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir a moeda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Moedas Aceitas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "R$ 0,10, R$ 0,25 R$ 0,50  R$ 1,00 ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSaldo);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(330, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 93);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // txtSaldo
            // 
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(3, 59);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(618, 31);
            this.txtSaldo.TabIndex = 8;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(3, 27);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(618, 31);
            this.txtStatus.TabIndex = 7;
            this.txtStatus.Text = "Moeda Invalida, por favor adicione a moeda novamente";
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdCafecomLeite);
            this.groupBox3.Controls.Add(this.cmdMocha);
            this.groupBox3.Controls.Add(this.cmdCappuccino);
            this.groupBox3.Controls.Add(this.cmdCafe);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(333, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(618, 166);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cafés";
            // 
            // cmdCafecomLeite
            // 
            this.cmdCafecomLeite.AutoEllipsis = true;
            this.cmdCafecomLeite.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdCafecomLeite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCafecomLeite.Location = new System.Drawing.Point(3, 126);
            this.cmdCafecomLeite.Name = "cmdCafecomLeite";
            this.cmdCafecomLeite.Size = new System.Drawing.Size(612, 33);
            this.cmdCafecomLeite.TabIndex = 7;
            this.cmdCafecomLeite.Text = "Café com leite R$3.00";
            this.cmdCafecomLeite.UseVisualStyleBackColor = false;
            // 
            // cmdMocha
            // 
            this.cmdMocha.AutoEllipsis = true;
            this.cmdMocha.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdMocha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdMocha.Location = new System.Drawing.Point(3, 93);
            this.cmdMocha.Name = "cmdMocha";
            this.cmdMocha.Size = new System.Drawing.Size(612, 33);
            this.cmdMocha.TabIndex = 6;
            this.cmdMocha.Text = "Mocha R$4.00";
            this.cmdMocha.UseVisualStyleBackColor = false;
            // 
            // cmdCappuccino
            // 
            this.cmdCappuccino.AutoEllipsis = true;
            this.cmdCappuccino.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdCappuccino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCappuccino.Location = new System.Drawing.Point(3, 60);
            this.cmdCappuccino.Name = "cmdCappuccino";
            this.cmdCappuccino.Size = new System.Drawing.Size(612, 33);
            this.cmdCappuccino.TabIndex = 5;
            this.cmdCappuccino.Text = "Cappuccino R$3.50";
            this.cmdCappuccino.UseVisualStyleBackColor = false;
            // 
            // cmdCafe
            // 
            this.cmdCafe.AutoEllipsis = true;
            this.cmdCafe.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdCafe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCafe.Location = new System.Drawing.Point(3, 27);
            this.cmdCafe.Name = "cmdCafe";
            this.cmdCafe.Size = new System.Drawing.Size(612, 33);
            this.cmdCafe.TabIndex = 4;
            this.cmdCafe.Text = "Café R$ 2,00";
            this.cmdCafe.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mskMoeda;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdCafecomLeite;
        private System.Windows.Forms.Button cmdMocha;
        private System.Windows.Forms.Button cmdCappuccino;
        private System.Windows.Forms.Button cmdCafe;
    }
}

