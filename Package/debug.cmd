XCOPY "..\Client\bin\Debug\netstandard2.1\drakozero.Sliders.Client.Oqtane.dll" "..\..\oqtane.framework\Oqtane.Server\bin\Debug\netcoreapp3.1\" /Y
XCOPY "..\Client\bin\Debug\netstandard2.1\drakozero.Sliders.Client.Oqtane.pdb" "..\..\oqtane.framework\Oqtane.Server\bin\Debug\netcoreapp3.1\" /Y
XCOPY "..\Server\bin\Debug\netcoreapp3.1\drakozero.Sliders.Server.Oqtane.dll" "..\..\oqtane.framework\Oqtane.Server\bin\Debug\netcoreapp3.1\" /Y
XCOPY "..\Server\bin\Debug\netcoreapp3.1\drakozero.Sliders.Server.Oqtane.pdb" "..\..\oqtane.framework\Oqtane.Server\bin\Debug\netcoreapp3.1\" /Y
XCOPY "..\Shared\bin\Debug\netstandard2.1\drakozero.Sliders.Shared.Oqtane.dll" "..\..\oqtane.framework\Oqtane.Server\bin\Debug\netcoreapp3.1\" /Y
XCOPY "..\Shared\bin\Debug\netstandard2.1\drakozero.Sliders.Shared.Oqtane.pdb" "..\..\oqtane.framework\Oqtane.Server\bin\Debug\netcoreapp3.1\" /Y
XCOPY "..\Server\wwwroot\Modules\drakozero.Sliders\*" "..\..\oqtane.framework\Oqtane.Server\wwwroot\Modules\drakozero.Sliders\" /Y /S /I
