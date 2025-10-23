namespace Tsinswreng.CsFactoryMkr;

[AttributeUsage(
	AttributeTargets.Class | AttributeTargets.Struct
	, AllowMultiple = false
	, Inherited = false
)]
public sealed class MkFactory : Attribute {
	public Type For { get; set; }   // 保留，未來可擴充
	public Type Source { get; set; }   // 保留
	public string MethodName { get; set; } = "Mk";
	public string[] IgnoredFields { get; set; } = Array.Empty<string>();
	public MkFactory(){
		if(Source is null){
			Source = For;
		}
	}
}
