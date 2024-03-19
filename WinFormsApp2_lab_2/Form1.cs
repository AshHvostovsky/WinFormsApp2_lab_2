namespace WinFormsApp2_lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //���� ����������
            this.StartPosition = FormStartPosition.CenterScreen;
            // �������� �������� �� ��������
            txtBox.Text = Properties.Settings.Default.text_in.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string text_in = "";

            text_in = this.txtBox.Text;

            MessageBox.Show(Logic.GetResult(text_in), "���������");
            //������ ����� �� ��������� ����
            returnFocus();

            //  �������� ��������� �������� � ���������
            Properties.Settings.Default.text_in = text_in;
            Properties.Settings.Default.Save(); // ��������� ���������� ��������, ����� ��� �������������� ��� ��������� �������
        }

        private void returnFocus()
        {
            // ������������� ����� ������� �� ��������� ����
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
                // ������ ������
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
                result = "������� ��� ������������� ����: " + amount + ". \n������������� �����: " + letters;
                // ����� ������
                return result;
            }
        }


    }
}


