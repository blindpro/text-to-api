public static class Setup
{
public static void Start()
{
Database.AddMethod("text",Methods.Text);
Database.AddMethod("file",Methods.ReadFile);
}
}