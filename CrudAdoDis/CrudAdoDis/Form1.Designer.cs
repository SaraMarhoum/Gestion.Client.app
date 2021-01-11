
namespace CrudAdoDis
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clientManageDataSet = new CrudAdoDis.ClientManageDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new CrudAdoDis.ClientManageDataSetTableAdapters.ClientsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inp_Nom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inp_Prenom = new System.Windows.Forms.TextBox();
            this.inp_Adresse = new System.Windows.Forms.TextBox();
            this.Abtn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_maj = new System.Windows.Forms.Button();
            this.btn_filtre = new System.Windows.Forms.Button();
            this.txt_titre = new System.Windows.Forms.Label();
            this.inp_ville = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.inp_filtre = new System.Windows.Forms.TextBox();
            this.btn_filtre2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientManageDataSet
            // 
            this.clientManageDataSet.DataSetName = "ClientManageDataSet";
            this.clientManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.clientManageDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // inp_Nom
            // 
            this.inp_Nom.Location = new System.Drawing.Point(176, 128);
            this.inp_Nom.Name = "inp_Nom";
            this.inp_Nom.Size = new System.Drawing.Size(167, 22);
            this.inp_Nom.TabIndex = 1;
            // 
            // txt_nom
            // 
            this.txt_nom.AutoSize = true;
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(35, 124);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(59, 26);
            this.txt_nom.TabIndex = 2;
            this.txt_nom.Text = "Nom";
            this.txt_nom.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ville";
            // 
            // inp_Prenom
            // 
            this.inp_Prenom.Location = new System.Drawing.Point(176, 173);
            this.inp_Prenom.Name = "inp_Prenom";
            this.inp_Prenom.Size = new System.Drawing.Size(167, 22);
            this.inp_Prenom.TabIndex = 6;
            // 
            // inp_Adresse
            // 
            this.inp_Adresse.Location = new System.Drawing.Point(176, 216);
            this.inp_Adresse.Name = "inp_Adresse";
            this.inp_Adresse.Size = new System.Drawing.Size(167, 22);
            this.inp_Adresse.TabIndex = 7;
            // 
            // Abtn_add
            // 
            this.Abtn_add.Location = new System.Drawing.Point(467, 128);
            this.Abtn_add.Name = "Abtn_add";
            this.Abtn_add.Size = new System.Drawing.Size(111, 39);
            this.Abtn_add.TabIndex = 9;
            this.Abtn_add.Text = "Ajouter";
            this.Abtn_add.UseVisualStyleBackColor = true;
            this.Abtn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(467, 191);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(111, 39);
            this.btn_del.TabIndex = 10;
            this.btn_del.Text = "Supprimer";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(594, 128);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(111, 39);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Enregistrer";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_maj
            // 
            this.btn_maj.Location = new System.Drawing.Point(594, 191);
            this.btn_maj.Name = "btn_maj";
            this.btn_maj.Size = new System.Drawing.Size(111, 39);
            this.btn_maj.TabIndex = 12;
            this.btn_maj.Text = "MAJ";
            this.btn_maj.UseVisualStyleBackColor = true;
            this.btn_maj.Click += new System.EventHandler(this.btn_maj_Click);
            // 
            // btn_filtre
            // 
            this.btn_filtre.Location = new System.Drawing.Point(467, 252);
            this.btn_filtre.Name = "btn_filtre";
            this.btn_filtre.Size = new System.Drawing.Size(131, 39);
            this.btn_filtre.TabIndex = 14;
            this.btn_filtre.Text = "Chercher par ville";
            this.btn_filtre.UseVisualStyleBackColor = true;
            this.btn_filtre.Click += new System.EventHandler(this.btn_filtre_Click);
            // 
            // txt_titre
            // 
            this.txt_titre.AutoSize = true;
            this.txt_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titre.Location = new System.Drawing.Point(137, 21);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(248, 39);
            this.txt_titre.TabIndex = 24;
            this.txt_titre.Text = "Gestion Clients";
            // 
            // inp_ville
            // 
            this.inp_ville.Location = new System.Drawing.Point(176, 257);
            this.inp_ville.Name = "inp_ville";
            this.inp_ville.Size = new System.Drawing.Size(167, 22);
            this.inp_ville.TabIndex = 16;
            this.inp_ville.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(610, 255);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(95, 39);
            this.btn_back.TabIndex = 25;
            this.btn_back.Text = "Retour";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // inp_filtre
            // 
            this.inp_filtre.Location = new System.Drawing.Point(176, 257);
            this.inp_filtre.Name = "inp_filtre";
            this.inp_filtre.Size = new System.Drawing.Size(167, 22);
            this.inp_filtre.TabIndex = 26;
            this.inp_filtre.Visible = false;
            // 
            // btn_filtre2
            // 
            this.btn_filtre2.Location = new System.Drawing.Point(467, 252);
            this.btn_filtre2.Name = "btn_filtre2";
            this.btn_filtre2.Size = new System.Drawing.Size(131, 39);
            this.btn_filtre2.TabIndex = 27;
            this.btn_filtre2.Text = "Checher";
            this.btn_filtre2.UseVisualStyleBackColor = true;
            this.btn_filtre2.Visible = false;
            this.btn_filtre2.Click += new System.EventHandler(this.btn_filtre2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 724);
            this.Controls.Add(this.btn_filtre2);
            this.Controls.Add(this.inp_filtre);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_titre);
            this.Controls.Add(this.inp_ville);
            this.Controls.Add(this.btn_filtre);
            this.Controls.Add(this.btn_maj);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.Abtn_add);
            this.Controls.Add(this.inp_Adresse);
            this.Controls.Add(this.inp_Prenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.inp_Nom);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ClientManageDataSet clientManageDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ClientManageDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox inp_Nom;
        private System.Windows.Forms.Label txt_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inp_Prenom;
        private System.Windows.Forms.TextBox inp_Adresse;
        private System.Windows.Forms.Button Abtn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_maj;
        private System.Windows.Forms.Button btn_filtre;
        private System.Windows.Forms.Label txt_titre;
        private System.Windows.Forms.TextBox inp_ville;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox inp_filtre;
        private System.Windows.Forms.Button btn_filtre2;
    }
}

