
namespace CapaDePresentacion
{
    partial class Contenedor
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
            this.tabControlContenedor = new System.Windows.Forms.TabControl();
            this.Ingresar = new System.Windows.Forms.TabPage();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGuarda = new System.Windows.Forms.Button();
            this.labelCantidadIngresar = new System.Windows.Forms.Label();
            this.labelValorIngresar = new System.Windows.Forms.Label();
            this.labelDescripcionIngresar = new System.Windows.Forms.Label();
            this.LabelCodigoIngresar = new System.Windows.Forms.Label();
            this.textBox4Cantidad = new System.Windows.Forms.TextBox();
            this.textBox3Valor = new System.Windows.Forms.TextBox();
            this.textBox2Descripcion = new System.Windows.Forms.TextBox();
            this.textBox1Codigo = new System.Windows.Forms.TextBox();
            this.Consultar = new System.Windows.Forms.TabPage();
            this.tablaResultadosConsulta = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Modificar = new System.Windows.Forms.TabPage();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelProductoModificar = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.labelProdcutoEliminar = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel1CustomerField = new System.Windows.Forms.Panel();
            this.textBox5EmailCliente = new System.Windows.Forms.TextBox();
            this.textBox4CelularCliente = new System.Windows.Forms.TextBox();
            this.textBox3DireccionCliente = new System.Windows.Forms.TextBox();
            this.textBox2NombreCliente = new System.Windows.Forms.TextBox();
            this.textBoxIDCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSelectVista = new System.Windows.Forms.ComboBox();
            this.buttonGuardarNuCliente = new System.Windows.Forms.Button();
            this.tabControlContenedor.SuspendLayout();
            this.Ingresar.SuspendLayout();
            this.Consultar.SuspendLayout();
            this.tablaResultadosConsulta.SuspendLayout();
            this.Modificar.SuspendLayout();
            this.Eliminar.SuspendLayout();
            this.panel1CustomerField.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlContenedor
            // 
            this.tabControlContenedor.Controls.Add(this.Ingresar);
            this.tabControlContenedor.Controls.Add(this.Consultar);
            this.tabControlContenedor.Controls.Add(this.Modificar);
            this.tabControlContenedor.Controls.Add(this.Eliminar);
            this.tabControlContenedor.Location = new System.Drawing.Point(21, 40);
            this.tabControlContenedor.Name = "tabControlContenedor";
            this.tabControlContenedor.SelectedIndex = 0;
            this.tabControlContenedor.Size = new System.Drawing.Size(584, 285);
            this.tabControlContenedor.TabIndex = 0;
            this.tabControlContenedor.Visible = false;
            // 
            // Ingresar
            // 
            this.Ingresar.Controls.Add(this.buttonLimpiar);
            this.Ingresar.Controls.Add(this.buttonGuarda);
            this.Ingresar.Controls.Add(this.labelCantidadIngresar);
            this.Ingresar.Controls.Add(this.labelValorIngresar);
            this.Ingresar.Controls.Add(this.labelDescripcionIngresar);
            this.Ingresar.Controls.Add(this.LabelCodigoIngresar);
            this.Ingresar.Controls.Add(this.textBox4Cantidad);
            this.Ingresar.Controls.Add(this.textBox3Valor);
            this.Ingresar.Controls.Add(this.textBox2Descripcion);
            this.Ingresar.Controls.Add(this.textBox1Codigo);
            this.Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Ingresar.Location = new System.Drawing.Point(4, 22);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Padding = new System.Windows.Forms.Padding(3);
            this.Ingresar.Size = new System.Drawing.Size(576, 259);
            this.Ingresar.TabIndex = 0;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.Lime;
            this.buttonLimpiar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpiar.Location = new System.Drawing.Point(332, 208);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(142, 33);
            this.buttonLimpiar.TabIndex = 9;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            // 
            // buttonGuarda
            // 
            this.buttonGuarda.BackColor = System.Drawing.Color.Lime;
            this.buttonGuarda.ForeColor = System.Drawing.Color.White;
            this.buttonGuarda.Location = new System.Drawing.Point(141, 208);
            this.buttonGuarda.Name = "buttonGuarda";
            this.buttonGuarda.Size = new System.Drawing.Size(141, 34);
            this.buttonGuarda.TabIndex = 8;
            this.buttonGuarda.Text = "Guardar";
            this.buttonGuarda.UseMnemonic = false;
            this.buttonGuarda.UseVisualStyleBackColor = false;
            // 
            // labelCantidadIngresar
            // 
            this.labelCantidadIngresar.AutoSize = true;
            this.labelCantidadIngresar.Location = new System.Drawing.Point(62, 163);
            this.labelCantidadIngresar.Name = "labelCantidadIngresar";
            this.labelCantidadIngresar.Size = new System.Drawing.Size(98, 24);
            this.labelCantidadIngresar.TabIndex = 7;
            this.labelCantidadIngresar.Text = "Cantidad:";
            // 
            // labelValorIngresar
            // 
            this.labelValorIngresar.AutoSize = true;
            this.labelValorIngresar.Location = new System.Drawing.Point(95, 120);
            this.labelValorIngresar.Name = "labelValorIngresar";
            this.labelValorIngresar.Size = new System.Drawing.Size(65, 24);
            this.labelValorIngresar.TabIndex = 6;
            this.labelValorIngresar.Text = "Valor:";
            // 
            // labelDescripcionIngresar
            // 
            this.labelDescripcionIngresar.AutoSize = true;
            this.labelDescripcionIngresar.Location = new System.Drawing.Point(33, 77);
            this.labelDescripcionIngresar.Name = "labelDescripcionIngresar";
            this.labelDescripcionIngresar.Size = new System.Drawing.Size(127, 24);
            this.labelDescripcionIngresar.TabIndex = 5;
            this.labelDescripcionIngresar.Text = "Descripción:";
            // 
            // LabelCodigoIngresar
            // 
            this.LabelCodigoIngresar.AutoSize = true;
            this.LabelCodigoIngresar.Location = new System.Drawing.Point(77, 33);
            this.LabelCodigoIngresar.Name = "LabelCodigoIngresar";
            this.LabelCodigoIngresar.Size = new System.Drawing.Size(83, 24);
            this.LabelCodigoIngresar.TabIndex = 4;
            this.LabelCodigoIngresar.Text = "Código:";
            this.LabelCodigoIngresar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox4Cantidad
            // 
            this.textBox4Cantidad.Location = new System.Drawing.Point(194, 163);
            this.textBox4Cantidad.Name = "textBox4Cantidad";
            this.textBox4Cantidad.Size = new System.Drawing.Size(304, 29);
            this.textBox4Cantidad.TabIndex = 3;
            // 
            // textBox3Valor
            // 
            this.textBox3Valor.Location = new System.Drawing.Point(194, 120);
            this.textBox3Valor.Name = "textBox3Valor";
            this.textBox3Valor.Size = new System.Drawing.Size(304, 29);
            this.textBox3Valor.TabIndex = 2;
            // 
            // textBox2Descripcion
            // 
            this.textBox2Descripcion.Location = new System.Drawing.Point(194, 74);
            this.textBox2Descripcion.Name = "textBox2Descripcion";
            this.textBox2Descripcion.Size = new System.Drawing.Size(304, 29);
            this.textBox2Descripcion.TabIndex = 1;
            // 
            // textBox1Codigo
            // 
            this.textBox1Codigo.Location = new System.Drawing.Point(194, 33);
            this.textBox1Codigo.Name = "textBox1Codigo";
            this.textBox1Codigo.Size = new System.Drawing.Size(304, 29);
            this.textBox1Codigo.TabIndex = 0;
            this.textBox1Codigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Consultar
            // 
            this.Consultar.Controls.Add(this.tablaResultadosConsulta);
            this.Consultar.Controls.Add(this.buttonConsultar);
            this.Consultar.Controls.Add(this.comboBox1);
            this.Consultar.Controls.Add(this.label1);
            this.Consultar.ForeColor = System.Drawing.Color.White;
            this.Consultar.Location = new System.Drawing.Point(4, 22);
            this.Consultar.Name = "Consultar";
            this.Consultar.Padding = new System.Windows.Forms.Padding(3);
            this.Consultar.Size = new System.Drawing.Size(576, 259);
            this.Consultar.TabIndex = 1;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            // 
            // tablaResultadosConsulta
            // 
            this.tablaResultadosConsulta.BackColor = System.Drawing.Color.MistyRose;
            this.tablaResultadosConsulta.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tablaResultadosConsulta.ColumnCount = 3;
            this.tablaResultadosConsulta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.59249F));
            this.tablaResultadosConsulta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.40751F));
            this.tablaResultadosConsulta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tablaResultadosConsulta.Controls.Add(this.label2, 0, 0);
            this.tablaResultadosConsulta.Controls.Add(this.label3, 1, 0);
            this.tablaResultadosConsulta.Controls.Add(this.label4, 2, 0);
            this.tablaResultadosConsulta.Location = new System.Drawing.Point(63, 154);
            this.tablaResultadosConsulta.Name = "tablaResultadosConsulta";
            this.tablaResultadosConsulta.RowCount = 2;
            this.tablaResultadosConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tablaResultadosConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tablaResultadosConsulta.Size = new System.Drawing.Size(479, 62);
            this.tablaResultadosConsulta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(93, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(374, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.Lime;
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(200, 93);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(139, 37);
            this.buttonConsultar.TabIndex = 3;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(357, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // Modificar
            // 
            this.Modificar.Controls.Add(this.buttonModificar);
            this.Modificar.Controls.Add(this.comboBox2);
            this.Modificar.Controls.Add(this.labelProductoModificar);
            this.Modificar.Location = new System.Drawing.Point(4, 22);
            this.Modificar.Name = "Modificar";
            this.Modificar.Padding = new System.Windows.Forms.Padding(3);
            this.Modificar.Size = new System.Drawing.Size(576, 259);
            this.Modificar.TabIndex = 2;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.Lime;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonModificar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonModificar.Location = new System.Drawing.Point(235, 129);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(113, 37);
            this.buttonModificar.TabIndex = 2;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(155, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(329, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // labelProductoModificar
            // 
            this.labelProductoModificar.AutoSize = true;
            this.labelProductoModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelProductoModificar.Location = new System.Drawing.Point(45, 65);
            this.labelProductoModificar.Name = "labelProductoModificar";
            this.labelProductoModificar.Size = new System.Drawing.Size(104, 25);
            this.labelProductoModificar.TabIndex = 0;
            this.labelProductoModificar.Text = "Producto:";
            // 
            // Eliminar
            // 
            this.Eliminar.Controls.Add(this.button1);
            this.Eliminar.Controls.Add(this.comboBox3);
            this.Eliminar.Controls.Add(this.labelProdcutoEliminar);
            this.Eliminar.Location = new System.Drawing.Point(4, 22);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.Eliminar.Size = new System.Drawing.Size(576, 259);
            this.Eliminar.TabIndex = 3;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(239, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(157, 65);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(310, 21);
            this.comboBox3.TabIndex = 1;
            // 
            // labelProdcutoEliminar
            // 
            this.labelProdcutoEliminar.AutoSize = true;
            this.labelProdcutoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelProdcutoEliminar.Location = new System.Drawing.Point(36, 61);
            this.labelProdcutoEliminar.Name = "labelProdcutoEliminar";
            this.labelProdcutoEliminar.Size = new System.Drawing.Size(104, 25);
            this.labelProdcutoEliminar.TabIndex = 0;
            this.labelProdcutoEliminar.Text = "Producto:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelTitulo.Location = new System.Drawing.Point(161, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(0, 25);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Visible = false;
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1CustomerField
            // 
            this.panel1CustomerField.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1CustomerField.Controls.Add(this.buttonGuardarNuCliente);
            this.panel1CustomerField.Controls.Add(this.textBox5EmailCliente);
            this.panel1CustomerField.Controls.Add(this.textBox4CelularCliente);
            this.panel1CustomerField.Controls.Add(this.textBox3DireccionCliente);
            this.panel1CustomerField.Controls.Add(this.textBox2NombreCliente);
            this.panel1CustomerField.Controls.Add(this.textBoxIDCliente);
            this.panel1CustomerField.Controls.Add(this.label9);
            this.panel1CustomerField.Controls.Add(this.label8);
            this.panel1CustomerField.Controls.Add(this.label7);
            this.panel1CustomerField.Controls.Add(this.labelI);
            this.panel1CustomerField.Controls.Add(this.label5);
            this.panel1CustomerField.Location = new System.Drawing.Point(38, 40);
            this.panel1CustomerField.Name = "panel1CustomerField";
            this.panel1CustomerField.Size = new System.Drawing.Size(538, 235);
            this.panel1CustomerField.TabIndex = 3;
            this.panel1CustomerField.Visible = false;
            this.panel1CustomerField.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1CustomerField_Paint);
            // 
            // textBox5EmailCliente
            // 
            this.textBox5EmailCliente.Location = new System.Drawing.Point(138, 162);
            this.textBox5EmailCliente.Name = "textBox5EmailCliente";
            this.textBox5EmailCliente.Size = new System.Drawing.Size(255, 20);
            this.textBox5EmailCliente.TabIndex = 9;
            // 
            // textBox4CelularCliente
            // 
            this.textBox4CelularCliente.Location = new System.Drawing.Point(137, 130);
            this.textBox4CelularCliente.Name = "textBox4CelularCliente";
            this.textBox4CelularCliente.Size = new System.Drawing.Size(256, 20);
            this.textBox4CelularCliente.TabIndex = 8;
            // 
            // textBox3DireccionCliente
            // 
            this.textBox3DireccionCliente.Location = new System.Drawing.Point(137, 93);
            this.textBox3DireccionCliente.Name = "textBox3DireccionCliente";
            this.textBox3DireccionCliente.Size = new System.Drawing.Size(256, 20);
            this.textBox3DireccionCliente.TabIndex = 7;
            // 
            // textBox2NombreCliente
            // 
            this.textBox2NombreCliente.Location = new System.Drawing.Point(137, 57);
            this.textBox2NombreCliente.Name = "textBox2NombreCliente";
            this.textBox2NombreCliente.Size = new System.Drawing.Size(256, 20);
            this.textBox2NombreCliente.TabIndex = 6;
            // 
            // textBoxIDCliente
            // 
            this.textBoxIDCliente.Location = new System.Drawing.Point(137, 21);
            this.textBoxIDCliente.Name = "textBoxIDCliente";
            this.textBoxIDCliente.Size = new System.Drawing.Size(256, 20);
            this.textBoxIDCliente.TabIndex = 5;
            this.textBoxIDCliente.TextChanged += new System.EventHandler(this.textBoxIDCliente_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label9.Location = new System.Drawing.Point(45, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Email:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label8.Location = new System.Drawing.Point(30, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label7.Location = new System.Drawing.Point(8, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Dirección:";
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelI.Location = new System.Drawing.Point(81, 21);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(35, 25);
            this.labelI.TabIndex = 1;
            this.labelI.Text = "Id:";
            this.labelI.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.Location = new System.Drawing.Point(23, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre:";
            // 
            // comboBoxSelectVista
            // 
            this.comboBoxSelectVista.FormattingEnabled = true;
            this.comboBoxSelectVista.Items.AddRange(new object[] {
            "Producto",
            "Cliente"});
            this.comboBoxSelectVista.Location = new System.Drawing.Point(21, 12);
            this.comboBoxSelectVista.Name = "comboBoxSelectVista";
            this.comboBoxSelectVista.Size = new System.Drawing.Size(119, 21);
            this.comboBoxSelectVista.TabIndex = 10;
            this.comboBoxSelectVista.Text = "Seleccionar";
            this.comboBoxSelectVista.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectVista_SelectedIndexChanged);
            // 
            // buttonGuardarNuCliente
            // 
            this.buttonGuardarNuCliente.BackColor = System.Drawing.Color.Lime;
            this.buttonGuardarNuCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonGuardarNuCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardarNuCliente.Location = new System.Drawing.Point(197, 188);
            this.buttonGuardarNuCliente.Name = "buttonGuardarNuCliente";
            this.buttonGuardarNuCliente.Size = new System.Drawing.Size(156, 36);
            this.buttonGuardarNuCliente.TabIndex = 10;
            this.buttonGuardarNuCliente.Text = "Guardar";
            this.buttonGuardarNuCliente.UseVisualStyleBackColor = false;
            this.buttonGuardarNuCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(617, 337);
            this.Controls.Add(this.panel1CustomerField);
            this.Controls.Add(this.comboBoxSelectVista);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.tabControlContenedor);
            this.Name = "Contenedor";
            this.Text = "NaturVida";
            this.tabControlContenedor.ResumeLayout(false);
            this.Ingresar.ResumeLayout(false);
            this.Ingresar.PerformLayout();
            this.Consultar.ResumeLayout(false);
            this.Consultar.PerformLayout();
            this.tablaResultadosConsulta.ResumeLayout(false);
            this.tablaResultadosConsulta.PerformLayout();
            this.Modificar.ResumeLayout(false);
            this.Modificar.PerformLayout();
            this.Eliminar.ResumeLayout(false);
            this.Eliminar.PerformLayout();
            this.panel1CustomerField.ResumeLayout(false);
            this.panel1CustomerField.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlContenedor;
        private System.Windows.Forms.TabPage Ingresar;
        private System.Windows.Forms.TabPage Consultar;
        private System.Windows.Forms.TabPage Modificar;
        private System.Windows.Forms.TabPage Eliminar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelCantidadIngresar;
        private System.Windows.Forms.Label labelValorIngresar;
        private System.Windows.Forms.Label labelDescripcionIngresar;
        private System.Windows.Forms.Label LabelCodigoIngresar;
        private System.Windows.Forms.TextBox textBox4Cantidad;
        private System.Windows.Forms.TextBox textBox3Valor;
        private System.Windows.Forms.TextBox textBox2Descripcion;
        private System.Windows.Forms.TextBox textBox1Codigo;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonGuarda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tablaResultadosConsulta;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelProductoModificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label labelProdcutoEliminar;
        private System.Windows.Forms.Panel panel1CustomerField;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5EmailCliente;
        private System.Windows.Forms.TextBox textBox4CelularCliente;
        private System.Windows.Forms.TextBox textBox3DireccionCliente;
        private System.Windows.Forms.TextBox textBox2NombreCliente;
        private System.Windows.Forms.TextBox textBoxIDCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSelectVista;
        private System.Windows.Forms.Button buttonGuardarNuCliente;
    }
}

