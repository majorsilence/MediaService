using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace LibMediaServiceCommon
{


    /// <summary>
    /// Delegate for use with MediaService events.  Uses MediaServce.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void MediaServiceEventHandler(object sender, MediaServiceEvent e);

    public class MediaServiceEvent : System.EventArgs
    {

        private string _msg;
        private long _value;
        private Image _img; 

        public MediaServiceEvent(string m)
        {
            _msg = m;
            _value = 0;
        }

        public MediaServiceEvent(long v)
        {
            _msg = "";
            _value = v;
        }

        public MediaServiceEvent(Image img, long IdMediaInfo)
        {
            _msg = "";
            _value = IdMediaInfo;
            _img = img;
        }



        /// <summary>
        /// Event Message.
        /// </summary>
        public string Message
        {
            get { return _msg; }
        }

        public long Value
        {
            get { return _value; }
        }

        public Image ImageValue
        {
            get { return _img; }
        }

    }
}
