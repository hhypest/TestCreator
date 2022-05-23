namespace TestCls
{
    internal static class ConvertTo
    {
        internal static T To<T>(this string source)
            => (source != null) ? (T)Convert.ChangeType(source, typeof(T)) : default!;
    }
}