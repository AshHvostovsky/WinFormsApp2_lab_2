namespace WinFormsApp2_lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Окно посередине
            this.StartPosition = FormStartPosition.CenterScreen;
            // считывем значения из настроек
            txtBox.Text = Properties.Settings.Default.text_in.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string text_in = "";

            text_in = this.txtBox.Text;

            MessageBox.Show(Logic.GetResult(text_in), "Результат");
            //вернем фокус на текстовое поле
            returnFocus();

            //  передаем введенные значения в параметры
            Properties.Settings.Default.text_in = text_in;
            Properties.Settings.Default.Save(); // сохраняем переданные значения, чтобы они восстановились пре очередном запуске
        }

        private void returnFocus()
        {
            // Устанавливаем фокус обратно на текстовое поле
            txtBox.Focus(); 
        }

        private void button2_Click(object sender, EventArgs e) {
                this.txtBox.Text = "";
        }
        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //button1_Click(this, e);
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        public class Logic
        {
            public static string GetResult(string text)
            {
                // НАЧАЛО логики
                string result = "";
                int amount = 0;
                String letters = "";
                text = text.Replace(" ", "");
                for (int i = 0; i < (text.Length - 1); i++)
                {
                    if (text[i] == text[i + 1] && char.IsLetter(text[i]))
                    {
                        amount++;
                        bool is_have = false;
                        foreach (char c in letters)
                        {
                            if (c == text[i])
                            {
                                is_have = true;
                            }
                        }
                        if (!is_have)
                        {
                            letters += text[i];
                            letters += " ";
                        }
                    }
                }
                result = "Найдено пар повторяющихся букв: " + amount + ". \nПовторяющиеся буквы: " + letters;
                // КОНЕЦ логики
                return result;
            }
        }


    }
}


