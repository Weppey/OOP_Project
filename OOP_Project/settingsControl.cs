using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Security.Policy;
using System.Threading.Tasks;
using WinFormsToolTip = System.Windows.Forms.ToolTip;

namespace OOP_Project
{
    public partial class settingsControl : UserControl
    {
        WinFormsToolTip tooltip = new WinFormsToolTip();
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";


        public settingsControl()
        {
            InitializeComponent();

            tooltip.IsBalloon = false;                        // Makes it balloon-shaped
            tooltip.BackColor = Color.LightYellow;           // Tooltip background color (only works in custom-drawn tips)
            tooltip.ForeColor = Color.Black;                 // Text color
            tooltip.UseFading = true;                        // Smooth fade-in/out
            tooltip.UseAnimation = true;                     // Animate appearance

            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 100;
            tooltip.ReshowDelay = 100;
            tooltip.ShowAlways = true;
        }

        private void settingsControl_Load(object sender, EventArgs e)
        {
            CurvePanel(appinfo_panel, 30);
            appinfo_panel.Resize += (s, aargs) => CurvePanel(appinfo_panel, 20);

            CurvePanel(privacy_panel, 30);
            privacy_panel.Resize += (s, aargs) => CurvePanel(privacy_panel, 20);

            CurvePanel(security_panel, 30);
            security_panel.Resize += (s, aargs) => CurvePanel(security_panel, 20);

            CurvePanel(theme_panel, 30);
            theme_panel.Resize += (s, aargs) => CurvePanel(theme_panel, 20);

            CurvePanel(system_panel, 30);
            system_panel.Resize += (s, aargs) => CurvePanel(system_panel, 20);
        }

        private void CurvePanel(System.Windows.Forms.Panel panel, int radius) // Method to apply curved corners to a panel
        {
            GraphicsPath path = new GraphicsPath(); // Method to apply curved corners to a panel
            path.StartFigure(); // Start the shape definition

            // Add arcs to the path to define the four rounded corners
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Top-left corner
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90); // Top-left corner
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90); // Bottom-right corner
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90); // Bottom-left corner
            path.CloseFigure(); // Close the shape definition
            panel.Region = new Region(path); // Apply the custom shape to the panel by setting its Region property
        }

        private void language_cmb_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gender_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
