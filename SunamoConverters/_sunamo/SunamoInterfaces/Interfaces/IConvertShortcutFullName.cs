namespace SunamoConverters._sunamo.SunamoInterfaces.Interfaces;

internal interface IConvertShortcutFullName
{
    string FromShortcut(string shortcut);
    string ToShortcut(string fullName);
}