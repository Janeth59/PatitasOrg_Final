namespace patitasOrgMILAV
{
    partial class frmEncargadoVoluntarios
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
            btnCerrarEV = new Button();
            pictureBox2 = new PictureBox();
            tabControlEV = new TabControl();
            tbPConsultarEV = new TabPage();
            panel1 = new Panel();
            dgvInfoEV = new DataGridView();
            btnCargInfoEV = new Button();
            label1 = new Label();
            tbPRegistrarEV = new TabPage();
            panel2 = new Panel();
            txtEdadREV = new TextBox();
            label9 = new Label();
            txtIdREV = new TextBox();
            label8 = new Label();
            txtAreaREV = new TextBox();
            txtContactoREV = new TextBox();
            txtApellido2REV = new TextBox();
            txtApellido1REV = new TextBox();
            txtNombreREV = new TextBox();
            label7 = new Label();
            btnGuardarREV = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbPActualizarEV = new TabPage();
            panel5 = new Panel();
            btnBuscarAEV = new Button();
            txtBuscarIdAEV = new TextBox();
            label18 = new Label();
            label19 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            txtEdadAEV = new TextBox();
            label10 = new Label();
            txtIdAEV = new TextBox();
            label11 = new Label();
            txtAreaAEV = new TextBox();
            txtContactoAEV = new TextBox();
            txtApellido2AEV = new TextBox();
            txtApellido1AEV = new TextBox();
            txtNombreAEV = new TextBox();
            label12 = new Label();
            btnGuardarAEV = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            tbPEliminarEV = new TabPage();
            panel7 = new Panel();
            panel6 = new Panel();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            btnEliminarEV = new Button();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            btnBuscarEEV = new Button();
            txtBuscIdEEV = new TextBox();
            label28 = new Label();
            label29 = new Label();
            panel8 = new Panel();
            txtEdadEEV = new TextBox();
            label30 = new Label();
            txtIDEEV = new TextBox();
            label31 = new Label();
            txtAreaEEV = new TextBox();
            txtContactoEEV = new TextBox();
            txtApellido2EEV = new TextBox();
            txtApellido1EEV = new TextBox();
            txtNombreEEV = new TextBox();
            label32 = new Label();
            btnGuardarEEV = new Button();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            btnBuscEEV = new Button();
            txtIDBuscarEEV = new TextBox();
            label38 = new Label();
            label39 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControlEV.SuspendLayout();
            tbPConsultarEV.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfoEV).BeginInit();
            tbPRegistrarEV.SuspendLayout();
            panel2.SuspendLayout();
            tbPActualizarEV.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            tbPEliminarEV.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrarEV
            // 
            btnCerrarEV.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarEV.Location = new Point(615, 37);
            btnCerrarEV.Name = "btnCerrarEV";
            btnCerrarEV.Size = new Size(87, 44);
            btnCerrarEV.TabIndex = 8;
            btnCerrarEV.Text = "Cerrar Sesion";
            btnCerrarEV.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LogoMILAV_Final;
            pictureBox2.InitialImage = Properties.Resources.LogoMILAV_Final;
            pictureBox2.Location = new Point(615, 235);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // tabControlEV
            // 
            tabControlEV.Controls.Add(tbPConsultarEV);
            tabControlEV.Controls.Add(tbPRegistrarEV);
            tabControlEV.Controls.Add(tbPActualizarEV);
            tabControlEV.Controls.Add(tbPEliminarEV);
            tabControlEV.Location = new Point(12, 12);
            tabControlEV.Name = "tabControlEV";
            tabControlEV.SelectedIndex = 0;
            tabControlEV.Size = new Size(597, 335);
            tabControlEV.TabIndex = 9;
            // 
            // tbPConsultarEV
            // 
            tbPConsultarEV.BackColor = Color.White;
            tbPConsultarEV.Controls.Add(panel1);
            tbPConsultarEV.Location = new Point(4, 24);
            tbPConsultarEV.Name = "tbPConsultarEV";
            tbPConsultarEV.Padding = new Padding(3);
            tbPConsultarEV.Size = new Size(589, 307);
            tbPConsultarEV.TabIndex = 0;
            tbPConsultarEV.Text = "Consultar";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvInfoEV);
            panel1.Controls.Add(btnCargInfoEV);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 307);
            panel1.TabIndex = 0;
            // 
            // dgvInfoEV
            // 
            dgvInfoEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfoEV.Location = new Point(15, 92);
            dgvInfoEV.Name = "dgvInfoEV";
            dgvInfoEV.Size = new Size(541, 193);
            dgvInfoEV.TabIndex = 8;
            // 
            // btnCargInfoEV
            // 
            btnCargInfoEV.Location = new Point(471, 19);
            btnCargInfoEV.Name = "btnCargInfoEV";
            btnCargInfoEV.Size = new Size(96, 53);
            btnCargInfoEV.TabIndex = 7;
            btnCargInfoEV.Text = "Cargar infromacion";
            btnCargInfoEV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 35);
            label1.Name = "label1";
            label1.Size = new Size(404, 18);
            label1.TabIndex = 6;
            label1.Text = "Consulta aqui la informacion sobre los animales";
            // 
            // tbPRegistrarEV
            // 
            tbPRegistrarEV.Controls.Add(panel2);
            tbPRegistrarEV.Location = new Point(4, 24);
            tbPRegistrarEV.Name = "tbPRegistrarEV";
            tbPRegistrarEV.Padding = new Padding(3);
            tbPRegistrarEV.Size = new Size(589, 307);
            tbPRegistrarEV.TabIndex = 1;
            tbPRegistrarEV.Text = "Registrar";
            tbPRegistrarEV.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtEdadREV);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtIdREV);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtAreaREV);
            panel2.Controls.Add(txtContactoREV);
            panel2.Controls.Add(txtApellido2REV);
            panel2.Controls.Add(txtApellido1REV);
            panel2.Controls.Add(txtNombreREV);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnGuardarREV);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 310);
            panel2.TabIndex = 0;
            // 
            // txtEdadREV
            // 
            txtEdadREV.Location = new Point(25, 250);
            txtEdadREV.Name = "txtEdadREV";
            txtEdadREV.Size = new Size(152, 23);
            txtEdadREV.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 222);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 40;
            label9.Text = "Edad: ";
            // 
            // txtIdREV
            // 
            txtIdREV.Location = new Point(407, 178);
            txtIdREV.Name = "txtIdREV";
            txtIdREV.Size = new Size(152, 23);
            txtIdREV.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(223, 148);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 38;
            label8.Text = "Area de voluntariado:";
            // 
            // txtAreaREV
            // 
            txtAreaREV.Location = new Point(223, 178);
            txtAreaREV.Name = "txtAreaREV";
            txtAreaREV.Size = new Size(150, 23);
            txtAreaREV.TabIndex = 37;
            // 
            // txtContactoREV
            // 
            txtContactoREV.Location = new Point(24, 178);
            txtContactoREV.Name = "txtContactoREV";
            txtContactoREV.Size = new Size(152, 23);
            txtContactoREV.TabIndex = 36;
            // 
            // txtApellido2REV
            // 
            txtApellido2REV.Location = new Point(407, 97);
            txtApellido2REV.Name = "txtApellido2REV";
            txtApellido2REV.Size = new Size(156, 23);
            txtApellido2REV.TabIndex = 35;
            // 
            // txtApellido1REV
            // 
            txtApellido1REV.Location = new Point(223, 97);
            txtApellido1REV.Name = "txtApellido1REV";
            txtApellido1REV.Size = new Size(152, 23);
            txtApellido1REV.TabIndex = 34;
            // 
            // txtNombreREV
            // 
            txtNombreREV.Location = new Point(24, 97);
            txtNombreREV.Name = "txtNombreREV";
            txtNombreREV.Size = new Size(157, 23);
            txtNombreREV.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 148);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 32;
            label7.Text = "ID:";
            // 
            // btnGuardarREV
            // 
            btnGuardarREV.Location = new Point(359, 250);
            btnGuardarREV.Name = "btnGuardarREV";
            btnGuardarREV.Size = new Size(84, 31);
            btnGuardarREV.TabIndex = 31;
            btnGuardarREV.Text = "Guardar.";
            btnGuardarREV.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 150);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 30;
            label6.Text = "Contacto: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(411, 69);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 29;
            label5.Text = "Apellido 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 64);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 28;
            label4.Text = "Apellido 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 69);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 27;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(203, 13);
            label2.Name = "label2";
            label2.Size = new Size(199, 18);
            label2.TabIndex = 26;
            label2.Text = "Registro de voluntarios";
            // 
            // tbPActualizarEV
            // 
            tbPActualizarEV.BackColor = Color.White;
            tbPActualizarEV.Controls.Add(panel5);
            tbPActualizarEV.Controls.Add(panel3);
            tbPActualizarEV.Location = new Point(4, 24);
            tbPActualizarEV.Name = "tbPActualizarEV";
            tbPActualizarEV.Size = new Size(589, 307);
            tbPActualizarEV.TabIndex = 2;
            tbPActualizarEV.Text = "Actualizar";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnBuscarAEV);
            panel5.Controls.Add(txtBuscarIdAEV);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label19);
            panel5.Location = new Point(422, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(167, 307);
            panel5.TabIndex = 1;
            // 
            // btnBuscarAEV
            // 
            btnBuscarAEV.Location = new Point(49, 243);
            btnBuscarAEV.Name = "btnBuscarAEV";
            btnBuscarAEV.Size = new Size(75, 23);
            btnBuscarAEV.TabIndex = 34;
            btnBuscarAEV.Text = "Buscar.";
            btnBuscarAEV.UseVisualStyleBackColor = true;
            // 
            // txtBuscarIdAEV
            // 
            txtBuscarIdAEV.Location = new Point(39, 154);
            txtBuscarIdAEV.Name = "txtBuscarIdAEV";
            txtBuscarIdAEV.Size = new Size(100, 23);
            txtBuscarIdAEV.TabIndex = 33;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(39, 126);
            label18.Name = "label18";
            label18.Size = new Size(97, 15);
            label18.TabIndex = 32;
            label18.Text = "ID del voluntario:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(49, 27);
            label19.Name = "label19";
            label19.Size = new Size(66, 18);
            label19.TabIndex = 31;
            label19.Text = "Buscar.";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(txtEdadAEV);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtIdAEV);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtAreaAEV);
            panel3.Controls.Add(txtContactoAEV);
            panel3.Controls.Add(txtApellido2AEV);
            panel3.Controls.Add(txtApellido1AEV);
            panel3.Controls.Add(txtNombreAEV);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(btnGuardarAEV);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label17);
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(423, 306);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Location = new Point(422, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(167, 304);
            panel4.TabIndex = 1;
            // 
            // txtEdadAEV
            // 
            txtEdadAEV.Location = new Point(33, 242);
            txtEdadAEV.Name = "txtEdadAEV";
            txtEdadAEV.Size = new Size(113, 23);
            txtEdadAEV.TabIndex = 57;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 214);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 56;
            label10.Text = "Edad: ";
            // 
            // txtIdAEV
            // 
            txtIdAEV.Location = new Point(292, 168);
            txtIdAEV.Name = "txtIdAEV";
            txtIdAEV.Size = new Size(110, 23);
            txtIdAEV.TabIndex = 55;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(157, 140);
            label11.Name = "label11";
            label11.Size = new Size(120, 15);
            label11.TabIndex = 54;
            label11.Text = "Area de voluntariado:";
            // 
            // txtAreaAEV
            // 
            txtAreaAEV.Location = new Point(164, 168);
            txtAreaAEV.Name = "txtAreaAEV";
            txtAreaAEV.Size = new Size(113, 23);
            txtAreaAEV.TabIndex = 53;
            // 
            // txtContactoAEV
            // 
            txtContactoAEV.Location = new Point(33, 168);
            txtContactoAEV.Name = "txtContactoAEV";
            txtContactoAEV.Size = new Size(113, 23);
            txtContactoAEV.TabIndex = 52;
            // 
            // txtApellido2AEV
            // 
            txtApellido2AEV.Location = new Point(292, 97);
            txtApellido2AEV.Name = "txtApellido2AEV";
            txtApellido2AEV.Size = new Size(110, 23);
            txtApellido2AEV.TabIndex = 51;
            // 
            // txtApellido1AEV
            // 
            txtApellido1AEV.Location = new Point(164, 97);
            txtApellido1AEV.Name = "txtApellido1AEV";
            txtApellido1AEV.Size = new Size(113, 23);
            txtApellido1AEV.TabIndex = 50;
            // 
            // txtNombreAEV
            // 
            txtNombreAEV.Location = new Point(32, 97);
            txtNombreAEV.Name = "txtNombreAEV";
            txtNombreAEV.Size = new Size(114, 23);
            txtNombreAEV.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(292, 138);
            label12.Name = "label12";
            label12.Size = new Size(21, 15);
            label12.TabIndex = 48;
            label12.Text = "ID:";
            // 
            // btnGuardarAEV
            // 
            btnGuardarAEV.Location = new Point(239, 234);
            btnGuardarAEV.Name = "btnGuardarAEV";
            btnGuardarAEV.Size = new Size(84, 31);
            btnGuardarAEV.TabIndex = 47;
            btnGuardarAEV.Text = "Guardar.";
            btnGuardarAEV.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 140);
            label13.Name = "label13";
            label13.Size = new Size(62, 15);
            label13.TabIndex = 46;
            label13.Text = "Contacto: ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(296, 69);
            label14.Name = "label14";
            label14.Size = new Size(63, 15);
            label14.TabIndex = 45;
            label14.Text = "Apellido 2:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(164, 64);
            label15.Name = "label15";
            label15.Size = new Size(63, 15);
            label15.TabIndex = 44;
            label15.Text = "Apellido 1:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(33, 69);
            label16.Name = "label16";
            label16.Size = new Size(54, 15);
            label16.TabIndex = 43;
            label16.Text = "Nombre:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(64, 17);
            label17.Name = "label17";
            label17.Size = new Size(313, 18);
            label17.TabIndex = 42;
            label17.Text = "Actualizar informacion de voluntarios";
            // 
            // tbPEliminarEV
            // 
            tbPEliminarEV.Controls.Add(panel8);
            tbPEliminarEV.Controls.Add(panel7);
            tbPEliminarEV.Controls.Add(panel6);
            tbPEliminarEV.Location = new Point(4, 24);
            tbPEliminarEV.Name = "tbPEliminarEV";
            tbPEliminarEV.Size = new Size(589, 307);
            tbPEliminarEV.TabIndex = 3;
            tbPEliminarEV.Text = "Eliminar";
            tbPEliminarEV.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtEdadEEV);
            panel7.Controls.Add(label30);
            panel7.Controls.Add(txtIDEEV);
            panel7.Controls.Add(label31);
            panel7.Controls.Add(txtAreaEEV);
            panel7.Controls.Add(txtContactoEEV);
            panel7.Controls.Add(txtApellido2EEV);
            panel7.Controls.Add(txtApellido1EEV);
            panel7.Controls.Add(txtNombreEEV);
            panel7.Controls.Add(label32);
            panel7.Controls.Add(btnGuardarEEV);
            panel7.Controls.Add(label33);
            panel7.Controls.Add(label34);
            panel7.Controls.Add(label35);
            panel7.Controls.Add(label36);
            panel7.Controls.Add(label37);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(419, 307);
            panel7.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 100);
            panel6.TabIndex = 1;
            // 
            // label20
            // 
            label20.Location = new Point(0, 0);
            label20.Name = "label20";
            label20.Size = new Size(100, 23);
            label20.TabIndex = 0;
            // 
            // label21
            // 
            label21.Location = new Point(0, 0);
            label21.Name = "label21";
            label21.Size = new Size(100, 23);
            label21.TabIndex = 0;
            // 
            // label22
            // 
            label22.Location = new Point(0, 0);
            label22.Name = "label22";
            label22.Size = new Size(100, 23);
            label22.TabIndex = 0;
            // 
            // btnEliminarEV
            // 
            btnEliminarEV.Location = new Point(0, 0);
            btnEliminarEV.Name = "btnEliminarEV";
            btnEliminarEV.Size = new Size(75, 23);
            btnEliminarEV.TabIndex = 0;
            // 
            // label23
            // 
            label23.Location = new Point(0, 0);
            label23.Name = "label23";
            label23.Size = new Size(100, 23);
            label23.TabIndex = 0;
            // 
            // label24
            // 
            label24.Location = new Point(0, 0);
            label24.Name = "label24";
            label24.Size = new Size(100, 23);
            label24.TabIndex = 0;
            // 
            // label25
            // 
            label25.Location = new Point(0, 0);
            label25.Name = "label25";
            label25.Size = new Size(100, 23);
            label25.TabIndex = 0;
            // 
            // label26
            // 
            label26.Location = new Point(0, 0);
            label26.Name = "label26";
            label26.Size = new Size(100, 23);
            label26.TabIndex = 0;
            // 
            // label27
            // 
            label27.Location = new Point(0, 0);
            label27.Name = "label27";
            label27.Size = new Size(100, 23);
            label27.TabIndex = 0;
            // 
            // btnBuscarEEV
            // 
            btnBuscarEEV.Location = new Point(0, 0);
            btnBuscarEEV.Name = "btnBuscarEEV";
            btnBuscarEEV.Size = new Size(75, 23);
            btnBuscarEEV.TabIndex = 0;
            // 
            // txtBuscIdEEV
            // 
            txtBuscIdEEV.Location = new Point(0, 0);
            txtBuscIdEEV.Name = "txtBuscIdEEV";
            txtBuscIdEEV.Size = new Size(100, 23);
            txtBuscIdEEV.TabIndex = 0;
            // 
            // label28
            // 
            label28.Location = new Point(0, 0);
            label28.Name = "label28";
            label28.Size = new Size(100, 23);
            label28.TabIndex = 0;
            // 
            // label29
            // 
            label29.Location = new Point(0, 0);
            label29.Name = "label29";
            label29.Size = new Size(100, 23);
            label29.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnBuscEEV);
            panel8.Controls.Add(txtIDBuscarEEV);
            panel8.Controls.Add(label38);
            panel8.Controls.Add(label39);
            panel8.Location = new Point(418, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(171, 307);
            panel8.TabIndex = 2;
            // 
            // txtEdadEEV
            // 
            txtEdadEEV.Location = new Point(25, 254);
            txtEdadEEV.Name = "txtEdadEEV";
            txtEdadEEV.Size = new Size(113, 23);
            txtEdadEEV.TabIndex = 73;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(25, 226);
            label30.Name = "label30";
            label30.Size = new Size(39, 15);
            label30.TabIndex = 72;
            label30.Text = "Edad: ";
            // 
            // txtIDEEV
            // 
            txtIDEEV.Location = new Point(284, 180);
            txtIDEEV.Name = "txtIDEEV";
            txtIDEEV.Size = new Size(110, 23);
            txtIDEEV.TabIndex = 71;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(149, 152);
            label31.Name = "label31";
            label31.Size = new Size(120, 15);
            label31.TabIndex = 70;
            label31.Text = "Area de voluntariado:";
            // 
            // txtAreaEEV
            // 
            txtAreaEEV.Location = new Point(156, 180);
            txtAreaEEV.Name = "txtAreaEEV";
            txtAreaEEV.Size = new Size(113, 23);
            txtAreaEEV.TabIndex = 69;
            // 
            // txtContactoEEV
            // 
            txtContactoEEV.Location = new Point(25, 180);
            txtContactoEEV.Name = "txtContactoEEV";
            txtContactoEEV.Size = new Size(113, 23);
            txtContactoEEV.TabIndex = 68;
            // 
            // txtApellido2EEV
            // 
            txtApellido2EEV.Location = new Point(284, 109);
            txtApellido2EEV.Name = "txtApellido2EEV";
            txtApellido2EEV.Size = new Size(110, 23);
            txtApellido2EEV.TabIndex = 67;
            // 
            // txtApellido1EEV
            // 
            txtApellido1EEV.Location = new Point(156, 109);
            txtApellido1EEV.Name = "txtApellido1EEV";
            txtApellido1EEV.Size = new Size(113, 23);
            txtApellido1EEV.TabIndex = 66;
            // 
            // txtNombreEEV
            // 
            txtNombreEEV.Location = new Point(24, 109);
            txtNombreEEV.Name = "txtNombreEEV";
            txtNombreEEV.Size = new Size(114, 23);
            txtNombreEEV.TabIndex = 65;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(284, 150);
            label32.Name = "label32";
            label32.Size = new Size(21, 15);
            label32.TabIndex = 64;
            label32.Text = "ID:";
            // 
            // btnGuardarEEV
            // 
            btnGuardarEEV.Location = new Point(231, 246);
            btnGuardarEEV.Name = "btnGuardarEEV";
            btnGuardarEEV.Size = new Size(84, 31);
            btnGuardarEEV.TabIndex = 63;
            btnGuardarEEV.Text = "Guardar.";
            btnGuardarEEV.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(25, 152);
            label33.Name = "label33";
            label33.Size = new Size(62, 15);
            label33.TabIndex = 62;
            label33.Text = "Contacto: ";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(288, 81);
            label34.Name = "label34";
            label34.Size = new Size(63, 15);
            label34.TabIndex = 61;
            label34.Text = "Apellido 2:";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(156, 76);
            label35.Name = "label35";
            label35.Size = new Size(63, 15);
            label35.TabIndex = 60;
            label35.Text = "Apellido 1:";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(25, 81);
            label36.Name = "label36";
            label36.Size = new Size(54, 15);
            label36.TabIndex = 59;
            label36.Text = "Nombre:";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label37.Location = new Point(56, 29);
            label37.Name = "label37";
            label37.Size = new Size(298, 18);
            label37.TabIndex = 58;
            label37.Text = "Eliminar informacion de voluntarios";
            // 
            // btnBuscEEV
            // 
            btnBuscEEV.Location = new Point(42, 249);
            btnBuscEEV.Name = "btnBuscEEV";
            btnBuscEEV.Size = new Size(75, 23);
            btnBuscEEV.TabIndex = 38;
            btnBuscEEV.Text = "Buscar.";
            btnBuscEEV.UseVisualStyleBackColor = true;
            // 
            // txtIDBuscarEEV
            // 
            txtIDBuscarEEV.Location = new Point(32, 160);
            txtIDBuscarEEV.Name = "txtIDBuscarEEV";
            txtIDBuscarEEV.Size = new Size(100, 23);
            txtIDBuscarEEV.TabIndex = 37;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(32, 132);
            label38.Name = "label38";
            label38.Size = new Size(97, 15);
            label38.TabIndex = 36;
            label38.Text = "ID del voluntario:";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label39.Location = new Point(42, 33);
            label39.Name = "label39";
            label39.Size = new Size(66, 18);
            label39.TabIndex = 35;
            label39.Text = "Buscar.";
            // 
            // frmEncargadoVoluntarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 359);
            Controls.Add(tabControlEV);
            Controls.Add(btnCerrarEV);
            Controls.Add(pictureBox2);
            Name = "frmEncargadoVoluntarios";
            Text = "frmEncargadoVoluntarios";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControlEV.ResumeLayout(false);
            tbPConsultarEV.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfoEV).EndInit();
            tbPRegistrarEV.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tbPActualizarEV.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tbPEliminarEV.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrarEV;
        private PictureBox pictureBox2;
        private TabControl tabControlEV;
        private TabPage tbPConsultarEV;
        private TabPage tbPRegistrarEV;
        private TabPage tbPActualizarEV;
        private TabPage tbPEliminarEV;
        private Panel panel1;
        private Button btnCargInfoEV;
        private Label label1;
        private DataGridView dgvInfoEV;
        private Panel panel2;
        private TextBox txtIdREV;
        private Label label8;
        private TextBox txtAreaREV;
        private TextBox txtContactoREV;
        private TextBox txtApellido2REV;
        private TextBox txtApellido1REV;
        private TextBox txtNombreREV;
        private Label label7;
        private Button btnGuardarREV;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEdadREV;
        private Label label9;
        private Panel panel3;
        private TextBox txtEdadAEV;
        private Label label10;
        private TextBox txtIdAEV;
        private Label label11;
        private TextBox txtAreaAEV;
        private TextBox txtContactoAEV;
        private TextBox txtApellido2AEV;
        private TextBox txtApellido1AEV;
        private TextBox txtNombreAEV;
        private Label label12;
        private Button btnGuardarAEV;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Panel panel4;
        private Panel panel5;
        private Button btnBuscarAEV;
        private TextBox txtBuscarIdAEV;
        private Label label18;
        private Label label19;
        private Panel panel6;
        private TextBox txtEdadEEV;
        private Label label20;
        private TextBox txtIDEEV;
        private Label label21;
        private TextBox txtAreaEEV;
        private TextBox txtContactoEEV;
        private TextBox txtApellido2EEV;
        private TextBox txtApellido1EEV;
        private TextBox txtNombreEEV;
        private Label label22;
        private Button btnEliminarEV;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Panel panel7;
        private Button btnBuscarEEV;
        private TextBox txtBuscIdEEV;
        private Label label28;
        private Label label29;
        private Panel panel8;
        private Button btnBuscEEV;
        private TextBox txtIDBuscarEEV;
        private Label label38;
        private Label label39;
        private Label label30;
        private Label label31;
        private Label label32;
        private Button btnGuardarEEV;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
    }
}