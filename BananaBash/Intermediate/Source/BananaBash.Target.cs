using UnrealBuildTool;

public class BananaBashTarget : TargetRules
{
	public BananaBashTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("BananaBash");
	}
}
