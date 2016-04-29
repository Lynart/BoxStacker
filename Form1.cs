using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int length;
        int width;
        int height;
        int volume;
        public Form1()
        {
            InitializeComponent();
            length = 18;
            width = 18;
            height = 8;
            volume = length * width * height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userLength = Convert.ToInt32(uLength.Value);
            int userWidth = Convert.ToInt32(uWidth.Value);
            int userHeight = Convert.ToInt32(uHeight.Value);

            //Box too big to fit
            if (userLength * userWidth * userHeight > volume)
            {
                Output.Text = "Your box is too big!";
            }

            else if (userLength > length || userWidth > width || userHeight > height)
            {
                Output.Text = "Some part of your box is too big!";
            }
            else
            {
                //Int will floor every number I think
                //Should double check via manual math
                int numberOfBoxes = (length / userLength) * (width / userWidth) * (height / userHeight);
                Output.Text = "You can fit " + numberOfBoxes + ".";
            }
        }
    }
}
