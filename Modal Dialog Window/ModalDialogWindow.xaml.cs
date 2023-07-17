using System.Windows;


namespace Modal_Dialog_Window
{
    /// <summary>
    /// Interaction logic for Modalne_okienko.xaml
    /// </summary>
    public partial class ModalDialogWindow : Window
    {
        public ModalDialogWindow()
        {
            InitializeComponent();

        }

        public Person newPerson;

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(nameInput.Text) && !string.IsNullOrEmpty(surnameInput.Text)
                && !string.IsNullOrEmpty(yearOfBirthInput.Text) && !string.IsNullOrEmpty(cityInput.Text))
            {
                newPerson = new Person(nameInput.Text, surnameInput.Text, int.Parse(yearOfBirthInput.Text), cityInput.Text);
                this.Close();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
