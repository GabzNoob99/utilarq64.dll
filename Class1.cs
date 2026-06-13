using System.Diagnostics;

namespace utilarq64
{
    public class Open
    {
        public void OpenURL(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to open the URL.", ex);
            }
        }
        public Process Start(string app)
        {
            try
            {
                return Process.Start(app);
            } catch(Exception ex) { 
                throw new InvalidOperationException("Failed to start the application.", ex);
            }
            
        }
    }
}