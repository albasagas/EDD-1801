﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace BDISLoadTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinComboBox uIOpenComboBox = this.UIRunWindow.UIItemWindow.UIOpenComboBox;
            WinEdit uIOpenEdit = this.UIRunWindow.UIItemWindow1.UIOpenEdit;
            WinEdit uINameEdit = this.UIItem290Window.UIItemWindow.UIHISTORYListItem.UINameEdit;
            WinEdit uINameEdit1 = this.UIItem290Window.UIItemWindow1.UIUseradminaspListItem.UINameEdit;
            WinCheckBox uIAlwaysusethisapptoopCheckBox = this.UIItemWindow.UIFlyoutwindowClient.UIAlwaysusethisapptoopCheckBox;
            WinButton uIOKButton = this.UIItemWindow.UIFlyoutwindowClient.UIOKButton;
            #endregion

            // Press keyboard shortcut keys 'Windows + r'
            Keyboard.SendKeys(this.RecordedMethod1Params.SendKeys, ModifierKeys.Windows);

            // Select 'C:\Users\alba.sagastume\Desktop\290' in 'Open:' combo box
            uIOpenComboBox.EditableItem = this.RecordedMethod1Params.UIOpenComboBoxEditableItem;

            // Type '{Enter}' in 'Open:' text box
            Keyboard.SendKeys(uIOpenEdit, this.RecordedMethod1Params.UIOpenEditSendKeys, ModifierKeys.None);

            // Double-Click 'Name' text box
            Mouse.DoubleClick(uINameEdit, new Point(49, 12));

            // Double-Click 'Name' text box
            Mouse.DoubleClick(uINameEdit1, new Point(42, 12));

            // Select 'Always use this app to open .asp files' check box
            uIAlwaysusethisapptoopCheckBox.Checked = this.RecordedMethod1Params.UIAlwaysusethisapptoopCheckBoxChecked;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(100, 13));
        }
        
        /// <summary>
        /// AssertMethod1 - Use 'AssertMethod1ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod1()
        {
            #region Variable Declarations
            WinWindow uIRunWindow = this.UIRunWindow;
            #endregion

            // Verify that the 'Name' property of 'Run' window equals 'Run'
            Assert.AreEqual(this.AssertMethod1ExpectedValues.UIRunWindowName, uIRunWindow.Name);
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public virtual AssertMethod1ExpectedValues AssertMethod1ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod1ExpectedValues == null))
                {
                    this.mAssertMethod1ExpectedValues = new AssertMethod1ExpectedValues();
                }
                return this.mAssertMethod1ExpectedValues;
            }
        }
        
        public UIRunWindow UIRunWindow
        {
            get
            {
                if ((this.mUIRunWindow == null))
                {
                    this.mUIRunWindow = new UIRunWindow();
                }
                return this.mUIRunWindow;
            }
        }
        
        public UIItem290Window UIItem290Window
        {
            get
            {
                if ((this.mUIItem290Window == null))
                {
                    this.mUIItem290Window = new UIItem290Window();
                }
                return this.mUIItem290Window;
            }
        }
        
        public UIItemWindow3 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow3();
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private AssertMethod1ExpectedValues mAssertMethod1ExpectedValues;
        
        private UIRunWindow mUIRunWindow;
        
        private UIItem290Window mUIItem290Window;
        
        private UIItemWindow3 mUIItemWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Press keyboard shortcut keys 'Windows + r'
        /// </summary>
        public string SendKeys = "r";
        
        /// <summary>
        /// Select 'C:\Users\alba.sagastume\Desktop\290' in 'Open:' combo box
        /// </summary>
        public string UIOpenComboBoxEditableItem = "C:\\Users\\alba.sagastume\\Desktop\\290";
        
        /// <summary>
        /// Type '{Enter}' in 'Open:' text box
        /// </summary>
        public string UIOpenEditSendKeys = "{Enter}";
        
        /// <summary>
        /// Select 'Always use this app to open .asp files' check box
        /// </summary>
        public bool UIAlwaysusethisapptoopCheckBoxChecked = true;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class AssertMethod1ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Run' window equals 'Run'
        /// </summary>
        public string UIRunWindowName = "Run";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIRunWindow : WinWindow
    {
        
        public UIRunWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Run";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Run");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIItemWindow1 mUIItemWindow1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "12298";
            this.WindowTitles.Add("Run");
            #endregion
        }
        
        #region Properties
        public WinComboBox UIOpenComboBox
        {
            get
            {
                if ((this.mUIOpenComboBox == null))
                {
                    this.mUIOpenComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUIOpenComboBox.SearchProperties[WinComboBox.PropertyNames.Name] = "Open:";
                    this.mUIOpenComboBox.WindowTitles.Add("Run");
                    #endregion
                }
                return this.mUIOpenComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinComboBox mUIOpenComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1001";
            this.WindowTitles.Add("Run");
            #endregion
        }
        
        #region Properties
        public WinEdit UIOpenEdit
        {
            get
            {
                if ((this.mUIOpenEdit == null))
                {
                    this.mUIOpenEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIOpenEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Open:";
                    this.mUIOpenEdit.WindowTitles.Add("Run");
                    #endregion
                }
                return this.mUIOpenEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIOpenEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItem290Window : WinWindow
    {
        
        public UIItem290Window()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "290";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CabinetWClass";
            this.WindowTitles.Add("290");
            this.WindowTitles.Add("HISTORY");
            #endregion
        }
        
        #region Properties
        public UIItemWindow2 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow2(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow11 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow11(this);
                }
                return this.mUIItemWindow1;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow2 mUIItemWindow;
        
        private UIItemWindow11 mUIItemWindow1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow2 : WinWindow
    {
        
        public UIItemWindow2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("290");
            #endregion
        }
        
        #region Properties
        public UIHISTORYListItem UIHISTORYListItem
        {
            get
            {
                if ((this.mUIHISTORYListItem == null))
                {
                    this.mUIHISTORYListItem = new UIHISTORYListItem(this);
                }
                return this.mUIHISTORYListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIHISTORYListItem mUIHISTORYListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIHISTORYListItem : WinListItem
    {
        
        public UIHISTORYListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "HISTORY";
            this.WindowTitles.Add("290");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("290");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow11 : WinWindow
    {
        
        public UIItemWindow11(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("HISTORY");
            #endregion
        }
        
        #region Properties
        public UIUseradminaspListItem UIUseradminaspListItem
        {
            get
            {
                if ((this.mUIUseradminaspListItem == null))
                {
                    this.mUIUseradminaspListItem = new UIUseradminaspListItem(this);
                }
                return this.mUIUseradminaspListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIUseradminaspListItem mUIUseradminaspListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIUseradminaspListItem : WinListItem
    {
        
        public UIUseradminaspListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "useradmin.asp";
            this.WindowTitles.Add("HISTORY");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("HISTORY");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow3 : WinWindow
    {
        
        public UIItemWindow3()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Flyout window";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            #endregion
        }
        
        #region Properties
        public UIFlyoutwindowClient UIFlyoutwindowClient
        {
            get
            {
                if ((this.mUIFlyoutwindowClient == null))
                {
                    this.mUIFlyoutwindowClient = new UIFlyoutwindowClient(this);
                }
                return this.mUIFlyoutwindowClient;
            }
        }
        #endregion
        
        #region Fields
        private UIFlyoutwindowClient mUIFlyoutwindowClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIFlyoutwindowClient : WinClient
    {
        
        public UIFlyoutwindowClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Flyout window";
            #endregion
        }
        
        #region Properties
        public WinCheckBox UIAlwaysusethisapptoopCheckBox
        {
            get
            {
                if ((this.mUIAlwaysusethisapptoopCheckBox == null))
                {
                    this.mUIAlwaysusethisapptoopCheckBox = new WinCheckBox(this);
                    #region Search Criteria
                    this.mUIAlwaysusethisapptoopCheckBox.SearchProperties[WinCheckBox.PropertyNames.Name] = "Always use this app to open .asp files";
                    #endregion
                }
                return this.mUIAlwaysusethisapptoopCheckBox;
            }
        }
        
        public WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOKButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                    #endregion
                }
                return this.mUIOKButton;
            }
        }
        #endregion
        
        #region Fields
        private WinCheckBox mUIAlwaysusethisapptoopCheckBox;
        
        private WinButton mUIOKButton;
        #endregion
    }
}
