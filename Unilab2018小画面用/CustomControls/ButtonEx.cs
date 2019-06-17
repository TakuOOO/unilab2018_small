using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unilab2018.CustomControl
{

    public class ButtonEx : Button
    {
        [System.Security.Permissions.UIPermission(
            System.Security.Permissions.SecurityAction.Demand,
            Window = System.Security.Permissions.UIPermissionWindow.AllWindows)]
        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Down:
                case Keys.Right:
                case Keys.Up:
                case Keys.Left:
                    break;
                default:
                    return base.IsInputKey(keyData);
            }
            return true;
        }
    }
}
