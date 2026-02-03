/*
   Programmeur : Dosso Ibrahima Elimane
                 Haba Jean de croix
                 Douanla Dountio Jerry Bostel
   Date : 18/01/2026
   but :Formulaire des commandes des client des villes M ET P
*/

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
        private bool filtreActif=false;

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
            /*  SELECT CustomerID, CompanyName, Phone, Country, City
  FROM Customers
  WHERE(City LIKE 'M%') OR
                           (City LIKE 'P%')
  ORDER BY CompanyName DESC*/
            /*SELECT o.OrderID, o.CustomerID, o.OrderDate, o.RequiredDate, o.Freight, DATEDIFF(day, o.OrderDate, o.RequiredDate) AS DelaiLivraison, e.LastName + ', ' + e.FirstName AS Vendeur
  FROM     Orders AS o INNER JOIN
                    Employees AS e ON o.EmployeeID = e.EmployeeID
  WHERE  (o.CustomerID IN
                        (SELECT CustomerID
                         FROM      Customers
                         WHERE   (City LIKE 'M%') OR
                                           (City LIKE 'P%')))
  ORDER BY o.RequiredDate DESC*/
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
            foreach (DataRowView drvClient in dtClientsDataTableBindingSource)
            {
                // Récupération de la ligne typée
                dsClientCommandeDataSet.dtClientsDataTableRow client =
                    (dsClientCommandeDataSet.dtClientsDataTableRow)drvClient.Row;

                // Affichage du client
                Console.WriteLine(
                    $"{client.CustomerID,-6} {client.CompanyName,-30} {client.Country,-5} {client.Phone}"
                );

                // Accès HIÉRARCHIQUE aux commandes via la relation
                foreach (dsClientCommandeDataSet.dtCommandesDataTableRow commande
                         in client.GetdtCommandesDataTableRows())
                {
                    Console.WriteLine(
                        $"       {commande.OrderID,-8} {commande.OrderDate:MMMM d, yyyy}"
                    );
                }
            }

            #endregion
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!filtreActif)
            {
                // Active le filtre
                dtClientsDataTableBindingSource.Filter =
                    "Country = 'USA' AND (City LIKE 'M%' OR City LIKE 'P%')";

                dtClientsDataTableBindingSource.Sort = "Phone DESC";

                filtreActif = true;
            }
            else
            {
                // Désactive le filtre
                dtClientsDataTableBindingSource.Filter ="";
                dtClientsDataTableBindingSource.Sort = "";

                filtreActif = false;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            imprimerXml();
        }

        private void imprimerXml()
        {
            Console.WriteLine("Clients des villes M et P et leurs commandes respectives");

            try
            {
                // Création du DataSet (non typé)
                DataSet ds = new DataSet();

                // Lecture du fichier XML avec son schéma
                ds.ReadXml("VentesClientsMetP.xml", XmlReadMode.ReadSchema);

                // Table des clients (première table)
                DataTable tableClients = ds.Tables[0];

                // Relation clients / commandes
                DataRelation relation = ds.Relations[0];

                // Parcours des clients
                foreach (DataRow client in tableClients.Rows)
                {
                    Console.WriteLine(
                        String.Format(
                            "{0,-6} {1}",
                            client[0],  // 
                            client[1]   
                        )
                    );

                    // Commandes du client
                    DataRow[] commandes = client.GetChildRows(relation);

                    foreach (DataRow commande in commandes)
                    {
                        Console.WriteLine(
                            String.Format(
                                "    {0,-8} {1:MMMM d, yyyy}",
                                commande[0],   
                                commande[1]    
                            )
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erreur lors de la lecture du fichier XML :\n" + ex.Message,
                    "Erreur XML",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


    }
}
