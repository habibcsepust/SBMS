using SBMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Repository;
using SBMS.ViewModel;

namespace SBMS.BLL
{
    public class CategoryManager
    { CategoryRepository _categoryRepository = new CategoryRepository();
        public bool IsAddCategory(Category category)
        {
            return _categoryRepository.IsAddCategory(category);
        }

        public List<Category> DisplayCategory()
        {
            return _categoryRepository.DisplayCategory();
        }

        public bool IsExistCode(Category category)
        {
            return _categoryRepository.IsExistCode(category);
        }

        public bool IsExistName(Category category)
        {
            return _categoryRepository.IsExistName(category);
        }

        public bool IsUpdateCategory(Category category,int id)
        {
            return _categoryRepository.IsUpdateCategory(category,id);
        }

        public List<Category> SearchCategory(string criteria)
        {
            return _categoryRepository.SearchCategory(criteria);
        }

        public bool DeleteCategory(Category category)
        {
            return _categoryRepository.DeleteCategory(category);
        }

        public bool IsCodeExist(Category category)
        {
            return _categoryRepository.IsExistCode(category);
        }
    }
}
