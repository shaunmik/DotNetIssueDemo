namespace TripleTarget;

public class TripleTargetDemo
{
    public static string GetTargetOfTripleTarget()
    {
#if NET
        return "Net";
#elif NETFRAMEWORK
        return "NetFramework";
#else
        return "NetStandard2.0";
#endif
    }
}
