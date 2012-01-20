using System;
using System.Security.Cryptography;
using System.IO;

namespace LibMediaServiceCommon
{
	/// <summary>
	/// This classes contains funtions with working with various hashes.
	/// MD5, SHA512, etc....
	/// </summary>
	public class Hashes
	{
		public Hashes ()
		{
		}
		
		/// <summary>
		/// This function converts a string into an MD5 hash.
		/// </summary>
		/// <param name="nonHashedString">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A MD5 hash of the string passed in.<see cref="System.String"/>
		/// </returns>
		public static string GetMD5StringHash(string nonHashedString)
        {
            string hashValue = "";
            using (MD5 _md5 = new MD5CryptoServiceProvider())
            {
				
				byte[] data = System.Text.Encoding.UTF8.GetBytes(nonHashedString);

                byte[] retVal = _md5.ComputeHash(data);
                hashValue = BitConverter.ToString(retVal).Replace("-", ""); // hex string
			}


            return hashValue;
        }

		/// <summary>
		/// This function creates an md5 hash of the file passed.
		/// </summary>
		/// <param name="fileName">
		/// The filepath location of the file to hash. <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A md5 hash of the file <see cref="System.String"/>
		/// </returns>
        public static string GetMD5FileHash(string fileName)
        {
            string hashValue = "";
            using (MD5 _md5 = new MD5CryptoServiceProvider())
            {
                using (FileStream file = new FileStream(fileName, FileMode.Open))
                {
                    byte[] retVal = _md5.ComputeHash(file);
                    hashValue = BitConverter.ToString(retVal).Replace("-", ""); // hex string
                }
            }


            return hashValue;
        }

		
		/// <summary>
		/// Creates a SHA1 hash has of a string.
		/// </summary>
		/// <param name="nonHashedString">
		/// The string to hash <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A SHA1 hash<see cref="System.String"/>
		/// </returns>
        public static string GetSHA1StringHash(string nonHashedString)
        {
            string hashValue = "";
            using (SHA1 _sha1 = new SHA1CryptoServiceProvider())
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(nonHashedString);
                byte[] retVal = _sha1.ComputeHash(data);
                hashValue = BitConverter.ToString(retVal).Replace("-", ""); // hex string
            
            }


            return hashValue;
        }
	
		/// <summary>
		/// Creates a SHA1 hash of a file.
		/// </summary>
		/// <param name="fileName">
		/// The filepath location of the file to hash <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A SHA1 hash<see cref="System.String"/>
		/// </returns>
        public static string GetSHA1FileHash(string fileName)
        {
            string hashValue = "";
            using (SHA1 _sha1 = new SHA1CryptoServiceProvider())
            {
                using (FileStream file = new FileStream(fileName, FileMode.Open))
                {
                    byte[] retVal = _sha1.ComputeHash(file);
                    hashValue = BitConverter.ToString(retVal).Replace("-", ""); // hex string
                }
            }


            return hashValue;
        }

		
		/// <summary>
		/// Creates a SHA512 hash of a string.
		/// </summary>
		/// <param name="nonHashedString">
		/// The string to hash<see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A SHA512 hash <see cref="System.String"/>
		/// </returns>
        public static string GetSHA512StringHash(string nonHashedString)
        {
            string hashValue = "";
            using (SHA512 _sha512 = new SHA512Managed())
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(nonHashedString);
                byte[] retVal = _sha512.ComputeHash(data);
                hashValue = BitConverter.ToString(retVal).Replace("-", ""); // hex string
            
            }


            return hashValue;
        }
		
		/// <summary>
		/// Creates a SHA512 hash of a file.
		/// </summary>
		/// <param name="fileName">
		/// The filepath location that will be hashed<see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A SHA512 hash <see cref="System.String"/>
		/// </returns>
        public static string GetSHA512FileHash(string fileName)
        {
            string hashValue = "";
            using (SHA512 _sha512 = new SHA512Managed())
            {
                using (FileStream file = new FileStream(fileName, FileMode.Open))
                {
                    byte[] retVal = _sha512.ComputeHash(file);
                    hashValue = BitConverter.ToString(retVal).Replace("-", ""); // hex string
                }
            }


            return hashValue;
        }
		
	}
}

