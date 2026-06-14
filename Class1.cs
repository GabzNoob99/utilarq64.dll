using System.Diagnostics;
using System;
using System.IO;
using System.IO.Compression;


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
        public void Openl(string path)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = path,
                    UseShellExecute = false
                });

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to execute the process.", ex);
            }
        }
    }
    public class Show
    {
        public static int FileCount(string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                int count = dir.GetFiles("*", SearchOption.AllDirectories).Length;
                return count;
            }
            catch (Exception ex)
            {
                return 0;
                throw new InvalidOperationException("Failed to find the path.", ex);
            }
        }
        public static long Size(string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                long totalSize = dir.GetFiles("*", SearchOption.AllDirectories)
                    .Sum(file => file.Length);
                return totalSize;
            }
            catch (Exception ex)
            {
                return 0;
                throw new InvalidOperationException("Failed to find the path.", ex);
            }
        }
    }
    public class Zip
    {
        public static void zip(string caminhoOrigem, string caminhoDestino)
        {
            try
            {
                ZipFile.CreateFromDirectory(caminhoOrigem, caminhoDestino);
                if (!Directory.Exists(caminhoDestino))
                {
                    Directory.CreateDirectory(caminhoDestino);
                }
            }
            catch (DirectoryNotFoundException)
            {
                throw new InvalidOperationException($"Directory Not Found: {caminhoOrigem}");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error compressing {caminhoOrigem}:", ex);
            }
        }
        public static void Extract(string caminhoZip, string caminhoDestino)
        {
            try
            {
                if (!File.Exists(caminhoZip))
                {
                    throw new FileNotFoundException($"failed to find the ZIP: {caminhoZip}");
                }
                if (!Directory.Exists(caminhoDestino))
                {
                    Directory.CreateDirectory(caminhoDestino);
                }

                ZipFile.ExtractToDirectory(caminhoZip, caminhoDestino, overwriteFiles: true);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Erro ao descompactar: {caminhoZip}", ex);
            }
        }
        public static void Arq()
        {
            
        }
    }
}