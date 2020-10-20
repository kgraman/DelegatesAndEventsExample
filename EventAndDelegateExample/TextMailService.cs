using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegateExample
{
    class TextMailService
    {
        public void OnVideoEncoded(object source,VideoEncoderEventArgs video)
        {
            Console.WriteLine("Mail Service : Sending Text Mail with Attachment:"+ video.Video.VideoTitle);
        }
    }
}
