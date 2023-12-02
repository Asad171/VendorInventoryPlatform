namespace VendorAppInventory
{
    public partial class MainForm : Form
    {
        public static User user = new User();

        public static MainForm MainInstance = new MainForm();
        public MainForm()
        {
            InitializeComponent();
            MainInstance = this;


            // Add and centralize Login User Control
            MainInstance.Controls.Add(LoginUserControl.LoginInstance);
            CenterControlInParent(LoginUserControl.LoginInstance);
            LoginUserControl.LoginInstance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Add and centralize Register User Control
            MainInstance.Controls.Add(RegisterUserControl.RegisterInstance);
            RegisterUserControl.RegisterInstance.Hide();
            CenterControlInParent(RegisterUserControl.RegisterInstance);
            RegisterUserControl.RegisterInstance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Add and centralize Menu User Control
            MainInstance.Controls.Add(MenuUserControl.MenuInstance);
            MenuUserControl.MenuInstance.Hide();
            CenterControlInParent(MenuUserControl.MenuInstance);
            MenuUserControl.MenuInstance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Add and centralize Add Product User Control
            MainInstance.Controls.Add(AddProductUserControl.AddProductInstance);
            AddProductUserControl.AddProductInstance.Hide();
            CenterControlInParent(AddProductUserControl.AddProductInstance);
            AddProductUserControl.AddProductInstance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Add and centralize Product Detail User Control
            MainInstance.Controls.Add(ProductDetailUserControl.ProductDetailInstance);
            ProductDetailUserControl.ProductDetailInstance.Hide();
            CenterControlInParent(ProductDetailUserControl.ProductDetailInstance);
            ProductDetailUserControl.ProductDetailInstance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Add and centralize Vendor Add User Control
            MainInstance.Controls.Add(VendorAddUserControl.VendorAddInstance);
            VendorAddUserControl.VendorAddInstance.Hide();
            CenterControlInParent(VendorAddUserControl.VendorAddInstance);
            VendorAddUserControl.VendorAddInstance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Add and centralize Vendor View User Control
            MainInstance.Controls.Add(VendorViewUserControl.VendorViewInstance);
            VendorViewUserControl.VendorViewInstance.Hide();
            CenterControlInParent(VendorViewUserControl.VendorViewInstance);
            VendorViewUserControl.VendorViewInstance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Add and centralize Vendor Detail User Control
            MainInstance.Controls.Add(VendorDetailUserControl.VendorDetailInstance);
            VendorDetailUserControl.VendorDetailInstance.Hide();
            CenterControlInParent(VendorDetailUserControl.VendorDetailInstance);
            VendorDetailUserControl.VendorDetailInstance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        public void CenterControlInParent(Control child)
        {
            // Assuming 'this' is the MainForm and 'child' is the UserControl you want to center
            int centerX = (this.ClientSize.Width - child.Width) / 2;
            int centerY = (this.ClientSize.Height - child.Height) / 2;
            child.Location = new Point(centerX, centerY);
        }

    }
}