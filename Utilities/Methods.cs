using System;
using System.IO;
using System.Linq;
using OnlineShop.DAL;
using OnlineShop.Models;

namespace OnlineShop.Utilities
{
    public class Methods
    {
      
        public static void FileDelete(string root, string folder, string image)
        {
            string filePath = Path.Combine(root, folder, image);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
        public static bool CheckCategory(int? id,Category existed)
        {
            if (existed !=null && existed.Id!=id)
            {
                return true;
            }
            return false;
        }
    }
}

