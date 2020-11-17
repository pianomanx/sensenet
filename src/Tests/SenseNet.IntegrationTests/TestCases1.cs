﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SenseNet.ContentRepository;
using SenseNet.ContentRepository.Storage;

namespace SenseNet.IntegrationTests
{
    public class TestCases1 : TestCaseBase
    {
        public void TestCase_1()
        {
            IntegrationTest(() =>
            {
                // ASSIGN
                var created = new SystemFolder(Repository.Root);
                created.Save();

                // ACTION
                var edited = Node.LoadNode(created.Id);
                edited.Index = 42;
                edited.Save();

                //ASSERT
                var loaded = Node.LoadNode(created.Id);
                Assert.AreEqual(42, loaded.Index);
            });
        }
    }
}
