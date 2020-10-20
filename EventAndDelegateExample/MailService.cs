using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegateExample
{
    class MailService
    {
        public void OnVideoEncoded(object source,VideoEncoderEventArgs video)
        {
            Console.WriteLine("Mail Service:Sending Mail with attachment:"+ video.Video.VideoTitle);
        }

    }
}
