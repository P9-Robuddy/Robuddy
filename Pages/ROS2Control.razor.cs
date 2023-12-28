using Robuddy.Services;

namespace Robuddy.Pages
{
    public partial class ROS2Control
    {
        public void SendTwistCommand(int x, int y, string topic)
        {
            ROS2TwistPublisher publisher = new ROS2TwistPublisher();
            publisher.SendTwistCommand(x, y, topic);
        }
    }
}
