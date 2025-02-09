﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessObjects
{
    public class CategoriesDAO
    {
        public static List<Category> GetCategories()
        {
            var listCategories = new List<Category>();
            try
            {
                using var context = new FunewsManagementContext();
                listCategories = context.Categories.ToList();

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listCategories;
        }

    }
}
