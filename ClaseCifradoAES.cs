using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace AppDesktopCifradoAES
{
    public class ClaseCifradoAES
    {
        public string CifradoAES(string textoacifrar, string password, string vectorinicio, int interacciones)
        {
            AesManaged aes = null;
            MemoryStream streammemoria = null;
            CryptoStream streamcifrado = null;
            try
            {
                var rfc2889 = new Rfc2898DeriveBytes
                    (password, Encoding.UTF8.GetBytes(vectorinicio), interacciones);
                aes = new AesManaged();
                aes.Key = rfc2889.GetBytes(32);
                aes.IV = rfc2889.GetBytes(16);
                streammemoria = new MemoryStream();
                streamcifrado = new CryptoStream(streammemoria, aes.CreateEncryptor(), CryptoStreamMode.Write);
                byte[] datos = Encoding.UTF8.GetBytes(textoacifrar);
                streamcifrado.Write(datos, 0, datos.Length);
                streamcifrado.FlushFinalBlock();
                return Convert.ToBase64String(streammemoria.ToArray());

            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                if (streamcifrado != null)
                    streamcifrado.Close();
                if (streammemoria != null)
                    streammemoria.Close();
                if (aes != null)
                    aes.Clear();
            }

        }
        public string DescifradoAES(string textoadescifrar, string password, string vectorinicio, int interacciones)
        {
            AesManaged aes = null;
            MemoryStream streammemoria = null;
            CryptoStream streamdescifrado = null;
            try
            {
                var rfc2889 = new Rfc2898DeriveBytes
                    (password, Encoding.UTF8.GetBytes(vectorinicio), interacciones);
                aes = new AesManaged();
                aes.Key = rfc2889.GetBytes(32);
                aes.IV = rfc2889.GetBytes(16);
                streammemoria = new MemoryStream();
                streamdescifrado = new CryptoStream(streammemoria, aes.CreateDecryptor(), CryptoStreamMode.Write);
                byte[] datos = Convert.FromBase64String(textoadescifrar);
                streamdescifrado.Write(datos, 0, datos.Length);
                streamdescifrado.FlushFinalBlock();
                byte[] arreglodescifrado = streammemoria.ToArray();
                if (streamdescifrado != null)
                    streamdescifrado.Dispose();
                return Encoding.UTF8.GetString(arreglodescifrado, 0, arreglodescifrado.Length);



            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                if (streamdescifrado != null)
                    streamdescifrado.Close();
                if (streammemoria != null)
                    streammemoria.Close();
                if (aes != null)
                    aes.Clear();
            }
        }
    }
}
