using Chinook.DataAccess.Repository;
using Chinook.DataAccess.Repository.Interface;
using Chinook.Entity.BaseQry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.UI.Windows
{
    public partial class frmSalesMaintenance : Form
    {
        private readonly DbContext dbContext;
        //private readonly ICustomerRepository customerRepository;
        //private readonly IInvoiceRepository invoiceRepository;
        //private readonly ITrackRepository trackRepository;
        private readonly IUnitOfWork unitOfWork;

        private bool mbLoaded = false;
        private float mfPriceTotal = 0;
        private int miCustomer = 0;
        private int miTrackId = 0;
        private List<AddTrackToInvoice> mltrackToInvoiceList = new List<AddTrackToInvoice>();
        

        #region Function 
        public frmSalesMaintenance()
        {
            InitializeComponent();

            this.dbContext = new ChinookDBModel();
            //this.customerRepository = new CustomerRepository(dbContext);
            //this.invoiceRepository = new InvoiceRepository(dbContext);
            //this.trackRepository = new TrackRepository(dbContext);
            this.unitOfWork = new UnitOfWork(dbContext);
        }
        private void LoadCustomerNameToCombo()
        {
            mbLoaded = false;
            var customer = this.unitOfWork.CustomerRepository.GetForCustomerItem();

            this.cmbCustomerName.DataSource = null;
            this.cmbCustomerName.Items.Clear();
            this.cmbCustomerName.Text = "";
            this.cmbCustomerName.DataSource = customer;
            this.cmbCustomerName.DisplayMember = "CustomerName";
            this.cmbCustomerName.ValueMember = "CustomerId";

            if (this.cmbCustomerName.Items.Count > 0)
            {
                this.cmbCustomerName.SelectedIndex = 0;
                mbLoaded = true;
                this.ChangedCustomerNameSelected();
            }
            
        }
        private void ChangedCustomerNameSelected()
        {
            if (mbLoaded){
                var index = cmbCustomerName.SelectedValue;
                var customer = this.unitOfWork.CustomerRepository.GetById((int)index);

                this.miCustomer = customer.CustomerId;
                this.txtAddress.Text = customer.Address;
                this.txtCity.Text = customer.City;
                this.txtCountry.Text = customer.Country;
            }
            

            
        }
        private void GetTrack()
        {
            frmSearchTrack SearchTrack = new frmSearchTrack();
            if (SearchTrack.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                var track = unitOfWork.TrackRepository.GetById(SearchTrack.TrackId);
                this.miTrackId = track.TrackId;
                this.txtTrackId.Text = track.TrackId.ToString();
                this.txtTrackName.Text = track.Name;
                this.txtPrice.Text = track.UnitPrice.ToString();                
            }
        }
        private void dgvTrackToInvoice()
        {
            AddTrackToInvoice trackToInvoice = new AddTrackToInvoice();

            trackToInvoice.TrackId = miTrackId;
            trackToInvoice.Name = txtTrackName.Text.Trim();
            trackToInvoice.Composer = "";
            trackToInvoice.Milliseconds = 0;
            trackToInvoice.UnitPrice = float.Parse(txtPrice.Text);
            trackToInvoice.Quantity = (int)nudTrackQty.Value;

            mfPriceTotal += trackToInvoice.UnitPrice;

            mltrackToInvoiceList.Add(trackToInvoice);

            dgvInvoiceLine.DataSource = null;
            dgvInvoiceLine.DataSource = mltrackToInvoiceList;
            dgvInvoiceLine.Refresh();

            txtTackPriceTotal.Text = mfPriceTotal.ToString();
        }
        private void Save()
        {
            var invoice = new Invoice();
            var invoiceLine = new List<InvoiceLine>();
            invoice.CustomerId = miCustomer;
            invoice.InvoiceDate = DateTime.Parse(dtpDate.Text);
            invoice.BillingAddress = txtAddress.Text.Trim();
            invoice.BillingCity = txtCity.Text.Trim();
            invoice.BillingState = "";
            invoice.BillingCountry = txtCountry.Text.Trim();
            invoice.BillingPostalCode = "Lima 32";

            invoice.InvoiceLine = new List<InvoiceLine>();
            foreach (DataGridViewRow row in dgvInvoiceLine.Rows)
            {
                invoice.InvoiceLine.Add(new InvoiceLine()
                {
                    TrackId = int.Parse(row.Cells["TrackId"].Value.ToString()),
                    Quantity = int.Parse(row.Cells["Quantity"].Value.ToString()),
                    UnitPrice = decimal.Parse(row.Cells["UnitPrice"].Value.ToString())
                });

            }

            invoice.Total = invoice.InvoiceLine.Sum(item => item.UnitPrice * item.Quantity);


            this.unitOfWork.InvoiceRepository.add(invoice);
            unitOfWork.Complete();
            unitOfWork.Dispose();


        }
        private void Deleted()
        {
            //List<AddTrackToInvoice> f = (List<AddTrackToInvoice>)dgvInvoiceLine.DataSource;
            //AddTrackToInvoice trackToInvoice = (AddTrackToInvoice)dgvInvoiceLine.Rows[dgvInvoiceLine.CurrentRow.Index].DataBoundItem;

            /*
             int index = list.Select((item, i) => new { Item = item, Index = i }).First(x => x.Item == search).Index;
            */

            //int index = f.Select(item => item.InvoiceLineId=trackToInvoice.InvoiceLineId && item.TrackId=trackToInvoice.TrackId).FirstOrDefault();

            
            //f.OrderBy(item => item.InvoiceLineId);
            //f.RemoveAt(1);
            ////dgvInvoiceLine.Rows.Remove(dgvInvoiceLine.CurrentRow);
            ////var track = (Track)dgvTrack.Rows[dgvTrack.CurrentRow.Index].DataBoundItem;
            //int i = dgvInvoiceLine.CurrentRow.Index;
            //dgvInvoiceLine.Rows.RemoveAt(i);
        }
        #endregion

        #region Controle
        private void cmbCustomerName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.ChangedCustomerNameSelected();
        }
        private void btnSearchTrack_Click(object sender, EventArgs e)
        {
            this.GetTrack();
        }

        #endregion

        private void frmSalesMaintenance_Load(object sender, EventArgs e)
        {
            this.LoadCustomerNameToCombo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.dgvTrackToInvoice();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            this.Deleted();
        }
    }
}
