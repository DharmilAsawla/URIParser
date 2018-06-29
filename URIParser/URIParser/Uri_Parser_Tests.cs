using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using URI_Parser;


namespace URIParser
{
    [TestClass]
    public class Uri_Parser_Tests
    {
        static Uri URI1 = new Uri("ftp://username:password@hostname/");
        static Uri URI2 = new Uri("http://www.ietf.org/rfc/rfc2396.txt");
        static Uri URI3 = new Uri("ldap://[2001:db8::7]/c=GB?objectClass?one");
        static Uri URI4 = new Uri("mailto:John.Doe@example.com");
        static Uri URI5 = new Uri("tel:+1-816-555-1212");
        static Uri URI6 = new Uri("telnet://192.0.2.16:80/");
        static Uri URI7 = new Uri("news:comp.infosystems.www.servers.unix");
        static Uri URI8 = new Uri("https://example.com/path/resource.txt#fragment");
        static Uri URI9 = new Uri("http://matt:secret@www.chilkatsoft.com:8080/somepath.asp?test=123&size=2");


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
            Assert.AreEqual("ftp", parser1.scheme);
            Assert.AreEqual("http", parser2.scheme);
            Assert.AreEqual("ldap", parser3.scheme);
            Assert.AreEqual("mailto", parser4.scheme);
            Assert.AreEqual("tel", parser5.scheme);
            Assert.AreEqual("telnet", parser6.scheme);
            Assert.AreEqual("news", parser7.scheme);
            Assert.AreEqual("https", parser8.scheme);
            Assert.AreEqual("http", parser9.scheme);
        }

        [TestMethod]
        public void User()
        {
            Assert.AreEqual("username", parser1.user);
            Assert.AreEqual("matt", parser9.user);
        }

        [TestMethod]
        public void Password()
        {
            Assert.AreEqual("password", parser1.password);
            Assert.AreEqual("secret", parser9.password);
        }

        [TestMethod]
        public void Host()
        {
            Assert.AreEqual("ftp", parser1.host);
            Assert.AreEqual("http", parser2.host);
            Assert.AreEqual("ldap", parser3.host);
            Assert.AreEqual("mailto", parser4.host);
            Assert.AreEqual("tel", parser5.host);
            Assert.AreEqual("telnet", parser6.host);
            Assert.AreEqual("news", parser7.host);
            Assert.AreEqual("https", parser8.host);
            Assert.AreEqual("http", parser9.host);
        }

        [TestMethod]
        public void Port()
        {
            Assert.AreEqual("ftp", parser1.port);
            Assert.AreEqual("http", parser2.port);
            Assert.AreEqual("ldap", parser3.port);
            Assert.AreEqual("mailto", parser4.port);
            Assert.AreEqual("tel", parser5.port);
            Assert.AreEqual("telnet", parser6.port);
            Assert.AreEqual("news", parser7.port);
            Assert.AreEqual("https", parser8.port);
            Assert.AreEqual("http", parser9.port); ;
        }

        [TestMethod]
        public void Path()
        {
            Assert.AreEqual("ftp", parser1.path);
            Assert.AreEqual("http", parser2.path);
            Assert.AreEqual("ldap", parser3.path);
            Assert.AreEqual("mailto", parser4.path);
            Assert.AreEqual("tel", parser5.path);
            Assert.AreEqual("telnet", parser6.path);
            Assert.AreEqual("news", parser7.path);
            Assert.AreEqual("https", parser8.path);
            Assert.AreEqual("http", parser9.path);
        }

        [TestMethod]
        public void Query()
        {
            Assert.AreEqual("ftp", parser1.query);
            Assert.AreEqual("http", parser2.query);
            Assert.AreEqual("ldap", parser3.query);
            Assert.AreEqual("mailto", parser4.query);
            Assert.AreEqual("tel", parser5.query);
            Assert.AreEqual("telnet", parser6.query);
            Assert.AreEqual("news", parser7.query);
            Assert.AreEqual("https", parser8.query);
            Assert.AreEqual("http", parser9.query);
        }

        [TestMethod]
        public void Fragment()
        {
            Assert.AreEqual("ftp", parser1.fragment);
            Assert.AreEqual("http", parser2.fragment);
            Assert.AreEqual("ldap", parser3.fragment);
            Assert.AreEqual("mailto", parser4.fragment);
            Assert.AreEqual("tel", parser5.fragment);
            Assert.AreEqual("telnet", parser6.fragment);
            Assert.AreEqual("news", parser7.fragment);
            Assert.AreEqual("https", parser8.fragment);
            Assert.AreEqual("http", parser9.fragment);
        }


    }
}
