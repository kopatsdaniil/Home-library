using Home_library.Forms;
using Home_library.Interfaces;
using Home_library.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Home_library;

public partial class LoginForm : Form
{
    private readonly IManager<User> _userManager;
    private readonly IValidator<User> _userValidator;
    private readonly IServiceProvider _provider;

    public LoginForm(IManager<User> userManager, IValidator<User> userValidator, IServiceProvider provider)
    {
        InitializeComponent();

        PasswordVisible.Visible = false;
        PasswordInvisible.Visible = false;

        _userManager = userManager;
        _userValidator = userValidator;
        _provider = provider;
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
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void LogInButton_Click(object sender, EventArgs? e)
    {
        var username = TextUsername.Text;
        var password = TextPassword.Text;

        var users = _userManager.Load();

        if (TextUsername.Text == "admin" && TextPassword.Text == "admin")
        {
            Hide();
            _provider.GetRequiredService<AdminForm>().ShowDialog();
        }

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