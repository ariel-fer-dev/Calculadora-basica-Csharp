namespace Calculadora
  {
  partial class Form1
    {
    /// <summary>
    /// Variable del diseñador requerida.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén utilizando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
    protected override void Dispose(bool disposing)
      {
      if (disposing && (components != null))
        {
        components.Dispose();
        }
      base.Dispose(disposing);
      }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido del método con el editor de código.
    /// </summary>
    private void InitializeComponent()
      {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPantalla = new System.Windows.Forms.Label();
            this.bLimpiarPanel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.RichTextBox();
            this.txtFieldPantalla = new System.Windows.Forms.TextBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.bDivision = new System.Windows.Forms.Button();
            this.bProducto = new System.Windows.Forms.Button();
            this.bResta = new System.Windows.Forms.Button();
            this.bSuma = new System.Windows.Forms.Button();
            this.bResultado = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bComa = new System.Windows.Forms.Button();
            this.bSigno = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.lbPantalla);
            this.panel1.Controls.Add(this.bLimpiarPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Controls.Add(this.txtFieldPantalla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 248);
            this.panel1.TabIndex = 0;
            // 
            // lbPantalla
            // 
            this.lbPantalla.BackColor = System.Drawing.SystemColors.Window;
            this.lbPantalla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPantalla.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lbPantalla.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbPantalla.Location = new System.Drawing.Point(11, 14);
            this.lbPantalla.MinimumSize = new System.Drawing.Size(266, 40);
            this.lbPantalla.Name = "lbPantalla";
            this.lbPantalla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPantalla.Size = new System.Drawing.Size(287, 43);
            this.lbPantalla.TabIndex = 1;
            this.lbPantalla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bLimpiarPanel
            // 
            this.bLimpiarPanel.Font = new System.Drawing.Font("Arial", 7F);
            this.bLimpiarPanel.Location = new System.Drawing.Point(451, 1);
            this.bLimpiarPanel.Name = "bLimpiarPanel";
            this.bLimpiarPanel.Size = new System.Drawing.Size(51, 20);
            this.bLimpiarPanel.TabIndex = 13;
            this.bLimpiarPanel.Text = "Limpiar";
            this.bLimpiarPanel.UseVisualStyleBackColor = true;
            this.bLimpiarPanel.Click += new System.EventHandler(this.bLimpiarPanel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bClear);
            this.panel3.Controls.Add(this.bBack);
            this.panel3.Controls.Add(this.bDivision);
            this.panel3.Controls.Add(this.bProducto);
            this.panel3.Controls.Add(this.bResta);
            this.panel3.Controls.Add(this.bSuma);
            this.panel3.Controls.Add(this.bResultado);
            this.panel3.Location = new System.Drawing.Point(144, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 170);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.b0);
            this.panel2.Controls.Add(this.bComa);
            this.panel2.Controls.Add(this.bSigno);
            this.panel2.Controls.Add(this.b8);
            this.panel2.Controls.Add(this.b3);
            this.panel2.Controls.Add(this.b6);
            this.panel2.Controls.Add(this.b2);
            this.panel2.Controls.Add(this.b1);
            this.panel2.Controls.Add(this.b9);
            this.panel2.Controls.Add(this.b7);
            this.panel2.Controls.Add(this.b5);
            this.panel2.Controls.Add(this.b4);
            this.panel2.Location = new System.Drawing.Point(12, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 170);
            this.panel2.TabIndex = 11;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Window;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel.Cursor = System.Windows.Forms.Cursors.No;
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.panel.HideSelection = false;
            this.panel.Location = new System.Drawing.Point(305, 21);
            this.panel.Name = "panel";
            this.panel.ReadOnly = true;
            this.panel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel.Size = new System.Drawing.Size(197, 215);
            this.panel.TabIndex = 1;
            this.panel.TabStop = false;
            this.panel.Text = "";
            this.panel.Click += new System.EventHandler(this.panel_Click_1);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            // 
            // txtFieldPantalla
            // 
            this.txtFieldPantalla.BackColor = System.Drawing.SystemColors.Window;
            this.txtFieldPantalla.Cursor = System.Windows.Forms.Cursors.No;
            this.txtFieldPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldPantalla.ForeColor = System.Drawing.Color.Black;
            this.txtFieldPantalla.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtFieldPantalla.Location = new System.Drawing.Point(321, 156);
            this.txtFieldPantalla.MinimumSize = new System.Drawing.Size(166, 55);
            this.txtFieldPantalla.Name = "txtFieldPantalla";
            this.txtFieldPantalla.ReadOnly = true;
            this.txtFieldPantalla.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFieldPantalla.Size = new System.Drawing.Size(166, 35);
            this.txtFieldPantalla.TabIndex = 0;
            this.txtFieldPantalla.WordWrap = false;
            this.txtFieldPantalla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFieldPantalla_KeyDown);
            this.txtFieldPantalla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPantalla_KeyPress);
            // 
            // bClear
            // 
            this.bClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bClear.BackgroundImage")));
            this.bClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bClear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(77, 5);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(70, 35);
            this.bClear.TabIndex = 20;
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bBack
            // 
            this.bBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bBack.BackgroundImage")));
            this.bBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bBack.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.Location = new System.Drawing.Point(7, 5);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(70, 35);
            this.bBack.TabIndex = 19;
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bDivision
            // 
            this.bDivision.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDivision.BackgroundImage")));
            this.bDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bDivision.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDivision.Location = new System.Drawing.Point(77, 47);
            this.bDivision.Name = "bDivision";
            this.bDivision.Size = new System.Drawing.Size(70, 35);
            this.bDivision.TabIndex = 18;
            this.bDivision.UseVisualStyleBackColor = true;
            this.bDivision.Click += new System.EventHandler(this.bDivision_Click);
            // 
            // bProducto
            // 
            this.bProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bProducto.BackgroundImage")));
            this.bProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bProducto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProducto.Location = new System.Drawing.Point(7, 47);
            this.bProducto.Name = "bProducto";
            this.bProducto.Size = new System.Drawing.Size(70, 35);
            this.bProducto.TabIndex = 17;
            this.bProducto.UseVisualStyleBackColor = true;
            this.bProducto.Click += new System.EventHandler(this.bProducto_Click);
            // 
            // bResta
            // 
            this.bResta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bResta.BackgroundImage")));
            this.bResta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bResta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bResta.Location = new System.Drawing.Point(77, 89);
            this.bResta.Name = "bResta";
            this.bResta.Size = new System.Drawing.Size(70, 35);
            this.bResta.TabIndex = 16;
            this.bResta.UseVisualStyleBackColor = true;
            this.bResta.Click += new System.EventHandler(this.bResta_Click);
            // 
            // bSuma
            // 
            this.bSuma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSuma.BackgroundImage")));
            this.bSuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bSuma.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSuma.Location = new System.Drawing.Point(7, 89);
            this.bSuma.Name = "bSuma";
            this.bSuma.Size = new System.Drawing.Size(70, 35);
            this.bSuma.TabIndex = 10;
            this.bSuma.UseVisualStyleBackColor = true;
            this.bSuma.Click += new System.EventHandler(this.bSuma_Click);
            // 
            // bResultado
            // 
            this.bResultado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bResultado.BackgroundImage")));
            this.bResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bResultado.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bResultado.Location = new System.Drawing.Point(7, 130);
            this.bResultado.Name = "bResultado";
            this.bResultado.Size = new System.Drawing.Size(140, 35);
            this.bResultado.TabIndex = 9;
            this.bResultado.UseVisualStyleBackColor = true;
            this.bResultado.Click += new System.EventHandler(this.bResultado_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.SystemColors.Window;
            this.b0.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Image = global::Calculadora.Properties.Resources.Number_0_icon;
            this.b0.Location = new System.Drawing.Point(86, 128);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(38, 38);
            this.b0.TabIndex = 13;
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bComa
            // 
            this.bComa.BackColor = System.Drawing.SystemColors.Window;
            this.bComa.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bComa.Image = global::Calculadora.Properties.Resources.icons8_comma_16;
            this.bComa.Location = new System.Drawing.Point(45, 128);
            this.bComa.Name = "bComa";
            this.bComa.Size = new System.Drawing.Size(38, 38);
            this.bComa.TabIndex = 12;
            this.bComa.UseVisualStyleBackColor = false;
            this.bComa.Click += new System.EventHandler(this.bComa_Click);
            // 
            // bSigno
            // 
            this.bSigno.BackColor = System.Drawing.SystemColors.Window;
            this.bSigno.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSigno.Image = global::Calculadora.Properties.Resources.icons8_plus_minus_____16;
            this.bSigno.Location = new System.Drawing.Point(4, 128);
            this.bSigno.Name = "bSigno";
            this.bSigno.Size = new System.Drawing.Size(38, 38);
            this.bSigno.TabIndex = 11;
            this.bSigno.UseVisualStyleBackColor = false;
            this.bSigno.Click += new System.EventHandler(this.bSigno_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.SystemColors.Window;
            this.b8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Image = global::Calculadora.Properties.Resources.Number_8_icon;
            this.b8.Location = new System.Drawing.Point(45, 5);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(38, 38);
            this.b8.TabIndex = 9;
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.Window;
            this.b3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Image = global::Calculadora.Properties.Resources.Number_3_icon;
            this.b3.Location = new System.Drawing.Point(86, 87);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(38, 38);
            this.b3.TabIndex = 2;
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.SystemColors.Window;
            this.b6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Image = global::Calculadora.Properties.Resources.Number_6_icon;
            this.b6.Location = new System.Drawing.Point(86, 46);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(38, 38);
            this.b6.TabIndex = 3;
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.Window;
            this.b2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Image = global::Calculadora.Properties.Resources.Number_2_icon;
            this.b2.Location = new System.Drawing.Point(45, 87);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(38, 38);
            this.b2.TabIndex = 4;
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.Window;
            this.b1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Image = global::Calculadora.Properties.Resources.Number_1_icon;
            this.b1.Location = new System.Drawing.Point(4, 87);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(38, 38);
            this.b1.TabIndex = 7;
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.SystemColors.Window;
            this.b9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Image = global::Calculadora.Properties.Resources.Number_9_icon;
            this.b9.Location = new System.Drawing.Point(86, 5);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(38, 38);
            this.b9.TabIndex = 10;
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.SystemColors.Window;
            this.b7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Image = global::Calculadora.Properties.Resources.Number_7_icon;
            this.b7.Location = new System.Drawing.Point(4, 5);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(38, 38);
            this.b7.TabIndex = 8;
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.SystemColors.Window;
            this.b5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Image = global::Calculadora.Properties.Resources.Number_5_icon;
            this.b5.Location = new System.Drawing.Point(45, 46);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(38, 38);
            this.b5.TabIndex = 6;
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.Window;
            this.b4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Image = global::Calculadora.Properties.Resources.Number_4_icon;
            this.b4.Location = new System.Drawing.Point(4, 46);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(38, 38);
            this.b4.TabIndex = 5;
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(511, 248);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Calculadora";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

      }

    #endregion

    private System.Windows.Forms.Panel panel1;
    public System.Windows.Forms.TextBox txtFieldPantalla;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button bClear;
    private System.Windows.Forms.Button bBack;
    private System.Windows.Forms.Button bDivision;
    private System.Windows.Forms.Button bProducto;
    private System.Windows.Forms.Button bResta;
    private System.Windows.Forms.Button bSuma;
    private System.Windows.Forms.Button bResultado;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button b0;
    private System.Windows.Forms.Button bComa;
    private System.Windows.Forms.Button bSigno;
    private System.Windows.Forms.Button b8;
    private System.Windows.Forms.Button b3;
    private System.Windows.Forms.Button b6;
    private System.Windows.Forms.Button b2;
    private System.Windows.Forms.Button b1;
    private System.Windows.Forms.Button b9;
    private System.Windows.Forms.Button b7;
    private System.Windows.Forms.Button b5;
    private System.Windows.Forms.Button b4;
    private System.Windows.Forms.RichTextBox panel;
    private System.Windows.Forms.Button bLimpiarPanel;
        private System.Windows.Forms.Label lbPantalla;
    }
  }

