using System;
using AppKit;
using Foundation;

namespace KVMCALC
{
    public partial class ViewController : NSViewController
    {
        //  Metoden som anropas när "Räkna ut"- knappen klickas på
        [Action("CalculateButtonClicked:")]
        private void CalculateButtonClicked(NSObject sender)
        {
            //Konverterar innehållet i längd- och breddtextfälten till double-värden
            if (double.TryParse(lengthTextField.StringValue, out double length) &&
                double.TryParse(widthTextField.StringValue, out double width))
            {    //Beräknar ut area genom att multiplicera längd med bredd
                double area = length * width;

                //Skapar en NSAlert för att visa resultatet.
                var alert = new NSAlert
                {
                    AlertStyle = NSAlertStyle.Informational,
                    MessageText = "Resultat",
                    InformativeText = $"Ytan är {area:N2} kvadratmeter." 
                }; //Blockerar användaren från att integrera med övriga appen medans resultat rutan öppen.
                alert.RunModal();
            }
        }
        // Metoden som anropas när "Återställ"-knappen klickas på.
        [Action("ResetButtonClicked:")]
        private void ResetButtonClicked(NSObject sender)
        {     //Rensar textfälten genom att sätta deras innehåll till en tom sträng.
            lengthTextField.StringValue = "";
            widthTextField.StringValue = "";
        }

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }
    }
}