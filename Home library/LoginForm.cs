using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Home_library
{
    public partial class LoginForm : Form
    {
        public DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(User));

        public LoginForm()
        {
            InitializeComponent();

            passwordVisible.Visible = false;
            passwordInvisible.Visible = false;
        }

        private void VisibilityIcon(bool argument)
        {
            if (argument)
            {
                passwordInvisible.Visible = true;
                passwordVisible.Visible = true;
            }

            else
            {
                passwordVisible.Visible = false;
                passwordInvisible.Visible = false;
            }
        }
            
        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void textUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (textUsername.Text == "Username")
            {
                textUsername.Clear();
            }

            if (String.IsNullOrEmpty(textPassword.Text))
            {
                textPassword.Text = "Password";
                textPassword.PasswordChar = '\0';
                VisibilityIcon(false);
            }
        }

        private void textPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textPassword.Text == "Password")
            {
                textPassword.Clear();
                textPassword.PasswordChar = '*';
            }

            if (String.IsNullOrEmpty(textUsername.Text))
            {
                textUsername.Text = "Username";
                VisibilityIcon(true);
            }

            VisibilityIcon(true);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            StreamReader reader = new StreamReader(stream);

            string serialization;
            serialization = reader.ReadToEnd();
            stream.Position = 0;
            User users = (User)serializer.ReadObject(stream);
        }


    private void signUpButton_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            User new_user = new User(username, password);

            if (!new_user.Validate())
            {
                textMessage.Text = "Invalid user data. Please try again";
                textPassword.Text = "Password";
                textUsername.Text = "Username";
                textPassword.PasswordChar = '\0';
                VisibilityIcon(false);
            }

            else
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.WriteObject(stream, new_user);
                }

                textMessage.Text = "You have successfully sign up!";
                textPassword.Text = "Password";
                textUsername.Text = "Username";
                textPassword.PasswordChar = '\0';
            }
        }

        private void passwordVisible_Click(object sender, EventArgs e)
        {
            if(textPassword.Text != "Password")
            {
                textPassword.PasswordChar = '*';
            }

            passwordInvisible.BringToFront();
        }

        private void passwordInvisible_Click(object sender, EventArgs e)
        {
            if (textPassword.Text != "Password")
            {
                textPassword.PasswordChar = '\0';
            }

            passwordVisible.BringToFront();
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

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Username)) isValid = false;
            if (string.IsNullOrWhiteSpace(Password)) isValid = false;

            return isValid;
        }
    }
}
