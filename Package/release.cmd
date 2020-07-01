"..\..\oqtane.framework\oqtane.package\nuget.exe" pack drakozero.Sliders.nuspec 
XCOPY "*.nupkg" "..\..\oqtane.framework\Oqtane.Server\wwwroot\Modules\" /Y
