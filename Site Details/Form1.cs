namespace Site_Details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_OnLoad(object sender, EventArgs e)
        {
        }

        private void aboutBtn_OnClick(object sender, EventArgs e)
        {
        }

        private void RulesBtn_OnClick(object sender, EventArgs e)
        {
        }

        private void RateBtn_OnClick(object sender, EventArgs e)
        {
        }

        #region Rate button events
        private void Rate5Btn_OnClick(object sender, EventArgs e)
        {

        }

        private void Rate4Btn_OnClick(object sender, EventArgs e)
        {

        }

        private void Rate3Btn_OnClick(object sender, EventArgs e)
        {

        }

        private void Rate2Btn_OnClick(object sender, EventArgs e)
        {

        }

        private void Rate1Btn_OnClick(object sender, EventArgs e)
        {

        }
        #endregion
    public class SiteDetails
    {
        public SiteDetails(string[] aboutTexts, string[] rulesTexts, string[] rateTexts)
        {
            this.About = aboutTexts;
            this.Rules = rulesTexts;
            this.Rate = rateTexts;
        }

        public string[] About { get; set; }

        public string[] Rules { get; set; }

        public string[] Rate { get; set; }
    }
}