﻿using System;

using Autofac;

using BetterCMS.Module.LuceneSearch.Services.IndexerService;
using BetterCMS.Module.LuceneSearch.Services.WebCrawlerService;

using BetterCms.Core.DataAccess;
using BetterCms.Core.Security;
using BetterCms.Core.Services;
using BetterCms.Module.Search.Models;

using HtmlAgilityPack;

using NUnit.Framework;

namespace BetterCms.Test.Module.LuceneSearch.ServiceTests
{
    [TestFixture]
    public class IndexerServiceTests : TestBase
    {
        const string FullShortText = "Any section of UI that should update dynamically with Knockout can be handled more simply and in a maintainable fashion.";

        const string FullText = "Knockout is a fast, extensible and simple JavaScript library designed to work with HTML document elements "
                + "using a clean underlying view model. It helps to create rich and responsive user interfaces. "
                + "Any section of UI that should update dynamically (e.g., changing depending on the user’s actions "
                + "or when an external data source changes) with Knockout can be handled more simply and in a maintainable fashion.";

        private const string MiddleText = "... elements using a clean underlying view model. It helps to create rich and responsive user interfaces. "
            + "Any section of UI that should update dynamically (e.g., changing depending on the user’s actions or when...";

        private const string StartText = "Knockout is a fast, extensible and simple JavaScript library designed to work with HTML document "
            + "elements using a clean underlying view model. It helps to create rich and responsive user interfaces. Any section of UI that...";

        private const string EndText = "... section of UI that should update dynamically (e.g., changing depending on the user’s actions "
            + "or when an external data source changes) with Knockout can be handled more simply and in a maintainable fashion.";

        const string FullTextForOneLetterSearch = "Any section of UI that should update dynamically with Knockout can be handled more simply and in[...]"
            + "Any section of UI that should update dynamically with Knockout can be handled more simply and in[...]"
            + "Any section of UI that should update dynamically with Knockout can be handled more simply and in a maintainable fashion."
            + "Any section of UI that should update dynamically with Knockout can be handled more simply and in[...]"
            + "Any section of UI that should update dynamically with Knockout can be handled more simply and in[...]";

        private const string FullTextForOneLetterSearchResult = "... in[...]Any section of UI that should update dynamically with Knockout can be handled "
            + "more simply and in a maintainable fashion.Any section of UI that should update dynamically with Knockout can be handled...";

        [Test]
        public void Should_Return_Correct_Search_Results()
        {
            var document1 = new HtmlDocument();
            document1.DocumentNode.AppendChild(HtmlNode.CreateNode("<title>Test title</title>"));
            document1.DocumentNode.AppendChild(HtmlNode.CreateNode("<body><p>Body with search phrase test</p></body>"));
            
            var document2 = new HtmlDocument();
            document2.DocumentNode.AppendChild(HtmlNode.CreateNode("<title>Test title</title>"));
            document2.DocumentNode.AppendChild(HtmlNode.CreateNode("<body><p>Body without search phrase</p></body>"));

            var page1 = new PageData { AbsolutePath = "/test1", Content = document1, Id = Guid.NewGuid(), IsPublished = true};
            var page2 = new PageData { AbsolutePath = "/test2", Content = document2, Id = Guid.NewGuid(), IsPublished = true };

            var service = new DefaultIndexerService(Container.Resolve<ICmsConfiguration>(), Container.Resolve<IRepository>(),
                Container.Resolve<ISecurityService>(), Container.Resolve<IAccessControlService>());
            
            service.Open();
            service.AddHtmlDocument(page1);
            service.AddHtmlDocument(page2);
            service.Close();

            var results = service.Search(new SearchRequest("test"));

            Assert.IsNotNull(results.Items);
            Assert.IsTrue(results.Items.Count == 1);
            Assert.IsTrue(results.Items[0].Link == page1.AbsolutePath);
        }

        [Test]
        public void Should_Return_Correct_Snippet_FromMiddleText()
        {
            var document1 = new HtmlDocument();
            document1.DocumentNode.AppendChild(HtmlNode.CreateNode("<title>Test title</title>"));
            document1.DocumentNode.AppendChild(HtmlNode.CreateNode("<body>" + FullText + "</body>"));

            var page1 = new PageData { AbsolutePath = "/test1", Content = document1, Id = Guid.NewGuid(), IsPublished = true };

            var service = new DefaultIndexerService(Container.Resolve<ICmsConfiguration>(), Container.Resolve<IRepository>(),
                Container.Resolve<ISecurityService>(), Container.Resolve<IAccessControlService>());

            service.Open();
            service.AddHtmlDocument(page1);
            service.Close();

            var results = service.Search(new SearchRequest("section"));

            Assert.IsNotNull(results.Items);
            Assert.IsTrue(results.Items.Count == 1);
            // Should be found the middle of the string, because the key word is in the middle of long text
            Assert.AreEqual(results.Items[0].Snippet, MiddleText);
        }
        
