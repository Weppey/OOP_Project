using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Project
{
    public class movieitem_form : UserControl
    {
        private Label titleLabel;
        private Label descriptionLabel;
        private Panel top_dock;
        private PictureBox minimize_pb;
        private PictureBox close_pb;
        private PictureBox Pb_logo;
        private Panel signup_panel;
        private Panel choice1_panel;
        private Panel mv8_panel;
        private Panel mv4_panel;
        private Panel mv7_panel;
        private Panel mv3_panel;
        private Panel mv5_panel;
        private Panel mv6_panel;
        private Panel mv1_panel;
        private Panel mv2_panel;
        private Panel choice2_panel;
        private Panel mv16_panel;
        private Panel mv12_panel;
        private Panel mv15_panel;
        private Panel mv11_panel;
        private Panel mv13_panel;
        private Panel mv14_panel;
        private Panel mv9_panel;
        private Panel mv10_panel;
        private Button back_btn;
        private Button add_btn;
        private PictureBox moviePictureBox;

        public string MovieTitle
        {
            get => titleLabel.Text;
            set => titleLabel.Text = value;
        }

        public string MovieDescription
        {
            get => descriptionLabel.Text;
            set => descriptionLabel.Text = value;
        }

        public string MovieImage
        {
            get => moviePictureBox.ImageLocation;
            set => moviePictureBox.Load(value);
        }

        public movieitem_form()
        {
            this.Width = 300;
            this.Height = 100;
            this.BackColor = Color.LightGray;

            moviePictureBox = new PictureBox
            {
                Size = new Size(80, 80),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            titleLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(100, 10)
            };

            descriptionLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Arial", 9),
                Location = new Point(100, 40),
                MaximumSize = new Size(200, 40)
            };

            this.Controls.Add(moviePictureBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(descriptionLabel);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movieitem_form));
            this.top_dock = new System.Windows.Forms.Panel();
            this.minimize_pb = new System.Windows.Forms.PictureBox();
            this.close_pb = new System.Windows.Forms.PictureBox();
            this.Pb_logo = new System.Windows.Forms.PictureBox();
            this.signup_panel = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.choice2_panel = new System.Windows.Forms.Panel();
            this.mv16_panel = new System.Windows.Forms.Panel();
            this.mv12_panel = new System.Windows.Forms.Panel();
            this.mv15_panel = new System.Windows.Forms.Panel();
            this.mv11_panel = new System.Windows.Forms.Panel();
            this.mv13_panel = new System.Windows.Forms.Panel();
            this.mv14_panel = new System.Windows.Forms.Panel();
            this.mv9_panel = new System.Windows.Forms.Panel();
            this.mv10_panel = new System.Windows.Forms.Panel();
            this.choice1_panel = new System.Windows.Forms.Panel();
            this.mv8_panel = new System.Windows.Forms.Panel();
            this.mv4_panel = new System.Windows.Forms.Panel();
            this.mv7_panel = new System.Windows.Forms.Panel();
            this.mv3_panel = new System.Windows.Forms.Panel();
            this.mv5_panel = new System.Windows.Forms.Panel();
            this.mv6_panel = new System.Windows.Forms.Panel();
            this.mv1_panel = new System.Windows.Forms.Panel();
            this.mv2_panel = new System.Windows.Forms.Panel();
            this.top_dock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_logo)).BeginInit();
            this.signup_panel.SuspendLayout();
            this.choice2_panel.SuspendLayout();
            this.choice1_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_dock
            // 
            this.top_dock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.top_dock.Controls.Add(this.minimize_pb);
            this.top_dock.Controls.Add(this.close_pb);
            this.top_dock.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_dock.Location = new System.Drawing.Point(0, 0);
            this.top_dock.Name = "top_dock";
            this.top_dock.Size = new System.Drawing.Size(870, 38);
            this.top_dock.TabIndex = 3;
            // 
            // minimize_pb
            // 
            this.minimize_pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.minimize_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimize_pb.Image = global::OOP_Project.Properties.Resources.icons8_minimize_48;
            this.minimize_pb.Location = new System.Drawing.Point(808, 7);
            this.minimize_pb.Name = "minimize_pb";
            this.minimize_pb.Size = new System.Drawing.Size(25, 23);
            this.minimize_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_pb.TabIndex = 9;
            this.minimize_pb.TabStop = false;
            // 
            // close_pb
            // 
            this.close_pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.close_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.close_pb.Image = global::OOP_Project.Properties.Resources.icons8_close_48;
            this.close_pb.Location = new System.Drawing.Point(837, 7);
            this.close_pb.Name = "close_pb";
            this.close_pb.Size = new System.Drawing.Size(25, 23);
            this.close_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_pb.TabIndex = 8;
            this.close_pb.TabStop = false;
            this.close_pb.Click += new System.EventHandler(this.close_pb_Click);
            // 
            // Pb_logo
            // 
            this.Pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pb_logo.Image")));
            this.Pb_logo.Location = new System.Drawing.Point(369, 50);
            this.Pb_logo.Name = "Pb_logo";
            this.Pb_logo.Size = new System.Drawing.Size(100, 50);
            this.Pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_logo.TabIndex = 39;
            this.Pb_logo.TabStop = false;
            // 
            // signup_panel
            // 
            this.signup_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.signup_panel.Controls.Add(this.back_btn);
            this.signup_panel.Controls.Add(this.add_btn);
            this.signup_panel.Controls.Add(this.choice2_panel);
            this.signup_panel.Controls.Add(this.choice1_panel);
            this.signup_panel.Controls.Add(this.Pb_logo);
            this.signup_panel.Location = new System.Drawing.Point(12, 44);
            this.signup_panel.Name = "signup_panel";
            this.signup_panel.Size = new System.Drawing.Size(846, 454);
            this.signup_panel.TabIndex = 4;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(26, 77);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 45;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(746, 77);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 44;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // choice2_panel
            // 
            this.choice2_panel.AutoScroll = true;
            this.choice2_panel.Controls.Add(this.mv16_panel);
            this.choice2_panel.Controls.Add(this.mv12_panel);
            this.choice2_panel.Controls.Add(this.mv15_panel);
            this.choice2_panel.Controls.Add(this.mv11_panel);
            this.choice2_panel.Controls.Add(this.mv13_panel);
            this.choice2_panel.Controls.Add(this.mv14_panel);
            this.choice2_panel.Controls.Add(this.mv9_panel);
            this.choice2_panel.Controls.Add(this.mv10_panel);
            this.choice2_panel.Location = new System.Drawing.Point(26, 279);
            this.choice2_panel.Name = "choice2_panel";
            this.choice2_panel.Size = new System.Drawing.Size(795, 155);
            this.choice2_panel.TabIndex = 43;
            // 
            // mv16_panel
            // 
            this.mv16_panel.Location = new System.Drawing.Point(1081, 17);
            this.mv16_panel.Name = "mv16_panel";
            this.mv16_panel.Size = new System.Drawing.Size(130, 120);
            this.mv16_panel.TabIndex = 7;
            // 
            // mv12_panel
            // 
            this.mv12_panel.Location = new System.Drawing.Point(477, 17);
            this.mv12_panel.Name = "mv12_panel";
            this.mv12_panel.Size = new System.Drawing.Size(130, 120);
            this.mv12_panel.TabIndex = 3;
            // 
            // mv15_panel
            // 
            this.mv15_panel.Location = new System.Drawing.Point(931, 17);
            this.mv15_panel.Name = "mv15_panel";
            this.mv15_panel.Size = new System.Drawing.Size(130, 120);
            this.mv15_panel.TabIndex = 5;
            // 
            // mv11_panel
            // 
            this.mv11_panel.Location = new System.Drawing.Point(327, 17);
            this.mv11_panel.Name = "mv11_panel";
            this.mv11_panel.Size = new System.Drawing.Size(130, 120);
            this.mv11_panel.TabIndex = 1;
            // 
            // mv13_panel
            // 
            this.mv13_panel.Location = new System.Drawing.Point(628, 17);
            this.mv13_panel.Name = "mv13_panel";
            this.mv13_panel.Size = new System.Drawing.Size(130, 120);
            this.mv13_panel.TabIndex = 4;
            // 
            // mv14_panel
            // 
            this.mv14_panel.Location = new System.Drawing.Point(778, 17);
            this.mv14_panel.Name = "mv14_panel";
            this.mv14_panel.Size = new System.Drawing.Size(130, 120);
            this.mv14_panel.TabIndex = 6;
            // 
            // mv9_panel
            // 
            this.mv9_panel.Location = new System.Drawing.Point(24, 17);
            this.mv9_panel.Name = "mv9_panel";
            this.mv9_panel.Size = new System.Drawing.Size(130, 120);
            this.mv9_panel.TabIndex = 0;
            // 
            // mv10_panel
            // 
            this.mv10_panel.Location = new System.Drawing.Point(174, 17);
            this.mv10_panel.Name = "mv10_panel";
            this.mv10_panel.Size = new System.Drawing.Size(130, 120);
            this.mv10_panel.TabIndex = 1;
            // 
            // choice1_panel
            // 
            this.choice1_panel.AutoScroll = true;
            this.choice1_panel.Controls.Add(this.mv8_panel);
            this.choice1_panel.Controls.Add(this.mv4_panel);
            this.choice1_panel.Controls.Add(this.mv7_panel);
            this.choice1_panel.Controls.Add(this.mv3_panel);
            this.choice1_panel.Controls.Add(this.mv5_panel);
            this.choice1_panel.Controls.Add(this.mv6_panel);
            this.choice1_panel.Controls.Add(this.mv1_panel);
            this.choice1_panel.Controls.Add(this.mv2_panel);
            this.choice1_panel.Location = new System.Drawing.Point(26, 106);
            this.choice1_panel.Name = "choice1_panel";
            this.choice1_panel.Size = new System.Drawing.Size(795, 155);
            this.choice1_panel.TabIndex = 42;
            // 
            // mv8_panel
            // 
            this.mv8_panel.Location = new System.Drawing.Point(1081, 17);
            this.mv8_panel.Name = "mv8_panel";
            this.mv8_panel.Size = new System.Drawing.Size(130, 120);
            this.mv8_panel.TabIndex = 7;
            // 
            // mv4_panel
            // 
            this.mv4_panel.Location = new System.Drawing.Point(477, 17);
            this.mv4_panel.Name = "mv4_panel";
            this.mv4_panel.Size = new System.Drawing.Size(130, 120);
            this.mv4_panel.TabIndex = 3;
            // 
            // mv7_panel
            // 
            this.mv7_panel.Location = new System.Drawing.Point(931, 17);
            this.mv7_panel.Name = "mv7_panel";
            this.mv7_panel.Size = new System.Drawing.Size(130, 120);
            this.mv7_panel.TabIndex = 5;
            // 
            // mv3_panel
            // 
            this.mv3_panel.Location = new System.Drawing.Point(327, 17);
            this.mv3_panel.Name = "mv3_panel";
            this.mv3_panel.Size = new System.Drawing.Size(130, 120);
            this.mv3_panel.TabIndex = 1;
            // 
            // mv5_panel
            // 
            this.mv5_panel.Location = new System.Drawing.Point(628, 17);
            this.mv5_panel.Name = "mv5_panel";
            this.mv5_panel.Size = new System.Drawing.Size(130, 120);
            this.mv5_panel.TabIndex = 4;
            // 
            // mv6_panel
            // 
            this.mv6_panel.Location = new System.Drawing.Point(778, 17);
            this.mv6_panel.Name = "mv6_panel";
            this.mv6_panel.Size = new System.Drawing.Size(130, 120);
            this.mv6_panel.TabIndex = 6;
            // 
            // mv1_panel
            // 
            this.mv1_panel.Location = new System.Drawing.Point(24, 17);
            this.mv1_panel.Name = "mv1_panel";
            this.mv1_panel.Size = new System.Drawing.Size(130, 120);
            this.mv1_panel.TabIndex = 0;
            // 
            // mv2_panel
            // 
            this.mv2_panel.Location = new System.Drawing.Point(174, 17);
            this.mv2_panel.Name = "mv2_panel";
            this.mv2_panel.Size = new System.Drawing.Size(130, 120);
            this.mv2_panel.TabIndex = 1;
            // 
            // movieitem_form
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.signup_panel);
            this.Controls.Add(this.top_dock);
            this.Name = "movieitem_form";
            this.Size = new System.Drawing.Size(870, 510);
            this.top_dock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_logo)).EndInit();
            this.signup_panel.ResumeLayout(false);
            this.choice2_panel.ResumeLayout(false);
            this.choice1_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            //back lang to
        }

        private void close_pb_Click(object sender, EventArgs e)
        {
            string msg = "Do you want to leave this page?";
            string title = "Confirm Naviagtion";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(msg, title, btn, icon);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
