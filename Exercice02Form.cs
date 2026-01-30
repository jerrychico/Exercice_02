using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercice_02
{
    public partial class Exercice02Form : Form
    {
        public Exercice02Form()
        {
            InitializeComponent();
        }

        #region Événements du formulaire

        /// <summary>
        /// Événement déclenché au chargement du formulaire
        /// Initialise les données de la grille en chargeant les ventes de 1997
        /// </summary>

        private void Exercice02Form_Load(object sender, EventArgs e)
        {
            // ====================================================================
            // ORDRE PRÉFÉRABLE
            // ====================================================================
            try
            {
                this.taClientsTableAdapter.Fill(this.dsClientCommandeDataSet.dtClientsDataTable);

                try
                {
                    this.taCommandesTableAdapter.Fill(this.dsClientCommandeDataSet.dtCommandesDataTable);

                }
                catch (Exception exEnfant)
                {
                    MessageBox.Show(
                        "Erreur lors du chargement des commandes :\n" + exEnfant.Message,
                        "Erreur Commandes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    
                }



            }
            catch (Exception exParent)
            {
                MessageBox.Show(
                    "Erreur critique - Impossible de charger les clients :\n" + exParent.Message,
                    "Erreur Fatale",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Close();
            }


        }

        #endregion

        #region Événements du BindingSource
        /// <summary>
        /// Événement déclenché lorsque la ligne courante change dans le BindingSource
        /// Configure les en-têtes et le formatage des colonnes du DataGridView
        /// </summary>

        private void dtCommandesDataTableDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtCommandesDataTableDataGridView.Columns.Count > 0) 
            {
                if (this.dtCommandesDataTableDataGridView.Columns.Contains("OrderID"))
                {
                    this.dtCommandesDataTableDataGridView.Columns["OrderID"].HeaderText = "Numéro de la Commande";
                }

                if (this.dtCommandesDataTableDataGridView.Columns.Contains("OrderDate"))
                {

                    this.dtCommandesDataTableDataGridView.Columns["OrderDate"].HeaderText = "Date de commande";
                }

                if (this.dtCommandesDataTableDataGridView.Columns.Contains("RequiredDate"))
                {
                    this.dtCommandesDataTableDataGridView.Columns["RequiredDate"].HeaderText = "Date requise";
                }
            }
        }
        #endregion

        private void imprimer(object sender, EventArgs e)
        {
            #region Impression
            //Debut de la phase 2

            Console.WriteLine("Clients des villes M et P et leurs commandes respectives");

            //Parcourt le dataTable dtClientsDataTable
            foreach (dsClientCommandeDataSet.dtClientsDataTableRow odtClient in dsClientCommandeDataSet.dtClientsDataTable.Rows)
            {
                
                Console.WriteLine($"{odtClient.CustomerID,-10} {odtClient.CompanyName,-30} {odtClient.Country,-20} {odtClient.Phone} ");

                foreach (dsClientCommandeDataSet.dtCommandesDataTableRow odtCommande in dsClientCommandeDataSet.dtCommandesDataTable.Rows)
                {
                    //Fait une vérification pour voir si l'id de la clé étrangère est pareille à celle de dtclientCommandes
                    if (odtCommande.CustomerID == odtClient.CustomerID)
                    {
                        Console.WriteLine($"       {odtCommande.OrderID,-9} {odtCommande.OrderDate:MMMM d, yyyy}");
                    }
                }
            }

            #endregion
        }
    }
}
