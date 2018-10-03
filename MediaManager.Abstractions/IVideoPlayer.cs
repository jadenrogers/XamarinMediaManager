using System.Threading.Tasks;
using Plugin.MediaManager.Abstractions.Enums;

namespace Plugin.MediaManager.Abstractions
{
    /// <summary>
    /// Plays the video
    /// </summary>
    public interface IVideoPlayer : IPlaybackManager
    {
        /// <summary>
        /// The native view where the video should be rendered on
        /// </summary>
        IVideoSurface RenderSurface { get; set; }

        /// <summary>
        /// The aspect mode of the video
        /// </summary>
        VideoAspectMode AspectMode { get; set; }

        /// <summary>
        ///  Steps forward or backward by number of provided frames
        /// </summary>
        /// <param name="frameCount">Number of frames to step by. Use negative numbers to step backwards</param>
        Task StepFrame( int frameCount = 1 );

        /// <summary>
        /// Adjusts the video play rate
        /// </summary>
        /// <param name="speed">Normal, Half, Double speed options</param>
        Task PlaySpeed( PlaySpeed speed );
    }
}