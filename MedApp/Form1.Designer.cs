
namespace MedApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PatientButton = new Krypton.Toolkit.KryptonButton();
            this.DoctorButton = new Krypton.Toolkit.KryptonButton();
            this.HomeButton = new Krypton.Toolkit.KryptonButton();
            this.LogoText = new System.Windows.Forms.Label();
            this.DoctorPanel = new System.Windows.Forms.Panel();
            this.DocId = new System.Windows.Forms.Label();
            this.DeleteDoctorButton = new Krypton.Toolkit.KryptonButton();
            this.AddNewDoctor = new Krypton.Toolkit.KryptonButton();
            this.NewDoctorSpecBox = new System.Windows.Forms.TextBox();
            this.DoctorSpecTextNew = new System.Windows.Forms.Label();
            this.NewDoctorNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DoctorAddLabel = new System.Windows.Forms.Label();
            this.DoctorEditButton = new Krypton.Toolkit.KryptonButton();
            this.DocSpec = new System.Windows.Forms.TextBox();
            this.DocName = new System.Windows.Forms.TextBox();
            this.DoctorSpeLabel = new System.Windows.Forms.Label();
            this.DoctorNameLabel = new System.Windows.Forms.Label();
            this.DoctorIdLabel = new System.Windows.Forms.Label();
            this.DoctorEditLabel = new System.Windows.Forms.Label();
            this.DoctorText = new System.Windows.Forms.Label();
            this.DoctorsList = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Nume = new System.Windows.Forms.ColumnHeader();
            this.Specialitate = new System.Windows.Forms.ColumnHeader();
            this.Pacienti = new System.Windows.Forms.ColumnHeader();
            this.HomePanel = new Krypton.Toolkit.KryptonPanel();
            this.HomeOnePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HomeTextArgumentOne = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HomeTextTwo = new System.Windows.Forms.Label();
            this.HomeTextOne = new System.Windows.Forms.Label();
            this.PatientPanel = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.PatiensBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.PatientNameText = new System.Windows.Forms.Label();
            this.AddPatient = new System.Windows.Forms.Label();
            this.Patiens = new System.Windows.Forms.Label();
            this.PatiensList = new System.Windows.Forms.ListView();
            this.Id_Pacient = new System.Windows.Forms.ColumnHeader();
            this.Patient_Name = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Id_Doc = new System.Windows.Forms.ColumnHeader();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DoctorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePanel)).BeginInit();
            this.HomePanel.SuspendLayout();
            this.HomeOnePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PatientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.White;
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Controls.Add(this.PatientButton);
            this.MenuPanel.Controls.Add(this.DoctorButton);
            this.MenuPanel.Controls.Add(this.HomeButton);
            this.MenuPanel.Controls.Add(this.LogoText);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(188, 450);
            this.MenuPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PatientButton
            // 
            this.PatientButton.Location = new System.Drawing.Point(3, 177);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.PatientButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.PatientButton.Size = new System.Drawing.Size(182, 40);
            this.PatientButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.PatientButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.PatientButton.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.PatientButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.PatientButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.PatientButton.StateCommon.Border.ColorAngle = 45F;
            this.PatientButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PatientButton.StateCommon.Border.Rounding = 20F;
            this.PatientButton.StateCommon.Border.Width = 1;
            this.PatientButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.PatientButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.PatientButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientButton.TabIndex = 3;
            this.PatientButton.Values.Text = "Pacienti";
            this.PatientButton.Click += new System.EventHandler(this.PatientButton_Click);
            // 
            // DoctorButton
            // 
            this.DoctorButton.Location = new System.Drawing.Point(3, 131);
            this.DoctorButton.Name = "DoctorButton";
            this.DoctorButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DoctorButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DoctorButton.Size = new System.Drawing.Size(182, 40);
            this.DoctorButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DoctorButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DoctorButton.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.DoctorButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DoctorButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DoctorButton.StateCommon.Border.ColorAngle = 45F;
            this.DoctorButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DoctorButton.StateCommon.Border.Rounding = 20F;
            this.DoctorButton.StateCommon.Border.Width = 1;
            this.DoctorButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.DoctorButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.DoctorButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoctorButton.TabIndex = 2;
            this.DoctorButton.Values.Text = "Medici";
            this.DoctorButton.Click += new System.EventHandler(this.DoctorButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(3, 85);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.HomeButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.HomeButton.Size = new System.Drawing.Size(182, 40);
            this.HomeButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.HomeButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.HomeButton.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.HomeButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.HomeButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.HomeButton.StateCommon.Border.ColorAngle = 45F;
            this.HomeButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.HomeButton.StateCommon.Border.Rounding = 20F;
            this.HomeButton.StateCommon.Border.Width = 1;
            this.HomeButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.HomeButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.HomeButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Values.Text = "Acasa";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LogoText
            // 
            this.LogoText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoText.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            this.LogoText.Location = new System.Drawing.Point(0, 0);
            this.LogoText.Name = "LogoText";
            this.LogoText.Size = new System.Drawing.Size(188, 82);
            this.LogoText.TabIndex = 0;
            this.LogoText.Text = "MedProject";
            this.LogoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoctorPanel
            // 
            this.DoctorPanel.Controls.Add(this.DocId);
            this.DoctorPanel.Controls.Add(this.DeleteDoctorButton);
            this.DoctorPanel.Controls.Add(this.AddNewDoctor);
            this.DoctorPanel.Controls.Add(this.NewDoctorSpecBox);
            this.DoctorPanel.Controls.Add(this.DoctorSpecTextNew);
            this.DoctorPanel.Controls.Add(this.NewDoctorNameBox);
            this.DoctorPanel.Controls.Add(this.label2);
            this.DoctorPanel.Controls.Add(this.DoctorAddLabel);
            this.DoctorPanel.Controls.Add(this.DoctorEditButton);
            this.DoctorPanel.Controls.Add(this.DocSpec);
            this.DoctorPanel.Controls.Add(this.DocName);
            this.DoctorPanel.Controls.Add(this.DoctorSpeLabel);
            this.DoctorPanel.Controls.Add(this.DoctorNameLabel);
            this.DoctorPanel.Controls.Add(this.DoctorIdLabel);
            this.DoctorPanel.Controls.Add(this.DoctorEditLabel);
            this.DoctorPanel.Controls.Add(this.DoctorText);
            this.DoctorPanel.Controls.Add(this.DoctorsList);
            this.DoctorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorPanel.Location = new System.Drawing.Point(0, 0);
            this.DoctorPanel.Name = "DoctorPanel";
            this.DoctorPanel.Size = new System.Drawing.Size(612, 450);
            this.DoctorPanel.TabIndex = 6;
            // 
            // DocId
            // 
            this.DocId.AutoSize = true;
            this.DocId.Location = new System.Drawing.Point(394, 68);
            this.DocId.Name = "DocId";
            this.DocId.Size = new System.Drawing.Size(0, 20);
            this.DocId.TabIndex = 32;
            // 
            // DeleteDoctorButton
            // 
            this.DeleteDoctorButton.Location = new System.Drawing.Point(519, 245);
            this.DeleteDoctorButton.Name = "DeleteDoctorButton";
            this.DeleteDoctorButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DeleteDoctorButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DeleteDoctorButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.DeleteDoctorButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.DeleteDoctorButton.Size = new System.Drawing.Size(80, 41);
            this.DeleteDoctorButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DeleteDoctorButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DeleteDoctorButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DeleteDoctorButton.StateCommon.Border.Rounding = 10F;
            this.DeleteDoctorButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.DeleteDoctorButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.DeleteDoctorButton.TabIndex = 31;
            this.DeleteDoctorButton.Values.Text = "Sterge";
            this.DeleteDoctorButton.Click += new System.EventHandler(this.DeleteDoctorButton_Click);
            // 
            // AddNewDoctor
            // 
            this.AddNewDoctor.Location = new System.Drawing.Point(493, 398);
            this.AddNewDoctor.Name = "AddNewDoctor";
            this.AddNewDoctor.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.AddNewDoctor.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.AddNewDoctor.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.AddNewDoctor.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.AddNewDoctor.Size = new System.Drawing.Size(106, 37);
            this.AddNewDoctor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.AddNewDoctor.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.AddNewDoctor.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddNewDoctor.StateCommon.Border.Rounding = 10F;
            this.AddNewDoctor.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.AddNewDoctor.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.AddNewDoctor.TabIndex = 30;
            this.AddNewDoctor.Values.Text = "Adaugare";
            this.AddNewDoctor.Click += new System.EventHandler(this.AddNewDoctor_Click);
            // 
            // NewDoctorSpecBox
            // 
            this.NewDoctorSpecBox.Location = new System.Drawing.Point(336, 404);
            this.NewDoctorSpecBox.Name = "NewDoctorSpecBox";
            this.NewDoctorSpecBox.Size = new System.Drawing.Size(142, 27);
            this.NewDoctorSpecBox.TabIndex = 29;
            // 
            // DoctorSpecTextNew
            // 
            this.DoctorSpecTextNew.AutoSize = true;
            this.DoctorSpecTextNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DoctorSpecTextNew.Location = new System.Drawing.Point(234, 404);
            this.DoctorSpecTextNew.Name = "DoctorSpecTextNew";
            this.DoctorSpecTextNew.Size = new System.Drawing.Size(96, 20);
            this.DoctorSpecTextNew.TabIndex = 28;
            this.DoctorSpecTextNew.Text = "Specializare :";
            // 
            // NewDoctorNameBox
            // 
            this.NewDoctorNameBox.Location = new System.Drawing.Point(76, 404);
            this.NewDoctorNameBox.Name = "NewDoctorNameBox";
            this.NewDoctorNameBox.Size = new System.Drawing.Size(142, 27);
            this.NewDoctorNameBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.label2.Location = new System.Drawing.Point(14, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nume :";
            // 
            // DoctorAddLabel
            // 
            this.DoctorAddLabel.AutoSize = true;
            this.DoctorAddLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoctorAddLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DoctorAddLabel.Location = new System.Drawing.Point(14, 362);
            this.DoctorAddLabel.Name = "DoctorAddLabel";
            this.DoctorAddLabel.Size = new System.Drawing.Size(142, 25);
            this.DoctorAddLabel.TabIndex = 25;
            this.DoctorAddLabel.Text = "Adaugare medic";
            // 
            // DoctorEditButton
            // 
            this.DoctorEditButton.Location = new System.Drawing.Point(394, 245);
            this.DoctorEditButton.Name = "DoctorEditButton";
            this.DoctorEditButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DoctorEditButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DoctorEditButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.DoctorEditButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.DoctorEditButton.Size = new System.Drawing.Size(112, 41);
            this.DoctorEditButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DoctorEditButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DoctorEditButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DoctorEditButton.StateCommon.Border.Rounding = 10F;
            this.DoctorEditButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.DoctorEditButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.DoctorEditButton.TabIndex = 24;
            this.DoctorEditButton.Values.Text = "Actualizare";
            this.DoctorEditButton.Click += new System.EventHandler(this.DoctorEditButton_Click);
            // 
            // DocSpec
            // 
            this.DocSpec.Location = new System.Drawing.Point(394, 203);
            this.DocSpec.Name = "DocSpec";
            this.DocSpec.Size = new System.Drawing.Size(205, 27);
            this.DocSpec.TabIndex = 23;
            // 
            // DocName
            // 
            this.DocName.Location = new System.Drawing.Point(394, 134);
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(205, 27);
            this.DocName.TabIndex = 22;
            // 
            // DoctorSpeLabel
            // 
            this.DoctorSpeLabel.AutoSize = true;
            this.DoctorSpeLabel.Location = new System.Drawing.Point(394, 180);
            this.DoctorSpeLabel.Name = "DoctorSpeLabel";
            this.DoctorSpeLabel.Size = new System.Drawing.Size(89, 20);
            this.DoctorSpeLabel.TabIndex = 21;
            this.DoctorSpeLabel.Text = "Specializare";
            // 
            // DoctorNameLabel
            // 
            this.DoctorNameLabel.AutoSize = true;
            this.DoctorNameLabel.Location = new System.Drawing.Point(394, 111);
            this.DoctorNameLabel.Name = "DoctorNameLabel";
            this.DoctorNameLabel.Size = new System.Drawing.Size(49, 20);
            this.DoctorNameLabel.TabIndex = 20;
            this.DoctorNameLabel.Text = "Nume";
            // 
            // DoctorIdLabel
            // 
            this.DoctorIdLabel.AutoSize = true;
            this.DoctorIdLabel.Location = new System.Drawing.Point(394, 42);
            this.DoctorIdLabel.Name = "DoctorIdLabel";
            this.DoctorIdLabel.Size = new System.Drawing.Size(22, 20);
            this.DoctorIdLabel.TabIndex = 19;
            this.DoctorIdLabel.Text = "Id";
            // 
            // DoctorEditLabel
            // 
            this.DoctorEditLabel.AutoSize = true;
            this.DoctorEditLabel.Location = new System.Drawing.Point(394, 15);
            this.DoctorEditLabel.Name = "DoctorEditLabel";
            this.DoctorEditLabel.Size = new System.Drawing.Size(105, 20);
            this.DoctorEditLabel.TabIndex = 18;
            this.DoctorEditLabel.Text = "Detalii medic :";
            // 
            // DoctorText
            // 
            this.DoctorText.AutoSize = true;
            this.DoctorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.DoctorText.Location = new System.Drawing.Point(14, 15);
            this.DoctorText.Name = "DoctorText";
            this.DoctorText.Size = new System.Drawing.Size(135, 20);
            this.DoctorText.TabIndex = 17;
            this.DoctorText.Text = "Medici disponibili :";
            // 
            // DoctorsList
            // 
            this.DoctorsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nume,
            this.Specialitate,
            this.Pacienti});
            this.DoctorsList.GridLines = true;
            this.DoctorsList.HideSelection = false;
            this.DoctorsList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DoctorsList.LabelWrap = false;
            this.DoctorsList.Location = new System.Drawing.Point(14, 38);
            this.DoctorsList.Name = "DoctorsList";
            this.DoctorsList.Size = new System.Drawing.Size(362, 291);
            this.DoctorsList.TabIndex = 16;
            this.DoctorsList.UseCompatibleStateImageBehavior = false;
            this.DoctorsList.View = System.Windows.Forms.View.Details;
            this.DoctorsList.SelectedIndexChanged += new System.EventHandler(this.DoctorsList_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 160;
            // 
            // Specialitate
            // 
            this.Specialitate.Text = "Specialitate";
            this.Specialitate.Width = 160;
            // 
            // Pacienti
            // 
            this.Pacienti.Text = "Nr. Pacienti";
            this.Pacienti.Width = 50;
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.HomeOnePanel);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(188, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(612, 450);
            this.HomePanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.HomePanel.StateDisabled.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.HomePanel.StateDisabled.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.HomePanel.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.HomePanel.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.HomePanel.TabIndex = 1;
            // 
            // HomeOnePanel
            // 
            this.HomeOnePanel.Controls.Add(this.PatientPanel);
            this.HomeOnePanel.Controls.Add(this.label1);
            this.HomeOnePanel.Controls.Add(this.HomeTextArgumentOne);
            this.HomeOnePanel.Controls.Add(this.pictureBox3);
            this.HomeOnePanel.Controls.Add(this.pictureBox2);
            this.HomeOnePanel.Controls.Add(this.HomeTextTwo);
            this.HomeOnePanel.Controls.Add(this.HomeTextOne);
            this.HomeOnePanel.Controls.Add(this.DoctorPanel);
            this.HomeOnePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeOnePanel.Location = new System.Drawing.Point(0, 0);
            this.HomeOnePanel.Name = "HomeOnePanel";
            this.HomeOnePanel.Size = new System.Drawing.Size(612, 450);
            this.HomeOnePanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.label1.Location = new System.Drawing.Point(141, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "O locație sigură și securizată pentru stocarea datelor\r\nmedicale ale fiecarui pac" +
    "ient pe termen lung.";
            // 
            // HomeTextArgumentOne
            // 
            this.HomeTextArgumentOne.AutoSize = true;
            this.HomeTextArgumentOne.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeTextArgumentOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.HomeTextArgumentOne.Location = new System.Drawing.Point(141, 217);
            this.HomeTextArgumentOne.Name = "HomeTextArgumentOne";
            this.HomeTextArgumentOne.Size = new System.Drawing.Size(425, 60);
            this.HomeTextArgumentOne.TabIndex = 16;
            this.HomeTextArgumentOne.Text = "Conceput pentru a vă ajuta afacerea de asistență medicală\r\nsă aibă succes într-o " +
    "lume digitală a asistenței medicale\r\nîn schimbare.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(46, 306);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // HomeTextTwo
            // 
            this.HomeTextTwo.AutoSize = true;
            this.HomeTextTwo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeTextTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.HomeTextTwo.Location = new System.Drawing.Point(93, 128);
            this.HomeTextTwo.Name = "HomeTextTwo";
            this.HomeTextTwo.Size = new System.Drawing.Size(438, 66);
            this.HomeTextTwo.TabIndex = 13;
            this.HomeTextTwo.Text = "MedProject reprezinta aplicatia perfecta de a gestiona\r\ninteractiunea dintre medi" +
    "ci si pacientii acestora\r\n\r\n";
            this.HomeTextTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeTextOne
            // 
            this.HomeTextOne.AutoSize = true;
            this.HomeTextOne.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeTextOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.HomeTextOne.Location = new System.Drawing.Point(136, 88);
            this.HomeTextOne.Name = "HomeTextOne";
            this.HomeTextOne.Size = new System.Drawing.Size(363, 35);
            this.HomeTextOne.TabIndex = 12;
            this.HomeTextOne.Text = "Ce reprezinta MedProject ?";
            // 
            // PatientPanel
            // 
            this.PatientPanel.Controls.Add(this.kryptonButton1);
            this.PatientPanel.Controls.Add(this.PatiensBox);
            this.PatientPanel.Controls.Add(this.label3);
            this.PatientPanel.Controls.Add(this.PatientName);
            this.PatientPanel.Controls.Add(this.PatientNameText);
            this.PatientPanel.Controls.Add(this.AddPatient);
            this.PatientPanel.Controls.Add(this.Patiens);
            this.PatientPanel.Controls.Add(this.PatiensList);
            this.PatientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientPanel.Location = new System.Drawing.Point(0, 0);
            this.PatientPanel.Name = "PatientPanel";
            this.PatientPanel.Size = new System.Drawing.Size(612, 450);
            this.PatientPanel.TabIndex = 8;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(507, 403);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.kryptonButton1.Size = new System.Drawing.Size(97, 27);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.kryptonButton1.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20F;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonButton1.TabIndex = 15;
            this.kryptonButton1.Values.Text = "Adauga";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click_1);
            // 
            // PatiensBox
            // 
            this.PatiensBox.FormattingEnabled = true;
            this.PatiensBox.Location = new System.Drawing.Point(331, 403);
            this.PatiensBox.Name = "PatiensBox";
            this.PatiensBox.Size = new System.Drawing.Size(170, 28);
            this.PatiensBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.label3.Location = new System.Drawing.Point(258, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Doctor :";
            // 
            // PatientName
            // 
            this.PatientName.Location = new System.Drawing.Point(82, 403);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(167, 27);
            this.PatientName.TabIndex = 12;
            // 
            // PatientNameText
            // 
            this.PatientNameText.AutoSize = true;
            this.PatientNameText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.PatientNameText.Location = new System.Drawing.Point(9, 408);
            this.PatientNameText.Name = "PatientNameText";
            this.PatientNameText.Size = new System.Drawing.Size(67, 22);
            this.PatientNameText.TabIndex = 11;
            this.PatientNameText.Text = "Nume :";
            // 
            // AddPatient
            // 
            this.AddPatient.AutoSize = true;
            this.AddPatient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.AddPatient.Location = new System.Drawing.Point(9, 372);
            this.AddPatient.Name = "AddPatient";
            this.AddPatient.Size = new System.Drawing.Size(132, 22);
            this.AddPatient.TabIndex = 10;
            this.AddPatient.Text = "Adauga pacient";
            // 
            // Patiens
            // 
            this.Patiens.AutoSize = true;
            this.Patiens.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Patiens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.Patiens.Location = new System.Drawing.Point(9, 19);
            this.Patiens.Name = "Patiens";
            this.Patiens.Size = new System.Drawing.Size(85, 22);
            this.Patiens.TabIndex = 9;
            this.Patiens.Text = "Pacienti :";
            // 
            // PatiensList
            // 
            this.PatiensList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_Pacient,
            this.Patient_Name,
            this.Date,
            this.Id_Doc});
            this.PatiensList.GridLines = true;
            this.PatiensList.HideSelection = false;
            this.PatiensList.Location = new System.Drawing.Point(9, 46);
            this.PatiensList.Name = "PatiensList";
            this.PatiensList.Size = new System.Drawing.Size(563, 306);
            this.PatiensList.TabIndex = 8;
            this.PatiensList.UseCompatibleStateImageBehavior = false;
            this.PatiensList.View = System.Windows.Forms.View.Details;
            // 
            // Id_Pacient
            // 
            this.Id_Pacient.Text = "Id";
            // 
            // Patient_Name
            // 
            this.Patient_Name.Text = "Nume";
            this.Patient_Name.Width = 150;
            // 
            // Date
            // 
            this.Date.Text = "Data internarii";
            this.Date.Width = 150;
            // 
            // Id_Doc
            // 
            this.Id_Doc.Text = "Doctor";
            this.Id_Doc.Width = 170;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "Form1";
            this.Text = "MedProject";
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DoctorPanel.ResumeLayout(false);
            this.DoctorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePanel)).EndInit();
            this.HomePanel.ResumeLayout(false);
            this.HomeOnePanel.ResumeLayout(false);
            this.HomeOnePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PatientPanel.ResumeLayout(false);
            this.PatientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label LogoText;
        private Krypton.Toolkit.KryptonButton HomeButton;
        private Krypton.Toolkit.KryptonButton PatientButton;
        private Krypton.Toolkit.KryptonButton DoctorButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel DoctorPanel;
        private Krypton.Toolkit.KryptonButton DeleteDoctorButton;
        private Krypton.Toolkit.KryptonButton AddNewDoctor;
        private System.Windows.Forms.TextBox NewDoctorSpecBox;
        private System.Windows.Forms.Label DoctorSpecTextNew;
        private System.Windows.Forms.TextBox NewDoctorNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DoctorAddLabel;
        private Krypton.Toolkit.KryptonButton DoctorEditButton;
        private System.Windows.Forms.TextBox DocSpec;
        private System.Windows.Forms.TextBox DocName;
        private System.Windows.Forms.Label DoctorSpeLabel;
        private System.Windows.Forms.Label DoctorNameLabel;
        private System.Windows.Forms.Label DoctorIdLabel;
        private System.Windows.Forms.Label DoctorEditLabel;
        private System.Windows.Forms.Label DoctorText;
        private System.Windows.Forms.ListView DoctorsList;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Specialitate;
        private System.Windows.Forms.ColumnHeader Pacienti;
        private Krypton.Toolkit.KryptonPanel HomePanel;
        private System.Windows.Forms.Panel HomeOnePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HomeTextArgumentOne;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label HomeTextTwo;
        private System.Windows.Forms.Label HomeTextOne;
        private System.Windows.Forms.Label DocId;
        private System.Windows.Forms.Panel PatientPanel;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.ComboBox PatiensBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.Label PatientNameText;
        private System.Windows.Forms.Label AddPatient;
        private System.Windows.Forms.Label Patiens;
        private System.Windows.Forms.ListView PatiensList;
        private System.Windows.Forms.ColumnHeader Id_Pacient;
        private System.Windows.Forms.ColumnHeader Patient_Name;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Id_Doc;
    }
}

