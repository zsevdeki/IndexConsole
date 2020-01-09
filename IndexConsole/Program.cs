using IndexConsole.Models;
using Microsoft.Practices.ServiceLocation;
using Newtonsoft.Json;
using SolrNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexConsole
{
    class Program
    {


        static void Main(string[] args)
        {

         
            
            Startup.Init<Media>("http://localhost:8989/solr/mercCloud_shard1_replica1");
            
            ISolrOperations<Media> solr = ServiceLocator.Current.GetInstance<ISolrOperations<Media>>();



            List<Media> allMedia = JsonConvert.DeserializeObject<List<Media>>(File.ReadAllText(@"..\..\media.json"));

            foreach (Media media in allMedia)
            {
                solr.Add(media);
            }

            solr.Commit();		


        }
    }
}
