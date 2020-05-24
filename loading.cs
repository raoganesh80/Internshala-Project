using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internshala_Project
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        public Action Worker { get; set; }

        public loading(Action Worker)
        {
            InitializeComponent();
            if (Worker == null)
                throw new ArgumentNullException();
            this.Worker = Worker;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
