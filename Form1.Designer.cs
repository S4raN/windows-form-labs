namespace PolylineApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.NumericUpDown numericUpDownPoints;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Panel panelDraw;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownPoints = new System.Windows.Forms.NumericUpDown();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.panelDraw = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPoints
            // 
            this.numericUpDownPoints.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownPoints.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownPoints.Name = "numericUpDownPoints";
            this.numericUpDownPoints.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPoints.TabIndex = 0;
            this.numericUpDownPoints.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(138, 12);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(219, 12);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 2;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDraw.Location = new System.Drawing.Point(12, 41);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(776, 397);
            this.panelDraw.TabIndex = 3;
            this.panelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDraw_Paint);
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseMove);
            this.panelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseUp);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.numericUpDownPoints);
            this.Name = "Form1";
            this.Text = "Polyline App";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
