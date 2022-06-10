using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DivisionEntreNumeros
{
  public partial class frmDivision : Form
  {
    int nSeleccion;
    float resultado;  // declaro variable para poder usar en cualquier lugar
    float mV1;
    float mV2;
    public frmDivision()
    {
      InitializeComponent();
    }
    private void frmDivision_Load(object sender, EventArgs e)
    {
      this.KeyPreview = true;  // activa el teclado de comandos en el formulario
      this.Text = HMenu.cia + "   Aritméticas    " + HMenu.pc;   // le coloca titulo al formulario

      label1.Text = "Dividendo";
      label2.Text = "Divisor";

      List<Item> lista = new List<Item>();
      lista.Add(new Item("Ninguno", 0));
      lista.Add(new Item("Sumar", 1));
      lista.Add(new Item("Restar", 2));
      lista.Add(new Item("Multiplicar", 3));
      lista.Add(new Item("Dividir", 4));
      lista.Add(new Item("Porciento", 5));

      cboSeleccion.DisplayMember = "Name";
      cboSeleccion.ValueMember = "Value";
      cboSeleccion.DataSource = lista;
      ckbControl.Checked = true;
      rbtnSumar.Checked = true;
    }
    private void frmDivision_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape) //verificar la tecla escape
      {
        this.Close();
      }
    }
    // ------------------------------------------------------------------------
    // investigar porque no se esta ejecutando el codigo aqui
    // ------------------------------------------------------------------------
    //
    // el codigo esta bien
    // el switch no funciona por que hay que asignarle el valor a nSelecciom
    //
    // el lblResultado.Text siempre sera valor cero, por que mV1 y mV2 no tienen valores llegan vacio
    // que deben hacer ???
    private void cboSeleccion_SelectedIndexChanged(object sender, EventArgs e)
    {
      ManejoCombobox();
    }
    // ------------------------------------------------------------------------
    private void txtV01_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int)e.KeyChar == (int)Keys.Enter)  // verifica si presionaste la tecla enter
      {
        e.Handled = true;
        if (txtV01.Text.Trim() != string.Empty)  // aqui verifica si esta vacio el textbox --> trim() elimina los espacios vacio dentro del textbox
        {
          txtV02.Focus(); // coloca el focus o cursor en el siguiente textbox
        }
      }
      if (Char.IsLetter(e.KeyChar)) // Solo permitir numeros en el texto            
      {
        e.Handled = true;
        MessageBox.Show("Solo numeros");
      }
      KeyPreview = true;
    }
    private void txtV02_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int)e.KeyChar == (int)Keys.Enter)  // verifica si presionaste la tecla enter
      {
        e.Handled = true;
        if (txtV02.Text.Trim() != string.Empty)  // aqui verifica si esta vacio el textbox --> trim() elimina los espacios vacio dentro del textbox
        {
          btnCalcular.PerformClick(); // performClick se dirige hacia el evento click del boton y ejecuta el codigo
        }
      }
      if (Char.IsLetter(e.KeyChar)) // Solo permitir numeros en el texto            
      {
        e.Handled = true;
        MessageBox.Show("Solo numeros");
      }
      KeyPreview = true;
    }
    private void btnCalcular_Click(object sender, EventArgs e)
    {
      ManejoRButtoms();
    }
    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      Limpiar();
    }


    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();   // cierra la aplicación
    }
    private void rbtnDividir_CheckedChanged(object sender, EventArgs e)
    {
      // aqui debajo coloca el codigo para cambiar el text a los labels (label1 / label2)
      // según el radiobutton
      label1.Text = "Dividendo";
      label2.Text = "Divisor";
    }
    private void rbtnMultiplica_CheckedChanged(object sender, EventArgs e)
    {
      // aqui debajo coloca el codigo para cambiar el text a los labels (label1 / label2)
      // según el radiobutton
      label1.Text = "Multiplicando";
      label2.Text = "Multiplicador ";
    }
    private void rbtnPorciento_CheckedChanged(object sender, EventArgs e)
    {
      // aqui debajo coloca el codigo para cambiar el text a los labels (label1 / label2)
      // según el radiobutton
      label1.Text = "Cantidad";
      label2.Text = "porcentaje";
    }
    private void rbtnSumar_CheckedChanged(object sender, EventArgs e)
    {
      // aqui debajo coloca el codigo para cambiar el text a los labels (label1 / label2)
      // según el radiobutton
      label1.Text = "Sumando (a)";
      label2.Text = "Sumando (b)";
    }

    private void ckbControl_CheckedChanged(object sender, EventArgs e)
    {
      if (ckbControl.Checked == true)
      {
        cboSeleccion.Enabled = false;
        rbtnDividir.Enabled = true;
        rbtnMultiplica.Enabled = true;
        rbtnPorciento.Enabled = true;
        rbtnSumar.Enabled = true;
        rbtnSumar.Checked = true;
      }
      else
      {
        rbtnDividir.Checked = false;
        rbtnMultiplica.Checked = false;
        rbtnPorciento.Checked = false;
        rbtnSumar.Checked = false;
        rbtnDividir.Enabled = false;
        rbtnMultiplica.Enabled = false;
        rbtnPorciento.Enabled = false;
        rbtnSumar.Enabled = false;
        cboSeleccion.Enabled = true;
      }
    }
    // !Logica y funcionalidades del programa
    private void ManejoCombobox()
    {
      Item seleccion = cboSeleccion.SelectedItem as Item;
      if (seleccion == null) return;
      nSeleccion = Convert.ToInt32(seleccion.Value);
      try
      {
        float mV1 = float.Parse(txtV01.Text);
        float mV2 = float.Parse(txtV02.Text);


        switch (nSeleccion)
        {
          case 0:
            resultado = 0;
            lblResultado.Text = Convert.ToString(resultado);
            break; //! sale del switch
          case 1:
            resultado = mV1 + mV2;
            lblResultado.Text = Convert.ToString(resultado);
            break;
          case 2:
            resultado = mV1 + mV2;
            lblResultado.Text = Convert.ToString(resultado);
            break;
          case 3:
            resultado = mV1 * mV2;
            lblResultado.Text = Convert.ToString(resultado);
            break;
          case 4:
            resultado = mV1 / mV2;
            lblResultado.Text = Convert.ToString(resultado);
            break;
          case 5:
            resultado = (mV1 * mV2) / 100;
            lblResultado.Text = Convert.ToString(resultado);
            break;
        }
      }
      catch (Exception)
      {
        // MessageBox.Show("Tengo Un Error : " + error.Message);  // de haber error aparece una caja de mensajes
      }
    }
    private void ManejoRButtoms()
    {
      try  // el comando try --> tratará de realizar la acción solicitada (esto es una trampa de errores)
      {
        float v01 = float.Parse(txtV01.Text);
        float v02 = float.Parse(txtV02.Text);
        //! coloca aqui la operación de División según el radio button
        // ----------------------------------------------------------
        if (rbtnDividir.Checked == true)
        {
          resultado = v01 / v02;   // realiza la operación de dividir
        }
        // -------------------------------------------------------------
        //!coloca aqui la operación de Multiplicar según el radio button
        // -------------------------------------------------------------
        if (rbtnMultiplica.Checked == true)
        {
          resultado = v01 * v02;   // realiza la operación de dividir
        }
        // ---------------------------------------------------------
        //! coloca aqui la operación sumar según el radio button
        // ---------------------------------------------------------
        if (rbtnSumar.Checked == true)
        {
          resultado = v01 + v02;   // realiza la operación de dividir
        }
        // ---------------------------------------------------------
        //! coloca aqui la operación Porciento según el radio button
        // ---------------------------------------------------------
        if (rbtnPorciento.Checked == true)
        {
          resultado = (v01 * v02) / 100;   // realiza la operación de dividir
        }
        // ---------------------------------------------------------
        // !asigna el Resultado
        // ---------------------------------------------------------
        lblResultado.Text = Convert.ToString(resultado); // convierte a resultado a string
      }
      catch (Exception error)  // de haber algún error es atrapado por el comando --> catch
      {
        MessageBox.Show("Tengo Un Error : " + error.Message);  // de haber error aparece una caja de mensajes
      }
    }
    private void Limpiar()
    {
      txtV01.Clear();  // Clear --> Limpiar el textbox dividendo
      txtV02.Clear();    // Clear --> Limpiar el textbox divisor
      lblResultado.Text = ""; // limpiar este label
      rbtnSumar.Checked = true; // se vera marcado el radio button
      lblResultado.Text = ""; // limpiar este label
      txtV01.Focus();  // Focus --> El puntero del mouse se coloca en este textbox
    }

  }
}
