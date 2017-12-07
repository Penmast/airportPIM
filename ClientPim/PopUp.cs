using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientPim
{
    public partial class PopUp : Form
    {
        public PopUp(List<ServiceReferencePim.BagageDefinition> bagages)
        {
            InitializeComponent();
            buttonSelect.Enabled = false;
            foreach(ServiceReferencePim.BagageDefinition bagage in bagages)
            {
                comboBox1.Items.Add(bagage.IdBagage);
            }
        }

        public int bagageSelected()
        {
            return (int)comboBox1.SelectedItem;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSelect.Enabled = true;
        }
    }
}
