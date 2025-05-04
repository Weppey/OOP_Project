using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

public static class ThemeManager
{
    public static bool IsDarkMode { get; private set; } = true;

    // Applies dark mode theme
    public static void ApplyDarkMode()
    {
        IsDarkMode = true;
        ApplyTheme(
            Color.White,
            Color.FromArgb(30, 30, 30),
            Color.FromArgb(26, 26, 26),
            Color.FromArgb(26, 26, 26),
            Color.Gray,
            Color.White
        );
    }

    // Applies light mode theme
    public static void ApplyLightMode()
    {
        IsDarkMode = false;
        ApplyTheme(
            Color.Black,
            Color.LightGray,
            Color.White,
            Color.Gray,
            Color.LightGray,
            Color.LightGray
        );
    }

    // General method to apply themes to forms
    public static void ApplyTheme(
        Color foreColor,
        Color formBackColor,
        Color controlBackColor,
        Color darkPanelColor,
        Color viewportColor,
        Color flowPanelColor)
    {
        foreach (Form form in Application.OpenForms)
        {
            ApplyThemeToForm(form, foreColor, formBackColor, controlBackColor, darkPanelColor, viewportColor, flowPanelColor);
        }
    }

    // Apply theme to a specific form
    public static void ApplyThemeToForm(
        Form form,
        Color foreColor,
        Color formBackColor,
        Color controlBackColor,
        Color darkPanelColor,
        Color viewportColor,
        Color flowPanelColor)
    {
        form.BackColor = formBackColor;
        form.ForeColor = foreColor;

        ApplyThemeToControls(form.Controls, foreColor, controlBackColor, darkPanelColor, viewportColor, flowPanelColor);

        // Ensure logo_pb always stays white
        var logoPb = form.Controls.Find("logo_pb", true).FirstOrDefault() as PictureBox;
        if (logoPb != null)
        {
            logoPb.BackColor = Color.White;
        }
    }

    // Recursively apply the theme to all controls on a form
    public static void ApplyThemeToControls(
        Control.ControlCollection controls,
        Color foreColor,
        Color backColor,
        Color darkPanelColor,
        Color viewportColor,
        Color flowPanelColor)
    {
        foreach (Control control in controls)
        {
            // Skip SettingsControl completely
            if (control is UserControl && control.GetType().Name == "SettingsControl")
                continue;

            // Skip all search textboxes
            if (control.Name.IndexOf("search_textbox", StringComparison.OrdinalIgnoreCase) >= 0)
                continue;

            // Skip logo PictureBox
            if (control is PictureBox && control.Name.Equals("logo_pb", StringComparison.OrdinalIgnoreCase))
            {
                control.BackColor = Color.Transparent;
                continue;
            }

            // Movie Details Form - Specific Labels
            if (control.Name == "dateRelease_lbl" ||
                control.Name == "genre_lbl" ||
                control.Name == "description_lbl")
            {
                control.ForeColor = IsDarkMode ? Color.White : Color.FromArgb(30, 30, 30);
                control.BackColor = Color.Transparent;
            }
            // Specific buttons always white
            else if (control.Name == "comment_btn" || control.Name == "favorite_btn")
            {
                control.ForeColor = Color.White;
            }
            // General label behavior
            else if (control is Label)
            {
                control.ForeColor = foreColor;
                control.BackColor = Color.Transparent;
            }
            else
            {
                control.ForeColor = foreColor;
                control.BackColor = backColor;
            }

            // Panel handling
            if (control.Name == "menu_panel" || control.Name == "settings_panel" ||
                control.Name == "favorite_panel" || control.Name == "popular_panel" ||
                control.Name == "userProfile_panel" || control.Name == "AdminControl_panel")
            {
                control.BackColor = darkPanelColor;
            }
            else if (control.Name == "home_form")
            {
                control.BackColor = Color.FromArgb(30, 30, 30);
            }
            else if (control.Name == "viewport_panel" || control.Name == "allMovie_panel" ||
                     control.Name == "recentlyMovie_panel")
            {
                control.BackColor = viewportColor;
            }
            else if (control.Name == "recommendedMovie_flp" || control.Name == "allMovie_flp" ||
                     control.Name == "recentlysearch_flp")
            {
                control.BackColor = flowPanelColor;
            }

            // Recurse into children
            if (control.HasChildren)
            {
                ApplyThemeToControls(control.Controls, foreColor, backColor, darkPanelColor, viewportColor, flowPanelColor);
            }
        }
    }
}
