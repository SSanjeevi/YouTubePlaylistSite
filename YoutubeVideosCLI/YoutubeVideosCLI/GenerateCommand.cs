using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Colors.Net;
using Microsoft.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace YoutubeVideosCLI
{
    public class CreateCommand : CommandLineApplication
    {
        private string youtubeApiUrl = string.Empty;
        private string youtubeChannelsApiUrl = string.Empty;
        private string youtubeSearchApiUrl = string.Empty;
        private string requestParametersChannelId = string.Empty;
        private string requestChannelVideosInfo = string.Empty;
        private string videoDetailsUrl = string.Empty;
        private string playlistsUrl = string.Empty;
        private string playlistItemsUrl = string.Empty;

        public CreateCommand()
        {
            try
            {
                this.Name = "Create";
                this.Description = "Create Name";

                CommandOption apiKey = this.Option("--api-key <apiKey>", "Api key", CommandOptionType.SingleValue);

                CommandOption channelName = this.Option("--channelName <channelName>", "channel Name", CommandOptionType.SingleValue);

                CommandOption channel = this.Option("--channel <channel>", "channel Id", CommandOptionType.SingleValue);

                CommandOption inputfilepath = this.Option("--input-file-path <inputfilepath>", "inputfilepath", CommandOptionType.SingleValue);

                CommandOption outputfilepath = this.Option("--output-file-path <outputfilepath>", "outputfilepath", CommandOptionType.SingleValue);

                CommandOption videoNodeInPortal = this.Option("--videoNodeInPortal <videoNodeInPortal>", "videoNodeInPortal", CommandOptionType.SingleValue);

                CommandOption title = this.Option("--title <title>", "title Name", CommandOptionType.SingleValue);

                CommandOption datefrom = this.Option("--date-from <datefrom>", "datefrom", CommandOptionType.SingleValue);

                CommandOption dateto = this.Option("--date-to <dateto>", "dateto Name", CommandOptionType.SingleValue);

                CommandOption interval = this.Option("--interval <interval>", "interval Name", CommandOptionType.SingleValue);

                this.OnExecute(async () =>
                {
                    string apiKeysStr = apiKey?.Value();
                    string channelStr = channel?.Value();
                    string outputfilepathStr = outputfilepath?.Value();
                    string inputfilepathStr = inputfilepath?.Value();
                    string titleStr = title?.Value();
                    string channelNameStr = channelName?.Value();
                    string datefromStr = datefrom?.Value();
                    string datetoStr = dateto?.Value();
                    string intervalStr = interval?.Value();
                    int videoNodeInPortalInt = videoNodeInPortal.Value() == null ? 1 : int.Parse(videoNodeInPortal.Value());

                    youtubeApiUrl = "https://youtube.googleapis.com/youtube/v3/";
                    playlistsUrl = youtubeApiUrl + "playlists?part=snippet%2CcontentDetails&key={0}";
                    playlistsUrl = string.Format(playlistsUrl, apiKeysStr) + "&channelId={0}&maxResults=25&pageToken={1}";
                    playlistItemsUrl = youtubeApiUrl + "playlistItems?part=snippet%2CcontentDetails&key={0}";
                    playlistItemsUrl = string.Format(playlistItemsUrl, apiKeysStr) + "&playlistId={0}&maxResults=25&pageToken={1}";
                    youtubeChannelsApiUrl = youtubeApiUrl + "channels?key={0}&";
                    youtubeChannelsApiUrl = string.Format(youtubeChannelsApiUrl, apiKeysStr);
                    youtubeSearchApiUrl = youtubeApiUrl + "search?key={0}&";
                    youtubeSearchApiUrl = string.Format(youtubeSearchApiUrl, apiKeysStr);
                    requestParametersChannelId = youtubeChannelsApiUrl + "id={0}&part=id";
                    requestChannelVideosInfo = youtubeSearchApiUrl + "channelId={0}&part=id&order=date&type=video&publishedBefore={1}&publishedAfter={2}&pageToken={3}&maxResults=50";
                    videoDetailsUrl = youtubeApiUrl + "videos?part=snippet%2CcontentDetails%2Cstatistics&id={0}&key=";
                    videoDetailsUrl = string.Format(videoDetailsUrl, apiKeysStr);

                    Paperbits paperbitObj = new Paperbits();
                    string channelId = this.getChannelId(channelStr);
                    List<PlayListItem> playListItems = getChannelPlaylists(channelId);

                    using (StreamReader r = new StreamReader(inputfilepathStr))
                    {
                        string json = r.ReadToEnd();

                        // update channel name.
                        if (!string.IsNullOrEmpty(channelNameStr))
                        {
                            json = json.Replace("#ChannelName", channelNameStr);
                        }

                        paperbitObj = JsonConvert.DeserializeObject<Paperbits>(json);
                        Page pageVid = paperbitObj.pages.Where(p => p.Value.locales.EnUs.title.ToLower() == titleStr.ToLower())?.Select(pg => pg.Value)?.FirstOrDefault();
                        string fileContentKey = pageVid.locales.EnUs.contentKey.Replace("files/", "");
                        Page file = paperbitObj.files[fileContentKey];
                        string nodeStr = JsonConvert.SerializeObject(file.nodes[videoNodeInPortalInt]);
                        string nodeFileBackup = JsonConvert.SerializeObject(file.nodes[videoNodeInPortalInt]);

                        string fileStr = JsonConvert.SerializeObject(paperbitObj.files[fileContentKey]);
                        string fileStrBackup = JsonConvert.SerializeObject(paperbitObj.files[fileContentKey]);


                        foreach (var item in playListItems)
                        {
                            if (!string.IsNullOrEmpty(item.snippet.title))
                            {
                                fileStr = fileStr.Replace("#PlayListTitle", item.snippet.title);
                            }

                            fileStr = fileStr.Replace("#PlaylistDesc", item.snippet.description);

                            Page fileval = JsonConvert.DeserializeObject<Page>(fileStr);
                            List<VideoItem> videoItems = getVideosFromPlaylists(item.id);
                            int count = 0;
                            int pageCount = 0;

                            foreach (var videoItem in videoItems)
                            {


                                Node node = new Node();
                                count++;
                                if (!string.IsNullOrEmpty(videoItem.snippet.title))
                                {
                                    nodeStr = nodeStr.Replace("#VidoeTitle1", videoItem.snippet.title);
                                }
                                if (!string.IsNullOrEmpty(videoItem.snippet.description))
                                {
                                    nodeStr = nodeStr.Replace("#VideoDescription1", videoItem.snippet.description);
                                }
                                if (!string.IsNullOrEmpty(videoItem.id))
                                {
                                    nodeStr = nodeStr.Replace("VideoId1", videoItem.snippet.resourceId.videoId);
                                }
                                node = JsonConvert.DeserializeObject<Node>(nodeStr);
                                nodeStr = nodeFileBackup;

                                if (count == 1)
                                {
                                    fileval.nodes[videoNodeInPortalInt] = node;
                                }
                                else
                                {
                                    fileval.nodes.Add(node);
                                }
                                if (count == 5)
                                {
                                    count = 0;
                                    pageCount++;
                                    AddPageToModel(paperbitObj, item, item.id + pageCount, fileval, pageCount.ToString());
                                    fileStr = fileStrBackup;
                                    if (!string.IsNullOrEmpty(item.snippet.title))
                                    {
                                        fileStr = fileStr.Replace("#PlayListTitle", item.snippet.title);
                                    }

                                    fileStr = fileStr.Replace("#PlaylistDesc", item.snippet.description);

                                }
                            }

                            if (paperbitObj.files.ContainsKey(item.id))
                            {
                                paperbitObj.files.Remove(item.id);
                            }
                            AddPageToModel(paperbitObj, item, item.id, fileval);
                            fileStr = fileStrBackup;

                            fileval = JsonConvert.DeserializeObject<Page>(fileStr);
                        }
                    }

                    string outJson = JsonConvert.SerializeObject(paperbitObj, Formatting.Indented, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    File.WriteAllText(outputfilepathStr, outJson);

                    return 1;
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void AddPageToModel(Paperbits paperbitObj, PlayListItem item, string pageName, Page fileval, string pageNum = "")
        {
            if (paperbitObj.files.ContainsKey(pageName))
            {
                paperbitObj.files[pageName] = fileval;
            }
            else
            {
                paperbitObj.files.Add(pageName, fileval);
            }

            Page newPage = new Page();
            string pageid = pageName + "_page";
            newPage.key = "pages/" + pageid;
            newPage.locales = new Locales();
            newPage.locales.EnUs = new EnUs();
            newPage.locales.EnUs.contentKey = "files/" + item.id;
            newPage.locales.EnUs.title = item.snippet.title + "-" + pageNum;
            newPage.locales.EnUs.description = item.snippet.description;
            newPage.locales.EnUs.permalink = "/videos-" + pageid;

            if (paperbitObj.pages.ContainsKey(pageid))
            {
                paperbitObj.pages.Remove(pageid);
            }
            paperbitObj.pages.Add(pageid, newPage);

            NavigationItem navigationItem = paperbitObj.navigationItems.Find(n => n.key == "navigationItemPlaylist");

            if (navigationItem == null)
            {
                navigationItem = new NavigationItem();
            }
            if (navigationItem.navigationItems == null)
            {
                navigationItem.navigationItems = new List<NavigationItem>();
            }

            //add menu navigations items based on pages created.
            navigationItem.navigationItems.Add(new NavigationItem
            {
                key = pageid + "_nav",
                label = newPage.locales.EnUs.title,
                targetWindow = "_self",
                anchor = "5FbTd",
                targetKey = newPage.key
            });
            int index = paperbitObj.navigationItems.FindIndex(n => n.key == "navigationItemPlaylist");
            paperbitObj.navigationItems[index] = navigationItem;
        }

        private string getChannelId(string channelName)
        {
            ColoredConsole.Out.WriteLine("Searching channel id for channel: " + channelName);

            try
            {
                string url = string.Format(requestParametersChannelId, channelName);

                HttpClient client = new HttpClient();

                string response = client.GetStringAsync(url).Result;

                if (response != string.Empty)
                {
                    Playlist playlist = JsonConvert.DeserializeObject<Playlist>(response);
                    return playlist.items[0].id;
                }
                else
                {
                    throw new Exception("channel id not found.");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private dynamic getVideoDetailsById(string videoId)
        {
            try
            {
                string url = string.Format(videoDetailsUrl, videoId);
                ColoredConsole.Out.WriteLine("Request: " + url);

                HttpClient client = new HttpClient();
                dynamic response = client.GetAsync(url).Result;

                if (response.items?.Count > 0)
                {
                    return response.items[0];
                }
                else
                {
                    throw new Exception("channel id not found.");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private List<PlayListItem> getChannelPlaylists(string channelId)
        {
            try
            {
                bool foundAll = false;
                List<PlayListItem> playlists = new List<PlayListItem>();
                string nextPageToken = string.Empty;

                while (!foundAll)
                {
                    string url = string.Format(playlistsUrl, channelId, nextPageToken);

                    ColoredConsole.Out.WriteLine("Request: " + url);

                    HttpClient client = new HttpClient();
                    string response = client.GetStringAsync(url).Result;

                    if (response != string.Empty)
                    {
                        Playlist playlist = JsonConvert.DeserializeObject<Playlist>(response);
                        playlist.items.ForEach(item => playlists.Add(item));

                        nextPageToken = playlist.nextPageToken;

                        if(nextPageToken == null || nextPageToken == string.Empty)
                        {
                            foundAll = true;
                        }
                    }
                    else
                    {
                        foundAll = true;
                        throw new Exception("channel id not found.");
                    }
                }
                return playlists;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private List<VideoItem> getVideosFromPlaylists(string playlistId)
        {
            try
            {
                bool foundAll = false;
                List<VideoItem> playlists = new List<VideoItem>();
                string nextPageToken = string.Empty;

                while (!foundAll)
                {
                    string url = string.Format(playlistItemsUrl, playlistId, nextPageToken);

                    ColoredConsole.Out.WriteLine("Request: " + url);

                    HttpClient client = new HttpClient();
                    string response = client.GetStringAsync(url).Result;

                    if (response != string.Empty)
                    {
                        PlaylistItemVal playlist = JsonConvert.DeserializeObject<PlaylistItemVal>(response);
                        playlist.items.ForEach(item => playlists.Add(item));
                        nextPageToken = playlist.nextPageToken;

                        if (nextPageToken == null || nextPageToken == string.Empty)
                        {
                            foundAll = true;
                        }
                    }
                    else
                    {
                        foundAll = true;
                        throw new Exception("channel id not found.");
                    }
                }
                return playlists;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
