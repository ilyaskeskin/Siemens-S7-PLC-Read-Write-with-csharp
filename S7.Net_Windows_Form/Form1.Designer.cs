
namespace S7.Net_Windows_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCpuType = new System.Windows.Forms.ComboBox();
            this.txtIpAdres = new System.Windows.Forms.TextBox();
            this.txtRack = new System.Windows.Forms.TextBox();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlcHafiza = new System.Windows.Forms.TextBox();
            this.txtOkunanDeger = new System.Windows.Forms.TextBox();
            this.txtYazilanDeger = new System.Windows.Forms.TextBox();
            this.txtBaglanti = new System.Windows.Forms.TextBox();
            this.btnBaglantiKur = new System.Windows.Forms.Button();
            this.btnBaglantıKes = new System.Windows.Forms.Button();
            this.btnVeriOku = new System.Windows.Forms.Button();
            this.btnVeriYaz = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU Tipi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP Adresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rack";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Slot";
            // 
            // cmbCpuType
            // 
            this.cmbCpuType.FormattingEnabled = true;
            this.cmbCpuType.Location = new System.Drawing.Point(141, 45);
            this.cmbCpuType.Name = "cmbCpuType";
            this.cmbCpuType.Size = new System.Drawing.Size(121, 21);
            this.cmbCpuType.TabIndex = 1;
            // 
            // txtIpAdres
            // 
            this.txtIpAdres.Location = new System.Drawing.Point(141, 87);
            this.txtIpAdres.Name = "txtIpAdres";
            this.txtIpAdres.Size = new System.Drawing.Size(121, 20);
            this.txtIpAdres.TabIndex = 2;
            // 
            // txtRack
            // 
            this.txtRack.Location = new System.Drawing.Point(141, 123);
            this.txtRack.Name = "txtRack";
            this.txtRack.Size = new System.Drawing.Size(121, 20);
            this.txtRack.TabIndex = 2;
            // 
            // txtSlot
            // 
            this.txtSlot.Location = new System.Drawing.Point(141, 163);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(121, 20);
            this.txtSlot.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "PLC Hafıza Alanı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Okunan Değer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yazılan Değer";
            // 
            // txtPlcHafiza
            // 
            this.txtPlcHafiza.Location = new System.Drawing.Point(465, 38);
            this.txtPlcHafiza.Name = "txtPlcHafiza";
            this.txtPlcHafiza.Size = new System.Drawing.Size(121, 20);
            this.txtPlcHafiza.TabIndex = 2;
            // 
            // txtOkunanDeger
            // 
            this.txtOkunanDeger.Location = new System.Drawing.Point(465, 80);
            this.txtOkunanDeger.Name = "txtOkunanDeger";
            this.txtOkunanDeger.Size = new System.Drawing.Size(121, 20);
            this.txtOkunanDeger.TabIndex = 2;
            // 
            // txtYazilanDeger
            // 
            this.txtYazilanDeger.Location = new System.Drawing.Point(465, 120);
            this.txtYazilanDeger.Name = "txtYazilanDeger";
            this.txtYazilanDeger.Size = new System.Drawing.Size(121, 20);
            this.txtYazilanDeger.TabIndex = 2;
            // 
            // txtBaglanti
            // 
            this.txtBaglanti.Location = new System.Drawing.Point(465, 297);
            this.txtBaglanti.Name = "txtBaglanti";
            this.txtBaglanti.Size = new System.Drawing.Size(121, 20);
            this.txtBaglanti.TabIndex = 2;
            // 
            // btnBaglantiKur
            // 
            this.btnBaglantiKur.Location = new System.Drawing.Point(72, 207);
            this.btnBaglantiKur.Name = "btnBaglantiKur";
            this.btnBaglantiKur.Size = new System.Drawing.Size(108, 54);
            this.btnBaglantiKur.TabIndex = 3;
            this.btnBaglantiKur.Text = "Bağlantı Kur";
            this.btnBaglantiKur.UseVisualStyleBackColor = true;
            this.btnBaglantiKur.Click += new System.EventHandler(this.btnBaglantiKur_Click);
            // 
            // btnBaglantıKes
            // 
            this.btnBaglantıKes.Location = new System.Drawing.Point(186, 207);
            this.btnBaglantıKes.Name = "btnBaglantıKes";
            this.btnBaglantıKes.Size = new System.Drawing.Size(108, 54);
            this.btnBaglantıKes.TabIndex = 3;
            this.btnBaglantıKes.Text = "Bağlantıyı Kes";
            this.btnBaglantıKes.UseVisualStyleBackColor = true;
            this.btnBaglantıKes.Click += new System.EventHandler(this.btnBaglantıKes_Click);
            // 
            // btnVeriOku
            // 
            this.btnVeriOku.Location = new System.Drawing.Point(338, 207);
            this.btnVeriOku.Name = "btnVeriOku";
            this.btnVeriOku.Size = new System.Drawing.Size(108, 54);
            this.btnVeriOku.TabIndex = 3;
            this.btnVeriOku.Text = "Veri Oku";
            this.btnVeriOku.UseVisualStyleBackColor = true;
            this.btnVeriOku.Click += new System.EventHandler(this.btnVeriOku_Click);
            // 
            // btnVeriYaz
            // 
            this.btnVeriYaz.Location = new System.Drawing.Point(478, 207);
            this.btnVeriYaz.Name = "btnVeriYaz";
            this.btnVeriYaz.Size = new System.Drawing.Size(108, 54);
            this.btnVeriYaz.TabIndex = 3;
            this.btnVeriYaz.Text = "Veri Yazdır";
            this.btnVeriYaz.UseVisualStyleBackColor = true;
            this.btnVeriYaz.Click += new System.EventHandler(this.btnVeriYaz_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Baglantı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 342);
            this.Controls.Add(this.btnVeriYaz);
            this.Controls.Add(this.btnVeriOku);
            this.Controls.Add(this.btnBaglantıKes);
            this.Controls.Add(this.btnBaglantiKur);
            this.Controls.Add(this.txtSlot);
            this.Controls.Add(this.txtRack);
            this.Controls.Add(this.txtBaglanti);
            this.Controls.Add(this.txtYazilanDeger);
            this.Controls.Add(this.txtOkunanDeger);
            this.Controls.Add(this.txtPlcHafiza);
            this.Controls.Add(this.txtIpAdres);
            this.Controls.Add(this.cmbCpuType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCpuType;
        private System.Windows.Forms.TextBox txtIpAdres;
        private System.Windows.Forms.TextBox txtRack;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlcHafiza;
        private System.Windows.Forms.TextBox txtOkunanDeger;
        private System.Windows.Forms.TextBox txtYazilanDeger;
        private System.Windows.Forms.TextBox txtBaglanti;
        private System.Windows.Forms.Button btnBaglantiKur;
        private System.Windows.Forms.Button btnBaglantıKes;
        private System.Windows.Forms.Button btnVeriOku;
        private System.Windows.Forms.Button btnVeriYaz;
        private System.Windows.Forms.Label label8;
    }
}

