namespace OOP_Project
{
    partial class AdminMovieControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.remove_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.insert_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.details_lbl = new System.Windows.Forms.Label();
            this.submit_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.title_tb = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.genre_cmb = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genre_cmb)).BeginInit();
            this.SuspendLayout();
            // 
            // remove_btn
            // 
            this.remove_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.remove_btn.Location = new System.Drawing.Point(29, 141);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(132, 45);
            this.remove_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.remove_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.remove_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.remove_btn.StateCommon.Border.Rounding = 20;
            this.remove_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.remove_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.remove_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.remove_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.remove_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.remove_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remove_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remove_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remove_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remove_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.remove_btn.TabIndex = 65;
            this.remove_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_remove_28;
            this.remove_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.remove_btn.Values.Text = "Remove";
            // 
            // insert_btn
            // 
            this.insert_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.insert_btn.Location = new System.Drawing.Point(29, 88);
            this.insert_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(132, 45);
            this.insert_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.insert_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.insert_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.insert_btn.StateCommon.Border.Rounding = 20;
            this.insert_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.insert_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.insert_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.insert_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.insert_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.insert_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insert_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insert_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insert_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insert_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.insert_btn.TabIndex = 66;
            this.insert_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_insert_column_right_28;
            this.insert_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.insert_btn.Values.Text = "Insert";
            // 
            // details_lbl
            // 
            this.details_lbl.AutoSize = true;
            this.details_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.details_lbl.Location = new System.Drawing.Point(24, 35);
            this.details_lbl.Name = "details_lbl";
            this.details_lbl.Size = new System.Drawing.Size(149, 26);
            this.details_lbl.TabIndex = 74;
            this.details_lbl.Text = "Movie Editor";
            // 
            // submit_btn
            // 
            this.submit_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.submit_btn.Location = new System.Drawing.Point(634, 227);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(132, 45);
            this.submit_btn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.submit_btn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.submit_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.submit_btn.StateCommon.Border.Rounding = 20;
            this.submit_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.submit_btn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.submit_btn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.submit_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.submit_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.submit_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.submit_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.submit_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.submit_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.submit_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.submit_btn.TabIndex = 67;
            this.submit_btn.Values.Image = global::OOP_Project.Properties.Resources.icons8_submit_28;
            this.submit_btn.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.submit_btn.Values.Text = "Submit";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(176, 327);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.Size = new System.Drawing.Size(590, 171);
            this.kryptonDataGridView1.TabIndex = 75;
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(201, 88);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(189, 26);
            this.title_tb.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_tb.TabIndex = 77;
            this.title_tb.Text = "Title";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker1.TabIndex = 79;
            // 
            // genre_cmb
            // 
            this.genre_cmb.DropDownWidth = 189;
            this.genre_cmb.Location = new System.Drawing.Point(201, 120);
            this.genre_cmb.Name = "genre_cmb";
            this.genre_cmb.Size = new System.Drawing.Size(189, 21);
            this.genre_cmb.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_cmb.TabIndex = 80;
            // 
            // AdminMovieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.genre_cmb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.title_tb);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.details_lbl);
            this.Name = "AdminMovieControl";
            this.Size = new System.Drawing.Size(792, 518);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genre_cmb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton remove_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton insert_btn;
        private System.Windows.Forms.Label details_lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonButton submit_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox title_tb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox genre_cmb;
    }
}
