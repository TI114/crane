//using System.Drawing;
using System.Windows.Forms;

namespace Crane
{
    public class View : Form
    {
        Crane crane = new Crane();
        public View()
        {
          
        }

        static void Main()
        {
            Application.Run(new View());
        }
    }
}