Project structure:
Demo (Net8.0) -> IntermediateStandard (NetStandard2.0) -> TripleTarget (Net48;Net8.0;NetStandard2.0)

Run with:
dotnet run --project Demo

Observe that it prints "NetStandard" instead of "Net"

This seems to be cause ```<DisableTransitiveProjectReferences>``` flag in the Demo is causing Demo to not see the transient reference to TripleTarget.
As a result, TripleTarget.dll is grabbed from IntermediateStandard's bin folder instead, which is NetStandard2.0 version of he TripleTarget.dll.

If either ```<DisableTransitiveProjectReferences>``` is set to false, or explicit ```<ProjectReference>``` to TripleTarget is set, correct version of dll (net8.0) is picked up.
