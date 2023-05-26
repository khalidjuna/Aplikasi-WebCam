using OpenCvSharp;

namespace WebcamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (VideoCapture capture = new VideoCapture(0))
            {
                using (Mat frame = new Mat())
                {
                    using (Window window = new Window("Webcam", WindowFlags.AutoSize))
                    {
                        while (true)
                        {
                            capture.Read(frame);

                            if (frame.Empty())
                                break;

                            Cv2.ImShow("Webcam", frame);

                            if (Cv2.WaitKey(1) == (int) 'q')
                                break;
                        }

                    }
                }
            }
        }
    }
}