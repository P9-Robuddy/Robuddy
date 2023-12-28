using System;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace Robuddy.Services
{
    public class ROS2TwistPublisher
    {
        public void SendTwistCommand(int x, int y, string topic)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "ros2";
                process.StartInfo.Arguments = $"topic pub --once {topic} geometry_msgs/Twist \"{{linear: {{x: {x}, y: {y}, z: 0}}, angular: {{x: 0, y: 0, z: 0}}}}\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
            }
        }

        public void StartPatrolling()
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "ros2";
                process.StartInfo.Arguments = $"run";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
            }
        }

        public void StopPatrolling()
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "ros2";
                process.StartInfo.Arguments = $"run";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
            }
        }

        public void StartExploration()
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "ros2";
                process.StartInfo.Arguments = $"run";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
            }
        }

        public void StopExploration()
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "ros2";
                process.StartInfo.Arguments = $"run";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
            }
        }
    }
}
