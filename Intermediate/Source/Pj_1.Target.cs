using UnrealBuildTool;

public class Pj_1Target : TargetRules
{
	public Pj_1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Pj_1");
	}
}
