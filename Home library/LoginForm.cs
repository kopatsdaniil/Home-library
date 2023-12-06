using Home_library.Interfaces;
using Home_library.Models;

namespace Home_library;

public partial class LoginForm : Form
{
    private readonly IManager<User> _userManager;
    private readonly IValidator<User> _userValidator;

    public LoginForm(IManager<User> userManager, IValidator<User> userValidator)
    {
        InitializeComponent();

        PasswordVisible.Visible = false;
        PasswordInvisible.Visible = false;

        _userManager = userManager;
        _userValidator = userValidator;
    }

    private void SetVisibilityIcon(bool argument)
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

    private void ResetUserInformation(string message)
    {
        TextMessage.Text = message;
        TextPassword.Clear();
        TextUsername.Clear();
        SetVisibilityIcon(false);
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
    }

    private void TextUsername_MouseClick(object sender, MouseEventArgs e)
    {
        SetVisibilityIcon(false);
    }

    private void TextPassword_MouseClick(object sender, MouseEventArgs e)
    {
        SetVisibilityIcon(true);
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void LogInButton_Click(object sender, EventArgs? e)
    {
        var username = TextUsername.Text;
        var password = TextPassword.Text;

        var users = _userManager.Load();

        foreach (var user in users)
            if (user.Username == username && user.Password == password)
            {
                DialogResult = DialogResult.OK;
                Close();
            }

        ResetUserInformation("Username or password are incorrect!");
    }


    private void SignUpButton_Click(object sender, EventArgs e)
    {
        var newUser = new User(TextUsername.Text, TextPassword.Text, Guid.NewGuid());
        var users = _userManager.Load();
        var validationResult = _userValidator.Validate(users, newUser);

        ResetUserInformation(validationResult.Message);

        if (!validationResult.Success) return;

        users.Add(newUser);

        _userManager.Save(users);

        SetVisibilityIcon(false);
    }

    private void PasswordVisible_Click(object sender, EventArgs e)
    {
        TextPassword.PasswordChar = '*';
        PasswordInvisible.BringToFront();
    }

    private void PasswordInvisible_Click(object sender, EventArgs e)
    {
        TextPassword.PasswordChar = '\0';
        PasswordVisible.BringToFront();
    }

    private void LoginForm_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyValue == (char)Keys.Enter) LogInButton.PerformClick();
    }
}