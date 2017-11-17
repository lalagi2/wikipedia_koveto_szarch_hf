using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;

namespace wikipedia_koveto.WikipediaAPI
{

    internal class JSONUtils
    {
        public static object GetValueFromJSONObject(object obj, string key)
        {
            if (!((Dictionary<string, object>)obj).ContainsKey(key))
            {
                throw new WikiAPIException("Wiki result JSON don't have key: " + key);
            }
            return ((Dictionary<string, object>)obj)[key];
        }

        public static Array DeserializeRevisions(string obj)
        {
            var serializer = new JavaScriptSerializer();
            var resultDict = serializer.DeserializeObject(obj);

            var query = GetValueFromJSONObject(resultDict, "query");
            var pages = (Dictionary<string, object>)GetValueFromJSONObject(query, "pages");
            if (pages.Count != 1)
                throw new WikiAPIException("Number of pages is not 1. The title of page is not correct.");
            var page = (Dictionary<string, object>)pages.First().Value;
            if (page.ContainsKey("missing"))
                throw new WikiAPIException("Missing page named " + page["title"] + ".");

            return (Array)GetValueFromJSONObject(page, "revisions");
        }

        public static string DeserializeCompare(string obj)
        {
            var serializer = new JavaScriptSerializer();
            var resultDict = serializer.DeserializeObject(obj);

            var compare = GetValueFromJSONObject(resultDict, "compare");
            return (string)GetValueFromJSONObject(compare, "*");
        }
    }

    class RevisionData
    {
        // Represents revision data of wikipedia page
        public RevisionData(int revId, int parentId, int size, DateTime timestamp)
        {
            RevId = revId;
            ParentId = parentId;
            Size = size;
            Timestamp = timestamp;
        }

        public int RevId { get; private set; }
        public int ParentId { get; private set; }
        public int Size { get; private set; }
        public DateTime Timestamp { get; private set; }
    }

    class WikiAPI
    {
        private const string apiLink = "https://en.wikipedia.org/w/api.php?";
        private const string apiQueryLink = apiLink + "action=query&prop=revisions";
        private const string apiCompareLink = apiLink + "action=compare";
        private const string encoding = "&utf8=";
        private const string format = "&format=json";
        private string revisionProperties = "&rvprop=ids|size|timestamp&rvlimit=max&rvdir=older";
        private string contentProperties = "&rvprop=content";

        private WebClient client;

        public WikiAPI()
        {
            client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
        }
        public string GetContent(string title, int revId = -1)
        {
            // returns the content of the given page
            // if revId not -1, then search by revId, otherwise search by title

            string cond = revId > -1 ? "&revids=" + revId : "&titles=" + title;
            string result = client.DownloadString(apiQueryLink + cond + contentProperties + format + encoding);
            try
            {
                var revisions = JSONUtils.DeserializeRevisions(result);
                return (string)((Dictionary<string, object>)revisions.GetValue(0))["*"];
            }
            catch (WikiAPIException exp)
            {
                return "Wrong wikipedia page.";
            }
        }

        public string LastDiff { get; set; }

        public int GetDiff(int fromRev, int torev)
        {
            // returns the diff of the page between to revisions

            if (fromRev <= 0)
            {
                // There is no revision yet
                return int.MaxValue;
            }

            string url = apiCompareLink + "&fromrev=" + fromRev + "&torev=" + torev + format + encoding;
            string result = client.DownloadString(url);
                
            try
            {
                LastDiff = JSONUtils.DeserializeCompare(result);
                return LastDiff.Length;
            }
            catch (WikiAPIException exp)
            {
                return -1;
            }
        }

        public List<RevisionData> GetRevisions(string title, int revId = -1)
        {
            // returns the revisions for the given wikipedia page
            // title: the name of the wikipedia page what we are looking for
            // revId: the first revision id, we interested in

            string rvendid = revId > -1 ? "&rvendid=" + revId : "";
            //Console.WriteLine(apiLink + "&prop=revisions&titles=" + title + revisionProperties + rvendid + format + encoding);
            string url = apiQueryLink + "&titles=" + title + revisionProperties + rvendid + format + encoding;
            string result = client.DownloadString(url);
            
            var revisions = new List<RevisionData>();
            try
            {
                var revisionsDict = JSONUtils.DeserializeRevisions(result);
                foreach (var entry in revisionsDict)
                {
                    int eRevId = (int)JSONUtils.GetValueFromJSONObject(entry, "revid");
                    int eParentId = (int)JSONUtils.GetValueFromJSONObject(entry, "parentid");
                    int eSize = (int)JSONUtils.GetValueFromJSONObject(entry, "size");
                    string eTimestamp = (string)JSONUtils.GetValueFromJSONObject(entry, "timestamp");
                    revisions.Add(new RevisionData(eRevId, eParentId, eSize, DateTime.ParseExact(eTimestamp, "yyyy-MM-ddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture)));
                }

                return revisions;
            }
            catch (WikiAPIException exp)
            {
                    return revisions;
            }
        }
    }
}