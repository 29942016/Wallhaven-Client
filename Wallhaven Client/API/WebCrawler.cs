using System;
using System.Collections.Generic;
using System.Net;

namespace Wallhaven_Client.API
{
    class WebCrawler
    {
        //Object used for web queries
        WebClient webObject = new WebClient();
        
        //The HTML page currently being searched
        string HTML = "";

        //Holds a list of URLs to the images container, and the raw image link
        List<string> ImageSiteList = new List<string>();
        List<string> rawImages = new List<string>();

        //Experssion to search for to find the image's container site
        string ImageIdentifier = "<a class=\"preview\" href=\"";
        string ImageIdentifierEnd = "target=\"_blank\"  ></a>";

        //Expression to search for to find the raw image
        string RawImageIdentifier = "//wallpapers.";
        string RawImageIdentifierEnd = "\" /><link";

        //This will get the pages full HTML
        public string getSite(string url)
        {
            HTML = webObject.DownloadString(url);
            return HTML;
        }

        //This will extract all images from the current HTML object
        public List<string> extractImages(string imgURL)
        {
           //Empty current list for fresh search.
           ImageSiteList.Clear();
           rawImages.Clear();

          //Get the list of image's pages.
          getSite(imgURL);

          while(HTML.Contains(ImageIdentifier))
          {
                //Leave us with the first object
                HTML.Substring(0, HTML.IndexOf(ImageIdentifier));

                //Get the image url  
                string temp = HTML.Substring(HTML.IndexOf(ImageIdentifier), HTML.IndexOf(ImageIdentifierEnd) - (HTML.IndexOf(ImageIdentifier) - ImageIdentifierEnd.Length));
               
                //Remove the old image from the list so we dont iterate it multiple times
                HTML = HTML.Replace(temp, "");

                //Removes all the wrapping html around the img url.
                temp = temp.Replace("<a class=\"preview\" href=\"", "");
                temp = temp.Replace("\"  target=\"_blank\"  ></a>", "");

                //Add the image to our list
                ImageSiteList.Add(temp);

          }
            //Give the list of images main url to then extract the raw image.
            extractRawImage(ImageSiteList);

            //Return the list of raw image urls
            return rawImages;

        }

        //Gets the raw image from the website eg the .png or .jpg from the webserver
        public List<string> extractRawImage(List<string> ImagesToExtract)
        {

            foreach (string s in ImagesToExtract)
            {
                string temp = "";
                //Get the raw images HTML site
                getSite(s);
                //extract the true picture
                temp = HTML.Substring(HTML.IndexOf(RawImageIdentifier), (HTML.IndexOf(RawImageIdentifierEnd) - HTML.IndexOf(RawImageIdentifier)));
                //append http protocol because cant connect to just the networkshare and Add the picture to our list
                rawImages.Add("http:" + temp);
            }

            //Return the list of true images.
            return rawImages;
        }

        public bool startDownload(string saveDirectory)
        {
            //Check if we can find the save directory, if not, make it.
            if (!System.IO.Directory.Exists(saveDirectory))
                System.IO.Directory.CreateDirectory(saveDirectory);

            try
            {
                //Foreach image
                foreach (string s in rawImages)
                {
                    //Download it
                    webObject.DownloadFile(s, saveDirectory + s.Substring(s.IndexOf("n-"), s.Length - s.IndexOf("n-")));
                    Form1.imagesDownloaded++;
                    
                }
            }
            catch (Exception ex) { return false; } //If error downloading, return fail.

            return true;
        }
    }
}
