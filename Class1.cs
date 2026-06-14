using System.Diagnostics;
using System;
using System.IO;
using System.IO.Compression;
//using Microsoft.VisualBasic.FileIO;

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
                if (!Directory.Exists(caminhoOrigem))
                    throw new DirectoryNotFoundException($"Source directory not found: {caminhoOrigem}");
                    
                ZipFile.CreateFromDirectory(caminhoOrigem, caminhoDestino);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new InvalidOperationException($"Directory not found: {caminhoOrigem}", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error compressing {caminhoOrigem}", ex);
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
                throw new InvalidOperationException($"unpacking error: {caminhoZip}", ex);
            }
        }
    }
    public class Arq
    {
        public static bool Exist(string path)
        {
            return File.Exists(path) || Directory.Exists(path);
        }
        public static void Remove(string path)
        {
            try{
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                else if (Directory.Exists(path))
                {
                    Directory.Delete(path);
                }
                else
                {
                    throw new InvalidOperationException($"Error trying to find the specified path: {path}");
                }
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException($"Error trying to remove: {path}", ex);
            }
        }
        public static void Copy(string source, string destination)
        {
            try
            {
                if (File.Exists(source))
                {
                    File.Copy(source, destination, true);
                }
                else if (Directory.Exists(source))
                {
                    CopyDirectory(source, destination);
                }
                else
                {
                    throw new InvalidOperationException($"Error trying to find the specified path: {source}");
                }
            }
        
            catch(Exception ex)
            {
                throw new InvalidOperationException($"Error trying to copy the specified path: {source} ", ex);
            }
        }
        private static void CopyDirectory(string source, string destination)
        {
            var dir = new DirectoryInfo(source);
            
            if (!Directory.Exists(destination))
                Directory.CreateDirectory(destination);

            foreach (var file in dir.GetFiles())
                file.CopyTo(Path.Combine(destination, file.Name), true);

            foreach (var subdir in dir.GetDirectories())
                CopyDirectory(subdir.FullName, Path.Combine(destination, subdir.Name));
        }
        public static string Read(string path)
        {
            try{
                if (File.Exists(path))
                {
                    return File.ReadAllText(path);
                }
                else
                {
                    throw new InvalidOperationException($"Error trying to find the specified path: {path}");
                }
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException($"Error trying to read the specified path: {path} ", ex);
            }
        }
        public static bool Move(string source, string destination)
        {
            try
            {
                if (File.Exists(source))
                {
                    File.Move(source, destination, true);
                    return true;
                }
                else if (Directory.Exists(source))
                {
                    Directory.Move(source, destination);
                    return true;
                }
                else
                {
                    throw new InvalidOperationException($"File or directory not found: {source}");
                }
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException($"Error trying to move: {source}", ex);
            }
        }
        public static void Write(string path, string content)
        {
            try
            {
                File.WriteAllText(path, content);
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException($"Error writing to: {path}", ex);
            }
        }
    }
}