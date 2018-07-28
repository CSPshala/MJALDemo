----------------------------------------------  
<h2 align="center">				
			Misfit Joe's Dynamic Asset Library<br>
					Ver. 1.1   <br>
			https://twitter.com/CSPshala  <br>
</h2>

 Designed to allow organization of any loaded assets and enable a range of much friendlier asset pipelines on the cheap for smaller games.

-----------------------  
System Requirements
-----------------------  
Tested on and built for UE4 4.20/4.19

If you need an older version of this project, clone the appropriate version engine tag.
EG: UE 4.19 is at tag "4.19"

-----------------------
Installation Guide
-----------------------  

Install MJAssetLibrary from the UE4 Marketplace to your engine.

If you plan on using MJAL via Blueprints that's all you need to do.

If you're planning on also using C++ interface:

1) In YourProject.build.cs add to respective arrays:
  	- PublicDependencyModuleNames - "MJAssetLibrary"
  	- PublicIncludePaths- "MJAssetLibrary/Classes"

2) Now include and use "MJAssetLibrary.h" where needed.

Search for USERTODO in example project to see.

-----------------------
User Guide
-----------------------  
Blueprints:
1. Create and store an instance of MJAssetLibrary somewhere. (GameInstance recommended).
2. Access instance of library, call load functions on resource path
3. Recieve actors/classes

C++:
1. Make sure to include in build.cs
2. Create UMJAssetLibrary somewhere and store.
3. Use functions in UMJAssetLibrary to load and spawn what you need.

Be careful if you mix methods. They should work together, but it's all up to you.

-----------------------
Technical Details
-----------------------  

List of Modules: MJAssetLibrary(Runtime)

Intended Platform: All Platforms  

Platforms Tested: Windows, MacOS

Demo Project: https://github.com/CSPshala/MJALDemo

Demo Video: https://youtu.be/ddBQFntaTL4

-----------------------
Contact and Support
-----------------------  

Yell at me on Twitter: https://twitter.com/CSPshala
Or at my email if you're old: joe.ricks.csp@gmail.com

-----------------------
 Version History
-----------------------  

Supported UE4 Versions:
*4.20
*4.19

Plugin Versions:

*1.0
- Core features
- Load any Blueprint and use it at runtime via C++ or BP.

*1.1
- Load any UAsset and use it at runtime via C++ or BP.
