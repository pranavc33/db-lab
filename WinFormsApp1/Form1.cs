namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string name;
        string regno;
        string gender;
        string year;
        string dept;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                year = "1st year";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = this.textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            regno = this.textBox2.Text;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)

                gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)

                gender = "Female";

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                year = "2nd year";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                year = "3rd year";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dept = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complete");
        }
    }
}