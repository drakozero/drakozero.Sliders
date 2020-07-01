"..\..\oqtane.framework\oqtane.package\nuget.exe" pack drakozero.Sliders.nuspec 
XCOPY "*.nupkg" "C:\oqtaneServer\fromweb\wwwroot\Modules\" /Y
