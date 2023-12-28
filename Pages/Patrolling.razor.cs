using Robuddy.Services;

namespace Robuddy.Pages
{
    public partial class Patrolling
    {
        public void StartPatrolling()
        {
            ROS2TwistPublisher publisher = new ROS2TwistPublisher();
            publisher.StartPatrolling();
        }

        public void StopPatrolling()
        {
            ROS2TwistPublisher publisher = new ROS2TwistPublisher();
            publisher.StopPatrolling();
        }
    }
}
