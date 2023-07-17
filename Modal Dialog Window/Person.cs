
namespace Modal_Dialog_Window
{
   public class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int YearOfBirth { get; private set; }
        public string City { get; private set; }


        public override string ToString()
        {
            return "Name: " + Name + ", Surname: " + Surname + ", Year of birth: " + YearOfBirth + ", City: " + City + "\r\n";
        }

        public Person(string nameInput, string surnameInput, int yearOfBirthInput, string cityInput)
        {
            Name = nameInput;
            Surname = surnameInput;
            YearOfBirth = yearOfBirthInput;
            City = cityInput;
        }
    }
}
