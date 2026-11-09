namespace pr8._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox3.Text = "";

            // 1. Проверка на конкатенацию (radioButton3)
            
            if (radioButton3.Checked)
            {
                textBox3.Text = textBox1.Text + textBox2.Text;
                return; 
            }

            // 2. Математические операции
            
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                
                if (radioButton1.Checked) 
                {
                    textBox3.Text = (num1 % num2).ToString();
                }
                else if (radioButton2.Checked) 
                {
                    textBox3.Text = Math.Pow(num1, num2).ToString();
                }
                else if (radioButton4.Checked) 
                {
                    // Проверка попытки деления на ноль
                    if (num2 == 0)
                    {
                        MessageBox.Show("Ошибка: Деление на ноль невозможно!", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        textBox3.Text = (num1 / num2).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите тип операции при помощи переключателей.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                
                MessageBox.Show("Пожалуйста, введите корректные числовые значения в textBox1 и textBox2.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
