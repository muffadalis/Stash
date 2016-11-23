﻿using System;

namespace MsftBuild.Model
{
	public class BuildTask : ITask
	{
		public void Execute( IServiceProvider provider, IState state )
		{
			// Get the BuildProfile that is defined in the project file, if it exists: 
			var profile = provider.GetService( typeof(BuildProfile) ) as BuildProfile ?? new DefaultBuildProfile();

			// From here, we could:
			// 1. Serialize profile (and other services) as XML.
			// 2. Execute XSLT against XML from above to generate a traditional .csproj file, save result to a temp directory.
			// 3. Launch msbuild.exe and point it to .csproj from above. 
		}

		class DefaultBuildProfile : BuildProfile {
			// ...
		}
	}
}