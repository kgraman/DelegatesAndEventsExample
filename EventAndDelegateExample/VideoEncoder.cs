using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventAndDelegateExample
{
    class VideoEncoder
    {

        //1.Define Delegates
        //2.Define Events using that Delegate
        //3.Raise and publish the Event.

        //public delegate void VideoEncoderEventHandler(object Source, VideoEncoderEventArgs video);

        //public event VideoEncoderEventHandler videoEncoded;

        //using Eventhandler
        public event EventHandler<VideoEncoderEventArgs> videoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video....");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
            Console.ReadLine();
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            //if (videoEncoded != null)
            //    videoEncoded(this, new VideoEncoderEventArgs() { Video = video });
            videoEncoded?.Invoke(this, new VideoEncoderEventArgs() { Video = video });

        }
    }
    public class VideoEncoderEventArgs
    {
        public Video Video;
    }
}
