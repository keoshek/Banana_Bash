using UnrealBuildTool;

public class BananaBashServerTarget : TargetRules
{
	public BananaBashServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("BananaBash");
	}
}
