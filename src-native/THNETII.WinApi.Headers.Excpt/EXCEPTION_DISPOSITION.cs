namespace THNETII.WinApi.Native.Excpt
{
    /// <summary>Exception disposition return values</summary>
    public enum EXCEPTION_DISPOSITION
    {
        ExceptionContinueExecution,
        ExceptionContinueSearch,
        ExceptionNestedException,
        ExceptionCollidedUnwind
    }
}
