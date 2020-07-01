# Slider

This is a proof of concept of an Oqtane module that uses a Third party Library.
Library used: [BlazorStrap.io] 
Repo: [BlazorStrap GitHub]

To add a third Party Nuget Package, the dll's of the package must be included in the module, within the .nupkg
Added BlazorStrap *.dll* files to the .nuspec in the **Package** project inside the *<files>* section:
><file src="..\Client\bin\Release\netstandard2.1\BlazorStrap.dll" target="lib\netstandard2.1" /> 
><file src="..\Client\bin\Release\netstandard2.1\BlazorComponentUtilities.dll" target="lib\netstandard2.1" /> 

Added **BlazorStrapService.cs** that runs **services.AddBootstrapCss();** as IClientStartup on the Assembly in the **Server** Project.


### Configuration

The Module configuration has three parameters:
    **Fade or Slide**: Selects if the slides have a fade transition, or a Slide transition.
    **Has Controls**: Selects if the slides have lateral arrows for sliding.
    **Has Indicator**: Selects if the slides have indicators at the bottom to show the current Slide and Total of Slides.
    
### TODO
    - Find a way to not display the Slide Module Title, so far leaving it empty do the trick.
    - Remove the horizontal line above the module.
    - Check if there is a conflict if more than one module is used on the same page (apparently not)


License
----

MIT


[//]: # (These are reference links used in the body of this note and get stripped out when the markdown processor does its job. There is no need to format nicely because it shouldn't be seen. Thanks SO - http://stackoverflow.com/questions/4823468/store-comments-in-markdown-syntax)


   [BlazorStrap.io]: <https://blazorstrap.io/>
   [BlazorStrap GitHub]: <https://github.com/chanan/BlazorStrap>
   [Oqtane]: <https://www.oqtane.org/>
   [Oqtane GitHub]: <https://github.com/oqtane/oqtane.framework>
