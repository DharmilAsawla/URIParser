
using Microsoft.VisualStudio.TestTools.UnitTesting;
using URI_Parser;


namespace URIParser
{
    [TestClass]
    public class Uri_Parser_Tests
    {

        //test example URI's taken from https://tools.ietf.org/html/rfc3986#section-1.1.2

        static string URI1 = "ftp://username:password@hostname/";
        static string URI2 = "http://www.ietf.org/rfc/rfc2396.txt";
        static string URI3 = "ldap://[2001:db8::7]/c=GB?objectClass?one";
        static string URI4 = "mailto:John.Doe@example.com";
        static string URI5 = "tel:+1-816-555-1212";
        static string URI6 = "telnet://192.0.2.16:80/";
        static string URI7 = "news:comp.infosystems.www.servers.unix";
        static string URI8 = "https://example.com/path/resource.txt#fragment";
        static string URI9 = "http://matt:secret@www.chilkatsoft.com:8080/somepath.asp?test=123&size=2";


        Uri_Parser parser1 = new Uri_Parser(URI1);
        Uri_Parser parser2 = new Uri_Parser(URI2);
        Uri_Parser parser3 = new Uri_Parser(URI3);
        Uri_Parser parser4 = new Uri_Parser(URI4);
        Uri_Parser parser5 = new Uri_Parser(URI5);
        Uri_Parser parser6 = new Uri_Parser(URI6);
        Uri_Parser parser7 = new Uri_Parser(URI7);
        Uri_Parser parser8 = new Uri_Parser(URI8);
        Uri_Parser parser9 = new Uri_Parser(URI9);



        [TestMethod]
        public void Scheme()
        {

            Assert.AreEqual("ftp", parser1.Scheme());
            Assert.AreEqual("http", parser2.Scheme());
            Assert.AreEqual("ldap", parser3.Scheme());
            Assert.AreEqual("mailto", parser4.Scheme());
            Assert.AreEqual("tel", parser5.Scheme());
            Assert.AreEqual("telnet", parser6.Scheme());
            Assert.AreEqual("news", parser7.Scheme());
            Assert.AreEqual("https", parser8.Scheme());
            Assert.AreEqual("http", parser9.Scheme());
        }

        [TestMethod]
        public void User()
        {
            Assert.AreEqual("username", parser1.User());
            Assert.AreEqual("matt", parser9.User());
        }

        [TestMethod]
        public void Password()
        {


            Assert.AreEqual("password", parser1.Password());
            Assert.AreEqual("secret", parser9.Password());
        }

        [TestMethod]
        public void Host()
        {
            Assert.AreEqual("hostname", parser1.Host());
            Assert.AreEqual("www.ietf.org", parser2.Host());
            Assert.AreEqual("[2001:db8::7]", parser3.Host());
            Assert.AreEqual("example.com", parser4.Host());
            Assert.AreEqual("", parser5.Host());
            Assert.AreEqual("192.0.2.16", parser6.Host());
            Assert.AreEqual("", parser7.Host());
            Assert.AreEqual("example.com", parser8.Host());
            Assert.AreEqual("www.chilkatsoft.com", parser9.Host());
        }



        //https://www.webopedia.com/quick_ref/portnumbers.asp (List of known port numbers)
        [TestMethod]
        public void Port()
        {
            Assert.AreEqual(21, parser1.Port());
            Assert.AreEqual(80, parser2.Port());
            Assert.AreEqual(389, parser3.Port());
            Assert.AreEqual(25, parser4.Port());
            Assert.AreEqual(null, parser5.Port());
            Assert.AreEqual(80, parser6.Port());
            Assert.AreEqual(null, parser7.Port());
            Assert.AreEqual(443, parser8.Port());
            Assert.AreEqual(8080, parser9.Port());
        }

        [TestMethod]
        public void Path()
        {
            Assert.AreEqual("/", parser1.Path());
            Assert.AreEqual("/rfc/rfc2396.txt", parser2.Path());
            Assert.AreEqual("/c=GB", parser3.Path());
            Assert.AreEqual("", parser4.Path());
            Assert.AreEqual("+1-816-555-1212", parser5.Path());
            Assert.AreEqual("/", parser6.Path());
            Assert.AreEqual("comp.infosystems.www.servers.unix", parser7.Path());
            Assert.AreEqual("/path/resource.txt", parser8.Path());
            Assert.AreEqual("/somepath.asp", parser9.Path());
        }

        [TestMethod]
        public void Query()
        {
            Assert.AreEqual("", parser1.Query());
            Assert.AreEqual("", parser2.Query());
            Assert.AreEqual("?objectClass?one", parser3.Query());
            Assert.AreEqual("", parser4.Query());
            Assert.AreEqual("", parser5.Query());
            Assert.AreEqual("", parser6.Query());
            Assert.AreEqual("", parser7.Query());
            Assert.AreEqual("", parser8.Query());
            Assert.AreEqual("?test=123&size=2", parser9.Query());
        }

        [TestMethod]
        public void Fragment()
        {
            Assert.AreEqual("", parser1.Fragment());
            Assert.AreEqual("", parser2.Fragment());
            Assert.AreEqual("", parser3.Fragment());
            Assert.AreEqual("", parser4.Fragment());
            Assert.AreEqual("", parser5.Fragment());
            Assert.AreEqual("", parser6.Fragment());
            Assert.AreEqual("", parser7.Fragment());
            Assert.AreEqual("#fragment", parser8.Fragment());
            Assert.AreEqual("", parser9.Fragment());
        }


    }
}
