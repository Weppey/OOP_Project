using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OOP_Project;
using static OOP_Project.StayLoggedIn;

public static class ThemeManager
{
    public static bool IsDarkMode { get; private set; } 

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

        // Force logo_pb to always be white
        var logoPb = form.Controls.Find("logo_pb", true).FirstOrDefault() as PictureBox;
        if (logoPb != null)
        {
            logoPb.BackColor = Color.White;
        }
    }

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
          

            if (control.Name == "settings_panel")
            {
                control.BackColor = IsDarkMode ? Color.Transparent : Color.LightGray;
                continue;
            }

        
            // Change the color of specific labels in SettingsControl


            // Manually preserve other settings panel colors
            if (control.Name == "theme_panel")
            {
                control.BackColor = Color.Firebrick;
                continue;
            }

            if (control.Name == "security_panel" || control.Name == "privacy_panel")
            {
                control.BackColor = Color.Maroon;
                continue;
            }

            if (control.Name == "system_panel")
            {
                control.BackColor = Color.Firebrick;
                continue;
            }

            if (control.Name == "appinfo_panel")
            {
                control.BackColor = Color.White;
                continue;
            }

            // Movie Details Form - Specific labels
            if (control.Name == "dateRelease_lbl" ||
                control.Name == "genre_lbl" ||
                control.Name == "description_lbl")
            {
                control.ForeColor = IsDarkMode ? Color.White : Color.FromArgb(30, 30, 30);
                control.BackColor = Color.Transparent;
            }
            // Buttons that always stay white
            else if (control.Name == "comment_btn" || control.Name == "favorite_btn")
            {
                control.ForeColor = Color.White;
            }
            // General label styling
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

            // Panel coloring
            if (control.Name == "menu_panel" || control.Name == "favorite_panel" ||
                control.Name == "popular_panel" || control.Name == "userProfile_panel" ||
                control.Name == "AdminControl_panel")
            {
                control.BackColor = darkPanelColor;
            }
            else if (control.Name == "home_form")
            {
                control.BackColor = IsDarkMode ? Color.FromArgb(30, 30, 30) : Color.LightGray;
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

            // Recurse
            if (control.HasChildren)
            {
                ApplyThemeToControls(control.Controls, foreColor, backColor, darkPanelColor, viewportColor, flowPanelColor);
            }
        }

    }
    public static void SaveThemePreference()
    {
        int? userId = StayLoggedIn.GetCurrentUserId();
        if (userId != null)
        {
            // Save the current theme preference to local storage
            UserThemeSettings.SaveTheme(userId.Value, IsDarkMode);
        }
    }
public static void LoadSavedThemePreference()
{
    int? userId = StayLoggedIn.GetCurrentUserId();
    if (userId != null)
    {
        bool? savedTheme = UserThemeSettings.LoadTheme(userId.Value);
        if (savedTheme == true)
            ApplyDarkMode();
        else
            ApplyLightMode();
    }
    else
    {
        ApplyLightMode(); // Default to light mode if no user session
    }
}


}
