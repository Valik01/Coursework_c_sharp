using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_c_sharp
{
   public partial class Secondary : Form
   {
      public Secondary()
      {
         InitializeComponent();
      }

      public string secondary;

      private void Secondary_Load(object sender, EventArgs e)
      {

      }

      private void butSave_Click(object sender, EventArgs e)
      {
         secondary=cecondarytB.Text;
         this.Close();
      }
   }
}
