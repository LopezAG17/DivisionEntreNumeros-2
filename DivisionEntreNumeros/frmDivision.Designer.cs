namespace DivisionEntreNumeros
{
  partial class frmDivision
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
      this.txtV01 = new System.Windows.Forms.TextBox();
      this.txtV02 = new System.Windows.Forms.TextBox();
      this.btnCalcular = new System.Windows.Forms.Button();
      this.btnAgain = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.lblResultado = new System.Windows.Forms.Label();
      this.rbtnDividir = new System.Windows.Forms.RadioButton();
      this.rbtnPorciento = new System.Windows.Forms.RadioButton();
      this.label4 = new System.Windows.Forms.Label();
      this.rbtnMultiplica = new System.Windows.Forms.RadioButton();
      this.rbtnSumar = new System.Windows.Forms.RadioButton();
      this.cboSeleccion = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label1.Location = new System.Drawing.Point(12, 83);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(197, 21);
      this.label1.TabIndex = 0;
      this.label1.Text = " Valor 1";
      // 
      // label2
      // 
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label2.Location = new System.Drawing.Point(12, 107);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(197, 21);
      this.label2.TabIndex = 1;
      this.label2.Text = " Valor 2";
      // 
      // label3
      // 
      this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(12, 174);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(197, 39);
      this.label3.TabIndex = 2;
      this.label3.Text = " Resultado";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtV01
      // 
      this.txtV01.Location = new System.Drawing.Point(215, 82);
      this.txtV01.Name = "txtV01";
      this.txtV01.Size = new System.Drawing.Size(130, 20);
      this.txtV01.TabIndex = 0;
      this.txtV01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtV01_KeyPress);
      // 
      // txtV02
      // 
      this.txtV02.Location = new System.Drawing.Point(215, 108);
      this.txtV02.Name = "txtV02";
      this.txtV02.Size = new System.Drawing.Size(130, 20);
      this.txtV02.TabIndex = 1;
      this.txtV02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtV02_KeyPress);
      // 
      // btnCalcular
      // 
      this.btnCalcular.Location = new System.Drawing.Point(13, 238);
      this.btnCalcular.Name = "btnCalcular";
      this.btnCalcular.Size = new System.Drawing.Size(107, 46);
      this.btnCalcular.TabIndex = 2;
      this.btnCalcular.Text = "Calcular";
      this.btnCalcular.UseVisualStyleBackColor = true;
      this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
      // 
      // btnAgain
      // 
      this.btnAgain.Location = new System.Drawing.Point(126, 238);
      this.btnAgain.Name = "btnAgain";
      this.btnAgain.Size = new System.Drawing.Size(107, 46);
      this.btnAgain.TabIndex = 4;
      this.btnAgain.Text = "Limpiar";
      this.btnAgain.UseVisualStyleBackColor = true;
      this.btnAgain.Click += new System.EventHandler(this.btnLimpiar_Click);
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(239, 238);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(107, 46);
      this.button1.TabIndex = 5;
      this.button1.Text = "Salir";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // lblResultado
      // 
      this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblResultado.Location = new System.Drawing.Point(216, 174);
      this.lblResultado.Name = "lblResultado";
      this.lblResultado.Size = new System.Drawing.Size(130, 39);
      this.lblResultado.TabIndex = 6;
      this.lblResultado.Text = ".00";
      this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // rbtnDividir
      // 
      this.rbtnDividir.BackColor = System.Drawing.Color.PaleTurquoise;
      this.rbtnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.rbtnDividir.Location = new System.Drawing.Point(12, 54);
      this.rbtnDividir.Name = "rbtnDividir";
      this.rbtnDividir.Size = new System.Drawing.Size(79, 20);
      this.rbtnDividir.TabIndex = 7;
      this.rbtnDividir.Text = "Dividir";
      this.rbtnDividir.UseVisualStyleBackColor = false;
      this.rbtnDividir.CheckedChanged += new System.EventHandler(this.rbtnDividir_CheckedChanged);
      // 
      // rbtnPorciento
      // 
      this.rbtnPorciento.BackColor = System.Drawing.Color.PaleTurquoise;
      this.rbtnPorciento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.rbtnPorciento.Location = new System.Drawing.Point(267, 54);
      this.rbtnPorciento.Name = "rbtnPorciento";
      this.rbtnPorciento.Size = new System.Drawing.Size(79, 20);
      this.rbtnPorciento.TabIndex = 8;
      this.rbtnPorciento.Text = "Porcentaje";
      this.rbtnPorciento.UseVisualStyleBackColor = false;
      this.rbtnPorciento.CheckedChanged += new System.EventHandler(this.rbtnPorciento_CheckedChanged);
      // 
      // label4
      // 
      this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(12, 27);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(333, 24);
      this.label4.TabIndex = 9;
      this.label4.Text = "Tipo de Operación";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // rbtnMultiplica
      // 
      this.rbtnMultiplica.BackColor = System.Drawing.Color.PaleTurquoise;
      this.rbtnMultiplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.rbtnMultiplica.Location = new System.Drawing.Point(97, 54);
      this.rbtnMultiplica.Name = "rbtnMultiplica";
      this.rbtnMultiplica.Size = new System.Drawing.Size(79, 20);
      this.rbtnMultiplica.TabIndex = 10;
      this.rbtnMultiplica.Text = "Multiplicar";
      this.rbtnMultiplica.UseVisualStyleBackColor = false;
      this.rbtnMultiplica.CheckedChanged += new System.EventHandler(this.rbtnMultiplica_CheckedChanged);
      // 
      // rbtnSumar
      // 
      this.rbtnSumar.BackColor = System.Drawing.Color.PaleTurquoise;
      this.rbtnSumar.Checked = true;
      this.rbtnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.rbtnSumar.Location = new System.Drawing.Point(182, 54);
      this.rbtnSumar.Name = "rbtnSumar";
      this.rbtnSumar.Size = new System.Drawing.Size(79, 20);
      this.rbtnSumar.TabIndex = 11;
      this.rbtnSumar.TabStop = true;
      this.rbtnSumar.Text = "Sumar";
      this.rbtnSumar.UseVisualStyleBackColor = false;
      this.rbtnSumar.CheckedChanged += new System.EventHandler(this.rbtnSumar_CheckedChanged);
      // 
      // cboSeleccion
      // 
      this.cboSeleccion.FormattingEnabled = true;
      this.cboSeleccion.Location = new System.Drawing.Point(215, 134);
      this.cboSeleccion.Name = "cboSeleccion";
      this.cboSeleccion.Size = new System.Drawing.Size(130, 21);
      this.cboSeleccion.TabIndex = 12;
      this.cboSeleccion.SelectedIndexChanged += new System.EventHandler(this.cboSeleccion_SelectedIndexChanged);
      // 
      // label5
      // 
      this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label5.Location = new System.Drawing.Point(12, 134);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(197, 21);
      this.label5.TabIndex = 13;
      this.label5.Text = " Operación Aritmética a Realizar";
      // 
      // frmDivision
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(363, 304);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.cboSeleccion);
      this.Controls.Add(this.rbtnSumar);
      this.Controls.Add(this.rbtnMultiplica);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.rbtnPorciento);
      this.Controls.Add(this.rbtnDividir);
      this.Controls.Add(this.lblResultado);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnAgain);
      this.Controls.Add(this.btnCalcular);
      this.Controls.Add(this.txtV02);
      this.Controls.Add(this.txtV01);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmDivision";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Division de Números";
      this.Load += new System.EventHandler(this.frmDivision_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDivision_KeyDown);

      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtV01;
    private System.Windows.Forms.TextBox txtV02;
    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.Button btnAgain;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label lblResultado;
    private System.Windows.Forms.RadioButton rbtnDividir;
    private System.Windows.Forms.RadioButton rbtnPorciento;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.RadioButton rbtnMultiplica;
    private System.Windows.Forms.RadioButton rbtnSumar;
    private System.Windows.Forms.ComboBox cboSeleccion;
    private System.Windows.Forms.Label label5;
  }
}

