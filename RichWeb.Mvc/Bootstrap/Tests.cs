using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NUnit.Framework;

namespace RichWeb.Mvc.Bootstrap
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestRightPanel()
        {
            var panel = new BootstrapRightPanel("collapseOne", "Help", "in", new ViewContext()).Render();

        }
    }
}