namespace SyncAsyncDiff
{
    public partial class FrmSync : Form
    {
        public FrmSync()
        {
            InitializeComponent();
        }

        private void timer1Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss ");
        }
       
        private void btn_sync_Click(object sender, EventArgs e)
        {
            txt_output.Text="";
            using (var dbContex -new DbContext())
            {
                txt_output.Lines dbcontext.GetCities();
            }
            
        }
        
        private async void bnt_async_Click(object sender, EventArgs e)
        {
            txt_output.Text = "";
            using (var dbContext = new DbContext())
            {
                txt_output.Lines await dbContext.GetCitiesAsync();
            }
            
        }
        
    }
}