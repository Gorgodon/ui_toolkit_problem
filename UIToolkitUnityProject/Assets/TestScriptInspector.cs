using UnityEditor;
using UnityEngine.UIElements;

[CustomEditor(typeof(TestScript))]
public class TestScriptInspector : Editor
{
    public VisualTreeAsset uxml;
    public override VisualElement CreateInspectorGUI()
    {
        return uxml.CloneTree();
    }
}
