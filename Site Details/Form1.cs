namespace Site_Details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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