using System.Collections.Generic;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository tagRepository;

        public TagService()
        {
            tagRepository = new TagRepository();
        }

        public List<Tag> GetTags() => tagRepository.GetTags();

        public Tag GetTagById(int id) => tagRepository.GetTagById(id);

        public void SaveTag(Tag tag) => tagRepository.SaveTag(tag);

        public void UpdateTag(Tag tag) => tagRepository.UpdateTag(tag);

        public void DeleteTag(Tag tag) => tagRepository.DeleteTag(tag);
    }
}
