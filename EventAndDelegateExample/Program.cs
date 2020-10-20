using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {

            var video = new Video() { VideoTitle = "C# Delegates and Events Video..." };
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var textMailService = new TextMailService();

            videoEncoder.videoEncoded += mailService.OnVideoEncoded;
            videoEncoder.videoEncoded += textMailService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
