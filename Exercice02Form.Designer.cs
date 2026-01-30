namespace Exercice_02
{
    partial class Exercice02Form
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label countryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercice02Form));
            this.dtClientsDataTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.dtClientsDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClientCommandeDataSet = new Exercice_02.dsClientCommandeDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.dtCommandesDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtCommandesDataTableDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelaiLivraison = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taClientsTableAdapter = new Exercice_02.dsClientCommandeDataSetTableAdapters.taClientsTableAdapter();
            this.tableAdapterManager = new Exercice_02.dsClientCommandeDataSetTableAdapters.TableAdapterManager();
            this.taCommandesTableAdapter = new Exercice_02.dsClientCommandeDataSetTableAdapters.taCommandesTableAdapter();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            customerIDLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientsDataTableBindingNavigator)).BeginInit();
            this.dtClientsDataTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientsDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientCommandeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCommandesDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCommandesDataTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(12, 51);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(83, 16);
            customerIDLabel.TabIndex = 9;
            customerIDLabel.Text = "Customer ID:";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(12, 79);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(70, 20);
            companyNameLabel.TabIndex = 11;
            companyNameLabel.Text = "Société:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(12, 166);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(76, 16);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Téléphone:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(12, 123);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(41, 16);
            countryLabel.TabIndex = 15;
            countryLabel.Text = "Pays:";
            // 
            // dtClientsDataTableBindingNavigator
            // 
            this.dtClientsDataTableBindingNavigator.AddNewItem = null;
            this.dtClientsDataTableBindingNavigator.BindingSource = this.dtClientsDataTableBindingSource;
            this.dtClientsDataTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dtClientsDataTableBindingNavigator.DeleteItem = null;
            this.dtClientsDataTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dtClientsDataTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.dtClientsDataTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dtClientsDataTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dtClientsDataTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dtClientsDataTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dtClientsDataTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dtClientsDataTableBindingNavigator.Name = "dtClientsDataTableBindingNavigator";
            this.dtClientsDataTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dtClientsDataTableBindingNavigator.Size = new System.Drawing.Size(792, 27);
            this.dtClientsDataTableBindingNavigator.TabIndex = 0;
            this.dtClientsDataTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // dtClientsDataTableBindingSource
            // 
            this.dtClientsDataTableBindingSource.DataMember = "dtClientsDataTable";
            this.dtClientsDataTableBindingSource.DataSource = this.dsClientCommandeDataSet;
            // 
            // dsClientCommandeDataSet
            // 
            this.dsClientCommandeDataSet.DataSetName = "dsClientCommandeDataSet";
            this.dsClientCommandeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // dtCommandesDataTableBindingSource
            // 
            this.dtCommandesDataTableBindingSource.DataMember = "FK_Orders_Customers1";
            this.dtCommandesDataTableBindingSource.DataSource = this.dtClientsDataTableBindingSource;
            // 
            // dtCommandesDataTableDataGridView
            // 
            this.dtCommandesDataTableDataGridView.AutoGenerateColumns = false;
            this.dtCommandesDataTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCommandesDataTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.CustomerID,
            this.OrderDate,
            this.RequiredDate,
            this.Freight,
            this.DelaiLivraison,
            this.Vendeur});
            this.dtCommandesDataTableDataGridView.DataSource = this.dtCommandesDataTableBindingSource;
            this.dtCommandesDataTableDataGridView.Location = new System.Drawing.Point(15, 209);
            this.dtCommandesDataTableDataGridView.Name = "dtCommandesDataTableDataGridView";
            this.dtCommandesDataTableDataGridView.RowHeadersWidth = 51;
            this.dtCommandesDataTableDataGridView.RowTemplate.Height = 24;
            this.dtCommandesDataTableDataGridView.Size = new System.Drawing.Size(757, 278);
            this.dtCommandesDataTableDataGridView.TabIndex = 9;
            this.dtCommandesDataTableDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtCommandesDataTableDataGridView_CellFormatting);
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Width = 125;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Visible = false;
            this.CustomerID.Width = 125;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Width = 125;
            // 
            // RequiredDate
            // 
            this.RequiredDate.DataPropertyName = "RequiredDate";
            this.RequiredDate.HeaderText = "RequiredDate";
            this.RequiredDate.MinimumWidth = 6;
            this.RequiredDate.Name = "RequiredDate";
            this.RequiredDate.Width = 125;
            // 
            // Freight
            // 
            this.Freight.DataPropertyName = "Freight";
            this.Freight.HeaderText = "Freight";
            this.Freight.MinimumWidth = 6;
            this.Freight.Name = "Freight";
            this.Freight.Visible = false;
            this.Freight.Width = 125;
            // 
            // DelaiLivraison
            // 
            this.DelaiLivraison.DataPropertyName = "DelaiLivraison";
            this.DelaiLivraison.HeaderText = "DelaiLivraison";
            this.DelaiLivraison.MinimumWidth = 6;
            this.DelaiLivraison.Name = "DelaiLivraison";
            this.DelaiLivraison.ReadOnly = true;
            this.DelaiLivraison.Visible = false;
            this.DelaiLivraison.Width = 125;
            // 
            // Vendeur
            // 
            this.Vendeur.DataPropertyName = "Vendeur";
            this.Vendeur.HeaderText = "Vendeur";
            this.Vendeur.MinimumWidth = 6;
            this.Vendeur.Name = "Vendeur";
            this.Vendeur.ReadOnly = true;
            this.Vendeur.Width = 125;
            // 
            // taClientsTableAdapter
            // 
            this.taClientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.taClientsTableAdapter = this.taClientsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Exercice_02.dsClientCommandeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taCommandesTableAdapter
            // 
            this.taCommandesTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientsDataTableBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(126, 48);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.customerIDTextBox.TabIndex = 10;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientsDataTableBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(126, 76);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.companyNameTextBox.TabIndex = 12;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientsDataTableBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(126, 163);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneTextBox.TabIndex = 14;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtClientsDataTableBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(126, 120);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 22);
            this.countryTextBox.TabIndex = 16;
            // 
            // Exercice02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 507);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.dtCommandesDataTableDataGridView);
            this.Controls.Add(this.dtClientsDataTableBindingNavigator);
            this.Name = "Exercice02Form";
            this.Text = "Commandes requises des clients des villes M et P ";
            this.Load += new System.EventHandler(this.Exercice02Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtClientsDataTableBindingNavigator)).EndInit();
            this.dtClientsDataTableBindingNavigator.ResumeLayout(false);
            this.dtClientsDataTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientsDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientCommandeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCommandesDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCommandesDataTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsClientCommandeDataSet dsClientCommandeDataSet;
        private System.Windows.Forms.BindingSource dtClientsDataTableBindingSource;
        private dsClientCommandeDataSetTableAdapters.taClientsTableAdapter taClientsTableAdapter;
        private dsClientCommandeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dtClientsDataTableBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.BindingSource dtCommandesDataTableBindingSource;
        private dsClientCommandeDataSetTableAdapters.taCommandesTableAdapter taCommandesTableAdapter;
        private System.Windows.Forms.DataGridView dtCommandesDataTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freight;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelaiLivraison;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendeur;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
    }
}

