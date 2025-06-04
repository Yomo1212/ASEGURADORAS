using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEGURADORAS
{
    public static class Limpiar
    {
        
        /// Limpia todos los TextBox, ComboBox, CheckBox, RadioButton y DateTimePicker dentro de un formulario o contenedor.
      public static void Controles(Control control)
        {
            foreach (Control c in control.Controls)
            {
                switch (c)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                    case ComboBox cmb:
                        cmb.SelectedIndex = -1;
                        break;
                    case CheckBox chk:
                        chk.Checked = false;
                        break;
                    case RadioButton rdo:
                        rdo.Checked = false;
                        break;
                    case DateTimePicker dtp:
                        dtp.Value = DateTime.Now;
                        break;
                }

             }
        }
    }
}