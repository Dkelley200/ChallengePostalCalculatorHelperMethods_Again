using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods_Again
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        // this has to be public or handleChange is not recognized in the textchanged and radio button changed events
        // use this instead of method call in every change event. still need auto post back for all.

        public void handleChange(object sender, EventArgs e)
        {
            calculateCharges();
        }

        private void calculateCharges()
        {
            //this replaces [if(checkforValues == true) to allow quick return
            if (!checkForValues()) return;
            //set value of volume for method, check to see if anything is returned from the package details
            int volume = 0;
            if (!package(out volume)) return;

            //set variable to get shipping charge from shiprate
            double shipping = shipRate();


            double cost = volume * shipping;

            resultLabel.Text = string.Format("Your shipping cost is {0:C}", cost);


        }
       


        private bool checkForValues()
        {
            //must check to see if at least one of the radio buttons are checked 
            //and if height and width have value. Length is not required

            if (!airRadioButton.Checked &&
                !groundRadioButton.Checked &&
                !nextDayRadioButton.Checked)
                return false;

            //0 is length of string not int value
            if (lengthTextBox.Text.Trim().Length == 0 ||
                widthTextBox.Text.Trim().Length == 0)
                return false;
          
                return true;

        }

      // need to set all the values and check to out them. set value for out length so you don't get a 0 in calculation
          public bool package(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;
      
            
            if (!int.TryParse(lengthTextBox.Text.Trim(), out length)) length =1;
            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(heightTextBox.Text.Trim(), out height)) return false;

            volume = height * width * length;
                return true;
        }

    
        //set the value for each ship option
        public double shipRate()
        {  if (groundRadioButton.Checked) return 0.15;
            else if (airRadioButton.Checked) return 0.25;
            else if (nextDayRadioButton.Checked) return 0.45;
            else return 0;
       }
        
     
    }
}



//    Postal Calculator  Business rules

//Business Rule 1: Accept width, height and optionally the length of a parcel.Accept the shipping method - Ground, Air, Next Day.

//Business Rule 2: Once you have the minimum amount of information you need, produce a result on screen.The result will be the volume of the package (width* height and optionally* length) multiplied by the "multiplier" for each shipping method.

//Ground: .15 multiplier
//Air: .25 multiplier
//Next Day: .45

//Non-Functional Requirement 1: You must name the project ChallengePostalCalculatorHelperMethods.

//Non-Functional Requirement 2: You must use methods.  Each method must do one thing and do it well.  


