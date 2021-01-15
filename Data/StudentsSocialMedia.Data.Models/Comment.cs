﻿using StudentsSocialMedia.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Data.Models
{
    public class Comment : BaseDeletableModel<string>
    {
        public Comment()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Content { get; set; }

        public string PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}