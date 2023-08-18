using FindUpdateFiles.Con;

namespace FindUpdateFiles.Tests 
{

    public class UnitTest1
    {
        [Fact]
        public void ErrCaseTest()
        {
            var targetPath = "";
            var startDate = "20xx/11/11";
            var endDate = "20xx/11/11";
            var search = new SearchPaths(targetPath, startDate, endDate);
            var paths=search.GetAllFiles().ToList();

            
            Assert.Equal("Please check the file path.", paths[0]);
            Assert.Equal("Please check date format", paths[1]);

         }

        [Fact]
        public void SucseccCaseTest()
        {
            var targetPath = "./Folder";
            var startDate = "2023/8/16";
            var endDate = "2023/8/18";
            var search = new SearchPaths(targetPath, startDate, endDate);
            var paths = search.GetAllFiles().ToList();


            Assert.Equal(@"./Folder\aaa.txt", paths[0]);
            Assert.Equal(@"./Folder\bbb.txt", paths[1]);
            Assert.Equal(@"./Folder\sub\aaa.txt", paths[2]);

        }
    }
}