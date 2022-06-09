using System;
using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Drawing;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
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

      rbtnSumar.Checked = true;
    }

    private void frmDivision_KeyPrees(object sender, KeyEventArgs e)
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
      Item seleccion = cboSeleccion.SelectedItem as Item;
      if (seleccion == null) return;  // si seleccion es nulo saldra del comboBox

      // --------------------------------------------------------------------------
      // coloca aqui las 3 lineas de código que faltan
      // --------------------------------------------------------------------------




      // --------------------------------------------------------------------------


      // el switch trabaja parecido al comando IF
      switch (nSeleccion)
      {
        case 0:
          break; // sale del switch
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
    }


    private void btnCalcular_Click(object sender, EventArgs e)
    {
      try  // el comando try --> tratará de realizar la acción solicitada (esto es una trampa de errores)
      {

        float v01 = float.Parse(txtV01.Text); // convierte a resultado a float ( float es parecido a double / decimal )
        float v02 = float.Parse(txtV02.Text); // convierte a resultado a float ( float es parecido a double / decimal )

        // ----------------------------------------------------------
        // coloca aqui la operación de División según el radio button
        // ----------------------------------------------------------
        if (rbtnDividir.Checked == true)
        {
          resultado = v01 / v02;   // realiza la operación de dividir
        }

        // -------------------------------------------------------------
        // coloca aqui la operación de Multiplicar según el radio button
        // -------------------------------------------------------------
        if (rbtnMultiplica.Checked == true)
        {
          resultado = v01 * v02;   // realiza la operación de dividir
        }


        // ---------------------------------------------------------
        // coloca aqui la operación sumar según el radio button
        // ---------------------------------------------------------
        if (rbtnSumar.Checked == true)
        {
          resultado = v01 + v02;   // realiza la operación de dividir
        }


        // ---------------------------------------------------------
        // coloca aqui la operación Porciento según el radio button
        // ---------------------------------------------------------
        if (rbtnPorciento.Checked == true)
        {
          resultado = (v01 * v02) / 100;   // realiza la operación de dividir
        }



        // ---------------------------------------------------------
        // asigna el Resultado
        // ---------------------------------------------------------
        lblResultado.Text = Convert.ToString(resultado); // convierte a resultado a string
      }
      catch (Exception error)  // de haber algún error es atrapado por el comando --> catch
      {
        MessageBox.Show("Tengo Un Error : " + error.Message);  // de haber error aparece una caja de mensajes
      }
    }


    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      txtV01.Clear();  // Clear --> Limpiar el textbox dividendo
      txtV02.Clear();    // Clear --> Limpiar el textbox divisor
      lblResultado.Text = ""; // limpiar este label

      rbtnSumar.Checked = true; // se vera marcado el radio button

      lblResultado.Text = ""; // limpiar este label

      txtV01.Focus();  // Focus --> El puntero del mouse se coloca en este textbox
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
      label1.Text = "Cantidad";
      label2.Text = "Multiplicar Por";
    }

    private void rbtnPorciento_CheckedChanged(object sender, EventArgs e)
    {
      // aqui debajo coloca el codigo para cambiar el text a los labels (label1 / label2)
      // según el radiobutton
      label1.Text = "Cantidad";
      label2.Text = "el porcentaje es";
    }

    private void rbtnSumar_CheckedChanged(object sender, EventArgs e)
    {
      // aqui debajo coloca el codigo para cambiar el text a los labels (label1 / label2)
      // según el radiobutton
      label1.Text = "Valor a sumar";
      label2.Text = "Valor a sumar";
      // !HOlas


    }



  }
}