        [Test]
        public void Should_Return_Correct_Snippet_FromTextStart()
        {
            var document1 = new HtmlDocument();
            document1.DocumentNode.AppendChild(HtmlNode.CreateNode("<title>Test title</title>"));
            document1.DocumentNode.AppendChild(HtmlNode.CreateNode("<body>" + FullText + "</body>"));

            var page1 = new PageData { AbsolutePath = "/test1", Content = document1, Id = Guid.NewGuid(), IsPublished = true };

            var service = new DefaultIndexerService(Container.Resolve<ICmsConfiguration>(), Container.Resolve<IRepository>(),
                Container.Resolve<ISecurityService>(), Container.Resolve<IAccessControlService>());

            service.Open();
            service.AddHtmlDocument(page1);
            service.Close();

            var results = service.Search(new SearchRequest("extensible"));

            Assert.IsNotNull(results.Items);
            Assert.IsTrue(results.Items.Count == 1);
            // Should be found the start of the string, because the start word is in the start
            Assert.AreEqual(results.Items[0].Snippet, StartText);
        }
        
        [Test]
        public void Should_Return_Correct_Snippet_FromTextEnd()
        {
            var document1 = new HtmlDocument();
            document1.DocumentNode.AppendChild(HtmlNode.CreateNode("<title>Test title</title>"));
            document1.DocumentNode.AppendChild(HtmlNode.CreateNode("<body>" + FullText + "</body>"));

            var page1 = new PageData { AbsolutePath = "/test1", Content = document1, Id = Guid.NewGuid(), IsPublished = true };

            var service = new DefaultIndexerService(Container.Resolve<ICmsConfiguration>(), Container.Resolve<IRepository>(),
                Container.Resolve<ISecurityService>(), Container.Resolve<IAccessControlService>());

            service.Open();
            service.AddHtmlDocument(page1);
            service.Close();

            var results = service.Search(new SearchRequest("maintainable"));

            Assert.IsNotNull(results.Items);
            Assert.IsTrue(results.Items.Count == 1);
            // Should be found the end of the string, because the key word is in the end
            Assert.AreEqual(results.Items[0].Snippet, EndText);
        }
        
        [Test]
        public void Should_Return_Correct_Snippet_Full()
        {
            var document1 = new HtmlDocument();
            document1.DocumentNode.AppendChild(HtmlNode.CreateNode("<title>Test title</title>"));
            document1.DocumentNode.AppendChild(HtmlNode.CreateNode("<body>" + FullShortText + "</body>"));

            var page1 = new PageData { AbsolutePath = "/test1", Content = document1, Id = Guid.NewGuid(), IsPublished = true };

            var service = new DefaultIndexerService(Container.Resolve<ICmsConfiguration>(), Container.Resolve<IRepository>(),
                Container.Resolve<ISecurityService>(), Container.Resolve<IAccessControlService>());

            service.Open();
            service.AddHtmlDocument(page1);
            service.Close();

            var results = service.Search(new SearchRequest("dynamically"));

            Assert.IsNotNull(results.Items);
            Assert.IsTrue(results.Items.Count == 1);
            // Should be found whole string, because it's too short for crop
            Assert.AreEqual(results.Items[0].Snippet, FullShortText);
        }
        
        [Test]
        public void Should_Return_Correct_Snippet_FullWord()
        {
            var document1 = new HtmlDocument();
            document1.DocumentNode.AppendChild(HtmlNode.CreateNode("<title>Test title</title>"));
            document1.DocumentNode.AppendChild(HtmlNode.CreateNode("<body>" + FullTextForOneLetterSearch + "</body>"));

            var page1 = new PageData { AbsolutePath = "/test1", Content = document1, Id = Guid.NewGuid(), IsPublished = true };

            var service = new DefaultIndexerService(Container.Resolve<ICmsConfiguration>(), Container.Resolve<IRepository>(),
                Container.Resolve<ISecurityService>(), Container.Resolve<IAccessControlService>());

            service.Open();
            service.AddHtmlDocument(page1);
            service.Close();

            var results = service.Search(new SearchRequest("a"));

            Assert.IsNotNull(results.Items);
            Assert.IsTrue(results.Items.Count == 1);
            // Should be found separate word "a" excluding "a" in another words
            Assert.AreEqual(results.Items[0].Snippet, FullTextForOneLetterSearchResult);
        }
    }
}
