using System;

namespace JogodaVelha
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.vitoriasX = new System.Windows.Forms.Label();
            this.empate = new System.Windows.Forms.Label();
            this.vitoriasO = new System.Windows.Forms.Label();
            this.contadorX = new System.Windows.Forms.Label();
            this.contadorempate = new System.Windows.Forms.Label();
            this.contadorO = new System.Windows.Forms.Label();
            this.reiniciarPontuaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoJogoToolStripMenuItem,
            this.reiniciarPontuaçõesToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // novoJogoToolStripMenuItem
            // 
            this.novoJogoToolStripMenuItem.Name = "novoJogoToolStripMenuItem";
            this.novoJogoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.novoJogoToolStripMenuItem.Text = "Novo Jogo";
            this.novoJogoToolStripMenuItem.Click += new System.EventHandler(this.novoJogoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(12, 39);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(93, 39);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(174, 39);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(12, 120);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(93, 120);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(174, 120);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(12, 201);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(93, 201);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(174, 201);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // vitoriasX
            // 
            this.vitoriasX.AutoSize = true;
            this.vitoriasX.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vitoriasX.Location = new System.Drawing.Point(300, 53);
            this.vitoriasX.Name = "vitoriasX";
            this.vitoriasX.Size = new System.Drawing.Size(77, 14);
            this.vitoriasX.TabIndex = 10;
            this.vitoriasX.Text = "Vitórias de X";
            this.vitoriasX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empate
            // 
            this.empate.AutoSize = true;
            this.empate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empate.Location = new System.Drawing.Point(300, 120);
            this.empate.Name = "empate";
            this.empate.Size = new System.Drawing.Size(55, 14);
            this.empate.TabIndex = 11;
            this.empate.Text = "Empates";
            this.empate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vitoriasO
            // 
            this.vitoriasO.AutoSize = true;
            this.vitoriasO.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vitoriasO.Location = new System.Drawing.Point(300, 181);
            this.vitoriasO.Name = "vitoriasO";
            this.vitoriasO.Size = new System.Drawing.Size(78, 14);
            this.vitoriasO.TabIndex = 12;
            this.vitoriasO.Text = "Vitórias de O";
            this.vitoriasO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contadorX
            // 
            this.contadorX.AutoSize = true;
            this.contadorX.Location = new System.Drawing.Point(320, 79);
            this.contadorX.Name = "contadorX";
            this.contadorX.Size = new System.Drawing.Size(13, 13);
            this.contadorX.TabIndex = 13;
            this.contadorX.Text = "0";
            this.contadorX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contadorempate
            // 
            this.contadorempate.AutoSize = true;
            this.contadorempate.Location = new System.Drawing.Point(320, 150);
            this.contadorempate.Name = "contadorempate";
            this.contadorempate.Size = new System.Drawing.Size(13, 13);
            this.contadorempate.TabIndex = 14;
            this.contadorempate.Text = "0";
            this.contadorempate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contadorO
            // 
            this.contadorO.AutoSize = true;
            this.contadorO.Location = new System.Drawing.Point(320, 221);
            this.contadorO.Name = "contadorO";
            this.contadorO.Size = new System.Drawing.Size(13, 13);
            this.contadorO.TabIndex = 15;
            this.contadorO.Text = "0";
            this.contadorO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reiniciarPontuaçõesToolStripMenuItem
            // 
            this.reiniciarPontuaçõesToolStripMenuItem.Name = "reiniciarPontuaçõesToolStripMenuItem";
            this.reiniciarPontuaçõesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.reiniciarPontuaçõesToolStripMenuItem.Text = "Reiniciar pontuações";
            this.reiniciarPontuaçõesToolStripMenuItem.Click += new System.EventHandler(this.reiniciarPontuaçõesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 313);
            this.Controls.Add(this.contadorO);
            this.Controls.Add(this.contadorempate);
            this.Controls.Add(this.contadorX);
            this.Controls.Add(this.vitoriasO);
            this.Controls.Add(this.empate);
            this.Controls.Add(this.vitoriasX);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Jogo da Velha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button_leave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button_enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label vitoriasX;
        private System.Windows.Forms.Label empate;
        private System.Windows.Forms.Label vitoriasO;
        private System.Windows.Forms.Label contadorX;
        private System.Windows.Forms.Label contadorempate;
        private System.Windows.Forms.Label contadorO;
        private System.Windows.Forms.ToolStripMenuItem reiniciarPontuaçõesToolStripMenuItem;
    }
}

