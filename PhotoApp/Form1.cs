namespace PhotoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Count_Amount_Click(object sender, EventArgs e)
        {
            CalculatePrice return_resultOutPut = new CalculatePrice(this);

            double result;
            result_output.Text = Convert.ToUInt32(return_resultOutPut.ReturnPriceToCustomer(out 
                result)).ToString();
        }
    }
    public class CalculatePrice 
    {
        private int numberofPrintingPictures;
     
        private const double smallSizePrice = 15.90;
        private const double mediumSizePrice = 20.20;
        private const double langeSizePrice = 23.20;

        private Form1 accesstoFormElements;

        public CalculatePrice(Form1 form)
        {
            accesstoFormElements = form;
        }
        public double ReturnPriceToCustomer(out double result)
        {
            result = 0;

            try
            {
                if (string.IsNullOrWhiteSpace(accesstoFormElements.amount_value.Text)) {

                    int defaultValue = 1;
                    numberofPrintingPictures = defaultValue;
                    throw new FormatException("Your value can NOT be empty or NULL" +
                        "\n Counting using default value...");
                }

                numberofPrintingPictures = Convert.ToInt32(accesstoFormElements.amount_value.Text);

                if (numberofPrintingPictures < 1){

                    result = 0;
                    throw new ArgumentOutOfRangeException("You can NOT choose value " +
                            "smaller than 1");

                }
            }
            catch (ArgumentNullException ex) { MessageBox.Show(ex.Message); }
            catch (FormatException ex) { MessageBox.Show(ex.Message); }
            catch (ArgumentOutOfRangeException ex) { MessageBox.Show(ex.Message); }


            if (accesstoFormElements.smallsize.Checked)  {

                result = smallSizePrice * numberofPrintingPictures;
           }
           else if(accesstoFormElements.mediumsize.Checked) {

                result = mediumSizePrice * numberofPrintingPictures;
           }
           else if(accesstoFormElements.largesize.Checked) {

                result = langeSizePrice * numberofPrintingPictures;
           }

            return result;
        }
    }
}
