using System;


namespace URI_Parser
{
    public class Uri_Parser : IParse
    {
        public Uri _uri { get; set; }


        // if argument is a string
        public Uri_Parser(string uri)
        {
            _uri = new Uri(uri);

        }

        //if argument is an URI
        public Uri_Parser(Uri uri)
        {
            _uri = uri;
        }

        public string Fragment()
        {
            return _uri.Fragment;
        }

        public string Host()
        {
            return _uri.Host;
        }


        //userinfo needs to be split

        public string User()
        {
            if (_uri == null || string.IsNullOrWhiteSpace(_uri.UserInfo))
            {
                return string.Empty;
            }
            else
            {
                var items = _uri.UserInfo.Split(new[] { ':' });
                return items.Length > 0 ? items[0] : string.Empty;
            }
        }

        public string Password()
        {
            if (_uri == null || string.IsNullOrWhiteSpace(_uri.UserInfo))
                return string.Empty;

            var items = _uri.UserInfo.Split(new[] { ':' });
            return items.Length > 1 ? items[1] : string.Empty;
        }

        public string Path()
        {
            return _uri.AbsolutePath;
        }
               
        public int? Port()
        {
            if (_uri.Port == -1) //if there is no default port this return -1
            {
                return null;
            }
            return _uri.Port;
        }

        public string Query()
        {
            return _uri.Query;
        }

        public string Scheme()
        {
            return _uri.Scheme;
        }


    }
}
