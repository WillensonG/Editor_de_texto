namespace Editor_de_texto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.editar = new System.Windows.Forms.ToolStripMenuItem();
            this.atras = new System.Windows.Forms.ToolStripMenuItem();
            this.adelante = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cortar = new System.Windows.Forms.ToolStripMenuItem();
            this.pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.color = new System.Windows.Forms.ToolStripMenuItem();
            this.formato = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_cortar = new System.Windows.Forms.ToolStripButton();
            this.btn_copiar = new System.Windows.Forms.ToolStripButton();
            this.btn_pegar = new System.Windows.Forms.ToolStripButton();
            this.ComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo,
            this.editar,
            this.color,
            this.formato});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivo
            // 
            this.archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrir,
            this.guardar,
            this.cerrar});
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(60, 20);
            this.archivo.Text = "Archivo";
            this.archivo.Click += new System.EventHandler(this.archivo_Click);
            // 
            // abrir
            // 
            this.abrir.Image = ((System.Drawing.Image)(resources.GetObject("abrir.Image")));
            this.abrir.Name = "abrir";
            this.abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrir.Size = new System.Drawing.Size(156, 22);
            this.abrir.Text = "Abrir";
            this.abrir.Click += new System.EventHandler(this.abrir_Click);
            // 
            // guardar
            // 
            this.guardar.Image = ((System.Drawing.Image)(resources.GetObject("guardar.Image")));
            this.guardar.Name = "guardar";
            this.guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardar.Size = new System.Drawing.Size(156, 22);
            this.guardar.Text = "Guardar";
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Name = "cerrar";
            this.cerrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F14)));
            this.cerrar.Size = new System.Drawing.Size(156, 22);
            this.cerrar.Text = "Cerrar";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // editar
            // 
            this.editar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atras,
            this.adelante,
            this.toolStripSeparator1,
            this.copiar,
            this.Cortar,
            this.pegar,
            this.toolStripSeparator2,
            this.seleccionarTodo,
            this.eliminarTodo});
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(49, 20);
            this.editar.Text = "Editar";
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // atras
            // 
            this.atras.Image = ((System.Drawing.Image)(resources.GetObject("atras.Image")));
            this.atras.Name = "atras";
            this.atras.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.atras.Size = new System.Drawing.Size(209, 22);
            this.atras.Text = "Atras";
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // adelante
            // 
            this.adelante.Image = ((System.Drawing.Image)(resources.GetObject("adelante.Image")));
            this.adelante.Name = "adelante";
            this.adelante.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.adelante.Size = new System.Drawing.Size(209, 22);
            this.adelante.Text = "Adelante";
            this.adelante.Click += new System.EventHandler(this.adelanteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // copiar
            // 
            this.copiar.Image = ((System.Drawing.Image)(resources.GetObject("copiar.Image")));
            this.copiar.Name = "copiar";
            this.copiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiar.Size = new System.Drawing.Size(209, 22);
            this.copiar.Text = "Copiar";
            this.copiar.Click += new System.EventHandler(this.copiar_Click);
            // 
            // Cortar
            // 
            this.Cortar.Image = ((System.Drawing.Image)(resources.GetObject("Cortar.Image")));
            this.Cortar.Name = "Cortar";
            this.Cortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Cortar.Size = new System.Drawing.Size(209, 22);
            this.Cortar.Text = "Cortar";
            this.Cortar.Click += new System.EventHandler(this.Cortar_Click);
            // 
            // pegar
            // 
            this.pegar.Image = ((System.Drawing.Image)(resources.GetObject("pegar.Image")));
            this.pegar.Name = "pegar";
            this.pegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegar.Size = new System.Drawing.Size(209, 22);
            this.pegar.Text = "pegar";
            this.pegar.Click += new System.EventHandler(this.pegar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // seleccionarTodo
            // 
            this.seleccionarTodo.Image = ((System.Drawing.Image)(resources.GetObject("seleccionarTodo.Image")));
            this.seleccionarTodo.Name = "seleccionarTodo";
            this.seleccionarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.seleccionarTodo.Size = new System.Drawing.Size(209, 22);
            this.seleccionarTodo.Text = "Seleccionar todo";
            this.seleccionarTodo.Click += new System.EventHandler(this.seleccionarTodo_Click);
            // 
            // eliminarTodo
            // 
            this.eliminarTodo.Image = ((System.Drawing.Image)(resources.GetObject("eliminarTodo.Image")));
            this.eliminarTodo.Name = "eliminarTodo";
            this.eliminarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.eliminarTodo.Size = new System.Drawing.Size(209, 22);
            this.eliminarTodo.Text = "Eliminar todo";
            this.eliminarTodo.Click += new System.EventHandler(this.eliminarTodoToolStripMenuItem_Click);
            // 
            // color
            // 
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(48, 20);
            this.color.Text = "Color";
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // formato
            // 
            this.formato.Name = "formato";
            this.formato.Size = new System.Drawing.Size(64, 20);
            this.formato.Text = "Formato";
            this.formato.Click += new System.EventHandler(this.formatoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cortar,
            this.btn_copiar,
            this.btn_pegar,
            this.ComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_cortar
            // 
            this.btn_cortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cortar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cortar.Image")));
            this.btn_cortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cortar.Name = "btn_cortar";
            this.btn_cortar.Size = new System.Drawing.Size(23, 22);
            this.btn_cortar.Text = "cortar";
            this.btn_cortar.Click += new System.EventHandler(this.Cortar_Click);
            // 
            // btn_copiar
            // 
            this.btn_copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_copiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_copiar.Image")));
            this.btn_copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_copiar.Name = "btn_copiar";
            this.btn_copiar.Size = new System.Drawing.Size(23, 22);
            this.btn_copiar.Text = "copiar";
            this.btn_copiar.Click += new System.EventHandler(this.copiar_Click);
            // 
            // btn_pegar
            // 
            this.btn_pegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_pegar.Image = ((System.Drawing.Image)(resources.GetObject("btn_pegar.Image")));
            this.btn_pegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_pegar.Name = "btn_pegar";
            this.btn_pegar.Size = new System.Drawing.Size(23, 22);
            this.btn_pegar.Text = "pegar";
            this.btn_pegar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pegar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40"});
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 25);
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.seleccionTamaño);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 401);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Text editor WR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivo;
        private ToolStripMenuItem abrir;
        private ToolStripMenuItem guardar;
        private ToolStripMenuItem cerrar;
        private ToolStripMenuItem editar;
        private ToolStripMenuItem atras;
        private ToolStripMenuItem adelante;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem copiar;
        private ToolStripMenuItem Cortar;
        private ToolStripMenuItem pegar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem seleccionarTodo;
        private ToolStripMenuItem eliminarTodo;
        private ToolStripMenuItem color;
        private ToolStripMenuItem formato;
        private ToolStrip toolStrip1;
        private RichTextBox richTextBox1;
        private ToolStripButton btn_cortar;
        private ToolStripButton btn_copiar;
        private ToolStripButton btn_pegar;
        private ToolStripComboBox ComboBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
    }
}