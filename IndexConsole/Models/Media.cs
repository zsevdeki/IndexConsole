using System;
using SolrNet.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexConsole.Models
{
    class Media
    {
        [SolrUniqueKey("mediaid")]
        public string MediaId { get; set; }

        [SolrField("mediatitle")]
        public string MediaTitle { get; set; }

        [SolrField("durationseconds")]
        public int DurationInSeconds { get; set; }

        [SolrField("releasedate")]
        public DateTime ReleaseDate { get; set; }

        [SolrField("description")]
        public string Description { get; set; }

        [SolrField("tags")]
        public List<string> Tags { get; set; }

        [SolrField("tagsdescription")]
        public string TagsDescription { get; set; }

        [SolrField("author")]
        public List<string> Author { get; set; }

        [SolrField("authorid")]
        public List<string> AuthorId { get; set; }

        [SolrField("fakeviews")]
        public int FakeViews { get; set; }

        [SolrField("fakerating")]
        public float FakeRating { get; set; }

        [SolrField("staticsnippet")]
        public string StaticSnippet { get; set; }

        [SolrField("metadata")]
        public string Metadata { get; set; }
    }
}
