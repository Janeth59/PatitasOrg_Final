namespace patitasOrgMILAV
{
    partial class frmVoluntarios
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            menuStrip1 = new MenuStrip();
            áreaToolStripMenuItem = new ToolStripMenuItem();
            btnCerrarSessionVoluntarios = new Button();
            pictureBox2 = new PictureBox();
            campañasToolStripMenuItem = new ToolStripMenuItem();
            animalesToolStripMenuItem = new ToolStripMenuItem();
            veterinariaToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnInfoVoluntario = new Button();
            dgvVoluntarios = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVoluntarios).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(625, 374);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvVoluntarios);
            tabPage1.Controls.Add(btnInfoVoluntario);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(menuStrip1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(617, 346);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consultar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { áreaToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(611, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // áreaToolStripMenuItem
            // 
            áreaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { campañasToolStripMenuItem, animalesToolStripMenuItem, veterinariaToolStripMenuItem });
            áreaToolStripMenuItem.Name = "áreaToolStripMenuItem";
            áreaToolStripMenuItem.Size = new Size(43, 20);
            áreaToolStripMenuItem.Text = "Área";
            // 
            // btnCerrarSessionVoluntarios
            // 
            btnCerrarSessionVoluntarios.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSessionVoluntarios.Location = new Point(647, 39);
            btnCerrarSessionVoluntarios.Name = "btnCerrarSessionVoluntarios";
            btnCerrarSessionVoluntarios.Size = new Size(87, 44);
            btnCerrarSessionVoluntarios.TabIndex = 9;
            btnCerrarSessionVoluntarios.Text = "Cerrar Sesion";
            btnCerrarSessionVoluntarios.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LogoMILAV_Final;
            pictureBox2.InitialImage = Properties.Resources.LogoMILAV_Final;
            pictureBox2.Location = new Point(634, 260);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // campañasToolStripMenuItem
            // 
            campañasToolStripMenuItem.Name = "campañasToolStripMenuItem";
            campañasToolStripMenuItem.Size = new Size(180, 22);
            campañasToolStripMenuItem.Text = "Campañas";
            // 
            // animalesToolStripMenuItem
            // 
            animalesToolStripMenuItem.Name = "animalesToolStripMenuItem";
            animalesToolStripMenuItem.Size = new Size(180, 22);
            animalesToolStripMenuItem.Text = "Animales";
            // 
            // veterinariaToolStripMenuItem
            // 
            veterinariaToolStripMenuItem.Name = "veterinariaToolStripMenuItem";
            veterinariaToolStripMenuItem.Size = new Size(180, 22);
            veterinariaToolStripMenuItem.Text = "Veterinaria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 60);
            label1.Name = "label1";
            label1.Size = new Size(437, 25);
            label1.TabIndex = 1;
            label1.Text = "Consulta la informacion de tu area aqui.";
            // 
            // btnInfoVoluntario
            // 
            btnInfoVoluntario.Location = new Point(500, 53);
            btnInfoVoluntario.Name = "btnInfoVoluntario";
            btnInfoVoluntario.Size = new Size(89, 47);
            btnInfoVoluntario.TabIndex = 2;
            btnInfoVoluntario.Text = "Cargar informacion";
            btnInfoVoluntario.UseVisualStyleBackColor = true;
            // 
            // dgvVoluntarios
            // 
            dgvVoluntarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVoluntarios.Location = new Point(39, 137);
            dgvVoluntarios.Name = "dgvVoluntarios";
            dgvVoluntarios.Size = new Size(535, 167);
            dgvVoluntarios.TabIndex = 3;
            // 
            // frmVoluntarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 374);
            Controls.Add(btnCerrarSessionVoluntarios);
            Controls.Add(pictureBox2);
            Controls.Add(tabControl1);
            MainMenuStrip = menuStrip1;
            Name = "frmVoluntarios";
            Text = "frmVoluntarios";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVoluntarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem áreaToolStripMenuItem;
        private Button btnCerrarSessionVoluntarios;
        private PictureBox pictureBox2;
        private ToolStripMenuItem campañasToolStripMenuItem;
        private ToolStripMenuItem animalesToolStripMenuItem;
        private ToolStripMenuItem veterinariaToolStripMenuItem;
        private Button btnInfoVoluntario;
        private Label label1;
        private DataGridView dgvVoluntarios;
    }
}