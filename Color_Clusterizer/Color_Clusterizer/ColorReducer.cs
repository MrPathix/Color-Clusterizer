using Color_Reducer.Controllers;
using System.Windows.Forms;

namespace Color_Reducer
{
    public partial class ColorReducer : Form
    {
        private MainViewController Controller { get; }

        public ColorReducer()
        {
            InitializeFiltersDictionary();
            InitializeComponent();
            InitializeContextMenus();
            InitializeImageGallery();
            Controller = new MainViewController();

            InitializeProgressTimer();
        }
    }
}
