namespace FrmCalculator
{
    public partial class FrmCalc : Form
    {
        public FrmCalc()
        {
            InitializeComponent();
        }

        string temp = "";
        string op = ""; 
        int result =0 ;


        private void Switch_operation(string _op)
        {
            switch (_op)
            {
                case "+":
                    result = result + int.Parse(temp);
                    break;
                case "-":
                    result = result - int.Parse(temp);
                    break;
                case "*":
                    if (result == 0) { result = 1; };
                    result = result * int.Parse(temp);
                    break;
                case "/":
                    if (result == 0) { result = 1; };
                    result = result / int.Parse(temp);
                    break;
                case "%":
                    if (result == 0) { result = 1; };
                    result = result % int.Parse(temp);
                    break;

                default:
                    break;
            }
            temp = "";
        }


        private void Operation_Click(string _op)
        {
            op = _op;
            if (TxtOutput.Text.Length > 0)
            {
                TxtOutput.Text = TxtOutput.Text + _op;
                if (temp != "")
                {
                    Switch_operation(_op);
                   
                }
            }
        }

        private void Num_Click(string num)
        {
            TxtOutput.Text = TxtOutput.Text + num;
            temp = temp + num;
        }

        private void TxtOutput_TextChanged(object sender, EventArgs e)
        {

        }


        private void FrmCalc_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            Num_Click("1");
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            Num_Click("2");
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            Num_Click("3");
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            Num_Click("4");
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            Num_Click("5");
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            Num_Click("6");
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            Num_Click("7");
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            Num_Click("8");
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            Num_Click("9");
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            Operation_Click("+");
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            Operation_Click("-");
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            Operation_Click("*");
        }

        private void BtnDivi_Click(object sender, EventArgs e)
        {
            Operation_Click("/");
        }

        private void BtnModu_Click(object sender, EventArgs e)
        {
            Operation_Click("%");
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            
               //TxtOutput.Text = TxtOutput.Text + ".";
            
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {

            Num_Click("0");

        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {


            Switch_operation(op);
            TxtOutput.Text = $"{result}";
            


        }
    }
}