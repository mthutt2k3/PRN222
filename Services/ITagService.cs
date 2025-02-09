﻿using System.Collections.Generic;
using BusinessObjects;

namespace Services
{
    public interface ITagService
    {
        List<Tag> GetTags();
        Tag GetTagById(int id);
        void SaveTag(Tag tag);
        void UpdateTag(Tag tag);
        void DeleteTag(Tag tag);
    }
}
