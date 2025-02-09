using System.Collections.Generic;
using System.Linq;
using BusinessObjects;
using DataAccess;
using DataAccessObjects;

namespace Repositories
{
    public class TagRepository : ITagRepository
    {
        public List<Tag> GetTags()
        {
            using var context = new FunewsManagementContext();
            return context.Tags.ToList();
        }

        public Tag GetTagById(int id)
        {
            using var context = new FunewsManagementContext();
            return context.Tags.FirstOrDefault(t => t.TagId == id);
        }

        public void SaveTag(Tag tag)
        {
            using var context = new FunewsManagementContext();
            context.Tags.Add(tag);
            context.SaveChanges();
        }

        public void UpdateTag(Tag tag)
        {
            using var context = new FunewsManagementContext();
            context.Tags.Update(tag);
            context.SaveChanges();
        }

        public void DeleteTag(Tag tag)
        {
            using var context = new FunewsManagementContext();
            context.Tags.Remove(tag);
            context.SaveChanges();
        }
    }
}
