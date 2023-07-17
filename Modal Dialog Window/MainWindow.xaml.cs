using System.Windows;

namespace Modal_Dialog_Window
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            list.Text = deafeult.ToString();
        }

        readonly Person deafeult = new Person("Ala", "Tyler", 1999, "New York");

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ModalDialogWindow modalDialogWindow = new ModalDialogWindow();
            modalDialogWindow.confirm.Content = "Add";
            modalDialogWindow.Title = "Add person";
            modalDialogWindow.ShowDialog();

            if (modalDialogWindow.newPerson != null)
            {
                list.Text += modalDialogWindow.newPerson.ToString();
            }
        }
    }
}
