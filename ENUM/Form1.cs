namespace ENUM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum colors { red, green =7, blue, orange, yellow, black };
        private void button1_Click(object sender, EventArgs e)
        {
            string text = "red "+ (int)colors.red+ Environment.NewLine;
            text += "green " + (int)colors.green+ Environment.NewLine;
            text+=  "blue " + (int)colors.blue+ Environment.NewLine;
            text+= "orange " +(int)colors.orange+ Environment.NewLine;
            text+= "yellow "+ (int) colors.yellow+ Environment.NewLine;
            text+= "black "+ (int)(colors.black);
            textBox1.Text = text;

        }
    }
}