﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientSample.DataModel
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set;}
        public int userId { get; set; }
    }
}
