using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HazyBits.Twain.Cloud.Forms
{
    public abstract class FormLogin : Form
    {
        /// <summary>
        /// Occurs when TWAIN Cloud successfully authorized the user and issued access tokens.
        /// </summary>
        public event EventHandler<TwainCloudAuthorizedEventArgs> Authorized;

        protected virtual void OnAuthorized(TwainCloudAuthorizedEventArgs e)
        {
            Authorized?.Invoke(this, e);
        }
    }
}
