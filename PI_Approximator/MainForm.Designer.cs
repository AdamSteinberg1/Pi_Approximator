namespace PI_Approximator2
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numSidesBox = new System.Windows.Forms.TextBox();
            this.InnerLabel = new System.Windows.Forms.Label();
            this.Approx = new System.Windows.Forms.Label();
            this.Iteration = new System.Windows.Forms.Label();
            this.Increment = new System.Windows.Forms.Button();
            this.Decrement = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OuterLabel = new System.Windows.Forms.Label();
            this.attribution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numSidesBox
            // 
            this.numSidesBox.Location = new System.Drawing.Point(157, 57);
            this.numSidesBox.Name = "numSidesBox";
            this.numSidesBox.Size = new System.Drawing.Size(32, 20);
            this.numSidesBox.TabIndex = 0;
            this.numSidesBox.TabStop = false;
            this.numSidesBox.Text = "3";
            this.toolTip1.SetToolTip(this.numSidesBox, "Press Enter to Draw");
            this.numSidesBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numSidesBox_KeyPress);
            this.numSidesBox.Leave += new System.EventHandler(this.numSidesBox_Leave);
            // 
            // InnerLabel
            // 
            this.InnerLabel.AutoSize = true;
            this.InnerLabel.Location = new System.Drawing.Point(25, 9);
            this.InnerLabel.Name = "InnerLabel";
            this.InnerLabel.Size = new System.Drawing.Size(103, 13);
            this.InnerLabel.TabIndex = 2;
            this.InnerLabel.Text = "Inscribed Perimeter: ";
            // 
            // Approx
            // 
            this.Approx.AutoSize = true;
            this.Approx.Location = new System.Drawing.Point(3, 43);
            this.Approx.Name = "Approx";
            this.Approx.Size = new System.Drawing.Size(125, 13);
            this.Approx.TabIndex = 3;
            this.Approx.Text = "Current π Approximation: ";
            // 
            // Iteration
            // 
            this.Iteration.AutoSize = true;
            this.Iteration.Location = new System.Drawing.Point(37, 60);
            this.Iteration.Name = "Iteration";
            this.Iteration.Size = new System.Drawing.Size(88, 13);
            this.Iteration.TabIndex = 4;
            this.Iteration.Text = "Number of Sides:";
            // 
            // Increment
            // 
            this.Increment.BackgroundImage = global::PI_Approximator2.Properties.Resources.iconfinder_plus_172525;
            this.Increment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Increment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Increment.Location = new System.Drawing.Point(195, 56);
            this.Increment.Name = "Increment";
            this.Increment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Increment.Size = new System.Drawing.Size(20, 20);
            this.Increment.TabIndex = 5;
            this.Increment.TabStop = false;
            this.Increment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Increment.UseVisualStyleBackColor = true;
            this.Increment.Click += new System.EventHandler(this.Increment_Click);
            // 
            // Decrement
            // 
            this.Decrement.BackgroundImage = global::PI_Approximator2.Properties.Resources.iconfinder_minus_172505;
            this.Decrement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Decrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrement.Location = new System.Drawing.Point(131, 56);
            this.Decrement.Name = "Decrement";
            this.Decrement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Decrement.Size = new System.Drawing.Size(20, 20);
            this.Decrement.TabIndex = 6;
            this.Decrement.TabStop = false;
            this.Decrement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Decrement.UseVisualStyleBackColor = true;
            this.Decrement.Click += new System.EventHandler(this.Decrement_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // OuterLabel
            // 
            this.OuterLabel.AutoSize = true;
            this.OuterLabel.Location = new System.Drawing.Point(2, 26);
            this.OuterLabel.Name = "OuterLabel";
            this.OuterLabel.Size = new System.Drawing.Size(126, 13);
            this.OuterLabel.TabIndex = 7;
            this.OuterLabel.Text = "Circumscribed Perimeter: ";
            // 
            // attribution
            // 
            this.attribution.AutoSize = true;
            this.attribution.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.attribution.Location = new System.Drawing.Point(0, 527);
            this.attribution.Name = "attribution";
            this.attribution.Size = new System.Drawing.Size(136, 13);
            this.attribution.TabIndex = 8;
            this.attribution.Text = "Created by Adam Steinberg";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1092, 540);
            this.Controls.Add(this.attribution);
            this.Controls.Add(this.OuterLabel);
            this.Controls.Add(this.Decrement);
            this.Controls.Add(this.Increment);
            this.Controls.Add(this.Iteration);
            this.Controls.Add(this.Approx);
            this.Controls.Add(this.InnerLabel);
            this.Controls.Add(this.numSidesBox);
            this.Name = "MainForm";
            this.Text = "Pi Approximator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ClientSizeChanged += new System.EventHandler(this.MainForm_ClientSizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numSidesBox;
        private System.Windows.Forms.Label InnerLabel;
        private System.Windows.Forms.Label Approx;
        private System.Windows.Forms.Label Iteration;
        private System.Windows.Forms.Button Increment;
        private System.Windows.Forms.Button Decrement;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label OuterLabel;
        private System.Windows.Forms.Label attribution;
    }
}

