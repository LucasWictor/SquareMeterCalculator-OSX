// VARNING
//
// Denna fil har genererats automatiskt av Visual Studio för att lagra outlets och
// actions som skapats i användargränssnittsdesignern. Om den tas bort kommer de att förloras.
// Manuella ändringar i denna fil kanske inte hanteras korrekt.
//
using Foundation;
using System.CodeDom.Compiler;

namespace KVMCALC
{
    [Register("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSTextField lengthTextField { get; set; }

        [Outlet]
        AppKit.NSTextField widthTextField { get; set; }

        [Action("CalculateButtonClicked:")]
        partial void CalculateButtonClicked(AppKit.NSButton sender);

        [Action("ResetButtonClicked:")]
        partial void ResetButtonClicked(AppKit.NSButton sender);

        void ReleaseDesignerOutlets()
        {
            if (lengthTextField != null)
            {
                lengthTextField.Dispose();
                lengthTextField = null;
            }

            if (widthTextField != null)
            {
                widthTextField.Dispose();
                widthTextField = null;
            }
        }
    }
}
