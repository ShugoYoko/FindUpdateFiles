# 使用方法
1.Research folder path に探索したいフォルダのパスを指定<br>
2.Start date(yyyy/MM/dd) に探索期間の開始日時を設定<br>
3.End date(yyyy/MM/dd) に探索期間の終了日時を設定<br>
4.開始日時から終了日時に更新されたファイルのパスが返却される<br>

# How to use.
1.Specify the path of the folder to be explored in Research folder path.<br>
2.Set the start date and time of the search period in Start date (yyyy/MM/dd).<br>
3.Set the end date and time of the search period in End date (yyyy/MM/dd).<br>
4.The path of the file updated from the start date to the end date/time is returned.<br>

# Creation procedure(Memo)
(1)CLI<br>
1.cd target_folder<br>
2.dotnet new sln<br>
3.mkdir src<br>
4.cd src
5.dotnet new console <br>
5.cd .. <br>
6.dotnet sln add ./src/src.csproj<br>
7.dotnet new xunit -o FindUpdateFiles.Tests<br>
8.dotnet sln add ./FindUpdateFiles.Tests/FindUpdateFiles.Tests.csproj<br>
9.dotnet add ./FindUpdateFiles.Tests/FindUpdateFiles.Tests.csproj reference ./src/src.csproj<br>

(2)Visual Studio<br>
1.git init by GUI<br>
2.Coding<br>
