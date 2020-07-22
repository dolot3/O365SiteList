using System;
using System.Collections.Generic;
using O365SiteList;
using Xunit;

namespace O365SiteList_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetFileLines_IsValid()
        {

            //arrange
            List<SiteData> inputList = Program.GetTestSiteData();
            //act
            var outputList = Program.GetFileLines(inputList);


            //assert
            Assert.Equal(4, outputList.Count);
            Assert.Equal("SiteCollectionName, Owner, LastAccessed", outputList[0]);
            Assert.Equal("Collection 1,Dave,7/7/2020", outputList[1]);

        }


    }
}
