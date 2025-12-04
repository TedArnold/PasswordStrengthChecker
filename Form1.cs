#nullable disable
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordStrengthChecker
{
    public partial class Form1 : Form
    {
        private Label titleLabel;
        private TextBox passwordBox;
        private Button checkButton;
        private Label strengthLabel;
        private Label suggestionLabel;

        public Form1()
        {
            InitializeComponent();
            BuildUI();
        }

        private void BuildUI()
        {
            // Window settings
            this.Text = "Capstone Project Password Checker";
            this.Size = new Size(650, 420);
            this.BackColor = Color.FromArgb(224, 207, 186);  // 🌍 Earth-tone beige
            this.StartPosition = FormStartPosition.CenterScreen;

            // ===================== TITLE =====================
            titleLabel = new Label();
            titleLabel.Text = "Capstone Project Password Checker";
            titleLabel.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(92, 64, 51); // Dark brown
            titleLabel.AutoSize = true;

            // ===================== PASSWORD BOX =====================
            passwordBox = new TextBox();
            passwordBox.Font = new Font("Segoe UI", 14);
            passwordBox.Width = 380;
            passwordBox.Height = 40;
            passwordBox.BackColor = Color.FromArgb(245, 239, 230); // Light cream
            passwordBox.ForeColor = Color.Black;
            passwordBox.BorderStyle = BorderStyle.FixedSingle;

            // ===================== CHECK BUTTON =====================
            checkButton = new Button();
            checkButton.Text = "Check Strength";
            checkButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            checkButton.Width = 200;
            checkButton.Height = 50;

            checkButton.BackColor = Color.FromArgb(135, 105, 83); // Earth brown
            checkButton.ForeColor = Color.White;

            checkButton.FlatStyle = FlatStyle.Flat;
            checkButton.FlatAppearance.BorderSize = 0;
            checkButton.Click += CheckButton_Click;

            // ===================== STRENGTH LABEL =====================
            strengthLabel = new Label();
            strengthLabel.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            strengthLabel.ForeColor = Color.FromArgb(92, 64, 51); // Dark brown
            strengthLabel.AutoSize = true;

            // ===================== SUGGESTION LABEL =====================
            suggestionLabel = new Label();
            suggestionLabel.Font = new Font("Segoe UI", 11);
            suggestionLabel.ForeColor = Color.FromArgb(100, 80, 70); // Muted brown
            suggestionLabel.AutoSize = true;
            suggestionLabel.MaximumSize = new Size(450, 200);

            // ===================== CENTER EVERYTHING =====================
            // Using a TableLayoutPanel to center ALL UI elements perfectly
            TableLayoutPanel layout = new TableLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.BackColor = this.BackColor;

            // 5 rows: Title, input, button, strength, suggestions
            layout.RowCount = 5;
            layout.ColumnCount = 1;
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            // Center-align all items
            layout.Controls.Add(titleLabel, 0, 0);
            layout.Controls.Add(passwordBox, 0, 1);
            layout.Controls.Add(checkButton, 0, 2);
            layout.Controls.Add(strengthLabel, 0, 3);
            layout.Controls.Add(suggestionLabel, 0, 4);

            titleLabel.Anchor = AnchorStyles.None;
            passwordBox.Anchor = AnchorStyles.None;
            checkButton.Anchor = AnchorStyles.None;
            strengthLabel.Anchor = AnchorStyles.None;
            suggestionLabel.Anchor = AnchorStyles.None;

            this.Controls.Add(layout);
        }


        private void CheckButton_Click(object sender, EventArgs e)
        {
            string pwd = passwordBox.Text;
            int score = 0;
            string suggestions = "";

            if (pwd.Length >= 8) score++; else suggestions += "• Use at least 8 characters\n";
            if (System.Text.RegularExpressions.Regex.IsMatch(pwd, "[A-Z]")) score++; else suggestions += "• Add an uppercase letter\n";
            if (System.Text.RegularExpressions.Regex.IsMatch(pwd, "[a-z]")) score++; else suggestions += "• Add a lowercase letter\n";
            if (System.Text.RegularExpressions.Regex.IsMatch(pwd, "[0-9]")) score++; else suggestions += "• Add a number\n";
            if (System.Text.RegularExpressions.Regex.IsMatch(pwd, "[^a-zA-Z0-9]")) score++; else suggestions += "• Add a special character (!@#$%)\n";

            switch (score)
            {
                case 1:
                case 2:
                    strengthLabel.Text = "Strength: Weak";
                    strengthLabel.ForeColor = Color.FromArgb(160, 50, 40); // Earth red
                    break;

                case 3:
                case 4:
                    strengthLabel.Text = "Strength: Medium";
                    strengthLabel.ForeColor = Color.FromArgb(181, 142, 53); // Warm gold
                    break;

                case 5:
                    strengthLabel.Text = "Strength: Strong";
                    strengthLabel.ForeColor = Color.FromArgb(34, 139, 34); // Forest green
                    break;
            }

            suggestionLabel.Text = suggestions == "" ? "Your password is strong!" : suggestions;
        }
    }
}
