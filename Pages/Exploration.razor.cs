using Robuddy.Services;

namespace Robuddy.Pages
{
    public partial class Exploration
    {
        public void StartExploration()
        {
            ROS2TwistPublisher publisher = new ROS2TwistPublisher();
            publisher.StartExploration();
        }

        public void StopExploration()
        {
            ROS2TwistPublisher publisher = new ROS2TwistPublisher();
            publisher.StopExploration();
        }
    }
}
