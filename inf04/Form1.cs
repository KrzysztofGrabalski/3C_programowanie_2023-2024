namespace employes
{
    public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    string lowercase_letters = "qwertyuiopasdfghjklzxcvbnm";
    string uppercase_letters = "QWERTYUIOPASDFGHJKLZXCVBNM";
    string numbers = "1234567890";
    string watchword = "";
    string especial_characters = "!@#$%^&*()+-=";

        Random random = new Random();

    private void generatePassword_button_Click(object sender, EventArgs e)
    {
            watchword = "";
        int length = Convert.ToInt32(numberOfCharacters_textBox.Text);

        if (letters_checkBox.Checked)
        {
            watchword += uppercase_letters[random.Next(0, uppercase_letters.Length)];
        }
        if (numbers_checkBox.Checked)
        {
            watchword += numbers[random.Next(0, numbers.Length)];
        }
        if (especialCharacters_checkBox.Checked)
        {
            watchword += especial_characters[random.Next(0, especial_characters.Length)];
        }

        while (password.Length < length)
        {
                watchword += lowercase_letters[random.Next(0, lowercase_letters.Length)];
        }
        MessageBox.Show(password);
    }
    private void confirm_button_Click(object sender, EventArgs e)
        {
            string position = position_comboBox.Text;
            string name = firstName_textBox.Text;
            string surname = lastName_textBox.Text;
        MessageBox.Show("Employee details: " + name + " " + surname + ", Position: " + position + ", Password: " + password);
    }
}
}
