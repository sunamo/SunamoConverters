namespace SunamoConverters;


internal interface IConvertShortcutFullName
{
    string FromShortcut(string shortcut);
    string ToShortcut(string fullName);
}