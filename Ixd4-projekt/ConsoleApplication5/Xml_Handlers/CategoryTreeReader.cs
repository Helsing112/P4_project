using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication5
{
    class CategorySubItemsReader : XmlProductReader
    {
        public string PathOfLibrary { get; }
        public Category MasterCategory { get; private set; }
        public CategorySubItemsReader(string path_of_library)
        {
            PathOfLibrary = path_of_library;
        }
        public void start()
        {
            Category master_category = new Category("MasterCategory", PathOfLibrary);
            MasterCategory = master_category;
            Create_category(PathOfLibrary,  master_category);

        }

        private void Create_category(string path, Category category_input)
        {
            DirectoryInfo directories = new DirectoryInfo(path);

            foreach (DirectoryInfo item in directories.GetDirectories())
            {
                Category temp_category = new Category(item.Name, item.FullName);

                category_input.Category_list.Add(temp_category);

                CreateProducts(temp_category, item.FullName);

                Create_category(item.FullName, temp_category);
            }


        }
        private void CreateProducts(Category input_category, string path)
        {
            DirectoryInfo directories = new DirectoryInfo(path);

            foreach (FileInfo item in directories.GetFiles())
            {
                input_category.Product_list.Add(Read_product<Product>(item.FullName));
                Console.WriteLine();
            }
        }

        public void print_lortet()
        {
            
        }
    }
}
