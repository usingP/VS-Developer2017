using Chinook.DataAccess.Repository;
using Chinook.DataAccess.Repository.Interface;
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
    public partial class frmSearchTrack : Form
    {
        private readonly DbContext dbContext;
        //private readonly ITrackRepository trackRepository;
        private readonly IUnitOfWork unitOfWork;

        public int TrackId { get; set; }

        #region Function 
        public frmSearchTrack()
        {
            InitializeComponent();

            this.dbContext = new ChinookDBModel();
            //this.trackRepository = new TrackRepository(dbContext);
            this.unitOfWork = new UnitOfWork(dbContext);
        }
        private void GetTrack()
        {
            var track = this.unitOfWork.TrackRepository.GetListTrackByName(this.txtTrackFilterName.Text.Trim());
            this.dgvTrack.DataSource = track;
        }
        
        #endregion

        private void btnSearchTrack_Click(object sender, EventArgs e)
        {
            this.GetTrack();
        }

        private void btnSelectedTrack_Click(object sender, EventArgs e)
        {
            var track = (Track)dgvTrack.Rows[dgvTrack.CurrentRow.Index].DataBoundItem;
            this.TrackId = track.TrackId;
            //this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
