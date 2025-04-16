using UnrealBuildTool;

public class BananaBashEditorTarget : TargetRules
{
	public BananaBashEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("BananaBash");
	}
}
