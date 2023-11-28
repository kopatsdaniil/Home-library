using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Home_library
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            PasswordVisible.Visible = false;
            PasswordInvisible.Visible = false;
        }

        private void VisibilityIcon(bool argument)
        {
            if (argument)
            {
                PasswordInvisible.Visible = true;
                PasswordVisible.Visible = true;
            }

            else
            {
                PasswordVisible.Visible = false;
                PasswordInvisible.Visible = false;
            }
        }

        private void ReturnUser(string message)
        {
            TextMessage.Text = message;
            TextPassword.Text = "Password";
            TextUsername.Text = "Username";
            TextPassword.PasswordChar = '\0';
        }
            
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void TextUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (TextUsername.Text == "Username")
            {
                TextUsername.Clear();
            }

            if (string.IsNullOrEmpty(TextPassword.Text))
            {
                TextPassword.Text = "Password";
                TextPassword.PasswordChar = '\0';
                VisibilityIcon(false);
            }
        }

        private void TextPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (TextPassword.Text == "Password")
            {
                TextPassword.Clear();
                TextPassword.PasswordChar = '*';
            }

            if (string.IsNullOrEmpty(TextUsername.Text))
            {
                TextUsername.Text = "Username";
                VisibilityIcon(true);
            }

            VisibilityIcon(true);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            var username = TextUsername.Text;
            var password = TextPassword.Text;

            var users = LoadUsers();

            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    this.Close();
                }
            }

            ReturnUser("Username or password are incorrect!");
        }

        private static List<User> LoadUsers()
        {
            var serializer = new XmlSerializer(typeof(List<User>));

            using var stream = File.OpenRead("users.xml");
            return (List<User>)serializer.Deserialize(stream);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var newUser = new User(TextUsername.Text, TextPassword.Text);

            if (!newUser.IsValid())
            {
                ReturnUser("Invalid username or password");

                return;
            }

            var users = LoadUsers();

            foreach (var user in users)
            {
                if (user.Username == newUser.Username)
                {
                    ReturnUser("This username has been already taken!");

                    return;
                }
            }

            ReturnUser("You have successfully sign up!");

            users.Add(newUser);
            SaveUsers(users);
        }

        public static void SaveUsers(List<User> users)
        {
            var serializer = new XmlSerializer(typeof(List<User>));
            using var stream = File.Create("users.xml");
            serializer.Serialize(stream, users);
        }

        private void PasswordVisible_Click(object sender, EventArgs e)
        {
            if(TextPassword.Text != "Password")
            {
                TextPassword.PasswordChar = '*';
            }

            PasswordInvisible.BringToFront();
        }

        private void PasswordInvisible_Click(object sender, EventArgs e)
        {
            if (TextPassword.Text != "Password")
            {
                TextPassword.PasswordChar = '\0';
            }

            PasswordVisible.BringToFront();
        }
    }

    [Serializable]
    public class User
    {
        [Required(ErrorMessage = "User must have a username")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Invalid length of username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "User must have a password")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Invalid length of password")]
        public string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User() { }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Username)) return false;
            if (string.IsNullOrWhiteSpace(Password)) return false;

            return true;
        }
    }
}
