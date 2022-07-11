using WordleLib;
using System.IO;
using WordleLib.Enums;
using WordleLib.Exceptions;

namespace WordleWinForms;

public partial class GameForm : Form
{
    public Button[,] buttons = new Button[5, 6];
    private readonly Wordle _wordle;

    public GameForm()
    {
        for (int x = 0; x < buttons.GetLength(0); x++)
        {
            for (int y = 0; y < buttons.GetLength(1); y++)
            {
                var btn = new Button();
                btn.Enabled = false;
                btn.Location = new Point(10 + 80 * x, 10 + 80 * y);
                btn.BackColor = Color.LightGray;
                btn.Size = new Size(80, 80);
                btn.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
                btn.Text = string.Empty;
                Controls.Add(btn); // IMPORTANT!
                buttons[x, y] = btn;
            }
        }



        // game setup
        _wordle = new WordleFactory().CreateWordle(6, 5, Path.GetFullPath(@"dictionary.txt"));
        
        InitializeComponent();

        // hacky way to make window unresizable
        // important that it's after InitializeComponent() call
        MaximumSize = Size;
        MinimumSize = Size;

        // force redraw
        Invalidate();
    }

    private void HandleColours(string guess, GuessState[] states)
    {
        int guessIdx = 5 - (int)_wordle.GuessesLeft;
        for (int i = 0; i < 5; i++)
        {
            Color color = Color.LightGray; // default to GuessState.None
            switch (states[i])
            {
                case GuessState.Elsewhere:
                    color = Color.LightYellow;
                    break;
                case GuessState.Correct:
                    color = Color.LightGreen;
                    break;
            }
            buttons[i, guessIdx].BackColor = color;
            buttons[i, guessIdx].Text = guess[i].ToString();
        }
    }

    private void guessTxtBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
        {
            return;
        }

        // remove annoying Windows beeps when enter is pressed
        e.Handled = e.SuppressKeyPress = true;

        string guess = ((TextBox)sender).Text.ToLower();
        guessTxtBox.Text = string.Empty;
        try
        {
            GuessState[] states = _wordle.Guess(guess);
            HandleColours(guess, states);

            // if all correct or out of guesses, disable guess button
            if (states.Count(state => state == GuessState.Correct) != 5
                && _wordle.GuessesLeft != 0)
            {
                return;
            }
        }
        catch (UnacceptableWordException)
        {
            // could maybe add some event to warn the player
            return;
        }

        guessTxtBox.Enabled = false;
        MessageBox.Show($"The word was {_wordle.WordToGuess}");
    }
}