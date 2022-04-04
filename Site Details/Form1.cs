namespace Site_Details
{
    public partial class Form1 : Form
    {
        #region Declaration

        //Declares a SiteDetails variable with no assigned value.
        public SiteDetails details;

        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Basic events
        private void Form1_OnLoad(object sender, EventArgs e)
        {
            /* 
             * Text to be displayed on the UI.
             * 
             * about & rules are stored as STRING arrays as a requirement by Windows Forms designer.
             * Each index counts as a new line, unlike other solutions that use "\n" as a break.
             * Lines can still be broken into several visible lines but only due to word wrapping.
             * If the UI is allowed to be extended horizontally, the word wrapping will no longer apply
             * and the whole string will be displayed as a single line.
             * 
             * rateArray is stored as a STRING array as well, but for a different reason.
             * Instead of having to make 5 different variables for essentially the same purpose,
             * only different targets, I combined them into an array instead for simplicity instead.
             */
            
            string[] about = new string[]
            {
                "YUMMY TEH FUD DA SAI' ay isang restaurant na nagawa ng mga estudyante ng " +
                "Bartholomew, sa pinagsama-samang kakaibang mga ideya ito ay nabuo. Burger " +
                "at fries ang kanilang pinaka produkto. Ang restaurant na ito ay isang ambisyon " +
                "na pilit tinutupad ng mga magkakagrupo. Sa tinagal ng panahon di malayong " +
                "ito'y maging patok din sa masa, ito ay proud pinoy brand na naglalayong " +
                "makarating ng ibat ibang bansa at makilala. Pinagmamalaki nila ang burger na " +
                "kung tawagin ay soo lit' dahil ito'y swak na swak sa bulsa ng masa ngunit kakaiba " +
                "ang sarap na naibibigay. Ang YUMMY TEH FUD DA SAI' din ang pwedeng maging " +
                "kauna - unahang brand na maitatatag dahil lamang sa proyekto nila noong " +
                "highschool. Hindi pa laganap ang aming branch ngunit patuloy na nagsisikap " +
                "upang makilala at tangkilikin ng kapawa kababayan natin ang produktong sariling " +
                "atin. Muli ito ang YUMMY TEH FUD DA SAI' order na!",
                "",
                "To place order kindly go to www.yummytehfuddasai.com.ph",
                "Landline number: 069 - 6969"
            };
            string[] rules = new string[]
            {
                "1. In banquets and formal gatherings, serve the host/hostess or the guest of " +
                "honor first, following a counterclockwise direction.",
                "" ,
                "2. In informal groups, serve the hostess first if she is known.If the hostess is not " +
                "identified, start with the most senior female in the group." ,
                "" ,
                "3. In small, intimate groups, serve the female first, then the males.Serve " +
                "following a counterclockwise direction.",
                "" ,
                "4. The service of lunch or dinner follows this order: ",
                "    a. As soon as the guest is seated, fill the water glass three - fourths full with " +
                "ice water. Keep the water glass refilled continuously during the meal." ,
                "    b. Serve chilled butter on a bread and butter plate and the appetizer at the " +
                "center of the cover, if these are included in the menu.",
                "    c. When the guest is through, remove the appetizer dish.",
                "    d. Serve the soup at the center of the cover.",
                "    e. Remove the soup plate or soup bowl after the guest is finished with the course.",
                "    f. Serve the main dish or entree at the center of the cover in front of the guest.",
                "    g. When the guest is through, remove main dishes and used flatware. Leave " +
                "the water glass, which is constantly replenished throughout the meal. Leave " +
                "the dessert implements, either teaspoon or dessert fork, if they are set on " +
                "the table.",
                "    h. If morsels of food or crumbs are on the table, clear the table with the use " +
                "of a napkin.",
                "    i. Set the dessert implements if they have not yet been set.",
                "    j. Serve the dessert at the center of the cover.",
                "    k. Serve the beverage, if the diner prefers that it be served with the dessert. " +
                "Otherwise, beverage may be served after the dessert.",
                "" ,
                "5. For breakfast, the order of service begins with the fruit or fruit juice.This is " +
                "equivalent to soup and appetizer for lunch and dinner."
            };
            string[] rateArray =
                {
                    "graVity ha, grabe nga yan vebs!",
                    "why? why naman 4 lang? di na ba ako special sayo? Diba sabi mo, I'm only four you",
                    "bakit? threegered ka ba? Soury na, uwu",
                    "seryoso? hindi e2 biro ah, ayusin mo.",
                    "nag rate ka pa"
                };
            details = new(about, rules, rateArray);

            //Applies changes on startup.
            displayText.Lines = details.About;
            opt1.Text = details.Rate[0];
            opt2.Text = details.Rate[1];
            opt3.Text = details.Rate[2];
            opt4.Text = details.Rate[3];
            opt5.Text = details.Rate[4];
        }

        //When aboutButton is clicked...
        private void aboutBtn_OnClick(object sender, EventArgs e)
        {
            //Make the text display visible.
            tabVisibility(true);

            //Set the text to value of details.About.
            displayText.Lines = details.About;
        }

        //When rulesButton is clicked...
        private void RulesBtn_OnClick(object sender, EventArgs e)
        {
            //Make the text display visible.
            tabVisibility(true);

            //Set the text to value of details.Rules.
            displayText.Lines = details.Rules;
        }

        //When rateButton is clicked...
        private void RateBtn_OnClick(object sender, EventArgs e)
        {
            //Make the text display invisible.
            //Subsequently, this also makes the buttons visible.
            tabVisibility(false);
        }
        #endregion

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

        #region Shortcut functions
        /// <summary>
        /// Toggles the visibility of tabs. Set to TRUE to set the text box visible. Set to FALSE to set the rating visible.
        /// </summary>
        /// <param name="opt"></param>
        void tabVisibility(bool opt)
        {
            opt = !opt; //Reversing value for simplicity.

            //Make the individual elements visible or invisible.
            displayText.Visible = !opt;
            opt1.Visible = opt;
            opt2.Visible = opt;
            opt3.Visible = opt;
            opt4.Visible = opt;
            opt5.Visible = opt;
            opt1Label.Visible = opt;
            opt2Label.Visible = opt;
            opt3Label.Visible = opt;
            opt4Label.Visible = opt;
            opt5Label.Visible = opt;
        }

        
        void activateRating(int num)
        {
            //Note to self: Don't use ELSE.
            if (num != 1)
            {
                //Change colors of opt1 and reset others'.
            }
        }
        #endregion
    }

    /// <summary>
    /// An object that holds the texts to be displayed in the UI.
    /// </summary>
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