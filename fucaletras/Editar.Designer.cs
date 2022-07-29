namespace fucaletras
{
    partial class EditPlay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarLetraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecionarPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemAlfabéticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porGêneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porArtistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okEdPlayBtt = new System.Windows.Forms.Button();
            this.cancEdPlaBtt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(412, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 349);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar a musica para ser adicionada na playlist";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(23, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(272, 300);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome Playlist:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.playlistsToolStripMenuItem,
            this.organizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(189, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarLetraToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // pesquisarLetraToolStripMenuItem
            // 
            this.pesquisarLetraToolStripMenuItem.Name = "pesquisarLetraToolStripMenuItem";
            this.pesquisarLetraToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pesquisarLetraToolStripMenuItem.Text = "Pesquisar Letra";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.sobreOSoftwareToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreOSoftwareToolStripMenuItem
            // 
            this.sobreOSoftwareToolStripMenuItem.Name = "sobreOSoftwareToolStripMenuItem";
            this.sobreOSoftwareToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.sobreOSoftwareToolStripMenuItem.Text = "Sobre o FucaLetras";
            // 
            // playlistsToolStripMenuItem
            // 
            this.playlistsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarPlaylistToolStripMenuItem,
            this.editarPlaylistToolStripMenuItem,
            this.selecionarPlaylistToolStripMenuItem});
            this.playlistsToolStripMenuItem.Name = "playlistsToolStripMenuItem";
            this.playlistsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.playlistsToolStripMenuItem.Text = "Playlists";
            // 
            // criarPlaylistToolStripMenuItem
            // 
            this.criarPlaylistToolStripMenuItem.Name = "criarPlaylistToolStripMenuItem";
            this.criarPlaylistToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.criarPlaylistToolStripMenuItem.Text = "Criar Playlist";
            // 
            // editarPlaylistToolStripMenuItem
            // 
            this.editarPlaylistToolStripMenuItem.Name = "editarPlaylistToolStripMenuItem";
            this.editarPlaylistToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editarPlaylistToolStripMenuItem.Text = "Editar Playlist";
            // 
            // selecionarPlaylistToolStripMenuItem
            // 
            this.selecionarPlaylistToolStripMenuItem.Name = "selecionarPlaylistToolStripMenuItem";
            this.selecionarPlaylistToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.selecionarPlaylistToolStripMenuItem.Text = "Selecionar Playlist";
            // 
            // organizarToolStripMenuItem
            // 
            this.organizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordemAlfabéticaToolStripMenuItem,
            this.porGêneroToolStripMenuItem,
            this.porAlbumToolStripMenuItem,
            this.porArtistaToolStripMenuItem});
            this.organizarToolStripMenuItem.Name = "organizarToolStripMenuItem";
            this.organizarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.organizarToolStripMenuItem.Text = "Organizar";
            // 
            // ordemAlfabéticaToolStripMenuItem
            // 
            this.ordemAlfabéticaToolStripMenuItem.Name = "ordemAlfabéticaToolStripMenuItem";
            this.ordemAlfabéticaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ordemAlfabéticaToolStripMenuItem.Text = "Ordem Alfabética";
            // 
            // porGêneroToolStripMenuItem
            // 
            this.porGêneroToolStripMenuItem.Name = "porGêneroToolStripMenuItem";
            this.porGêneroToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.porGêneroToolStripMenuItem.Text = "Por Gênero";
            // 
            // porAlbumToolStripMenuItem
            // 
            this.porAlbumToolStripMenuItem.Name = "porAlbumToolStripMenuItem";
            this.porAlbumToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.porAlbumToolStripMenuItem.Text = "Por Álbum";
            // 
            // porArtistaToolStripMenuItem
            // 
            this.porArtistaToolStripMenuItem.Name = "porArtistaToolStripMenuItem";
            this.porArtistaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.porArtistaToolStripMenuItem.Text = "Por Artista";
            // 
            // okEdPlayBtt
            // 
            this.okEdPlayBtt.Location = new System.Drawing.Point(311, 338);
            this.okEdPlayBtt.Name = "okEdPlayBtt";
            this.okEdPlayBtt.Size = new System.Drawing.Size(75, 23);
            this.okEdPlayBtt.TabIndex = 15;
            this.okEdPlayBtt.Text = "Ok";
            this.okEdPlayBtt.UseVisualStyleBackColor = true;
            // 
            // cancEdPlaBtt
            // 
            this.cancEdPlaBtt.Location = new System.Drawing.Point(230, 338);
            this.cancEdPlaBtt.Name = "cancEdPlaBtt";
            this.cancEdPlaBtt.Size = new System.Drawing.Size(75, 23);
            this.cancEdPlaBtt.TabIndex = 16;
            this.cancEdPlaBtt.Text = "Cancelar";
            this.cancEdPlaBtt.UseVisualStyleBackColor = true;
            // 
            // EditPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 456);
            this.Controls.Add(this.cancEdPlaBtt);
            this.Controls.Add(this.okEdPlayBtt);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "EditPlay";
            this.Text = "Editar Playlist";
            this.Load += new System.EventHandler(this.EditPlay_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarLetraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecionarPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemAlfabéticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porGêneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porArtistaToolStripMenuItem;
        private System.Windows.Forms.Button okEdPlayBtt;
        private System.Windows.Forms.Button cancEdPlaBtt;
    }
}