
commentTextBox = new TextBox
{
    Multiline = true,
    Width = 400,
    Height = 100,
    Visible = false,
    Location = new Point(30, 500) // Adjust location as needed
};

submitComment_btn = new Button
{
    Text = "Submit Comment",
    Width = 120,
    Height = 30,
    Visible = false,
    Location = new Point(440, 500) // Adjust location as needed
};

submitComment_btn.Click += SubmitComment_btn_Click;

this.Controls.Add(commentTextBox);
this.Controls.Add(submitComment_btn);