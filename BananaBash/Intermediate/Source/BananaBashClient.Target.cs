using UnrealBuildTool;

public class BananaBashClientTarget : TargetRules
{
	public BananaBashClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("BananaBash");
	}
}
