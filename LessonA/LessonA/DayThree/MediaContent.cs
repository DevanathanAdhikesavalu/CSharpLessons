using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DayThree
{
    internal class MediaContent
    {
        public virtual void StartPlayingContent()
        {
            Console.WriteLine("Start in media");
        }
        public void StopPlayingContent()
        {
            Console.WriteLine("Stop");
        }
        public void PausePlayingContent()
        {
            Console.WriteLine("Pause");
        }
        public void ContinuePlayingContent()
        {
            Console.WriteLine("Continue");
        }

        public sealed override string ToString()
        {
            Console.WriteLine("Media ToString");
            return "ott";
        }
    }
    //End of Media class
    internal class AudioContent : MediaContent
    {
        public override void StartPlayingContent()
        {
            Console.WriteLine("Start in audio");
        }
        //public sealed override string ToString()
        //{
        //    Console.WriteLine("AudioContent ToString");
        //    return "ott";
        //}
    }
    // End of Audio class
    internal class VideoContent : AudioContent
    {
        public override sealed void StartPlayingContent()
        {
            Console.WriteLine("Start in video");
        }
    }
    //end of videocontent class
    internal class MediaTester
    {
        public static void TestOne()
        {
            VideoContent video = new VideoContent();
            video.StartPlayingContent();
            AudioContent audio = new AudioContent();
            audio.StartPlayingContent();
        }
    }
    //End of MediaTester Class
}
