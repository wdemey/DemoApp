namespace CodedUITestProject
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    
    public partial class UIMap
    {
        public void ModifiedSimpleAppTest()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WpfButton uICloseButton = this.UIMainWindowWindow.UIMainWindowTitleBar.UICloseButton;
            
            #endregion

            // Launch '%VisualStudioDir%\Projects\DemoApp\DemoApp\bin\Debug\DemoApp.exe'
            string strPath = Environment.GetEnvironmentVariable("mstestpath");
            strPath = strPath + "\\DemoApp\\bin\\Debug\\DemoApp.exe";
            // ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.SimpleAppTestParams.UIMainWindowWindowExePath, this.SimpleAppTestParams.UIMainWindowWindowAlternateExePath);
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(strPath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(62, 22));

            uICheckBoxCheckBox.WaitForControlEnabled();

           
            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.SimpleAppTestParams.UICheckBoxCheckBoxChecked;

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(14, 6));
        }
    }
}
