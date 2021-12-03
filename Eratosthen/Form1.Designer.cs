namespace Eratosthen
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
            this._numMax = new System.Windows.Forms.NumericUpDown();
            this._btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._numMax)).BeginInit();
            this.SuspendLayout();
            // 
            // _numMax
            // 
            this._numMax.Location = new System.Drawing.Point(70, 80);
            this._numMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._numMax.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._numMax.Name = "_numMax";
            this._numMax.Size = new System.Drawing.Size(119, 22);
            this._numMax.TabIndex = 0;
            this._numMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // _btnGo
            // 
            this._btnGo.Location = new System.Drawing.Point(221, 68);
            this._btnGo.Name = "_btnGo";
            this._btnGo.Size = new System.Drawing.Size(114, 44);
            this._btnGo.TabIndex = 1;
            this._btnGo.Text = "Ukaž prvočísla";
            this._btnGo.UseVisualStyleBackColor = true;
            this._btnGo.Click += new System.EventHandler(this._btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zadejte maximum, do něhož chcete prvočísla vypsat";
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(341, 68);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(108, 44);
            this._btnSave.TabIndex = 3;
            this._btnSave.Text = "Uložit do souboru";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Uložení proběhne do binu pod názvem „Primes“";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 171);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnGo);
            this.Controls.Add(this._numMax);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._numMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _numMax;
        private System.Windows.Forms.Button _btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Label label2;
    }
}

