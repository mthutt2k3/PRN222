using BusinessObjects;
using DataAccessObjects;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class TagDAO
    {
        public static List<Tag> GetTags()
        {
            using var context = new FunewsManagementContext();
            return context.Tags.ToList();
        }

        public static Tag GetTagById(int id)
        {
            using var context = new FunewsManagementContext();
            return context.Tags.FirstOrDefault(t => t.TagId == id);
        }

        public static void SaveTag(Tag tag)
        {
            using var context = new FunewsManagementContext();
            context.Tags.Add(tag);
            context.SaveChanges();
        }

        public static void UpdateTag(Tag tag)
        {
            using var context = new FunewsManagementContext();
            context.Tags.Update(tag);
            context.SaveChanges();
        }

        public static void DeleteTag(Tag tag)
        {
            using var context = new FunewsManagementContext();
            context.Tags.Remove(tag);
            context.SaveChanges();
        }
    }
}
