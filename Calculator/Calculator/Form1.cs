using System.ComponentModel;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0; //because initially result will be 0
        string opPerform = " "; //because textbox gives us string
        bool isOpPerform = false;  //when operator is clicked then only true
      
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void n_click(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOpPerform))
                textBoxResult.Clear();
            isOpPerform = false;  //if no. clicked then false
            Button n = (Button)sender;
            if (n.Text == ".")
            {
                if (!textBoxResult.Text.Contains("."))
                
                    textBoxResult.Text = textBoxResult.Text + n.Text;
                
               
                
            }
            else

                textBoxResult.Text = textBoxResult.Text + n.Text;
        }

        private void op_click(object sender, EventArgs e)
        {
            Button n = (Button)sender;  //sender is what is being clicked
            opPerform = n.Text;
            resultValue = Double.Parse(textBoxResult.Text);   //textbox always gives reslt in string so parse to get in double 
            lcurrentOp.Text = resultValue + " " + opPerform;
            isOpPerform = true; //when operator clicked then true

        }
        //event of ce
        private void nce_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";//whole entry becomes 0
            isOpPerform = false; // reset the operator flag
        }

        private void nc_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultValue = 0;
        }

        private void nequal_Click(object sender, EventArgs e)
        {
            switch (opPerform)
            {
                case "+":
                    textBoxResult.Text = (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                //resultValue: It appears to be a variable containing a previous numeric result.
                //  Double.Parse(textBoxResult.Text): This part retrieves the numeric value entered in textBoxResult.Text(assuming it contains a valid numeric representation).
                //The addition is performed:  case "+":

                case "-":
                    textBoxResult.Text = (resultValue - Double.Parse(textBoxResult.Text)).ToString();
                    break;

                case "*":
                    textBoxResult.Text = (resultValue * Double.Parse(textBoxResult.Text)).ToString();
                    break;

                case "/":
                    textBoxResult.Text = (resultValue / Double.Parse(textBoxResult.Text)).ToString();
                    break;

                default:
                    break;






            }
        }


    }
}
