namespace digimon._04
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnabra = new System.Windows.Forms.RadioButton();
            this.btncartepie = new System.Windows.Forms.RadioButton();
            this.btnratata = new System.Windows.Forms.RadioButton();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.btngrowlithe = new System.Windows.Forms.RadioButton();
            this.btnpsyduck = new System.Windows.Forms.RadioButton();
            this.btnWeedle = new System.Windows.Forms.RadioButton();
            this.btnZubat = new System.Windows.Forms.RadioButton();
            this.btnOddish = new System.Windows.Forms.RadioButton();
            this.btnPikachu = new System.Windows.Forms.RadioButton();
            this.btnMankey = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Pokemon Solid", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Yellow;
            this.lbltitulo.Location = new System.Drawing.Point(40, 25);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(238, 55);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Escolha seu pokemon: ";
            this.lbltitulo.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // btnabra
            // 
            this.btnabra.AutoSize = true;
            this.btnabra.BackColor = System.Drawing.Color.Transparent;
            this.btnabra.Checked = true;
            this.btnabra.Font = new System.Drawing.Font("Pokemon Solid", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabra.ForeColor = System.Drawing.Color.Blue;
            this.btnabra.Location = new System.Drawing.Point(26, 108);
            this.btnabra.Name = "btnabra";
            this.btnabra.Size = new System.Drawing.Size(72, 50);
            this.btnabra.TabIndex = 2;
            this.btnabra.TabStop = true;
            this.btnabra.Text = "Abra";
            this.btnabra.UseVisualStyleBackColor = false;
            this.btnabra.CheckedChanged += new System.EventHandler(this.btnabra_CheckedChanged);
            // 
            // btncartepie
            // 
            this.btncartepie.AutoSize = true;
            this.btncartepie.BackColor = System.Drawing.Color.Transparent;
            this.btncartepie.Font = new System.Drawing.Font("Pokemon Solid", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncartepie.ForeColor = System.Drawing.Color.Blue;
            this.btncartepie.Location = new System.Drawing.Point(152, 108);
            this.btncartepie.Name = "btncartepie";
            this.btncartepie.Size = new System.Drawing.Size(103, 50);
            this.btncartepie.TabIndex = 3;
            this.btncartepie.Text = "Cartepie";
            this.btncartepie.UseVisualStyleBackColor = false;
            this.btncartepie.CheckedChanged += new System.EventHandler(this.btncartepie_CheckedChanged);
            // 
            // btnratata
            // 
            this.btnratata.AutoSize = true;
            this.btnratata.BackColor = System.Drawing.Color.Transparent;
            this.btnratata.Font = new System.Drawing.Font("Pokemon Solid", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnratata.ForeColor = System.Drawing.Color.Blue;
            this.btnratata.Location = new System.Drawing.Point(28, 164);
            this.btnratata.Name = "btnratata";
            this.btnratata.Size = new System.Drawing.Size(92, 50);
            this.btnratata.TabIndex = 4;
            this.btnratata.Text = "Ratata";
            this.btnratata.UseVisualStyleBackColor = false;
            this.btnratata.CheckedChanged += new System.EventHandler(this.btnratata_CheckedChanged);
            // 
            // imgBox
            // 
            this.imgBox.BackColor = System.Drawing.Color.Transparent;
            this.imgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgBox.Image = global::digimon._04.Properties.Resources.mankey1;
            this.imgBox.Location = new System.Drawing.Point(325, 0);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(475, 450);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgBox.TabIndex = 5;
            this.imgBox.TabStop = false;
            this.imgBox.Click += new System.EventHandler(this.imgBox_Click);
            // 
            // btngrowlithe
            // 
            this.btngrowlithe.AutoSize = true;
            this.btngrowlithe.BackColor = System.Drawing.Color.Transparent;
            this.btngrowlithe.Font = new System.Drawing.Font("Pokemon Solid", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrowlithe.ForeColor = System.Drawing.Color.Blue;
            this.btngrowlithe.Location = new System.Drawing.Point(152, 164);
            this.btngrowlithe.Name = "btngrowlithe";
            this.btngrowlithe.Size = new System.Drawing.Size(117, 50);
            this.btngrowlithe.TabIndex = 6;
            this.btngrowlithe.Text = "Growlithe";
            this.btngrowlithe.UseVisualStyleBackColor = false;
            this.btngrowlithe.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnpsyduck
            // 
            this.btnpsyduck.AutoSize = true;
            this.btnpsyduck.BackColor = System.Drawing.Color.Transparent;
            this.btnpsyduck.Font = new System.Drawing.Font("Pokemon Solid", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpsyduck.ForeColor = System.Drawing.Color.Blue;
            this.btnpsyduck.Location = new System.Drawing.Point(26, 220);
            this.btnpsyduck.Name = "btnpsyduck";
            this.btnpsyduck.Size = new System.Drawing.Size(101, 50);
            this.btnpsyduck.TabIndex = 7;
            this.btnpsyduck.Text = "Psyduck";
            this.btnpsyduck.UseVisualStyleBackColor = false;
            this.btnpsyduck.CheckedChanged += new System.EventHandler(this.btnpsyduck_CheckedChanged);
            // 
            // btnWeedle
            // 
            this.btnWeedle.AutoSize = true;
            this.btnWeedle.BackColor = System.Drawing.Color.Transparent;
            this.btnWeedle.Font = new System.Drawing.Font("Pokemon Solid", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeedle.ForeColor = System.Drawing.Color.Blue;
            this.btnWeedle.Location = new System.Drawing.Point(152, 220);
            this.btnWeedle.Name = "btnWeedle";
            this.btnWeedle.Size = new System.Drawing.Size(85, 50);
            this.btnWeedle.TabIndex = 8;
            this.btnWeedle.Text = "Weedle";
            this.btnWeedle.UseVisualStyleBackColor = false;
            this.btnWeedle.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnZubat
            // 
            this.btnZubat.AutoSize = true;
            this.btnZubat.BackColor = System.Drawing.Color.Transparent;
            this.btnZubat.Font = new System.Drawing.Font("Pokemon Solid", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZubat.ForeColor = System.Drawing.Color.Blue;
            this.btnZubat.Location = new System.Drawing.Point(26, 276);
            this.btnZubat.Name = "btnZubat";
            this.btnZubat.Size = new System.Drawing.Size(85, 50);
            this.btnZubat.TabIndex = 9;
            this.btnZubat.Text = "Zubat";
            this.btnZubat.UseVisualStyleBackColor = false;
            this.btnZubat.CheckedChanged += new System.EventHandler(this.btnZubat_CheckedChanged);
            // 
            // btnOddish
            // 
            this.btnOddish.AutoSize = true;
            this.btnOddish.BackColor = System.Drawing.Color.Transparent;
            this.btnOddish.Font = new System.Drawing.Font("Pokemon Solid", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOddish.ForeColor = System.Drawing.Color.Blue;
            this.btnOddish.Location = new System.Drawing.Point(152, 276);
            this.btnOddish.Name = "btnOddish";
            this.btnOddish.Size = new System.Drawing.Size(89, 50);
            this.btnOddish.TabIndex = 10;
            this.btnOddish.TabStop = true;
            this.btnOddish.Text = "Oddish";
            this.btnOddish.UseVisualStyleBackColor = false;
            this.btnOddish.CheckedChanged += new System.EventHandler(this.btnOddish_CheckedChanged);
            // 
            // btnPikachu
            // 
            this.btnPikachu.AutoSize = true;
            this.btnPikachu.BackColor = System.Drawing.Color.Transparent;
            this.btnPikachu.Font = new System.Drawing.Font("Pokemon Solid", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPikachu.ForeColor = System.Drawing.Color.Blue;
            this.btnPikachu.Location = new System.Drawing.Point(152, 332);
            this.btnPikachu.Name = "btnPikachu";
            this.btnPikachu.Size = new System.Drawing.Size(96, 50);
            this.btnPikachu.TabIndex = 11;
            this.btnPikachu.TabStop = true;
            this.btnPikachu.Text = "Pikachu";
            this.btnPikachu.UseVisualStyleBackColor = false;
            this.btnPikachu.CheckedChanged += new System.EventHandler(this.btnPikachu_CheckedChanged);
            // 
            // btnMankey
            // 
            this.btnMankey.AutoSize = true;
            this.btnMankey.BackColor = System.Drawing.Color.Transparent;
            this.btnMankey.Font = new System.Drawing.Font("Pokemon Solid", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMankey.ForeColor = System.Drawing.Color.Blue;
            this.btnMankey.Location = new System.Drawing.Point(26, 323);
            this.btnMankey.Name = "btnMankey";
            this.btnMankey.Size = new System.Drawing.Size(94, 50);
            this.btnMankey.TabIndex = 12;
            this.btnMankey.TabStop = true;
            this.btnMankey.Text = "Mankey";
            this.btnMankey.UseVisualStyleBackColor = false;
            this.btnMankey.CheckedChanged += new System.EventHandler(this.btnMankey_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::digimon._04.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMankey);
            this.Controls.Add(this.btnPikachu);
            this.Controls.Add(this.btnOddish);
            this.Controls.Add(this.btnZubat);
            this.Controls.Add(this.btnWeedle);
            this.Controls.Add(this.btnpsyduck);
            this.Controls.Add(this.btngrowlithe);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.btnratata);
            this.Controls.Add(this.btncartepie);
            this.Controls.Add(this.btnabra);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.RadioButton btnabra;
        private System.Windows.Forms.RadioButton btncartepie;
        private System.Windows.Forms.RadioButton btnratata;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.RadioButton btngrowlithe;
        private System.Windows.Forms.RadioButton btnpsyduck;
        private System.Windows.Forms.RadioButton btnWeedle;
        private System.Windows.Forms.RadioButton btnZubat;
        private System.Windows.Forms.RadioButton btnOddish;
        private System.Windows.Forms.RadioButton btnPikachu;
        private System.Windows.Forms.RadioButton btnMankey;
    }
}

