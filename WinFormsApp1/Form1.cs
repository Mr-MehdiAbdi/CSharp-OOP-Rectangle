namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double width = Convert.ToDouble(txtWidth.Text);

            double height = Convert.ToDouble(txtHeight.Text);

            Rectangle rectangle = new Rectangle(width, height);

            double area = rectangle.CalculateArea();

            double perimeter = rectangle.CalculatePerimeter();

            MessageBox.Show(
                $"Area: {area}\nPerimeter: {perimeter}"
            );
        }
    }
}
