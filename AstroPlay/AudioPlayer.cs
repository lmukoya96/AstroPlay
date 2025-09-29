using NAudio.Wave;

namespace AstroPlay
{
    public class AudioPlayer
    {
        private IWavePlayer? outputDevice;
        private AudioFileReader? audioFile;

        public void Play(string filePath)
        {
            Stop(); // In case something is already playing.

            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(filePath);
            outputDevice.Init(audioFile);
            outputDevice.Play();
        }

        public void Pause()
        {
            if (outputDevice?.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Pause();
            }
        }

        public void Resume()
        {
            if (outputDevice?.PlaybackState == PlaybackState.Paused)
            {
                outputDevice.Play();
            }
        }

        public void Stop()
        {
            outputDevice?.Stop();
            audioFile?.Dispose();
            outputDevice?.Dispose();

            audioFile = null;
            outputDevice = null;
        }

        public void Seek(TimeSpan position)
        {
            if (audioFile != null)
            {
                if (position < TimeSpan.Zero) position = TimeSpan.Zero;
                if (position > audioFile.TotalTime) position = audioFile.TotalTime;
                audioFile.CurrentTime = position;
            }
        }

    }
}